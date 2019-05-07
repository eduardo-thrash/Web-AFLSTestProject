using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class WebGroupsSteps
    {
        private readonly WebGroupsPage WebGroupsPage = new WebGroupsPage();
        private readonly PageMessages PageMessages = new PageMessages();

        [Given(@"No existe el grupo web")]
        public void GivenNoExisteElGrupoWeb()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Diligencio nombre de grupo web")]
        public void WhenDiligencioNombreDeGrupoWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebGroupsPage.WebGroupName, "Grupo FullAdmin UI");
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
            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", WebGroupsPage.WebGroupUsers, "Mike Hernandez WT", "a");
        }

        [When(@"Selecciono el Tab Grupos web")]
        public void WhenSeleccionoElTabGruposWeb()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en Guardar grupo web")]
        public void WhenDoyClickEnGuardarGrupoWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupSubmit);
        }

        [Then(@"Se registra el grupo en la tabla AFW_GROUPS")]
        public void ThenSeRegistraElGrupoEnLaTablaAFW_GROUPS()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el grupo web en la tabla AFLS_GROUPS_WEB")]
        public void ThenSeRegistraElGrupoWebEnLaTablaAFLS_GROUPS_WEB()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el usuario asociado al grupo web en la tabla AFW_GROUP_USER")]
        public void ThenSeRegistraElUsuarioAsociadoAlGrupoWebEnLaTablaAFW_GROUP_USER()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"El grupo web existe")]
        public void GivenElGrupoWebExiste()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Busco y selecciono el grupo web")]
        public void WhenBuscoYSeleccionoElGrupoWeb()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", WebGroupsPage.WebGroupFieldSearch, "Grupo Administradores WT");
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupButtonSearch);

            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupView);
        }

        [Then(@"Se muestra la tarjeta del grupo web y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelGrupoWebYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(WebGroupsPage.WebGroupName)).GetAttribute("value");
            Assert.AreEqual("Grupo Administradores WT", Value);
        }

        [When(@"Edito nombre de grupo web")]
        public void WhenEditoNombreDeGrupoWeb()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", WebGroupsPage.WebGroupName, "Grupo Monitores update WT");
        }

        [Then(@"Se registra el grupo editado en la tabla AFW_GROUPS")]
        public void ThenSeRegistraElGrupoEditadoEnLaTablaAFW_GROUPS()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en eliminar grupo web")]
        public void WhenDoyClickEnEliminarGrupoWeb()
        {
            CommonElementsAction.Click("XPath", WebGroupsPage.WebGroupIconRemoved);
        }

        [Then(@"No se registra el grupo en la tabla AFW_GROUPS")]
        public void ThenNoSeRegistraElGrupoEnLaTablaAFW_GROUPS()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en Nuevo grupo web")]
        public void WhenDoyClickEnNuevoGrupoWeb()
        {
            CommonElementsAction.Click("CssSelector", WebGroupsPage.WebGroupButtonNew);
        }
    }
}