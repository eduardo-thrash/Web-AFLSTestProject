using AFLSUIProjectTest.CommonAFLS;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.AFLS
{
    [Binding]
    public class LoginLogoutSteps
    {
        private AFLSCommonFunctions AFLSCommonFunctions = new AFLSCommonFunctions();

        public string user_nickname;
        public string user_id;
        public string UrlNow;

        [Given(@"Tengo usuario administrador")]
        public void GivenTengoUsuarioAdministrador()
        {
            user_nickname = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = 'administrator';", 1);
        }

        [When(@"Accedo a la aplicación")]
        public void WhenAccedoALaAplicacion()
        {
            int FindRow = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_ESTABLISHMENT", 1));
            int FindCOuntry = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_ESTABLISHMENT WHERE esta_country IS NOT NULL", 1));

            if (FindRow == 0)
            {
                AFLSCommonFunctions.DBEstablismentInsert("INSERT INTO dbo.AFLS_ESTABLISHMENT(esta_id"
                                                        + ", esta_code"
                                                        + ", esta_name"
                                                        + ", esta_address"
                                                        + ", esta_latitude"
                                                        + ", esta_longitude"
                                                        + ", esta_country"
                                                        + ", esta_filter_address)"
                                                        + "VALUES"
                                                        + "(1"
                                                        + ", 90008736364 - 3"
                                                        + ", 'Aranda Software Automation'"
                                                        + ", 'Calle 64, Chapinero, 111221 Chapinero, Distrito Capital, Colombia'"
                                                        + ", 4.6507338"
                                                        + ", -74.0632001"
                                                        + ", 'CO- COlombia, BR - Brasil'"
                                                        + ", 1)"
                                                        + "GO");
            }

            if (FindCOuntry == 0)
            {
                AFLSCommonFunctions.DBEstablismentUpdate("UPDATE AFLS_ESTABLISHMENT SET esta_country = 'CO- Colombia'");
            }
            CommonElementsAction.AccessPage(ConfigurationManager.AppSettings["Url"]);
        }

        [When(@"Ingreso nombre de usuario administrador valido")]
        public void WhenIngresoNombreDeUsuarioAdministradorValido(string user_nickname)
        {
            CommonElementsAction.SendKeys_InputText("XPath", "//form[@class='login-form']//input[@id='UserName']", user_nickname);
        }

        [When(@"Ingreso contraseña de usuario administrador valido")]
        public void WhenIngresoContrasenaDeUsuarioAdministradorValido(string password)
        {
            CommonElementsAction.SendKeys_InputText("XPath", "//form[@class='login-form']//input[@id='Password']", password);
        }

        [When(@"Doy click en Login")]
        public void WhenDoyClickEnLogin()
        {
            CommonElementsAction.Click("XPath", "//form[@class='login-form']//button[@id='btnSubmit']");
        }

        [When(@"Realizo Login con usuario rol administrador")]
        public void WhenRealizoLoginConUsuarioRolAdministrador()
        {
            WhenIngresoNombreDeUsuarioAdministradorValido("thrash");
            WhenIngresoContrasenaDeUsuarioAdministradorValido("123456");
            WhenDoyClickEnLogin();
            ThenAccedoALaPantallaPrincipalDeConfiguracion();
            ThenSeRegistraEnBaseDeDatosElUsuarioConSesionActivaEnLaTablaAFW_USER_SESSION_TOKEN();
            Thread.Sleep(5000);
        }

        [Given(@"Tengo un usuario con rol monitor y con proveedores asociados")]
        public string GivenTengoUnUsuarioConRolMonitorYConProveedoresAsociados()
        {
            string UserMonitor = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_id = (SELECT TOP 1 PRM.UserId FROM AFLS_PROVIDER_MONITORS PRM JOIN AFLS_USERS_WEB WEB ON PRM.UserId = WEB.user_id ORDER BY NEWID());", 1);
            return UserMonitor;
        }

        [When(@"Realizo Login con usuario rol monitor")]
        public void WhenRealizoLoginConUsuarioRolMonitor()
        {
            WhenIngresoNombreDeUsuarioAdministradorValido("thrash");
            WhenIngresoContrasenaDeUsuarioAdministradorValido("123456");
            WhenDoyClickEnLogin();
            ThenAccedoALaPantallaPrincipalDeConfiguracion();
            ThenSeRegistraEnBaseDeDatosElUsuarioConSesionActivaEnLaTablaAFW_USER_SESSION_TOKEN();
        }

        [When(@"Realizo Login con usuario rol monitor y despachador")]
        public void WhenRealizoLoginConUsuarioRolMonitorYDespachador()
        {
            WhenIngresoNombreDeUsuarioAdministradorValido("thrash");
            WhenIngresoContrasenaDeUsuarioAdministradorValido("123456");
            WhenDoyClickEnLogin();
            ThenAccedoALaPantallaPrincipalDeConfiguracion();
            //ThenSeRegistraEnBaseDeDatosElUsuarioConSesionActivaEnLaTablaAFW_USER_SESSION_TOKEN();
        }

        [When(@"Realizo Login con usuario rol despachador")]
        public void WhenRealizoLoginConUsuarioRolDespachador()
        {
            WhenIngresoNombreDeUsuarioAdministradorValido("thrash");
            WhenIngresoContrasenaDeUsuarioAdministradorValido("123456");
            WhenDoyClickEnLogin();
            ThenAccedoALaPantallaPrincipalDeConfiguracion();
        }

        [When(@"Pulso link de cierre de sesión")]
        public void WhenPulsoLinkDeCierreDeSesion()
        {
            UtilAction.Click("//div[@class='base top header row']//a[@href='/AFLS/Account/LogOff']");
        }

        [Then(@"Accedo a la pantalla principal de configuración")]
        public void ThenAccedoALaPantallaPrincipalDeConfiguracion()
        {
            CommonElementsAction.WaitElement("//div[@class='logo']");
            UrlNow = CommonHooks.driver.Url;
            Thread.Sleep(2000);
            CommonElementsAction.WaitUrl(UrlNow, ConfigurationManager.AppSettings["url"] + @"/#admin");
        }

        [Then(@"se registra en base de datos el usuario con sesión activa en la tabla AFW_USER_SESSION_TOKEN")]
        public void ThenSeRegistraEnBaseDeDatosElUsuarioConSesionActivaEnLaTablaAFW_USER_SESSION_TOKEN()
        {
            user_id = CommonQuery.DBSelectAValue("SELECT user_id FROM AFW_USERS WHERE user_nick_name = 'thrash';", 1);
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_USER_SESSION_TOKEN WHERE id = " + user_id + ";", 1);
        }

        [Then(@"Se cierra la sesión exitosamente del usuario administrador")]
        public void ThenSeCierraLaSesionExitosamenteDelUsuarioAdministrador()
        {
            UrlNow = CommonHooks.driver.Url;
            Assert.AreEqual(ConfigurationManager.AppSettings["url"] + @"/LogOn", UrlNow);
        }

        [Then(@"se elimina el registro de sesión de usuario de la tabla AFW_USER_SESSION_TOKEN")]
        public void ThenSeEliminaElRegistroDeSesionDeUsuarioDeLaTablaAFW_USER_SESSION_TOKEN()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_USER_SESSION_TOKEN WHERE id = " + user_id + ";", 0);
        }
    }
}