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
        private static string ProductSKU = "SKU ";
        private static string ProductName = "UI Product ";
        private static string EditProductName = "UI producto Edit ";
        private static string ProductDescription;

        [Given(@"El producto tipo cantidad con SKU no existe")]
        public void GivenElProductoTipoCantidadConSKUNoExiste()
        {
            ProductSKU = DefaultProductName + Functions.RandomText(2);
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_PRODUCTS WHERE prod_sku = '" + ProductSKU + "';", 0);
        }

        [Given(@"Existe una medida")]
        public void GivenExisteUnaMedida()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_MEASURES WHERE mea_active = 1;", 1);
        }

        [When(@"Doy click en Nuevo producto")]
        public void WhenDoyClickEnNuevoProducto()
        {
            CommonElementsAction.Click("CssSelector", ProductsPage.ProductButtonNew);
            Thread.Sleep(2000);
        }

        [When(@"Selecciono tipo producto cantidad")]
        public void WhenSeleccionoTipoProductoCantidad()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ProductsPage.ProductType, "Cantidad", "label");
        }

        [When(@"Diligencio SKU único")]
        public void WhenDiligencioSKUUnico()
        {
            ProductSKU = ProductSKU + Functions.RandomText(2);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ProductsPage.ProductSKU, ProductSKU);
        }

        [When(@"Diligencio nombre de producto")]
        public void WhenDiligencioNombreDeProducto()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ProductsPage.ProductName, ProductName + Functions.RandomText(5));
        }

        [When(@"Diligencio descripción de producto")]
        public void WhenDiligencioDescripcionDeProducto()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ProductsPage.ProductDescription, "Description");
        }

        [When(@"Diligencio cantidad mínima de producto")]
        public void WhenDiligencioCantidadMinimaDeProducto()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ProductsPage.ProductMinimalAmount, "500");
        }

        [When(@"Selecciono una medida")]
        public void WhenSeleccionoUnaMedida()
        {
            string ProductMeassure = CommonQuery.DBSelectAValue("SELECT TOP 1 mea_name FROM AFLS_STOCK_MEASURES where mea_active = 1 ORDER BY NEWID();", 1);
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ProductsPage.ProductMeasureUnit, ProductMeassure, "label");
        }

        [When(@"Diligencio precio de venta")]
        public void WhenDiligencioPrecioDeVenta()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ProductsPage.ProductSellingPrice, "2000");
        }

        [When(@"Doy click en switch de estado de producto")]
        public void WhenDoyClickEnSwitchDeEstadoDeProducto()
        {
            CommonElementsAction.Click("", "");
        }

        [When(@"Doy click en Guardar producto")]
        public void WhenDoyClickEnGuardarProducto()
        {
            CommonElementsAction.Click("CssSelector", ProductsPage.ProductSubmit);
        }

        [Then(@"Se registra el producto de tipo cantidad en la tabla AFLS_STOCK_PRODUCTS")]
        public void ThenSeRegistraElProductoDeTipoCantidadEnLaTablaAFLS_STOCK_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_PRODUCTS WHERE prod_sku = '" + ProductSKU + "' AND prod_type = 0;", 1);
        }

        [Given(@"El producto tipo único con SKU no existe")]
        public void GivenElProductoTipoUnicoConSKUNoExiste()
        {
            ProductName = DefaultProductName + Functions.RandomText(3);
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_PRODUCTS WHERE prod_sku = '" + ProductName + "';", 0);
        }

        [When(@"Selecciono tipo producto único")]
        public void WhenSeleccionoTipoProductoUnico()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ProductsPage.ProductType, "único", "label");
        }

        [Then(@"Se registra el producto de tipo único en la tabla AFLS_STOCK_PRODUCTS")]
        public void ThenSeRegistraElProductoDeTipoUnicoEnLaTablaAFLS_STOCK_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_PRODUCTS WHERE prod_sku = '" + ProductSKU + "' AND prod_type = 1;", 1);
        }

        [Given(@"El producto existe")]
        public void GivenElProductoExiste()
        {
            ProductSKU = CommonQuery.DBSelectAValue("SELECT TOP 1 prod_sku FROM AFLS_STOCK_PRODUCTS ORDER BY NEWID()", 1);
        }

        [When(@"Busco y selecciono el producto")]
        public void WhenBuscoYSeleccionoElProducto()
        {
            Thread.Sleep(5000);
            UtilAction.SendKeys(ProductsPage.ProductFieldSearch, ProductSKU, "CssSelector");
            UtilAction.Click(ProductsPage.ProductButtonSearch, "CssSelector");
            Thread.Sleep(5000);
            UtilAction.Click(ProductsPage.ProductView);
        }

        [Then(@"Se muestra la tarjeta del producto y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelProductoYElDetalleDelMismo()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ProductsPage.ProductSKU)).GetAttribute("value");
            Assert.AreEqual(ProductSKU, Value);
        }

        [When(@"Modifico el nombre de producto")]
        public void WhenModificoElNombreDeProducto()
        {
            EditProductName = EditProductName + Functions.RandomText(4);
            UtilAction.ClearBefore_SendKeys(ProductsPage.ProductName, EditProductName, "CssSelector");
        }

        [Then(@"Se registra el producto modificado en la tabla AFLS_STOCK_PRODUCTS")]
        public void ThenSeRegistraElProductoModificadoEnLaTablaAFLS_STOCK_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_PRODUCTS WHERE prod_sku = '" + ProductSKU + "' and prod_name = '" + EditProductName + "';", 1);
        }

        [When(@"Doy click en eliminar producto")]
        public void WhenDoyClickEnEliminarProducto()
        {
            UtilAction.Click(ProductsPage.ProductIconRemoved);
        }

        [Then(@"Se borra el registro de el producto en la tabla AFLS_STOCK_PRODUCTS")]
        public void ThenSeBorraElRegistroDeElProductoEnLaTablaAFLS_STOCK_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_PRODUCTS WHERE prod_sku = '" + ProductSKU + "';", 0);
        }
    }
}