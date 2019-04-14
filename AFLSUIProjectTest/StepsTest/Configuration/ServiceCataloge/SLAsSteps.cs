
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
    public sealed class SLAsSteps
    {
 
        private SLAsPage SLAsPage = new SLAsPage();

        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de ANS")]
        public void WhenCreacionExitosaDeANS()
        {
            //Login.
            
            //End Login.

            //Navigate ItemMenu, SubMenu and selected option.
            
            //End Navigate ItemMenu, SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",SLAsPage.SLAButtonNew);
            //End Navigate Module Content

            ////Navigate Module Details

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",SLAsPage.TabSLADetail);

            CommonElementsAction.SendKeys_InputText("CssSelector",SLAsPage.SLAName,"ANS UI Gold");

            CommonElementsAction.SendKeys_InputText("CssSelector",SLAsPage.SLADescription,"Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur. Nunc et dolor vitae libero rutrum eleifend.");

            CommonElementsAction.SendKeys_InputText("XPath",SLAsPage.SLAStartDate,"1/01/2018");

            CommonElementsAction.SendKeys_InputText("XPath",SLAsPage.SLAFinishDate,"30/12/2019");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",SLAsPage.CheckEndDate);

            CommonElementsAction.SendKeys_InputText("CssSelector",SLAsPage.LimitDaysFinishAlarm,"2");

            CommonElementsAction.SendKeys_InputText("XPath",SLAsPage.SLADateReview,"01/12/2019");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",SLAsPage.CheckReviewDate);

            CommonElementsAction.SendKeys_InputText("CssSelector",SLAsPage.LimitDaysReviewAlarm,"2");

            CommonElementsAction.ClearAndSendKeys_InputText("XPath",SLAsPage.Cost,"20000000");

            CommonElementsAction.ClearAndSendKeys_InputText("XPath",SLAsPage.Penality,"500000000");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Navigate from Secundary tab.
            Console.WriteLine("Navigate from Secundary tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",SLAsPage.TabTimeAgreements);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",SLAsPage.ChronometerAutocomplete,"Tiempo de Atención","a");
            Thread.Sleep(2000);

            CommonElementsAction.SendKeys_InputText("XPath",SLAsPage.ChronometerHours,"24");

            CommonElementsAction.SendKeys_InputText("XPath",SLAsPage.ChronometerMinutes,"0");

            CommonElementsAction.SendKeys_InputText("XPath",SLAsPage.ChronometerCompilance,"90");

            Console.WriteLine("\n" + "Navigate from Secundary tab.");
            //Navigate from Secundary tab.

            //Save
            Thread.Sleep(3000);
            CommonElementsAction.Click("CssSelector",SLAsPage.SLASubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de un ANS existente")]
        public void WhenBusquedaExitosaDeUnANSExistente()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",SLAsPage.SLAFieldSearch,"ANS Emergencia WT");
            CommonElementsAction.Click("CssSelector",SLAsPage.SLAButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",SLAsPage.SLAView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(SLAsPage.SLAName)).GetAttribute("value");
            Assert.AreEqual("ANS Emergencia WT",Value);
            //End Validate response of search.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de un ANS")]
        public void WhenModificacionExitosaDeUnANS()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
           
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",SLAsPage.SLAFieldSearch,"ANS Premium WT");
            CommonElementsAction.Click("CssSelector",SLAsPage.SLAButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",SLAsPage.SLAView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            //End Validate response of search.

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",SLAsPage.TabSLADetail);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",SLAsPage.SLAName,"ANS Premium Update WT");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",SLAsPage.SLADescription,"Description update");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",SLAsPage.SLASubmit);
            //End Save

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",SLAsPage.SLAFieldSearch,"ANS Premium Update WT");
            CommonElementsAction.Click("CssSelector",SLAsPage.SLAButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",SLAsPage.SLAView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(SLAsPage.SLAName)).GetAttribute("value");
            Assert.AreEqual("ANS Premium Update WT",Value);
            //End Validate response of search.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de ANS existente")]
        public void WhenBorradoExitosoDeANSExistente()
        {
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",SLAsPage.SLAFieldSearch,"ANS Prioridad WT");
            CommonElementsAction.Click("CssSelector",SLAsPage.SLAButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",SLAsPage.SLAView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(SLAsPage.SLAName)).GetAttribute("value");
            Assert.AreEqual("ANS Prioridad WT",Value);
            //End Validate response of search.

            //Delete element of List
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath",SLAsPage.SLAIconRemoved);
            Thread.Sleep(2000);
            
            //End Delete element of List

            //Validate response of search.
            
            //End Validate response of search.

            //LogOut.
            
            //End LogOut.
        }

   
    }
}