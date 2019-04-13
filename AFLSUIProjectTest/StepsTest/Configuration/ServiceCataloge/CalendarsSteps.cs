
using AFLSUIProjectTest.UIMap.ConfigurationElementsConfiguration;
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
    public class CalendarsSteps
    {
        
        
        private CalendarsPage CalendarsPage = new CalendarsPage();
        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de Calendarios")]
        public void WhenCreacionExitosaDeCalendarios()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarButtonNew);
            //End Navigate Module Content

            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarTabCalendarInformation);

            CommonElementsAction.SendKeys_InputText("CssSelector",CalendarsPage.CalendarName,"Calendario UI Fines de semana");

            CommonElementsAction.SendKeys_InputText("CssSelector",CalendarsPage.CalendarDescription,"Description calendar ipsum dolor sit amet");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Navigate from Secundary tab.
            Console.WriteLine("Navigate from Secundary tab." + "\n");

            //TabWorkingHours
            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarTabWorkingHours);

            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarAvailabiltty);

            //TabNonWorkingDays
            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarTabNonWorkingDays);

            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarFieldHoliday);
            Thread.Sleep(2000);

            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarHoliday);
            Thread.Sleep(1000);

            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarAddDay);

            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarLoadHolidays);

            Console.WriteLine("\n" + "Navigate from Secundary tab.");
            //Navigate from Secundary tab.

            //Save
            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda de calendario existente")]
        public void WhenBusquedaDeCalendarioExistente()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",CalendarsPage.CalendarFieldSearch,"Calendario AFLS 24x5 WT");
            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",CalendarsPage.CalendarView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(CalendarsPage.CalendarName)).GetAttribute("value");
            Assert.AreEqual("Calendario AFLS 24x5 WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"modificación parcial de calendario")]
        public void WhenModificacionParcialDeCalendario()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",CalendarsPage.CalendarFieldSearch,"Calendario AFLS 8x3 WT");
            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarButtonSearch);

            CommonElementsAction.Click("XPath",CalendarsPage.CalendarView);

            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarTabCalendarInformation);

            CommonElementsAction.Clear("CssSelector",CalendarsPage.CalendarName);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",CalendarsPage.CalendarName,"Calendario Update AFLS 8x3 WT");

            CommonElementsAction.Clear("CssSelector",CalendarsPage.CalendarDescription);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",CalendarsPage.CalendarDescription,"update Description calendar ipsum dolor sitsa");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",CalendarsPage.CalendarFieldSearch,"Calendario Update AFLS 8x3 WT");
            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",CalendarsPage.CalendarView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(CalendarsPage.CalendarName)).GetAttribute("value");
            Assert.AreEqual("Calendario Update AFLS 8x3 WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrar calendario existente")]
        public void WhenBorrarCalendarioExistente()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",CalendarsPage.CalendarFieldSearch,"Cronometro Resolución WT");
            CommonElementsAction.Click("CssSelector",CalendarsPage.CalendarButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath",CalendarsPage.CalendarView);

            //Delete element of List
            CommonElementsAction.Click("XPath",CalendarsPage.CalendarIconRemoved);

            Thread.Sleep(2000);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}