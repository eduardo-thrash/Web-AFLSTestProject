using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.Configuration.Monitor
{
    [Binding]
    public class SpecialistMonitorConfigurationSteps
    {
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private MobileUsersPage MobileUsersPage = new MobileUsersPage();

        private string SpecialistNickName;
        private string DefaultSpecialistNickName = "ui.specialist";
        private string EditSpecialistNickName = "ui.specialist.edit";
        private string SpecialistName = "UI Specialist";
        private int SpecialistId;
        private int UserId;

        [When(@"Selecciono la opción especialistas")]
        public void WhenSeleccionoLaOpcionEspecialistas()
        {
            CommonElementsAction.Click("XPath", "//div[@class='admin']//li[@class='active has-sub open _monitoring']//a[@href='#admin/users/mobile']");
            Thread.Sleep(5000);
        }

        [Given(@"no existe el especialista")]
        public void GivenNoExisteElEspecialista()
        {
            SpecialistNickName = DefaultSpecialistNickName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT * FROM  AFW_USERS WHERE user_nick_name = '" + SpecialistNickName + "';", 0);
        }

        [When(@"Accedo al menú Configuración de monitor")]
        public void WhenAccedoAlMenuConfiguracionDeMonitor()
        {
            Actions action = new Actions(CommonHooks.driver);
            IWebElement ItemConfiguration = CommonHooks.driver.FindElement(By.XPath(PrincipalMenuPage.ItemConfiguration));
            action.Release(ItemConfiguration).Build().Perform();
            CommonElementsAction.Click("XPath", "//li/a[@href='#admin/users/mobile/monitoring']");
        }

        [When(@"Doy click en Nuevo especialista de proveedor")]
        public void WhenDoyClickEnNuevoEspecialistaDeProveedor()
        {
            CommonElementsAction.Click("XPath", "//div[@class='users']//input[@id='commonNewItem']");
        }

        [When(@"Diligencio nombre de especialista de proveedor")]
        public void WhenDiligencioNombreDeEspecialistaDeProveedor()
        {
            CommonElementsAction.SendKeys_InputText("XPath", "//div[@class='users']//div[@id='tabs-1']//input[@name='Name']", SpecialistName + Functions.RandomText());
        }

        [When(@"Diligencio usuario de especialista de proveedor")]
        public void WhenDiligencioUsuarioDeEspecialistaDeProveedor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserUserName, SpecialistNickName);
        }

        [When(@"diligencio correo electrónico valido de especialista de proveedor")]
        public void WhenDiligencioCorreoElectronicoValidoDeEspecialistaDeProveedor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserEmail, "specialist@mailer.com");
        }

        [When(@"Diligencio teléfono de especialista de proveedor")]
        public void WhenDiligencioTelefonoDeEspecialistaDeProveedor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserPhone, "3008425830");
        }

        [When(@"diligencio contraseña de especialista de proveedor")]
        public void WhenDiligencioContrasenaDeEspecialistaDeProveedor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserPassword, "123456");
        }

        [When(@"selecciono cargo de especialista de proveedor")]
        public void WhenSeleccionoCargoDeEspecialistaDeProveedor()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("CssSelector", MobileUsersPage.MobileUserPosition, MobileUsersPage.MobileUserPositionOption);
        }

        [When(@"diligencio dirección valida de especialista de proveedor dando click en cursor")]
        public void WhenDiligencioDireccionValidaDeEspecialistaDeProveedorDandoClickEnCursor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA");
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserAddress);
        }

        [When(@"modifico dirección valida de especialista de proveedor dando click en cursor")]
        public void WhenModificoDireccionValidaDeEspecialistaDeProveedorDandoClickEnCursor()
        {
            UtilAction.Clear(MobileUsersPage.MobileUserAddress, "CssSelector");
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA");
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserAddressValidate);
            Thread.Sleep(3000);
        }

        [When(@"modifico dirección valida de especialista de proveedor dando enter")]
        public void WhenModificoDireccionValidaDeEspecialistaDeProveedorDandoEnter()
        {
            UtilAction.Clear(MobileUsersPage.MobileUserAddress, "CssSelector");
            UtilAction.EnterAfter_SendKeys(MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA", "CssSelector");
        }

        [When(@"modifico dirección valida de especialista de proveedor dando Tab")]
        public void WhenModificoDireccionValidaDeEspecialistaDeProveedorDandoTab()
        {
            UtilAction.Clear(MobileUsersPage.MobileUserAddress, "CssSelector");
            UtilAction.TabAfter_SendKeys(MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA", "CssSelector");
        }

        [When(@"modifico dirección valida de especialista de proveedor dando click en mapa")]
        public void WhenModificoDireccionValidaDeEspecialistaDeProveedorDandoClickEnMapa()
        {
            UtilAction.Click(MobileUsersPage.MobileUserAddress, "CssSelector");
            IWebElement UserMap = CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-1']//div[@id='mapUsersAddress']"));
            Actions ac = new Actions(CommonHooks.driver);
            ac.MoveToElement(UserMap);
            ac.MoveByOffset(20, 20);
            ac.Click().Build().Perform();
            
        }

        [When(@"diligencio dirección valida de especialista de proveedor click en mapa")]
        public void WhenDiligencioDireccionValidaDeEspecialistaDeProveedorClickEnMapa()
        {
            
            IWebElement UserMap = CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-1']//div[@id='mapUsersAddress']"));
            Actions ac = new Actions(CommonHooks.driver);
            ac.MoveToElement(UserMap);
            ac.MoveByOffset(20, 20);
            ac.Click().Build().Perform();
        }

        [When(@"diligencio dirección valida de especialista de proveedor dando enter")]
        public void WhenDiligencioDireccionValidaDeEspecialistaDeProveedorDandoEnter()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA");
        }

        [When(@"diligencio dirección valida de especialista de proveedor dando tab")]
        public void WhenDiligencioDireccionValidaDeEspecialistaDeProveedorDandoTab()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA");
            Thread.Sleep(2000);
            CommonHooks.driver.FindElement(By.CssSelector(MobileUsersPage.MobileUserAddress)).SendKeys(Keys.Tab);
        }

        [When(@"selecciono sede de inventario para especialista de proveedor")]
        public void WhenSeleccionoSedeDeInventarioParaEspecialistaDeProveedor()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("CssSelector", MobileUsersPage.MobileUserLocation, MobileUsersPage.MobileUserLocationOption);
        }

        [When(@"selecciono tipo de transporte de especialista de proveedor")]
        public void WhenSeleccionoTipoDeTransporteDeEspecialistaDeProveedor()
        {
            string Vehicle = CommonQuery.DBSelectAValue("SELECT TOP 1 vehi_name FROM AFLS_VEHICLE_TYPE ORDER BY NEWID();", 1);
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", MobileUsersPage.MobileUserTransport, Vehicle, "label");
        }

        [When(@"Doy click en Guardar especialista")]
        public void WhenDoyClickEnGuardarEspecialista()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserSubmit);
        }

        [When(@"Busco y selecciono el especialista de proveedor")]
        public void WhenBuscoYSeleccionoElEspecialistaDeProveedor()
        {
            SpecialistNickName = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_id = " + UserId + ";", 1);
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserFieldSearch, SpecialistNickName);
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserButtonSearch);
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", MobileUsersPage.MobileUserView);
        }

        [Given(@"Existe el especialista con proveedor y monitor relacionado")]
        public void GivenExisteElEspecialistaConProveedorYMonitorRelacionado()
        {
            try
            {
                CommonQuery.DBSelectAValue("SELECT TOP 1 PRM.UserId FROM AFLS_USERS_SPECIALISTS SPE JOIN AFLS_PROVIDER_MONITORS PRM ON PRM.ProviderId = SPE.spc_provider_id ORDER BY NEWID();", 1);
                UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 SPE.user_id FROM AFLS_USERS_SPECIALISTS SPE JOIN AFLS_PROVIDER_MONITORS PRM ON PRM.ProviderId = SPE.spc_provider_id ORDER BY NEWID();", 1));
            }
            catch
            {
                try
                {
                    Functions.DBInsert("INSERT INTO AFLS_PROVIDER_MONITORS"
                                    + "(ProviderId"
                                    + ", UserId)"
                                    + "VALUES"
                                    + "(1"
                                    + ", (SELECT user_id FROM AFW_USERS WHERE user_nick_name = 'thrash'));");
                    UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 PRM.UserId FROM AFLS_USERS_SPECIALISTS SPE JOIN AFLS_PROVIDER_MONITORS PRM ON PRM.ProviderId = SPE.spc_provider_id ORDER BY NEWID();", 1));
                }
                catch
                {
                    Assert.Fail("Error en consulta " + "SELECT TOP 1 PRM.UserId FROM AFLS_USERS_SPECIALISTS SPE JOIN AFLS_PROVIDER_MONITORS PRM ON PRM.ProviderId = SPE.spc_provider_id ORDER BY NEWID();");
                }
            }
        }

        [Then(@"Se registra el especialista de proveedor en la tabla AFW_USERS")]
        public void ThenSeRegistraElEspecialistaDeProveedorEnLaTablaAFW_USERS()
        {
            CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = '" + SpecialistNickName + "';", 1);
        }

        [Then(@"Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección")]
        public void ThenSeRegistraElEspecialistaDeProveedorConProveedorAsociadoEnLaTablaAFLS_USERS_SPECIALISTSConLongitudLatitudYDireccion()
        {
            SpecialistId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT user_id FROM AFW_USERS WHERE user_nick_name = '" + SpecialistNickName + "';", 1));
            CommonQuery.DBSelectAValue("SELECT user_id FROM AFLS_USERS_SPECIALISTS WHERE user_id = " + SpecialistId + " AND spc_initial_address IS NOT NULL AND spc_initial_longitude IS NOT NULL AND spc_initial_latitude IS NOT NULL;", 1);
        }

        [Then(@"Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección modificado")]
        public void ThenSeRegistraElEspecialistaDeProveedorConProveedorAsociadoEnLaTablaAFLS_USERS_SPECIALISTSConLongitudLatitudYDireccionModificado()
        {
            SpecialistId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT user_id FROM AFW_USERS WHERE user_nick_name = '" + SpecialistNickName + "';", 1));
            CommonQuery.DBSelectAValue("SELECT user_id FROM AFLS_USERS_SPECIALISTS WHERE user_id = " + SpecialistId + " AND spc_initial_address IS NOT NULL AND spc_initial_longitude IS NOT NULL AND spc_initial_latitude IS NOT NULL;", 1);
        }
    }
}