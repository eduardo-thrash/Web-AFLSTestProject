using AFLSUIProjectTest.StepsTest.AFLS;
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
    public class MeansTransportSteps
    {
        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private readonly MeansTransportPage MeansTransportPage = new MeansTransportPage();
        private readonly PageMessages PageMessages = new PageMessages();

        [Given(@"El transporte no existe")]
        public void GivenElTransporteNoExiste()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Diligencio nombre de transporte")]
        public void WhenDiligencioNombreDeTransporte()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en Nuevo transporte")]
        public void WhenDoyClickEnNuevoTransporte()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MeansTransportPage.MeansTransportName, "Automóvil UI");
            ;
        }

        [When(@"Diligencio descripción de transporte")]
        public void WhenDiligencioDescripcionDeTransporte()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MeansTransportPage.MeansTransportDescription, "Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur. Nunc et dolor vitae libero rutrum eleifend.");
        }

        [When(@"Diligencio costo inicial de transporte")]
        public void WhenDiligencioCostoInicialDeTransporte()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", MeansTransportPage.MeansTransportInitialcost, "0");
        }

        [When(@"Diligencio costo por kilómetro de transporte")]
        public void WhenDiligencioCostoPorKilometroDeTransporte()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", MeansTransportPage.MeansTransportCostByKilometer, "890");
        }

        [When(@"Selecciono medio de transporte")]
        public void WhenSeleccionoMedioDeTransporte()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", MeansTransportPage.MeansTransportsInfoTransport, "Automóvil", "label");
        }

        [When(@"Selecciono tipo de transporte publico si se habilita")]
        public void WhenSeleccionoTipoDeTransportePublicoSiSeHabilita()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en switch de estado de transporte")]
        public void WhenDoyClickEnSwitchDeEstadoDeTransporte()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en Guardar transporte")]
        public void WhenDoyClickEnGuardarTransporte()
        {
            CommonElementsAction.Click("CssSelector", MeansTransportPage.MeansTransportSubmit);
        }

        [Then(@"Se registra el transporte en la tabla AFLS_VEHICLE_TYPE")]
        public void ThenSeRegistraElTransporteEnLaTablaAFLS_VEHICLE_TYPE()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"El transporte existe")]
        public void GivenElTransporteExiste()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Busco y selecciono el transporte")]
        public void WhenBuscoYSeleccionoElTransporte()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MeansTransportPage.TransportFieldSearch, "Moto WT");
            CommonElementsAction.Click("CssSelector", MeansTransportPage.TransportButtonSearch);

            CommonElementsAction.Click("CssSelector", MeansTransportPage.TransportView);
        }

        [Then(@"Se muestra la tarjeta del transporte y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelTransporteYElDetalleDelMismo()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(MeansTransportPage.MeansTransportName)).GetAttribute("value");
            Assert.AreEqual("Automovil WT", Value);
        }

        [When(@"Edito nombre de transporte")]
        public void WhenEditoNombreDeTransporte()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", MeansTransportPage.MeansTransportName, "Moto WT Update");
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", MeansTransportPage.MeansTransportDescription, "Lorem update ipsum dolor sit amet consectetur adipiscing elit.");
        }

        [Then(@"Se registra modificado el transporte en la tabla AFLS_VEHICLE_TYPE")]
        public void ThenSeRegistraModificadoElTransporteEnLaTablaAFLS_VEHICLE_TYPE()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en eliminar transporte")]
        public void WhenDoyClickEnEliminarTransporte()
        {
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", MeansTransportPage.TransportIconRemoved);
        }

        [Then(@"No se registra el transporte en la tabla AFLS_VEHICLE_TYPE")]
        public void ThenNoSeRegistraElTransporteEnLaTablaAFLS_VEHICLE_TYPE()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Al buscar el transporte en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElTransporteEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            ScenarioContext.Current.Pending();
        }
    }
}