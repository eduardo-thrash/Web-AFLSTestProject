using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.AFLS;
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
    public class ChronometersSteps
    {
        private ChronometersPage ChronometersPage = new ChronometersPage();

        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();
        private MessagesElements MessagesElements = new MessagesElements();
        private static string ChronoNameDefault = "UI Chronometer ";
        private static string ChronoName;
        private static string EditChronoName = "UI Chronometer Edit";
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        [Given(@"El cronómetro no existe")]
        public void GivenElCronometroNoExiste()
        {
            ChronoName = ChronoNameDefault + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ITEM_TIMES WHERE name = '" + ChronoName + "';", 0);
        }

        [Given(@"El cronómetro existe")]
        public void GivenElCronometroExiste()
        {
            ChronoName = CommonQuery.DBSelectAValue("SELECT name FROM AFW_ITEM_TIMES WHERE id > 3 AND is_deleted = 0 ORDER BY NEWID();", 1);
        }

        [When(@"Modificación parcial de cronómetros")]
        public void WhenModificacionParcialDeCronometros()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Creación completa de Cronómetros")]
        public void WhenTengoUnUsuarioConRolAdministrador()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerButtonNew);
            //End Navigate Module Content

            ////Navigate Module Details

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");

            Thread.Sleep(5000);
            CommonElementsAction.Click("CssSelector", ChronometersPage.TabChronometerdetail);

            CommonElementsAction.SendKeys_InputText("CssSelector", ChronometersPage.ChronometerName, "cronómetro UI");
            Console.WriteLine("\t Click and diligently ChronometerName.");

            CommonElementsAction.SendKeys_InputText("CssSelector", ChronometersPage.ChronometerDescription, "Sed et orci ac massa feugiat consequat vitae ac neque. Integer tincidunt a leo id feugiat.");
            Console.WriteLine("\t Click and diligently ChronometerDescription.");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"consulta exitosa de cronómetro por nombre")]
        public void WhenConsultaExitosaDecronómetroPorNombre()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", ChronometersPage.ChronometerInputSearch, "cronómetro Trabajo WT");
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath", ChronometersPage.ChronometerItemView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ChronometersPage.ChronometerName)).GetAttribute("value");
            Assert.AreEqual("cronómetro Trabajo WT", Value);

            //LogOut.

            //End LogOut.
        }

        [When(@"Busco y selecciono el cronómetro")]
        public void WhenBuscoYSeleccionoElCronometro()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ChronometersPage.ChronometerInputSearch, ChronoName);
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerButtonSearch);
            CommonElementsAction.Click("XPath", ChronometersPage.ChronometerItemView);
        }

        [Then(@"Se muestra la tarjeta del cronómetro y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelCronometroYElDetalleDelMismo()
        {
            string RelationTextView = CommonHooks.driver.FindElement(By.XPath(ChronometersPage.ChronometerItemView)).Text;
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ChronometersPage.ChronometerName)).GetAttribute("value");
            Assert.AreEqual(RelationTextView, Value);
        }

        [When(@"Modifico nombre de cronometro")]
        public void WhenModificoNombreDeCronometro()
        {
            EditChronoName = EditChronoName + Functions.RandomText();
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ChronometersPage.ChronometerName, EditChronoName);
        }

        [Then(@"Se modifica la información del cronómetro en la tabla AFW_ITEM_TIMES")]
        public void ThenSeModificaLaInformacionDelCronometroEnLaTablaAFW_ITEM_TIMES()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ITEM_TIMES WHERE name = '" + EditChronoName + "';", 1);
        }

        [When(@"Doy click en eliminar cronómetro")]
        public void WhenDoyClickEnEliminarCronometro()
        {
            CommonElementsAction.Click("XPath", ChronometersPage.ChronometerIconRemoved);
        }

        [Then(@"Se marca como eliminada la información del cronómetro en la tabla AFW_ITEM_TIMES")]
        public void ThenSeEliminaLaInformacionDelCronometroEnLaTablaAFW_ITEM_TIMES()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ITEM_TIMES WHERE name = '" + ChronoName + "' AND is_deleted = 1;", 1);
        }

        [When(@"Modificación parcial de cronómeteros")]
        public void WhenModificacionParcialDecronómeteros()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", ChronometersPage.ChronometerInputSearch, "cronómetro Almuerzo WT");
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerButtonSearch);

            CommonElementsAction.Click("XPath", ChronometersPage.ChronometerItemView);

            CommonElementsAction.Click("CssSelector", ChronometersPage.TabChronometerdetail);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ChronometersPage.ChronometerName, "Tiempo Update Almuerzo WT");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ChronometersPage.ChronometerDescription, "Description update chronos");

            //Save
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ChronometersPage.ChronometerInputSearch, "Tiempo Update Almuerzo WT");
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerItemView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ChronometersPage.ChronometerName)).GetAttribute("value");
            Assert.AreEqual("Tiempo Update Almuerzo WT", Value);

            //LogOut.

            //End LogOut.
        }

        [When(@"Borrar cronómetro existente")]
        public void WhenBorrarcronómetroExistente()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", ChronometersPage.ChronometerInputSearch, "cronómetro Resolución WT");
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath", ChronometersPage.ChronometerItemView);

            //Delete element of List
            CommonElementsAction.Click("XPath", ChronometersPage.ChronometerIconRemoved);

            Thread.Sleep(2000);

            //End Delete element of List

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"Doy click en Nuevo cronometro")]
        public void WhenDoyClickEnNuevoCronometro()
        {
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerButtonNew);
        }

        [Then(@"Al buscar el cronómetro en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElCronometroEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            Thread.Sleep(1500);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ChronometersPage.ChronometerInputSearch, ChronoName);
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerButtonSearch);
            Thread.Sleep(2000);
            CommonElementsAction.WaitElementNoFound(ChronometersPage.ChronometerItemView);
        }

        [When(@"Diligencio nombre de cronometro")]
        public void WhenDiligencioNombreDeCronometro()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ChronometersPage.ChronometerName, ChronoName);
        }

        [When(@"Diligencio descripción de cronometro")]
        public void WhenDiligencioDescripcionDeCronometro()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ChronometersPage.ChronometerDescription, "Sed et orci ac massa feugiat consequat vitae ac neque. Integer tincidunt a leo id feugiat.");
        }

        [When(@"Doy click en Guardar cronometro")]
        public void WhenDoyClickEnGuardarCronometro()
        {
            CommonElementsAction.Click("CssSelector", ChronometersPage.ChronometerSubmit);
        }

        [Then(@"Se registra el cronometro en la tabla AFW_ITEM_TIMES")]
        public void ThenSeRegistraElCronometroEnLaTablaAFW_ITEM_TIMES()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ITEM_TIMES WHERE name = '" + ChronoName + "';", 1);
        }
    }
}