using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configuration
{
    class ElementsProduct
    {
        public string ProductModule = "Products";
        public string ProductButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.products #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string ProductSubmit = "div.products > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string ProductFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.products #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextProviderFieldSearch = "Field Search";

        public string ProductButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.products #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextProductButtonSearch = "Button Search";

        public string ProductView = "//div[@class='products']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //Xpath
        public string TextProductView = "product element view";

        public string ProductIconRemoved = "//div[@class='products']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']"; //Xpath
        public string TextProductIconRemoved = "Delete product icon";

        //Tab Products
        public string ProductTabProducts = "a[href = '#tabs-1'] > span.ui-icon.icon-product.icons_Products";
        public string ProductType = "#TypeProduct > div.dd-select > a.dd-selected";
        public string ProductSKU = ".container-app .container-module .admin .content.col.module .products .details .tabContent.product input[name='Sku']";
        public string ProductName = ".container-app .container-module .admin .content.col.module .products .details .tabContent.product input[name='Name']";
        public string ProductDescription = ".container-app .container-module .admin .content.col.module .products .details .tabContent.product textarea[name='Description']";
        public string ProductMinimalAmount = ".container-app .container-module .admin .content.col.module .products .details .tabContent.product input[name='MinimuAmount']";
        public string ProductMeasureUnit = "#Measure > div.dd-select > a.dd-selected";
        public string ProductSellingPrice = ".container-app .container-module .admin .content.col.module .products .details .tabContent.product input[name='Cost']";

        public string TextProductTabProducts = "Tab products";
        public string TextProductType = "Type Product";
        public string TextProductSKU = "Sku";
        public string TextProductName = "Name";
        public string TextProductDescription = "Description";
        public string TextProductMinimalAmount = "MinimuAmount";
        public string TextProductMeasureUnit = "Measure";
        public string TextProductSellingPrice = "Cost";
    }
}
