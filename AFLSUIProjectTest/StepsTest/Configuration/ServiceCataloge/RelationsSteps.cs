using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.ConfigurationMenuServiceCatalogue;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Service_Catalogue
{
    [Binding]
    public class RelationsSteps
    {
        private RelationsPage RelationsPage = new RelationsPage();
        private MessagesElements MessagesElements = new MessagesElements();
        private PageMessages PageMessages = new PageMessages();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        private static string DefaultRelationName = "UI Relation";
        private string RelationName;
        private string EditRelationName;
        private string EditRelationSource;
        private string EditRelationTarget;

        [Given(@"La relación no existe")]
        public void GivenLaRelacionNoExiste()
        {
            RelationName = DefaultRelationName + " " + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT ar_name FROM AFLS_RELATIONSHIP WHERE ar_name = '" + RelationName + "';", 0);
        }

        [Given(@"La relación existe")]
        public void GivenLaRelacionExiste()
        {
            RelationName = CommonQuery.DBSelectAValue("SELECT TOP 1 ar_name FROM AFLS_RELATIONSHIP ORDER BY NEWID();", 1);
        }

        [Given(@"La relación existe activa")]
        public void GivenLaRelacionExisteActiva()
        {
            RelationName = CommonQuery.DBSelectAValue("SELECT TOP 1 ar_name FROM AFLS_RELATIONSHIP WHERE ar_is_active = 1 ORDER BY NEWID();", 1);
        }

        [When(@"Diligencio nombre de relación existente")]
        public void WhenDiligencioNombreDeRelacionExistente()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", RelationsPage.RelationInputName, RelationName);
        }

        [When(@"Doy click en switch de estado de relación")]
        public void WhenDoyClickEnSwitchDeEstadoDeRelacion()
        {
            CommonElementsAction.Click("XPath", RelationsPage.RelationState);
        }

        [Then(@"Se registra la relación en la tabla AFLS_RELATIONSHIP como inactiva")]
        public void ThenNoSeRegistraLaRelacionEnLaTablaAFLS_RELATIONSHIPComoInactiva()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_RELATIONSHIP WHERE ar_name = '" + RelationName + "' AND ar_is_active = 0", 1);
        }

        [When(@"Doy click en Nueva relación")]
        public void WhenDoyClickEnNuevaRelacion()
        {
            CommonElementsAction.Click("CssSelector", RelationsPage.RelationTab);
            CommonElementsAction.Click("CssSelector", RelationsPage.RelationButtonNew);
        }

        [Then(@"Se borra la relación de la tabla AFLS_RELATIONSHIP")]
        public void ThenSeBorraLaRelacionDeLaTablaAFLS_RELATIONSHIP()
        {
            CommonQuery.DBSelectAValue("SELECT ar_name FROM AFLS_RELATIONSHIP WHERE ar_name = '" + RelationName + "';", 0);
        }

        [When(@"Diligencio nombre de relación")]
        public void WhenDiligencioNombreDeRelacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", RelationsPage.RelationInputName, RelationName);
        }

        [When(@"Doy click en Cancelar relación")]
        public void WhenDoyClickEnCancelarRelacion()
        {
            CommonElementsAction.Click("CssSelector", RelationsPage.RelationCancel);
            Thread.Sleep(3000);
        }

        [When(@"Doy click en Si de mensaje de confirmación")]
        public void WhenDoyClickEnSiDeMensajeDeConfirmacion()
        {
            try
            {
                Thread.Sleep(2000);
                CommonElementsAction.Click("CssSelector", MessagesElements.SubmitButton);
            }
            catch
            {
                Thread.Sleep(2000);
                CommonElementsAction.Click("CssSelector", MessagesElements.SubmitButton);
            }
        }

        [When(@"Selecciono tipo de relación Vinculo")]
        public void WhenSeleccionoTipoDeRelacionVinculo()
        {
            CommonElementsAction.Click("XPath", RelationsPage.RelationButtonLink);
        }

        [When(@"Diligencio campo origen de relación")]
        public void WhenDiligencioCampoOrigenDeRelacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", RelationsPage.RelationInputSource, "se conecta con");
        }

        [When(@"Diligencio campo destino de relación")]
        public void WhenDiligencioCampoDestinoDeRelacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", RelationsPage.RelationInputTarget, "se vincula desde");
        }

        [When(@"Doy click en Guardar relación")]
        public void WhenDoyClickEnGuardarRelacion()
        {
            EditRelationName = CommonElementsAction.VallueExtract("CssSelector", RelationsPage.RelationInputName);
            EditRelationSource = CommonElementsAction.VallueExtract("CssSelector", RelationsPage.RelationInputSource);
            EditRelationTarget = CommonElementsAction.VallueExtract("CssSelector", RelationsPage.RelationInputTarget);
            CommonElementsAction.Click("CssSelector", RelationsPage.RelationSubmit);
        }

        [When(@"Edito nombre de relación dejándolo vacío")]
        public void WhenEditoNombreDeRelacionDejandoloVacio()
        {
            CommonElementsAction.Clear("CssSelector", RelationsPage.RelationInputName);
        }

        [Then(@"Se muestra mensaje indicando que existen campos inválidos")]
        public void ThenSeMuestraMensajeIndicandoQueExistenCamposInvalidos()
        {
            string Response = CommonElementsAction.TextExtract("XPath", MessagesElements.ResponseError);
            try
            {
                Assert.IsTrue(Response.Contains(MessagesCopies.FailedElementConfigurationCreateOrUpdate));
            }
            catch
            {
                Assert.Fail(Response);
            }
        }

        [Then(@"Al buscar la relación con anterior nombre se muestra exitosamente")]
        public void ThenAlBuscarLaRelacionConAnteriorNombreSeMuestraExitosamente()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", RelationsPage.RelationFieldSearch, RelationName);
            CommonElementsAction.Click("CssSelector", RelationsPage.RelationButtonSearch);
            CommonElementsAction.Click("XPath", RelationsPage.RelationView);
        }

        [Then(@"Se muestra mensaje indicando que el elemento ya existe")]
        public void ThenSeMuestraMensajeIndicandoQueElElementoYaExiste()
        {
            string Response = CommonElementsAction.TextExtract("XPath", MessagesElements.ResponseError);
            try
            {
                Assert.IsTrue(Response.Contains(MessagesCopies.FailedElementConfigurationCreateOrUpdateRepeat));
            }
            catch
            {
                Assert.Fail(Response);
            }
        }

        [When(@"Edito nombre de relación")]
        public void WhenEditoNombreDeRelacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", RelationsPage.RelationInputName, " edit");
        }

        [When(@"Doy click en eliminar relación")]
        public void WhenDoyClickEnEliminarRelacion()
        {
            CommonElementsAction.Click("XPath", RelationsPage.RelationIconRemoved);
        }

        [Then(@"Al buscar la relación en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarLaRelacionEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", RelationsPage.RelationFieldSearch, RelationName);
            CommonElementsAction.Click("CssSelector", RelationsPage.RelationButtonSearch);
            CommonElementsAction.WaitElementNoFound(RelationsPage.RelationView);
        }

        [When(@"Edito campo origen de relación")]
        public void WhenEditoCampoOrigenDeRelacion()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", RelationsPage.RelationInputSource, "Edit source");
        }

        [When(@"Edito campo destino de relación")]
        public void WhenEditoCampoDestinoDeRelacion()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", RelationsPage.RelationInputTarget, "Edit Target");
        }

        [Then(@"Se modifica la información de la relación en la tabla AFLS_RELATIONSHIP")]
        public void ThenSeModificaLaInformacionDeLaRelacionEnLaTablaAFLS_RELATIONSHIP()
        {
            CommonQuery.DBSelectAValue("SELECT ar_name FROM AFLS_RELATIONSHIP WHERE ar_name = '" + EditRelationName + "' and ar_source_name = '" + EditRelationSource + "' and ar_target_name = '" + EditRelationTarget + "';", 1);
        }

        [Then(@"No se registra la relación en la tabla AFLS_RELATIONSHIP de tipo vinculo")]
        public void ThenNoSeRegistraLaRelacionEnLaTablaAFLS_RELATIONSHIPDeTipoVinculo()
        {
            CommonQuery.DBSelectAValue("SELECT ar_name FROM AFLS_RELATIONSHIP WHERE ar_name = '" + RelationName + "' AND art_id = 2", 0);
        }

        [Then(@"Se registra la relación en la tabla AFLS_RELATIONSHIP de tipo vinculo")]
        public void ThenSeRegistraLaRelacionEnLaTablaAFLS_RELATIONSHIPDeTipoVinculo()
        {
            CommonQuery.DBSelectAValue("SELECT ar_name FROM AFLS_RELATIONSHIP WHERE ar_name = '" + RelationName + "' AND art_id = 2", 1);
        }

        [When(@"Busco y selecciono la relación")]
        public void WhenBuscoYSeleccionoLaRelacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", RelationsPage.RelationFieldSearch, RelationName);
            CommonElementsAction.Click("CssSelector", RelationsPage.RelationButtonSearch);
            CommonElementsAction.Click("XPath", RelationsPage.RelationView);
        }

        [Then(@"Al buscar la relación con nuevo nombre se muestra exitosamente")]
        public void ThenAlBuscarLaRelacionConNuevoNombreSeMuestraExitosamente()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", RelationsPage.RelationFieldSearch, EditRelationName);
            CommonElementsAction.Click("CssSelector", RelationsPage.RelationButtonSearch);
            CommonElementsAction.Click("XPath", RelationsPage.RelationView);
        }

        [Then(@"Se muestra la tarjeta de la relación y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDeLaRelacionYElDetalleDelMismo()
        {
            string RelationTextView = CommonHooks.driver.FindElement(By.XPath(RelationsPage.RelationView)).Text;
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(RelationsPage.RelationInputName)).GetAttribute("value");
            Assert.AreEqual(RelationTextView, Value);
        }
    }
}