using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class PositionsSteps
    {
        private readonly ElementsPosition ElementsPosition = new ElementsPosition();
        private readonly PageMessages PageMessages = new PageMessages();

        [Given(@"El cargo no existe")]
        public void GivenElCargoNoExiste()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en Nuevo cargo")]
        public void WhenDoyClickEnNuevoCargo()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Diligencio nombre de cargo")]
        public void WhenDiligencioNombreDeCargo()
        {
            CommonElementsAction.Click("CssSelector", ElementsPosition.PositionTabPositionInfo);
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsPosition.PositionName, "Especialista UI");
        }

        [When(@"Diligencio costo por hora")]
        public void WhenDiligencioCostoPorHora()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsPosition.PositionCost, "12000");
        }

        [When(@"Doy click en switch de cargo")]
        public void WhenDoyClickEnSwitchDeCargo()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en Guardar cargo")]
        public void WhenDoyClickEnGuardarCargo()
        {
            CommonElementsAction.Click("CssSelector", ElementsPosition.PositionSubmit);
        }

        [Then(@"Se registra el cargo en la tabla AFLS_WORK_POSITIONS")]
        public void ThenSeRegistraElCargoEnLaTablaAFLS_WORK_POSITIONS()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"El cargo existe")]
        public void GivenElCargoExiste()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Busco y selecciono el cargo")]
        public void WhenBuscoYSeleccionoElCargo()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsPosition.PositionFieldSearch, "Tecnico WT");
            CommonElementsAction.Click("CssSelector", ElementsPosition.PositionButtonSearch);

            CommonElementsAction.Click("CssSelector", ElementsPosition.PositionView);
        }

        [Then(@"Se muestra la tarjeta del cargo y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelCargoYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsPosition.PositionName)).GetAttribute("value");
            Assert.AreEqual("Tecnico WT", Value);
        }

        [When(@"Edito nombre de cargo")]
        public void WhenEditoNombreDeCargo()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsPosition.PositionName, "Instalador Update WT");
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsPosition.PositionCost, "21000");
        }

        [Then(@"Se registra el cargo modificado en la tabla AFLS_WORK_POSITIONS")]
        public void ThenSeRegistraElCargoModificadoEnLaTablaAFLS_WORK_POSITIONS()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en eliminar cargo")]
        public void WhenDoyClickEnEliminarCargo()
        {
            CommonElementsAction.Click("XPath", ElementsPosition.PositionIconRemoved);
        }

        [Then(@"No se registra el cargo en la tabla AFLS_WORK_POSITIONS")]
        public void ThenNoSeRegistraElCargoEnLaTablaAFLS_WORK_POSITIONS()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Al buscar el cargo en la aplicación no se lista")]
        public void ThenAlBuscarElCargoEnLaAplicacionNoSeLista()
        {
            ScenarioContext.Current.Pending();
        }
    }
}