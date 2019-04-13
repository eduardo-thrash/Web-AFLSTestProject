
using AFLSUIProjectTest.UIMap.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using CommonTest.CommonTest;
using AFLSUIProjectTest.UIMap.Messages;

namespace AFLSUITestProject.TestSuite.Configuration.Service_Catalogue
{
    [Binding]
    public class OLAsSteps
    {
        
        
        private ElementsOLA ElementsOLA = new ElementsOLA();
        //private OLAsObjectData OLAsObjectData = new OLAsObjectData();
        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de OLA")]
        public void WhenCreacionExitosaDeOLA()
        {
            //Login.
            
            //End Login.

            //Navigate ItemMenu, SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.OLAOption,"");
            //End Navigate ItemMenu, SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",ElementsOLA.OLAButtonNew);
            //End Navigate Module Content

            ////Navigate Module Details

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath",ElementsOLA.OLATabDetail);

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLAName,"OLA UI Gold");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLADescription,"Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur. Nunc et dolor vitae libero rutrum eleifend.");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLAStartDate,"1/01/2018");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLAFinishDate,"31/12/2019");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",ElementsOLA.OLACheckEndDate);

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLALimitDaysFinishAlarm,"3");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLADateReview,"1/12/2019");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",ElementsOLA.OLACheckReviewDate);

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLALimitDaysReviewAlarm,"3");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLACost,"20000000");

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLAPenality,"400000000");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Navigate from Secundary tab.
            Console.WriteLine("Navigate from Secundary tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath",ElementsOLA.OLATabTimeAgreements);

            //CommonTest.CommonElementsAction.Select_ComboboxAutocomplete("XPath",ElementsOLA.OLAChronometerAutocomplete,"Tiempo de Atención","a");
            //Thread.Sleep(2000);

            //CommonElementsAction.SendKeys_InputText("XPath",ElementsOLA.OLAChronometerHours,"48");

            //CommonElementsAction.SendKeys_InputText("XPath",ElementsOLA.OLAChronometerMinutes,"0");

            //CommonElementsAction.SendKeys_InputText("XPath",ElementsOLA.OLAChronometerCompilance,"90");

            Console.WriteLine("\n" + "Navigate from Secundary tab.");
            //Navigate from Secundary tab.

            //Save
            Thread.Sleep(3000);
            CommonElementsAction.Click("CssSelector",ElementsOLA.OLASubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de OLA existente")]
        public void WhenBusquedaExitosaDeOLAExistente()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.OLAOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLAFieldSearch,"OLA Premium WT");
            CommonElementsAction.Click("CssSelector",ElementsOLA.OLAButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ElementsOLA.OLAView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsOLA.OLAName)).GetAttribute("value");
            Assert.AreEqual("OLA Premium WT",Value);
            //End Validate response of search.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de OLA")]
        public void WhenModificacionExitosaDeOLA()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.OLAOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLAFieldSearch,"OLA Normal WT");
            CommonElementsAction.Click("CssSelector",ElementsOLA.OLAButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ElementsOLA.OLAView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            //End Validate response of search.

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath",ElementsOLA.OLATabDetail);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsOLA.OLAName,"OLA Update Plata UI");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsOLA.OLADescription,"Update Description ipsum dolor sit amet consectetur adipiscing elit.");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",ElementsOLA.OLASubmit);
            //End Save

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ElementsOLA.OLAFieldSearch,"OLA Update Plata UI");
            CommonElementsAction.Click("CssSelector",ElementsOLA.OLAButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ElementsOLA.OLAView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsOLA.OLAName)).GetAttribute("value");
            Assert.AreEqual("OLA Update Plata UI",Value);
            //End Validate response of search.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de OLA existente")]
        public void WhenBorradoExitosoDeOLAExistente()
        {
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsOLA.OLAFieldSearch,"OLA Emergencia WT");
            CommonElementsAction.Click("CssSelector",ElementsOLA.OLAButtonSearch);
            //End Navigate Module List Content

            //Object search to read
            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",ElementsOLA.OLAView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsOLA.OLAName)).GetAttribute("value");
            Assert.AreEqual("OLA Emergencia WT",Value);
            //End Validate response of search.

            //Delete element of List
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath",ElementsOLA.OLAIconRemoved);
            Thread.Sleep(2000);
            
            //End Delete element of List

            //Validate response of search.
            
            //End Validate response of search.

            //LogOut.
            
            //End LogOut.
        }

        #region Data csv

       

        

        #endregion Data csv
    }
}