using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configurationonfiguration.MenuConfiguration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class EstablishmentSteps
    {
        private readonly EstablishmentPage EstablishmentPage = new EstablishmentPage();
        private readonly PageMessages PageMessages = new PageMessages();

        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        private string ValueFieldCompanyName;
        private string ValueFieldCompanyNIT;
        private string ValueFieldCompanyAddress;

        [When(@"Selecciono opción de Información básica")]
        public void WhenSeleccionoOpcionDeInformacionBasica()

        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.EstablishmentOption);
        }

        [When(@"Diligencio nombre de compañía en información básica")]
        public void WhenDiligencioNombreDeCompaniaEnInformacionBasica()
        {
            ValueFieldCompanyName = CommonElementsAction.VallueExtract("CssSelector", EstablishmentPage.EstablishmentInputName);
            UtilAction.ClearBefore_SendKeys(EstablishmentPage.EstablishmentInputName, "Aranda Software" + Functions.RandomText(5), "CssSelector");
        }

        [When(@"Diligencio NIT de compañía en información básica")]
        public void WhenDiligencioNITDeCompaniaEnInformacionBasica()
        {
            ValueFieldCompanyNIT = CommonElementsAction.VallueExtract("CssSelector", EstablishmentPage.EstablishmentInputId);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputId, "9008756744-6");
        }

        [When(@"Diligencio dirección de compañía en información básica dando click en cursor")]
        public void WhenDiligencioDireccionDeCompaniaEnInformacionBasicaDandoClickEnCursor()
        {
            ValueFieldCompanyAddress = CommonElementsAction.VallueExtract("CssSelector", EstablishmentPage.EstablishmentInputId);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputAddress, "calle 45 # 45-23 bogota");
            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath", EstablishmentPage.EstablishmentAddressValidate);
        }

        [When(@"Modifico nombre de compañía en información básica")]
        public void WhenModificoNombreDeCompaniaEnInformacionBasica()
        {
            UtilAction.ClearBefore_SendKeys(EstablishmentPage.EstablishmentInputName, "Aranda Software" + Functions.RandomText(5), "CssSelector");
            ValueFieldCompanyName = CommonElementsAction.VallueExtract("CssSelector", EstablishmentPage.EstablishmentInputName);
        }

        [When(@"Modifico NIT de compañía en información básica")]
        public void WhenModificoNITDeCompaniaEnInformacionBasica()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputId, "900875555555-0");
            ValueFieldCompanyNIT = CommonElementsAction.VallueExtract("CssSelector", EstablishmentPage.EstablishmentInputId);
        }

        [When(@"Modifico dirección de compañía en información básica dando click en cursor")]
        public void WhenModificoDireccionDeCompaniaEnInformacionBasicaDandoClickEnCursor()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputAddress, "calle 45 # 45-23 bogota");
            Thread.Sleep(2000);
            UtilAction.Click(EstablishmentPage.EstablishmentAddressValidate);
            ValueFieldCompanyAddress = CommonElementsAction.VallueExtract("CssSelector", EstablishmentPage.EstablishmentInputId);
        }

        [Then(@"Se registra la configuración básica en la tabla AFLS_ESTABLISHMENT con nombre, NIT y dirección modificado")]
        public void ThenSeRegistraLaConfiguracionBasicaEnLaTablaAFLS_ESTABLISHMENTConNombreNITYDireccionModificado()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_ESTABLISHMENT where esta_name = '" + ValueFieldCompanyName + "' AND esta_code = '" + ValueFieldCompanyNIT + "' AND esta_address = '" + ValueFieldCompanyAddress + "';", 1);
        }

        [When(@"Diligencio dirección de compañía en información básica dando tab")]
        public void WhenDiligencioDireccionDeCompaniaEnInformacionBasicaDandoTab()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputAddress, "calle 45 # 45-23 bogota");
            Thread.Sleep(2000);
            CommonHooks.driver.FindElement(By.CssSelector(EstablishmentPage.EstablishmentInputAddress)).SendKeys(Keys.Tab);
        }

        [Then(@"Se registra la configuración básica en la tabla AFLS_ESTABLISHMENT con longitud, latitud y dirección")]
        public void ThenSeRegistraLaConfiguracionBasicaEnLaTablaAFLS_ESTABLISHMENTConLongitudLatitudYDireccion()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_ESTABLISHMENT WHERE esta_latitude IS NOT NULL AND esta_longitude IS NOT NULL AND esta_address IS NOT NULL", 1);
        }

        [Then(@"Se registra por base de datos la zona geográfica de dos países")]
        public void ThenSeRegistraPorBaseDeDatosLaZonaGeograficaDeDosPaises()
        {
            Functions.DBEstablismentUpdate("UPDATE AFLS_ESTABLISHMENT set esta_country = 'CO - Colombia, BR - Brasil';");
        }

        [When(@"Diligencio dirección de compañía en información básica dando enter")]
        public void WhenDiligencioDireccionDeCompaniaEnInformacionBasicaDandoEnter()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputAddress, "calle 45 # 45-23 bogota");
        }

        [When(@"Doy click en Guardar información básica")]
        public void WhenDoyClickEnGuardarInformacionBasica()
        {
            CommonElementsAction.Click("CssSelector", EstablishmentPage.EstablishmentSubmit);
        }

        [When(@"Doy click en Cancelar información básica")]
        public void WhenDoyClickEnCancelarInformacionBasica()
        {
            UtilAction.Click(EstablishmentPage.EstablishmentCancel, "CssSelector");
        }

        [When(@"Modifico nombre de compañía en información básica dejándolo vacío")]
        public void WhenModificoNombreDeCompaniaEnInformacionBasicaDejandoloVacio()
        {
            UtilAction.Clear(EstablishmentPage.EstablishmentInputName, "Aranda Software" + Functions.RandomText(5), "CssSelector");
        }

        [Given(@"Tengo información básica configurada")]
        public void GivenTengoInformacionBasicaConfigurada()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_ESTABLISHMENT", 1);
        }

        [When(@"Doy click en confirmar cancelación de información básica")]
        public void WhenDoyClickEnConfirmarCancelacionDeInformacionBasica()
        {
            UtilAction.Click("//div[@class='ui-dialog-buttonpane ui-widget-content ui-helper-clearfix']//button[@class='my-button-submit ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only']");
            Thread.Sleep(2000);
        }

        [When(@"Modificación fallida de información básica dejando nombre vacio")]
        public void WhenModificacionFallidaDeInformacionBasicaDejandoNombreVacio()
        {
            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General

            ///     And diligencio el campo de nombre
            Thread.Sleep(3000);

            CommonElementsAction.Clear("CssSelector", EstablishmentPage.EstablishmentInputName);

            CommonElementsAction.Click("CssSelector", EstablishmentPage.EstablishmentSubmit);

            //LogOut.

            //End LogOut.
        }

        [Then(@"se mantiene la información básica sin modificar")]
        public void ThenSeMantieneLaInformacionBasicaSinModificar()
        {
            string NewValueFieldCompanyName = CommonElementsAction.VallueExtract("CssSelector", EstablishmentPage.EstablishmentInputName);
            string NewValueFieldCompanyNIT = CommonElementsAction.VallueExtract("CssSelector", EstablishmentPage.EstablishmentInputId);
            string NewValueFieldCompanyAddress = CommonElementsAction.VallueExtract("CssSelector", EstablishmentPage.EstablishmentInputId);

            Assert.AreEqual(ValueFieldCompanyName, NewValueFieldCompanyName);
            Assert.AreEqual(ValueFieldCompanyNIT, NewValueFieldCompanyNIT);
            Assert.AreEqual(ValueFieldCompanyAddress, NewValueFieldCompanyAddress);
        }
    }
}