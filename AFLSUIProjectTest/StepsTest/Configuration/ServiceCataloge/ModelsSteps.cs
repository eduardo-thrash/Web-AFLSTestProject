


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
        

        [When(@"Creación exitosa de modelos")]
        public void WhenCreacionExitosaDeModelos()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.ModelOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",ModelsPage.ModelButtonNew);
            //End Navigate Module Content

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.SendKeys_InputText("CssSelector",ModelsPage.ModelName,"Modelo UI Gold");

            CommonElementsAction.SendKeys_InputText("CssSelector",ModelsPage.ModelDescription,"Interdum et malesuada fames ac ante ipsum primis in faucibus");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ModelsPage.ModelSurvey,"Satisfacc","label");
            Thread.Sleep(2000);

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",ModelsPage.ModelSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de un modelo existente")]
        public void WhenBusquedaExitosaDeUnModeloExistente()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.ModelOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ModelsPage.ModelFieldSearch,"Modelo Normal WT");
            CommonElementsAction.Click("CssSelector",ModelsPage.ModelButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ModelsPage.ModelView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ModelsPage.ModelName)).GetAttribute("value");
            Assert.AreEqual("Modelo Normal WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de un modelo")]
        public void WhenModificacionExitosaDeUnModelo()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.ModelOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ModelsPage.ModelFieldSearch,"Modelo Normal WT");
            CommonElementsAction.Click("CssSelector",ModelsPage.ModelButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ModelsPage.ModelView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            CommonElementsAction.Clear("CssSelector",ModelsPage.ModelName);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ModelsPage.ModelName,"Modelo Update Normal WT");

            CommonElementsAction.Clear("CssSelector",ModelsPage.ModelDescription);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ModelsPage.ModelDescription,"update Descrription");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",ModelsPage.ModelSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ModelsPage.ModelFieldSearch,"Modelo Update Normal WT");
            CommonElementsAction.Click("CssSelector",ModelsPage.ModelButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ModelsPage.ModelView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ModelsPage.ModelName)).GetAttribute("value");
            Assert.AreEqual("Modelo Update Normal WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de modelo existente")]
        public void WhenBorradoExitosoDeModeloExistente()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.ModelOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ModelsPage.ModelFieldSearch,"Modelo Emergencia WT");
            CommonElementsAction.Click("CssSelector",ModelsPage.ModelButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ModelsPage.ModelView);

            //Delete element of List
            CommonElementsAction.Click("XPath",ModelsPage.ModelIconRemoved);

            Thread.Sleep(2000);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}