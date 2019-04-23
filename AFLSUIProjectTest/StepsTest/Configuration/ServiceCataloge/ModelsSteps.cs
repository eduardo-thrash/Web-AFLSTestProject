using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Service_Catalogue
{
    [Binding]
    public class ModelsSteps
    {
        private ModelsPage ModelsPage = new ModelsPage();
        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();
        private string ModelName;
        private string DefaultModelName = "UI Model ";
        private string EditModelName = "Edit UI Model ";
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        [Given(@"El modelo no existe")]
        public void GivenElModeloNoExiste()
        {
            ModelName = DefaultModelName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT name from AFW_ITEM_MODEL WHERE name = '" + ModelName + "';", 0);
        }

        [When(@"Diligencio nombre de modelo")]
        public void WhenDiligencioNombreDeModelo()
        {
            Thread.Sleep(3000);

            CommonElementsAction.SendKeys_InputText("CssSelector", ModelsPage.ModelName, ModelName);
        }

        [When(@"Doy click en Nuevo modelo")]
        public void WhenDoyClickEnNuevoModelo()
        {
            CommonElementsAction.Click("CssSelector", ModelsPage.ModelButtonNew);
        }

        [When(@"Diligencio descripción de modelo")]
        public void WhenDiligencioDescripcionDeModelo()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ModelsPage.ModelDescription, "Interdum et malesuada fames ac ante ipsum primis in faucibus");
        }

        [When(@"Selecciono encuesta para modelo")]
        public void WhenSeleccionoEncuestaParaModelo()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", ModelsPage.ModelSurvey, "//div[@id='Survey']/ul/li/a", false);
        }

        [Then(@"Se registra el modelo en la tabla AFW_ITEM_MODEL")]
        public void ThenSeRegistraElModeloEnLaTablaAFW_ITEM_MODEL()
        {
            CommonQuery.DBSelectAValue("SELECT name from AFW_ITEM_MODEL WHERE name = '" + ModelName + "';", 1);
        }

        [When(@"Doy click en Guardar modelo")]
        public void WhenDoyClickEnGuardarModelo()
        {
            CommonElementsAction.Click("CssSelector", ModelsPage.ModelSubmit);
        }

        [When(@"Busco y selecciono el modelo")]
        public void WhenBuscoYSeleccionoElModelo()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ModelsPage.ModelFieldSearch, ModelName);
            CommonElementsAction.Click("CssSelector", ModelsPage.ModelButtonSearch);

            Thread.Sleep(2000);

            CommonElementsAction.Click("XPath", ModelsPage.ModelView);
        }

        [Then(@"Se muestra la tarjeta de modelo y se carga formulario de información básica")]
        public void ThenSeMuestraLaTarjetaDeModeloYSeCargaFormularioDeInformacionBasica()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ModelsPage.ModelName)).GetAttribute("value");
            Assert.AreEqual(ModelName, Value);
        }

        [When(@"Edito nombre de modelo")]
        public void WhenEditoNombreDeModelo()
        {
            EditModelName = EditModelName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ModelsPage.ModelName, EditModelName);
        }

        [Then(@"Se modifica la información del modelo en la tabla AFW_ITEM_MODEL")]
        public void ThenSeModificaLaInformacionDelModeloEnLaTablaAFW_ITEM_MODEL()
        {
            CommonQuery.DBSelectAValue("SELECT name from AFW_ITEM_MODEL WHERE name = '" + EditModelName + "';", 1);
        }

        [When(@"Doy click en eliminar modelo")]
        public void WhenDoyClickEnEliminarModelo()
        {
            CommonElementsAction.Click("XPath", ModelsPage.ModelIconRemoved);
        }

        [Then(@"Se marca como eliminada la información del modelo en la tabla AFW_ITEM_MODEL")]
        public void ThenSeMarcaComoEliminadaLaInformacionDelModeloEnLaTablaAFW_ITEM_MODEL()
        {
            CommonQuery.DBSelectAValue("SELECT name from AFW_ITEM_MODEL WHERE name = '" + ModelName + "' AND is_deleted = 1;", 1);
        }

        [Given(@"El modelo existe")]
        public void GivenElModeloExiste()
        {
            ModelName = CommonQuery.DBSelectAValue("SELECT TOP 1 name from AFW_ITEM_MODEL WHERE is_deleted = 0 ORDER BY NEWID();", 1);
        }

        [Then(@"Al buscar el modelo en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElModeloEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ModelsPage.ModelFieldSearch, ModelName);
            CommonElementsAction.Click("CssSelector", ModelsPage.ModelButtonSearch);

            Thread.Sleep(2000);

            CommonElementsAction.WaitElementNoFound(ModelsPage.ModelView);
        }

        [When(@"Borrado exitoso de modelo existente")]
        public void WhenBorradoExitosoDeModeloExistente()
        {
            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", ModelsPage.ModelFieldSearch, "Modelo Emergencia WT");
            CommonElementsAction.Click("CssSelector", ModelsPage.ModelButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath", ModelsPage.ModelView);

            //Delete element of List

            Thread.Sleep(2000);

            //End Delete element of List

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }
    }
}