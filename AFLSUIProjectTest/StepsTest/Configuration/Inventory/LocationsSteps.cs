using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Inventory
{
    [Binding]
    public class LocationsSteps
    {
        private readonly ElementsLocationHeadquater LocationsHeadquaterPage = new ElementsLocationHeadquater();
        private readonly ElementsLocationTransport LocationsTransportPage = new ElementsLocationTransport();
        private readonly ElementsLocation LocationsPage = new ElementsLocation();
        private readonly PageMessages PageMessages = new PageMessages();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private UtilAction UtilAction = new UtilAction();

        private static string DefaultHeadquaterName = "UI Sede ";
        private static string EditHeadquaterName;
        private static string HeadquaterName = "UI Sede Edit ";

        private static string DefaultTransportName = "UI Sede ";
        private static string EditTransportName;
        private static string TransportName = "UI Sede Edit ";

        [Given(@"No existe la ubicación de tipo sede")]
        public void GivenNoExisteLaUbicacionDeTipoSede()
        {
            HeadquaterName = DefaultHeadquaterName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_LOCATION_INFO WHERE grou_name = '" + HeadquaterName + "';", 0);
        }

        [When(@"Doy click en Nueva ubicación sede")]
        public void WhenDoyClickEnNuevaUbicacionSede()
        {
            CommonElementsAction.Click("CssSelector", LocationsHeadquaterPage.LocationHeadquarterNew);
        }

        [When(@"Selecciono tipo de ubicación de sede")]
        public void WhenSeleccionoTipoDeUbicacionDeSede()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", LocationsHeadquaterPage.LocationHeadquaterTypeHead, "Almacen", "label");
        }

        [When(@"Diligencio nombre de ubicación")]
        public void WhenDiligencioNombreDeUbicacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsHeadquaterPage.LocationHeadquaterName, HeadquaterName);
        }

        [When(@"Diligencio descripción de ubicación")]
        public void WhenDiligencioDescripcionDeUbicacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsHeadquaterPage.LocationHeadquaterDescription, "descripcion");
        }

        [When(@"Diligencio dirección de ubicación")]
        public void WhenDiligencioDireccionDeUbicacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsHeadquaterPage.LocationHeadquaterAddress, "calle 4 bogota");
        }

        [When(@"Diligencio dirección de ubicación dando click en cursor")]
        public void WhenDiligencioDireccionDeUbicacionDandoClickEnCursor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsHeadquaterPage.LocationHeadquaterAddress, "calle 4 bogota");
            CommonElementsAction.Click("XPath", LocationsHeadquaterPage.LocationAddressValidate);
        }

        [When(@"Diligencio dirección de ubicación dando enter")]
        public void WhenDiligencioDireccionDeUbicacionDandoEnter()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", LocationsHeadquaterPage.LocationHeadquaterAddress, "calle 4 bogota");
        }

        [When(@"Diligencio dirección de ubicación dando tab")]
        public void WhenDiligencioDireccionDeUbicacionDandoTab()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsHeadquaterPage.LocationHeadquaterAddress, "calle 4 bogota");
            CommonHooks.driver.FindElement(By.CssSelector(LocationsHeadquaterPage.LocationHeadquaterAddress)).SendKeys(Keys.Tab);
        }

        [When(@"Diligencio dirección de ubicación dando click en mapa")]
        public void WhenDiligencioDireccionDeUbicacionDandoClickEnMapa()
        {
            UtilAction.Click("//div[@class='zones']//div[@id='mapHeadquarterAddress']");
        }

        [When(@"Diligencio detalle de dirección de ubicación")]
        public void WhenDiligencioDetalleDeDireccionDeUbicacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsHeadquaterPage.LocationHeadquaterAddress, " detalle calle 4 bogota");
        }

        [When(@"Doy click en switch de estado de ubicación")]
        public void WhenDoyClickEnSwitchDeEstadoDeUbicacion()
        {
            CommonElementsAction.Click("XPath", LocationsHeadquaterPage.LocationHeadquaterState);
        }

        [When(@"Selecciono el Tab de información de contacto de sede")]
        public void WhenSeleccionoElTabDeInformacionDeContactoDeSede()
        {
            CommonElementsAction.Click("CssSelector", LocationsPage.LocationTabInfoContact);
        }

        [When(@"Diligencio nombre de contacto de sede")]
        public void WhenDiligencioNombreDeContactoDeSede()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsPage.InfoContactName, Functions.RandomText(8));
        }

        [When(@"Diligencio teléfono de contacto de sede")]
        public void WhenDiligencioTelefonoDeContactoDeSede()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsPage.InfoContactPhone, "719245678");
        }

        [When(@"Diligencio email de contacto de sede")]
        public void WhenDiligencioEmailDeContactoDeSede()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsPage.InfoContactEmail, "mail@mailer.com");
        }

        [When(@"Doy click en Guardar ubicación")]
        public void WhenDoyClickEnGuardarUbicacion()
        {
            Thread.Sleep(2000);
            CommonElementsAction.Click("CssSelector", LocationsPage.LocationSubmit);
            Thread.Sleep(1000);
        }

        [Then(@"Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO")]
        public void ThenSeRegistraLaUbicacionEnLaTablaAFLS_STOCK_LOCATIONS_INFO()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_LOCATION_INFO WHERE grou_name = '" + HeadquaterName + "';", 1);
        }

        [Then(@"Se registra la ubicación transporte en la tabla AFLS_STOCK_LOCATIONS_INFO")]
        public void ThenSeRegistraLaUbicacionTransporteEnLaTablaAFLS_STOCK_LOCATIONS_INFO()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_LOCATION_INFO WHERE grou_name = '" + TransportName + "';", 1);
        }

        [Then(@"Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO con longitud, latitud y dirección")]
        public void ThenSeRegistraLaUbicacionEnLaTablaAFLS_STOCK_LOCATIONS_INFOConLongitudLatitudYDireccion()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_LOCATION_INFO WHERE grou_name = '" + HeadquaterName + "' AND asli_longitude IS NOT NULL AND asli_latitude IS NOT NULL AND asli_address IS NOT NULL;", 1);
        }

        [Given(@"No existe la ubicación de tipo transporte")]
        public void GivenNoExisteLaUbicacionDeTipoTransporte()
        {
            TransportName = DefaultTransportName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_LOCATION_INFO WHERE grou_name = '" + TransportName + "';", 1);
        }

        [When(@"Doy click en Nueva sede de transporte")]
        public void WhenDoyClickEnNuevaSedeDeTransporte()
        {
            CommonElementsAction.Click("CsSelector", LocationsTransportPage.LocationTransportNew);
        }

        [When(@"Selecciono tipo de ubicación de transporte")]
        public void WhenSeleccionoTipoDeUbicacionDeTransporte()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CsSelector", LocationsTransportPage.LocationTypeTransport, "Vehiculo", "label");
        }

        [When(@"Diligencio nombre de ubicación transporte")]
        public void WhenDiligencioNombreDeUbicacionTransporte()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsTransportPage.LocationNameTransport, "mail@mailer.com");
        }

        [When(@"Diligencio descripción de ubicación transporte")]
        public void WhenDiligencioDescripcionDeUbicacionTransporte()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", LocationsTransportPage.LocationDescriptionTransport, "mail@mailer.com");
        }

        [When(@"Doy click en switch de estado de ubicación transporte")]
        public void WhenDoyClickEnSwitchDeEstadoDeUbicacionTransporte()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono el Tab información de contacto de transporte")]
        public void WhenSeleccionoElTabInformacionDeContactoDeTransporte()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Diligencio nombre de contacto de transporte")]
        public void WhenDiligencioNombreDeContactoDeTransporte()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Diligencio teléfono de contacto de transporte")]
        public void WhenDiligencioTelefonoDeContactoDeTransporte()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Diligencio email de contacto de transporte")]
        public void WhenDiligencioEmailDeContactoDeTransporte()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Existe la ubicación")]
        public void GivenExisteLaUbicacion()
        {
            HeadquaterName = CommonQuery.DBSelectAValue("SELECT TOP 1 grou_name FROM AFLS_STOCK_LOCATION_INFO ORDER BY NEWID();", 1);
        }

        [When(@"Ubico y selecciono la ubicación deseada")]
        public void WhenUbicoYSeleccionoLaUbicacionDeseada()
        {
            CommonElementsAction.ClickOn_Random_List("CssSelector", "");
        }

        [Then(@"Se muestra el detalle de la ubicación")]
        public void ThenSeMuestraElDetalleDeLaUbicacion()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(LocationsHeadquaterPage.LocationHeadquaterName)).GetAttribute("value");
            string Valuea = CommonHooks.driver.FindElement(By.CssSelector(LocationsTransportPage.LocationNameTransport)).GetAttribute("value");
            Assert.AreEqual(HeadquaterName, Value);
        }

        [When(@"Modifico nombre de ubicación")]
        public void WhenModificoNombreDeUbicacion()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("", LocationsHeadquaterPage.LocationHeadquaterName, HeadquaterName);
        }

        [When(@"Doy click en eliminar ubicación")]
        public void WhenDoyClickEnEliminarUbicacion()
        {
            CommonElementsAction.Click("", "");
        }

        [Then(@"Se borra el registro de la ubicación en la tabla AFLS_STOCK_PRODUCTS")]
        public void ThenSeBorraElRegistroDeLaUbicacionEnLaTablaAFLS_STOCK_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("", 0);
        }
    }
}