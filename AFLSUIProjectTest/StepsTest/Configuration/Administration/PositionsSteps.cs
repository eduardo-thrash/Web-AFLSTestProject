
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class PositionsSteps
    {
        
        
        private readonly ElementsPosition ElementsPosition = new ElementsPosition();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de Cargos")]
        public void WhenCreacionExitosaDeCargos()
        {
            

            

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);
            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionTabPositionInfo);
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsPosition.PositionName,"Especialista UI");
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsPosition.PositionCost,"12000");
            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de cargo existente")]
        public void WhenUsquedaExitosaDeCargoExistente()
        {


            
            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsPosition.PositionFieldSearch,"Tecnico WT");
            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsPosition.PositionName)).GetAttribute("value");
            Assert.AreEqual("Tecnico WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de cargos")]
        public void WhenModificacionExitosaDeCargos()
        {
            

           // CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.AdministrationMenu,SectionAdminLeftColumn.PositionOption,"");

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsPosition.PositionFieldSearch,"Instalador WT");
            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionView);

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);
            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionTabPositionInfo);
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsPosition.PositionName,"Instalador Update WT");
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsPosition.PositionCost,"21000");
            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsPosition.PositionFieldSearch,"Instalador Update WT");
            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsPosition.PositionName)).GetAttribute("value");
            Assert.AreEqual("Instalador Update WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de cargo existente")]
        public void WhenBorradoExitosoDeCargoExistente()
        {
            

           
            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsPosition.PositionFieldSearch,"Instalador WT");
            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsPosition.PositionView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",ElementsPosition.PositionIconRemoved);

            
            //End Delete element of List

            //Validate response.
           
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}