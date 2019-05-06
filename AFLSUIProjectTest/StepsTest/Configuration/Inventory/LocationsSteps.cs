using System;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using AFLSUIProjectTest.CommonAFLS;

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

        private static string DefaultHeadquaterName = "UI Sede ";
        private static string EditHeadquaterName;
        private static string HeadquaterName = "UI Sede Edit ";


        [Given(@"No existe la ubicación de tipo sede")]
        public void GivenNoExisteLaUbicacionDeTipoSede()
        {
            CommonQuery.DBSelectAValue("", 0);
        }

        [When(@"Doy click en Nueva ubicación sede")]
        public void WhenDoyClickEnNuevaUbicacionSede()
        {
            CommonElementsAction.Click("", "");
        }

        [When(@"Selecciono tipo de ubicación de sede")]
        public void WhenSeleccionoTipoDeUbicacionDeSede()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("", LocationsHeadquaterPage.LocationHeadquarterNew, "", "");
        }

        [When(@"Diligencio nombre de ubicación")]
        public void WhenDiligencioNombreDeUbicacion()
        {
            CommonElementsAction.SendKeys_InputText("", LocationsHeadquaterPage.LocationHeadquaterName, HeadquaterName);
        }

        [When(@"Diligencio descripción de ubicación")]
        public void WhenDiligencioDescripcionDeUbicacion()
        {
            CommonElementsAction.SendKeys_InputText("", LocationsHeadquaterPage.LocationHeadquaterDescription, "descripcion");
        }

        [When(@"Diligencio dirección de ubicación")]
        public void WhenDiligencioDireccionDeUbicacion()
        {
            CommonElementsAction.SendKeys_InputText("", LocationsHeadquaterPage.LocationHeadquaterAddress, "calle 4 bogota");
        }

        [When(@"Diligencio detalle de dirección de ubicación")]
        public void WhenDiligencioDetalleDeDireccionDeUbicacion()
        {
            CommonElementsAction.SendKeys_InputText("", LocationsHeadquaterPage.LocationHeadquaterAddress, " detalle calle 4 bogota");
        }

        [When(@"Doy click en switch de estado de ubicación")]
        public void WhenDoyClickEnSwitchDeEstadoDeUbicacion()
        {
            CommonElementsAction.Click("", "");
        }

        [When(@"Selecciono el Tab de información de contacto de sede")]
        public void WhenSeleccionoElTabDeInformacionDeContactoDeSede()
        {
            CommonElementsAction.Click("", LocationsPage.LocationTabInfoContact);
        }

        [When(@"Diligencio nombre de contacto de sede")]
        public void WhenDiligencioNombreDeContactoDeSede()
        {
            CommonElementsAction.SendKeys_InputText("", LocationsPage.InfoContactName,"");
        }

        [When(@"Diligencio teléfono de contacto de sede")]
        public void WhenDiligencioTelefonoDeContactoDeSede()
        {
            CommonElementsAction.SendKeys_InputText("", LocationsPage.InfoContactPhone, "719245678");
        }

        [When(@"Diligencio email de contacto de sede")]
        public void WhenDiligencioEmailDeContactoDeSede()
        {
            CommonElementsAction.SendKeys_InputText("", LocationsPage.InfoContactEmail, "mail@mailer.com");
        }

        [When(@"Doy click en Guardar ubicación")]
        public void WhenDoyClickEnGuardarUbicacion()
        {
            CommonElementsAction.Click("", LocationsPage.LocationSubmit);
        }

        [Then(@"Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO")]
        public void ThenSeRegistraLaUbicacionEnLaTablaAFLS_STOCK_LOCATIONS_INFO()
        {
            CommonQuery.DBSelectAValue("", 0);
        }

        [Given(@"No existe la ubicación de tipo transporte")]
        public void GivenNoExisteLaUbicacionDeTipoTransporte()
        {
            CommonQuery.DBSelectAValue("", 0); ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en Nuevo transporte")]
        public void WhenDoyClickEnNuevoTransporte()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono tipo de ubicación de transporte")]
        public void WhenSeleccionoTipoDeUbicacionDeTransporte()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Diligencio nombre de ubicación transporte")]
        public void WhenDiligencioNombreDeUbicacionTransporte()
        {
            CommonElementsAction.SendKeys_InputText("", LocationsTransportPage.LocationNameTransport, "mail@mailer.com");
        }

        [When(@"Diligencio descripción de ubicación transporte")]
        public void WhenDiligencioDescripcionDeUbicacionTransporte()
        {
            CommonElementsAction.SendKeys_InputText("", LocationsTransportPage.LocationDescriptionTransport, "mail@mailer.com");
        }

        [When(@"Diligencio dirección de ubicación transporte")]
        public void WhenDiligencioDireccionDeUbicacionTransporte()
        {
            CommonElementsAction.SendKeys_InputText("", "", "mail@mailer.com");
        }

        [When(@"Diligencio detalle de dirección de ubicación transporte")]
        public void WhenDiligencioDetalleDeDireccionDeUbicacionTransporte()
        {
            ScenarioContext.Current.Pending();
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
            CommonQuery.DBSelectAValue("", 0);
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
