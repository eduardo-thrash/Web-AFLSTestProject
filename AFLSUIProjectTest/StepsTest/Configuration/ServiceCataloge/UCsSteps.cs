
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Service_Catalogue
{
    [Binding]
    public class UCsSteps
    {

        private ElementsUC ElementsUC = new ElementsUC();

        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de UC")]
        public void WhenCreacionExitosaDeUC()
        {
            //Login.
            
            //End Login.

            //Navigate ItemMenu, SubMenu and selected option.
           // 
            //End Navigate ItemMenu, SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",ElementsUC.UCButtonNew);
            //End Navigate Module Content

            ////Navigate Module Details

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath",ElementsUC.UCTabDetail);

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCName,"UC UI Gold");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCDescription,"Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur.");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCStartDate,"1/01/2018");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCFinishDate,"30/12/2019");
            Thread.Sleep(1000);

            CommonElementsAction.Click("CssSelector",ElementsUC.UCCheckEndDate);
            Thread.Sleep(1000);
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCLimitDaysFinishAlarm,"3");
            Thread.Sleep(1000);
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCDateReview,"01/12/2019");
            Thread.Sleep(1000);

            CommonElementsAction.Click("CssSelector",ElementsUC.UCCheckReviewDate);
            Thread.Sleep(1000);
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCLimitDaysReviewAlarm,"3");
            Thread.Sleep(1000);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsUC.UCCost,"20000000");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsUC.UCPenality,"200000000");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Navigate from Secundary tab.
            Console.WriteLine("Navigate from Secundary tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath",ElementsUC.UCTabTimeAgreements);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath",ElementsUC.UCChronometerAutocomplete,"Tiempo de Atención","a");
            Thread.Sleep(2000);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsUC.UCChronometerHours,"24");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsUC.UCChronometerMinutes,"0");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsUC.UCChronometerCompilance,"80");

            Console.WriteLine("\n" + "Navigate from Secundary tab.");
            //Navigate from Secundary tab.

            //Save
            Thread.Sleep(3000);
            CommonElementsAction.Click("CssSelector",ElementsUC.UCSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de UC existente")]
        public void WhenUsquedaExitosaDeUCExistente()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCFieldSearch,"UC Premium WT");
            CommonElementsAction.Click("CssSelector",ElementsUC.UCButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ElementsUC.UCView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsUC.UCName)).GetAttribute("value");
            Assert.AreEqual("UC Premium WT",Value);
            //End Validate response of search.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de UC")]
        public void WhenModificacionExitosaDeUC()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCFieldSearch,"UC Normal WT");
            CommonElementsAction.Click("CssSelector",ElementsUC.UCButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ElementsUC.UCView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            //End Validate response of search.

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath",ElementsUC.UCTabDetail);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsUC.UCName,"UC Update Plata UI");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsUC.UCDescription,"Update Description ipsum dolor sit amet consectetur adipiscing elit.");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",ElementsUC.UCSubmit);
            //End Save

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsUC.UCFieldSearch,"UC Update Plata UI");
            CommonElementsAction.Click("CssSelector",ElementsUC.UCButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ElementsUC.UCView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsUC.UCName)).GetAttribute("value");
            Assert.AreEqual("UC Update Plata UI",Value);
            //End Validate response of search.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de UC existente")]
        public void WhenBorradoExitosoDeUCExistente()
        {
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsUC.UCFieldSearch,"UC Emergencia WT");
            CommonElementsAction.Click("CssSelector",ElementsUC.UCButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ElementsUC.UCView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsUC.UCName)).GetAttribute("value");
            Assert.AreEqual("UC Emergencia WT",Value);
            //End Validate response of search.

            //Delete element of List
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath",ElementsUC.UCIconRemoved);
            Thread.Sleep(2000);
            //
            //End Delete element of List

            //Validate response of search.
            //
            //End Validate response of search.

            //LogOut.
            
            //End LogOut.
        }

       
    }
}