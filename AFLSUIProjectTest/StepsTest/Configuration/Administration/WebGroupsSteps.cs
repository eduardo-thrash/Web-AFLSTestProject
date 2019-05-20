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
    public class WebGroupsSteps
    {
        private readonly WebGroupsPage WebGroupsPage = new WebGroupsPage();
        private readonly PageMessages PageMessages = new PageMessages();

        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        private string DefaultGroupName = "UI Group Web";
        private string EditGroupName = "UI Edit Group Web";
        private string GroupName;
        private string GroupUserName;
        private int GroupId;
        private int UserId;
        private string UserName;

        [Given(@"No existe el grupo web")]
        public void GivenNoExisteElGrupoWeb()
        {
            GroupName = DefaultGroupName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUPS GRP JOIN AFLS_GROUPS_WEB GRW ON GRP.grou_id = GRW.grou_id AND grou_name = '" + GroupName + "';", 0);
        }

        [When(@"Diligencio nombre de grupo web")]
        public void WhenDiligencioNombreDeGrupoWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebGroupsPage.WebGroupName, GroupName);
        }

        [When(@"Diligencio descripción de grupo web")]
        public void WhenDiligencioDescripcionDeGrupoWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebGroupsPage.WebGroupDescription, "Descripcion de grupos web admin");
        }

        [When(@"Selecciono rol administrador de grupo web")]
        public void WhenSeleccionoRolAdministradorDeGrupoWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupCheckRoleAdministrator);
        }

        [When(@"Selecciono rol monitor de grupo web")]
        public void WhenSeleccionoRolMonitorDeGrupoWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupCheckRoleMonitor);
        }

        [When(@"Selecciono rol despachador de grupo web")]
        public void WhenSeleccionoRolDespachadorDeGrupoWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupCheckRoleDispatcher);
        }

        [When(@"Selecciono rol gestor de inventario de grupo web")]
        public void WhenSeleccionoRolGestorDeInventarioDeGrupoWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupCheckRoleInventory);
        }

        [When(@"Selecciono el Tab Usuarios de grupos web")]
        public void WhenSeleccionoElTabUsuariosDeGruposWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupTabUsers);
        }

        [When(@"Diligencio y selecciono el usuario para el grupo web")]
        public void WhenDiligencioYSeleccionoElUsuarioParaElGrupoWeb()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 URS.user_id FROM AFW_USERS URS JOIN AFLS_USERS_WEB WEB ON URS.user_id = WEB.user_id WHERE URS.user_active = 1 ORDER BY NEWID();", 1));
            UserName = CommonQuery.DBSelectAValue("SELECT user_name FROM AFW_USERS WHERE user_id = " + UserId + ";", 1);
            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", WebGroupsPage.WebGroupUsers, UserName, "a");
        }

        [When(@"Selecciono el Tab Grupos web")]
        public void WhenSeleccionoElTabGruposWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupTabWebGroup);
        }

        [When(@"Doy click en Guardar grupo web")]
        public void WhenDoyClickEnGuardarGrupoWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupSubmit);
        }

        [Then(@"Se registra el grupo en la tabla AFW_GROUPS")]
        public void ThenSeRegistraElGrupoEnLaTablaAFW_GROUPS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUPS WHERE grou_name = '" + GroupName + "';", 1);
        }

        [Then(@"Se registra el grupo web en la tabla AFLS_GROUPS_WEB")]
        public void ThenSeRegistraElGrupoWebEnLaTablaAFLS_GROUPS_WEB()
        {
            GroupId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT grou_id FROM AFLS_GROUPS_WEB WHERE grou_id = (SELECT grou_id FROM AFW_GROUPS WHERE grou_name = '" + GroupName + "');", 1));
        }

        [Then(@"Se registra el usuario asociado al grupo web en la tabla AFW_GROUP_USER")]
        public void ThenSeRegistraElUsuarioAsociadoAlGrupoWebEnLaTablaAFW_GROUP_USER()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUP_USER WHERE user_id = " + UserId + " AND grou_id = " + GroupId + ";", 1);
        }

        [Given(@"El grupo web existe")]
        public void GivenElGrupoWebExiste()
        {
            GroupName = CommonQuery.DBSelectAValue("SELECT TOP 1 GRP.grou_name FROM AFW_GROUPS GRP JOIN AFLS_GROUPS_WEB GRW ON GRP.grou_id = GRW.grou_id ORDER BY NEWID();", 1);
        }

        [When(@"Busco y selecciono el grupo web")]
        public void WhenBuscoYSeleccionoElGrupoWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebGroupsPage.WebGroupFieldSearch, GroupName);
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupButtonSearch);

            UtilAction.Click(WebGroupsPage.WebGroupView);
        }

        [Then(@"Se muestra la tarjeta del grupo web y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelGrupoWebYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(WebGroupsPage.WebGroupName)).GetAttribute("value");
            Assert.AreEqual(GroupName, Value);
        }

        [When(@"Edito nombre de grupo web")]
        public void WhenEditoNombreDeGrupoWeb()
        {
            EditGroupName = EditGroupName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", WebGroupsPage.WebGroupName, EditGroupName);
        }

        [Then(@"Se registra el grupo editado en la tabla AFW_GROUPS")]
        public void ThenSeRegistraElGrupoEditadoEnLaTablaAFW_GROUPS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUPS WHERE grou_name = '" + EditGroupName + "';", 1);
        }

        [When(@"Doy click en eliminar grupo web")]
        public void WhenDoyClickEnEliminarGrupoWeb()
        {
            CommonElementsAction.Click("XPath", WebGroupsPage.WebGroupIconRemoved);
        }

        [Then(@"No se registra el grupo en la tabla AFW_GROUPS")]
        public void ThenNoSeRegistraElGrupoEnLaTablaAFW_GROUPS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUPS WHERE grou_name = '" + GroupName + "';", 0);
        }

        [When(@"Doy click en Nuevo grupo web")]
        public void WhenDoyClickEnNuevoGrupoWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupButtonNew);
        }
    }
}