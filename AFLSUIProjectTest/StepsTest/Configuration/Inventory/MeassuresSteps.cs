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
    public class MeassuresSteps
    {
        private readonly ElementsMeasure ElementsMeasure = new ElementsMeasure();
        private readonly PageMessages PageMessages = new PageMessages();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        private static string DefaultMeassureName = "UI Medida ";
        private static string MeassureName;
        private static string EditMeassureName = "UI Med Edit ";
        private static string MeassureDescription;

        [Given(@"La medida no existe")]
        public void GivenLaMedidaNoExiste()
        {
            MeassureName = DefaultMeassureName + Functions.RandomText(6);
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_MEASURES WHERE mea_name = '" + MeassureName + "';", 0);
        }

        [When(@"Doy click en Nueva medida")]
        public void WhenDoyClickEnNuevaMedida()
        {
            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureButtonNew);
        }

        [When(@"Diligencio nombre de medida")]
        public void WhenDiligencioNombreDeMedida()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsMeasure.MeasureName, MeassureName);
        }

        [When(@"Diligencio descripción de medida")]
        public void WhenDiligencioDescripcionDeMedida()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsMeasure.MeasureDescription, Functions.RandomText(20) + Functions.RandomText(3));
        }

        [When(@"Doy click en Guardar medida")]
        public void WhenDoyClickEnGuardarMedida()
        {
            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureSubmit);
        }

        [Then(@"Se registra medida en la tabla AFLS_STOCK_MEASURES")]
        public void ThenSeRegistraMedidaEnLaTablaAFLS_STOCK_MEASURES()
        {
            CommonQuery.DBSelectAValue("SELECT TOP 1 mea_name FROM AFLS_STOCK_MEASURES WHERE mea_name = '" + MeassureName + "';", 1);
        }

        [Given(@"La medida existe")]
        public void GivenLaMedidaExiste()
        {
            MeassureName = CommonQuery.DBSelectAValue("SELECT TOP 1 mea_name FROM AFLS_STOCK_MEASURES ORDER BY NEWID();", 1);
        }

        [Then(@"Finaliza exitosa la prueba")]
        public void ThenFinalizaExitosaLaPrueba()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Búsqueda exitosa de Medida existente")]
        public void WhenBusquedaExitosaDeMedidaExistente()
        {
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.InventoryMenu,SectionAdminLeftColumn.MeasureOption,"");

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsMeasure.MeasureFieldSearch, "Unit WT");
            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureButtonSearch);

            CommonElementsAction.Click("XPath", ElementsMeasure.MeasureView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsMeasure.MeasureName)).GetAttribute("value");
            Assert.AreEqual("Unit WT", Value);

            //LogOut.
            //
            //End LogOut.
        }

        [When(@"Busco y selecciono la medida")]
        public void WhenBuscoYSeleccionoLaMedida()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsMeasure.MeasureFieldSearch, MeassureName);
            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureButtonSearch);
            CommonElementsAction.Click("XPath", ElementsMeasure.MeasureView);
        }

        [Then(@"Se muestra la tarjeta de la medida y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDeLaMedidaYElDetalleDelMismo()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsMeasure.MeasureName)).GetAttribute("value");
            Assert.AreEqual(MeassureName, Value);
        }

        [When(@"Edito nombre de medida")]
        public void WhenEditoNombreDeMedida()
        {
            EditMeassureName = EditMeassureName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsMeasure.MeasureName, EditMeassureName);
        }

        [Then(@"Se registra el nombre de medida modificado en la tabla AFLS_STOCK_MEASURES")]
        public void ThenSeRegistraElNombreDeMedidaModificadoEnLaTablaAFLS_STOCK_MEASURES()
        {
            CommonQuery.DBSelectAValue("SELECT mea_name FROM AFLS_STOCK_MEASURES WHERE mea_name = '" + EditMeassureName + "';", 1);
        }

        [When(@"Modificación exitosa de Medidas")]
        public void WhenModificacionExitosaDeMedidas()
        {
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.InventoryMenu,SectionAdminLeftColumn.MeasureOption,"");

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsMeasure.MeasureFieldSearch, "Mtrs WT");
            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureButtonSearch);

            CommonElementsAction.Click("XPath", ElementsMeasure.MeasureView);

            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureTabMeasures);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsMeasure.MeasureName, "Mtrs WT Update");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsMeasure.MeasureDescription, "Descrip Update measure");

            //Save
            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsMeasure.MeasureFieldSearch, "Mtrs WT Update");
            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureButtonSearch);

            CommonElementsAction.Click("XPath", ElementsMeasure.MeasureView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsMeasure.MeasureName)).GetAttribute("value");
            Assert.AreEqual("Mtrs WT Update", Value);

            //LogOut.

            //End LogOut.
        }

        [When(@"Borrado exitoso de Medida existente")]
        public void WhenBorradoExitosoDeMedidaExistente()
        {
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.InventoryMenu,SectionAdminLeftColumn.MeasureOption,"");

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsMeasure.MeasureFieldSearch, "Oz WT");
            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureButtonSearch);

            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", ElementsMeasure.MeasureIconRemoved);

            //End Delete element of List

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"Doy click en eliminar medida")]
        public void WhenDoyClickEnEliminarMedida()
        {
            CommonElementsAction.Click("XPath", ElementsMeasure.MeasureIconRemoved);
        }

        [Then(@"Al buscar la medida en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarLaMedidaEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            Thread.Sleep(1500);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsMeasure.MeasureFieldSearch, MeassureName);
            CommonElementsAction.Click("CssSelector", ElementsMeasure.MeasureButtonSearch);
            Thread.Sleep(2000);
            CommonElementsAction.WaitElementNoFound(ElementsMeasure.MeasureView);
        }

        [Then(@"No se registra la medida en la tabla AFLS_STOCK_MEASURES")]
        public void ThenNoSeRegistraLaRelacionEnLaTablaAFLS_STOCK_MEASURES()
        {
            CommonQuery.DBSelectAValue("SELECT mea_name FROM AFLS_STOCK_MEASURES WHERE mea_name = '" + MeassureName + "';", 0);
        }
    }
}