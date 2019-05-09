using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class WebUsersSteps
    {
        private readonly WebUsersPage WebUsersPage = new WebUsersPage();
        private readonly PageMessages PageMessages = new PageMessages();

        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        private string DefaultUserName = "UI User Web";
        private string EditUserName = "UI Edit User Web";
        private string UserName;
        private string User_NickName;
        private string Default_User_NickName = "user.web.";
        private string GroupName;
        private int GroupId;
        private int UserId;

        [Given(@"No existe el usuario web")]
        public void GivenNoExisteElUsuarioWeb()
        {
            User_NickName = Default_User_NickName + Functions.RandomText(4);
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_USERS USR JOIN AFLS_USERS_WEB WEB ON USR.user_id = WEB.user_id WHERE USR.user_nick_name = '" + User_NickName + "';", 0);
        }

        [When(@"Doy click en Nuevo Usuario Web")]
        public void WhenDoyClickEnNuevoUsuarioWeb()
        {
            CommonElementsAction.Click("XPath", WebUsersPage.WebUserButtonNew);
        }

        [Then(@"Se registra el usuario web en la tabla AFW_USERS")]
        public void ThenSeRegistraElUsuarioWebEnLaTablaAFW_USERS()
        {
            CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = '" + User_NickName + "';", 1);
        }

        [When(@"Diligencio nombre de usuario web")]
        public void WhenDiligencioNombreDeUsuarioWeb()
        {
            UserName = DefaultUserName + Functions.RandomText();
            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserName, UserName);
        }

        [When(@"Diligencio usuario de usuario web")]
        public void WhenDiligencioUsuarioDeUsuarioWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserUserName, User_NickName);
        }

        [When(@"Diligencio correo electrónico de usuario web")]
        public void WhenDiligencioCorreoElectronicoDeUsuarioWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserEmail, User_NickName + "@mail.com");
        }

        [When(@"Diligencio teléfono de usuario web")]
        public void WhenDiligencioTelefonoDeUsuarioWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserPhone, "3115246985");
        }

        [When(@"Diligencio contraseña de usuario web")]
        public void WhenDiligencioContrasenaDeUsuarioWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserPassword, "123456");
        }

        [When(@"Selecciono el Tab Grupos Web de usuarios web")]
        public void WhenSeleccionoElTabGruposWebDeUsuariosWeb()
        {
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserTabWebGroups);
        }

        [When(@"Diligencio y selecciono el grupo para el usuario web")]
        public void WhenDiligencioYSeleccionoElGrupoParaElUsuarioWeb()
        {
            GroupId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 GRP.grou_id FROM AFW_GROUPS GRP JOIN AFLS_GROUPS_WEB WEB ON GRP.grou_id = WEB.grou_id WHERE GRP.grou_is_active = 1 ORDER BY NEWID();", 1));

            GroupName = CommonQuery.DBSelectAValue("SELECT grou_name FROM AFW_GROUPS WHERE grou_id = " + GroupId + ";", 1);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", WebUsersPage.WebUserGroupWeb, GroupName, "a");
        }

        [When(@"Selecciono el Tab Información de usuario")]
        public void WhenSeleccionoElTabInformacionDeUsuario()
        {
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserTabUserInfo);
        }

        [When(@"Doy click en Guardar usuario web")]
        public void WhenDoyClickEnGuardarUsuarioWeb()
        {
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserSubmit);
        }

        [Then(@"Se registra el usuario web en la tabla AFLS_USERS_WEB")]
        public void ThenSeRegistraElUsuarioWebEnLaTablaAFLS_USERS_WEB()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT * FROM AFW_USERS USR JOIN AFLS_USERS_WEB WEB ON USR.user_id = WEB.user_id WHERE USR.user_nick_name = '" + User_NickName + "';", 1));
        }

        [Then(@"Se registra el grupo web asociado al usuario web en la tabla AFW_GROUP_USER")]
        public void ThenSeRegistraElGrupoWebAsociadoAlUsuarioWebEnLaTablaAFW_GROUP_USER()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUP_USER WHERE user_id = " + UserId + " AND grou_id = " + GroupId + ";", 1);
        }

        [Given(@"Existe el usuario web")]
        public void GivenExisteElUsuarioWeb()
        {
            UserName = CommonQuery.DBSelectAValue("SELECT USR.user_name FROM AFW_USERS USR JOIN AFLS_USERS_WEB WEB ON USR.user_id = WEB.user_id ORDER BY NEWID();", 1);
        }

        [When(@"Busco y selecciono el usuario web")]
        public void WhenBuscoYSeleccionoElUsuarioWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserFieldSearch, UserName);
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserButtonSearch);

            CommonElementsAction.Click("XPath", WebUsersPage.WebUserView);
        }

        [Then(@"Se muestra la tarjeta del usuario web y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelUsuarioWebYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(WebUsersPage.WebUserName)).GetAttribute("value");
            Assert.AreEqual(UserName, Value);
        }

        [When(@"Edito nombre de usuario web")]
        public void WhenEditoNombreDeUsuarioWeb()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en eliminar usuario web")]
        public void WhenDoyClickEnEliminarUsuarioWeb()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"No se registra el usuario en la tabla AFW_USERS")]
        public void ThenNoSeRegistraElUsuarioEnLaTablaAFW_USERS()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono rol administrador de usuario web")]
        public void WhenSeleccionoRolAdministradorDeUsuarioWeb()
        {
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserCheckAdministrator);
        }

        [When(@"Selecciono rol monitor de usuario web")]
        public void WhenSeleccionoRolMonitorDeUsuarioWeb()
        {
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserCheckMonitor);
        }

        [When(@"Selecciono rol despachador de usuario web")]
        public void WhenSeleccionoRolDespachadorDeUsuarioWeb()
        {
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserCheckDispatcher);
        }

        [When(@"Selecciono rol gestor de inventario de usuario web")]
        public void WhenSeleccionoRolGestorDeInventarioDeUsuarioWeb()
        {
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserCheckInventory);
        }

        [When(@"Creación exitosa de usuario web")]
        public void WhenCreacionExitosaDeUsuarioWeb()
        {
            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.
        }

        [When(@"Busqueda exitosa de usuario web existente")]
        public void WhenBusquedaExitosaDeUsuarioWebExistente()
        {
            //Navigate Module List Content

            //LogOut.

            //End LogOut.
        }

        [When(@"Modificación exitosa de usuario web")]
        public void WhenModificacionExitosaDeUsuarioWeb()
        {
            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserFieldSearch, "Oscar Carillo WT");
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserButtonSearch);

            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserView);

            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserTabUserInfo);

            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserName, "Oscar Carillo update WT");

            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserUserName, "carillo.update");

            //Save
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserFieldSearch, "Oscar Carillo update WT");
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserButtonSearch);

            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(WebUsersPage.WebUserName)).GetAttribute("value");
            Assert.AreEqual("Oscar Carillo update WT", Value);

            //LogOut.

            //End LogOut.
        }

        [When(@"Borrado exitoso de usuario web existente")]
        public void WhenBorradoExitosoDeUsuarioWebExistente()
        {
            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", WebUsersPage.WebUserFieldSearch, "Oscar Carillo WT");
            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserButtonSearch);

            CommonElementsAction.Click("CssSelector", WebUsersPage.WebUserView);

            //Delete element of List
            Thread.Sleep(3000);

            //End Delete element of List

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }
    }
}