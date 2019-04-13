
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Inventory
{
    [Binding]
    public class MeassuresSteps
    {
        
        
        private readonly ElementsMeasure ElementsMeasure = new ElementsMeasure();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de Medidas")]
        public void WhenCreacionExitosaDeMedidas()
        {
            

           // CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.InventoryMenu,SectionAdminLeftColumn.MeasureOption,"");

            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureButtonNew);

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureTabMeasures);

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsMeasure.MeasureName,"Metros UI");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsMeasure.MeasureDescription,"Description lorem ipsum des");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de Medida existente")]
        public void WhenBusquedaExitosaDeMedidaExistente()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.InventoryMenu,SectionAdminLeftColumn.MeasureOption,"");

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsMeasure.MeasureFieldSearch,"Unit WT");
            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureButtonSearch);

            CommonElementsAction.Click("XPath",ElementsMeasure.MeasureView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsMeasure.MeasureName)).GetAttribute("value");
            Assert.AreEqual("Unit WT",Value);

            //LogOut.
           // 
            //End LogOut.
        }

        [When(@"Modificación exitosa de Medidas")]
        public void WhenModificacionExitosaDeMedidas()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.InventoryMenu,SectionAdminLeftColumn.MeasureOption,"");

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsMeasure.MeasureFieldSearch,"Mtrs WT");
            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureButtonSearch);

            CommonElementsAction.Click("XPath",ElementsMeasure.MeasureView);

            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureTabMeasures);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsMeasure.MeasureName,"Mtrs WT Update");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsMeasure.MeasureDescription,"Descrip Update measure");

            //Save
            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsMeasure.MeasureFieldSearch,"Mtrs WT Update");
            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureButtonSearch);

            CommonElementsAction.Click("XPath",ElementsMeasure.MeasureView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsMeasure.MeasureName)).GetAttribute("value");
            Assert.AreEqual("Mtrs WT Update",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de Medida existente")]
        public void WhenBorradoExitosoDeMedidaExistente()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.InventoryMenu,SectionAdminLeftColumn.MeasureOption,"");

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsMeasure.MeasureFieldSearch,"Oz WT");
            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsMeasure.MeasureView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",ElementsMeasure.MeasureIconRemoved);


            //End Delete element of List

            //Validate response.
           
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}