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
    public class ProductsSteps
    {
        private readonly ElementsProduct ProductsPage = new ElementsProduct();
        private readonly PageMessages PageMessages = new PageMessages();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        private static string DefaultProductName = "UI producto ";
        private static string ProductName;
        private static string EditProductName = "UI producto Edit ";
        private static string ProductDescription;

        [Given(@"El producto tipo cantidad con SKU no existe")]
        public void GivenElProductoTipoCantidadConSKUNoExiste()
        {
            CommonQuery.DBSelectAValue("", 0);
        }

        [Given(@"Existe una medida")]
        public void GivenExisteUnaMedida()
        {
            CommonQuery.DBSelectAValue("", 1);
        }

        [When(@"Doy click en Nuevo producto")]
        public void WhenDoyClickEnNuevoProducto()
        {
            CommonElementsAction.Click("CssSelector", ProductsPage.ProductButtonNew);
        }

        [When(@"Selecciono tipo producto cantidad")]
        public void WhenSeleccionoTipoProductoCantidad()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", ProductsPage.ProductType, "", "");
        }

        [When(@"Diligencio SKU único")]
        public void WhenDiligencioSKUUnico()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("", ProductsPage.ProductSKU, "");
        }

        [When(@"Diligencio nombre de producto")]
        public void WhenDiligencioNombreDeProducto()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("", ProductsPage.ProductName, ProductName);
        }

        [When(@"Diligencio descripción de producto")]
        public void WhenDiligencioDescripcionDeProducto()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("", ProductsPage.ProductName, "Description");
        }

        [When(@"Diligencio cantidad mínima de producto")]
        public void WhenDiligencioCantidadMinimaDeProducto()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("", ProductsPage.ProductMinimalAmount, "Description");
        }

        [When(@"Selecciono una medida")]
        public void WhenSeleccionoUnaMedida()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("", ProductsPage.ProductMeasureUnit, "","");
        }

        [When(@"Diligencio precio de venta")]
        public void WhenDiligencioPrecioDeVenta()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("", ProductsPage.ProductSellingPrice, "2000");
        }

        [When(@"Doy click en switch de estado de producto")]
        public void WhenDoyClickEnSwitchDeEstadoDeProducto()
        {
            CommonElementsAction.Click("", "");
        }

        [When(@"Doy click en Guardar producto")]
        public void WhenDoyClickEnGuardarProducto()
        {
            CommonElementsAction.Click("", ProductsPage.ProductSubmit);
        }

        [Then(@"Se registra el producto de tipo cantidad en la tabla AFLS_STOCK_PRODUCTS")]
        public void ThenSeRegistraElProductoDeTipoCantidadEnLaTablaAFLS_STOCK_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("", 1);
        }

        [Given(@"El producto tipo único con SKU no existe")]
        public void GivenElProductoTipoUnicoConSKUNoExiste()
        {
            CommonQuery.DBSelectAValue("", 0);
        }

        [When(@"Selecciono tipo producto único")]
        public void WhenSeleccionoTipoProductoUnico()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("", ProductsPage.ProductType, "", "");
        }

        [Then(@"Se registra el producto de tipo único en la tabla AFLS_STOCK_PRODUCTS")]
        public void ThenSeRegistraElProductoDeTipoUnicoEnLaTablaAFLS_STOCK_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("", 1);
        }

        [Given(@"El producto existe")]
        public void GivenElProductoExiste()
        {
            CommonQuery.DBSelectAValue("", 1);
        }

        [When(@"Busco y selecciono el producto")]
        public void WhenBuscoYSeleccionoElProducto()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ProductsPage.ProductFieldSearch, ProductName);
            CommonElementsAction.Click("CssSelector", ProductsPage.ProductButtonSearch);
            CommonElementsAction.Click("XPath", ProductsPage.ProductView);
        }

        [Then(@"Se muestra la tarjeta del producto y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelProductoYElDetalleDelMismo()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ProductsPage.ProductName)).GetAttribute("value");
            Assert.AreEqual(ProductName, Value);
        }

        [When(@"Modifico el nombre de producto")]
        public void WhenModificoElNombreDeProducto()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("", ProductsPage.ProductName, EditProductName);
        }

        [Then(@"Se registra el producto modificado en la tabla AFLS_STOCK_PRODUCTS")]
        public void ThenSeRegistraElProductoModificadoEnLaTablaAFLS_STOCK_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("", 1);
        }

        [When(@"Doy click en eliminar producto")]
        public void WhenDoyClickEnEliminarProducto()
        {
            CommonElementsAction.Click("", ProductsPage.ProductIconRemoved);
        }

        [Then(@"Se borra el registro de el producto en la tabla AFLS_STOCK_PRODUCTS")]
        public void ThenSeBorraElRegistroDeElProductoEnLaTablaAFLS_STOCK_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("", 0);
        }

    }
}
