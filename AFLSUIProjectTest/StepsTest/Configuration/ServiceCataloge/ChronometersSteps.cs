
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
        

        [When(@"Creación completa de cronometros")]
        public void WhenTengoUnUsuarioConRolAdministrador()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",ChronometersPage.ChronometerButtonNew);
            //End Navigate Module Content

            ////Navigate Module Details

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");

            Thread.Sleep(5000);
            CommonElementsAction.Click("CssSelector",ChronometersPage.TabChronometerdetail);

            CommonElementsAction.SendKeys_InputText("CssSelector",ChronometersPage.ChronometerName,"Cronometro UI");
            Console.WriteLine("\t Click and diligently ChronometerName.");

            CommonElementsAction.SendKeys_InputText("CssSelector",ChronometersPage.ChronometerDescription,"Sed et orci ac massa feugiat consequat vitae ac neque. Integer tincidunt a leo id feugiat.");
            Console.WriteLine("\t Click and diligently ChronometerDescription.");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",ChronometersPage.ChronometerSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"consulta exitosa de cronometro por nombre")]
        public void WhenConsultaExitosaDeCronometroPorNombre()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ChronometersPage.ChronometerInputSearch,"Cronometro Trabajo WT");
            CommonElementsAction.Click("CssSelector",ChronometersPage.ChronometerButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ChronometersPage.ChronometerItemView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ChronometersPage.ChronometerName)).GetAttribute("value");
            Assert.AreEqual("Cronometro Trabajo WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación parcial de cronometeros")]
        public void WhenModificacionParcialDeCronometeros()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ChronometersPage.ChronometerInputSearch,"Cronometro Almuerzo WT");
            CommonElementsAction.Click("CssSelector",ChronometersPage.ChronometerButtonSearch);

            CommonElementsAction.Click("XPath",ChronometersPage.ChronometerItemView);

            CommonElementsAction.Click("CssSelector",ChronometersPage.TabChronometerdetail);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ChronometersPage.ChronometerName,"Tiempo Update Almuerzo WT");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ChronometersPage.ChronometerDescription,"Description update chronos");

            //Save
            CommonElementsAction.Click("CssSelector",ChronometersPage.ChronometerSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ChronometersPage.ChronometerInputSearch,"Tiempo Update Almuerzo WT");
            CommonElementsAction.Click("CssSelector",ChronometersPage.ChronometerButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ChronometersPage.ChronometerItemView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ChronometersPage.ChronometerName)).GetAttribute("value");
            Assert.AreEqual("Tiempo Update Almuerzo WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrar cronometro existente")]
        public void WhenBorrarCronometroExistente()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ChronometersPage.ChronometerInputSearch,"Cronometro Resolución WT");
            CommonElementsAction.Click("CssSelector",ChronometersPage.ChronometerButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ChronometersPage.ChronometerItemView);

            //Delete element of List
            CommonElementsAction.Click("XPath",ChronometersPage.ChronometerIconRemoved);

            Thread.Sleep(2000);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}