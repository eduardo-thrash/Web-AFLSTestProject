using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
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
        private readonly MeansTransportPage MeansTransportPage = new MeansTransportPage();
        private readonly PageMessages PageMessages = new PageMessages();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private string DefaultVehicleName = "UI Vehicle ";
        private string EditVehicleName = "UI Vehicle edit ";
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private MessagesElements MessagesElements = new MessagesElements();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private string VehicleName;

        [Given(@"El transporte existe")]
        public void GivenElTransporteExiste()
        {
            VehicleName = CommonQuery.DBSelectAValue("SELECT TOP 1 vehi_name FROM AFLS_VEHICLE_TYPE WHERE vehi_active = 1 ORDER BY NEWID();", 1);
        }

        [Given(@"El transporte no existe")]
        public void GivenElTransporteNoExiste()
        {
            VehicleName = DefaultVehicleName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_VEHICLE_TYPE WHERE vehi_name = '" + VehicleName + "';", 0);
        }

        [Then(@"Al buscar el transporte en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElTransporteEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", MeansTransportPage.TransportFieldSearch, VehicleName);
            CommonElementsAction.Click("CssSelector", MeansTransportPage.TransportButtonSearch);
            Thread.Sleep(3000);
            CommonElementsAction.WaitElementNoFound(MeansTransportPage.TransportView, "XPath");
        }

        [Then(@"No se registra el transporte en la tabla AFLS_VEHICLE_TYPE")]
        public void ThenNoSeRegistraElTransporteEnLaTablaAFLS_VEHICLE_TYPE()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_VEHICLE_TYPE WHERE vehi_name = '" + VehicleName + "';", 0);
        }

        [Then(@"Se muestra la tarjeta del transporte y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelTransporteYElDetalleDelMismo()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(MeansTransportPage.MeansTransportName)).GetAttribute("value");
            Assert.AreEqual(VehicleName, Value);
        }

        [Then(@"Se registra el transporte en la tabla AFLS_VEHICLE_TYPE")]
        public void ThenSeRegistraElTransporteEnLaTablaAFLS_VEHICLE_TYPE()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_VEHICLE_TYPE WHERE vehi_name = '" + VehicleName + "';", 1);
        }

        [Then(@"Se registra modificado el transporte en la tabla AFLS_VEHICLE_TYPE")]
        public void ThenSeRegistraModificadoElTransporteEnLaTablaAFLS_VEHICLE_TYPE()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_VEHICLE_TYPE WHERE vehi_name = '" + EditVehicleName + "';", 1);
        }

        [When(@"Busco y selecciono el transporte")]
        public void WhenBuscoYSeleccionoElTransporte()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MeansTransportPage.TransportFieldSearch, VehicleName);
            CommonElementsAction.Click("CssSelector", MeansTransportPage.TransportButtonSearch);

            UtilAction.Click(MeansTransportPage.TransportView);
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

        [When(@"Diligencio descripción de transporte")]
        public void WhenDiligencioDescripcionDeTransporte()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MeansTransportPage.MeansTransportDescription, "Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur. Nunc et dolor vitae libero rutrum eleifend.");
        }

        [When(@"Diligencio nombre de transporte")]
        public void WhenDiligencioNombreDeTransporte()
        {
            UtilAction.SendKeys(MeansTransportPage.MeansTransportName, VehicleName, "CssSelector");
        }

        [When(@"Doy click en eliminar transporte")]
        public void WhenDoyClickEnEliminarTransporte()
        {
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", MeansTransportPage.TransportIconRemoved);
        }

        [When(@"Doy click en Guardar transporte")]
        public void WhenDoyClickEnGuardarTransporte()
        {
            CommonElementsAction.Click("CssSelector", MeansTransportPage.MeansTransportSubmit);
        }

        [When(@"Doy click en Nuevo transporte")]
        public void WhenDoyClickEnNuevoTransporte()
        {
            UtilAction.Click(MeansTransportPage.MeansTransportButtonNew, "CssSelector");
        }

        [When(@"Edito nombre de transporte")]
        public void WhenEditoNombreDeTransporte()
        {
            EditVehicleName = EditVehicleName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", MeansTransportPage.MeansTransportName, EditVehicleName);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", MeansTransportPage.MeansTransportDescription, "Lorem update ipsum dolor sit amet consectetur adipiscing elit.");
        }

        [When(@"Selecciono medio de transporte")]
        public void WhenSeleccionoMedioDeTransporte()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", MeansTransportPage.MeansTransportsInfoTransport, "Automóvil", "label");
        }

        [When(@"Selecciono tipo de transporte publico si se habilita")]
        public void WhenSeleccionoTipoDeTransportePublicoSiSeHabilita()
        {
            Thread.Sleep(4000);
            try
            {
                CommonElementsAction.WaitElement("//div[@id='tabs-1']//div[@class='value TypeTransport disabled']");
            }
            catch
            {
                CommonElementsAction.WaitElement("//div[@id='tabs-1']//div[@class='value TypeTransport']");
                CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", "//*[@id='TransportPublic']/div/a", "//div[@id='TransportPublic']/ul/li/a/label");
            }
        }
    }
}