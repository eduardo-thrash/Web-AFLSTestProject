using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.ConfigurationElementsConfiguration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private static string DefaultCalendarName = "UI Calendar ";
        private static string CalendarName;
        private static string EditCalendarName = "Edit UI Cal ";

        [Given(@"El calendario no existe")]
        public void GivenElCalendarioNoExiste()
        {
            CalendarName = DefaultCalendarName + Functions.RandomText(4);
            CommonQuery.DBSelectAValue("SELECT cale_name FROM AFLS_CALENDAR WHERE cale_name = '" + CalendarName + "';", 0);
        }

        [When(@"Creación exitosa de Calendarios")]
        public void WhenCreacionExitosaDeCalendarios()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarButtonNew);
            //End Navigate Module Content

            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarTabCalendarInformation);

            CommonElementsAction.SendKeys_InputText("CssSelector", CalendarsPage.CalendarName, "Calendario UI Fines de semana");

            CommonElementsAction.SendKeys_InputText("CssSelector", CalendarsPage.CalendarDescription, "Description calendar ipsum dolor sit amet");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Navigate from Secundary tab.
            Console.WriteLine("Navigate from Secundary tab." + "\n");

            //TabWorkingHours
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarTabWorkingHours);

            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarAvailabiltty);

            //TabNonWorkingDays
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarTabNonWorkingDays);

            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarFieldHoliday);
            Thread.Sleep(2000);

            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarHoliday);
            Thread.Sleep(1000);

            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarAddDay);

            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarLoadHolidays);

            Console.WriteLine("\n" + "Navigate from Secundary tab.");
            //Navigate from Secundary tab.

            //Save
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"Busco y selecciono el calendario")]
        public void WhenBuscoYSeleccionoElCalendario()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CalendarsPage.CalendarFieldSearch, CalendarName);
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarButtonSearch);
            CommonElementsAction.Click("XPath", CalendarsPage.CalendarView);
        }

        [Then(@"Se muestra la tarjeta del calendario y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelCalendarioYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(CalendarsPage.CalendarName)).GetAttribute("value");
            Assert.AreEqual(CalendarName, Value);
        }

        [When(@"modificación parcial de calendario")]
        public void WhenModificacionParcialDeCalendario()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", CalendarsPage.CalendarFieldSearch, "Calendario AFLS 8x3 WT");
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarButtonSearch);

            CommonElementsAction.Click("XPath", CalendarsPage.CalendarView);

            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarTabCalendarInformation);

            CommonElementsAction.Clear("CssSelector", CalendarsPage.CalendarName);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", CalendarsPage.CalendarName, "Calendario Update AFLS 8x3 WT");

            CommonElementsAction.Clear("CssSelector", CalendarsPage.CalendarDescription);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", CalendarsPage.CalendarDescription, "update Description calendar ipsum dolor sitsa");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", CalendarsPage.CalendarFieldSearch, "Calendario Update AFLS 8x3 WT");
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath", CalendarsPage.CalendarView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(CalendarsPage.CalendarName)).GetAttribute("value");
            Assert.AreEqual("Calendario Update AFLS 8x3 WT", Value);

            //LogOut.

            //End LogOut.
        }

        [When(@"Doy click en eliminar calendario")]
        public void WhenDoyClickEnEliminarCalendario()
        {
            CommonElementsAction.Click("XPath", CalendarsPage.CalendarIconRemoved);
        }

        [Then(@"No se registra el calendario en la tabla AFLS_CALENDAR")]
        public void ThenNoSeRegistraElCalendarioEnLaTablaAFLS_CALENDAR()
        {
            CommonQuery.DBSelectAValue("SELECT cale_name FROM AFLS_CALENDAR WHERE cale_name = '" + CalendarName + "';", 0);
        }

        [Then(@"Al buscar el calendario en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElCalendarioEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CalendarsPage.CalendarFieldSearch, CalendarName);
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarButtonSearch);
            CommonElementsAction.WaitElementNoFound(CalendarsPage.CalendarView);
        }

        [When(@"Borrar calendario existente")]
        public void WhenBorrarCalendarioExistente()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", CalendarsPage.CalendarFieldSearch, "cronómetro Resolución WT");
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("XPath", CalendarsPage.CalendarView);

            //Delete element of List

            Thread.Sleep(2000);

            //End Delete element of List

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"Doy click en Nuevo calendario")]
        public void WhenDoyClickEnNuevoCalendario()
        {
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarButtonNew);
        }

        [When(@"Diligencio nombre de calendario")]
        public void WhenDiligencioNombreDeCalendario()
        {
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarTabCalendarInformation);

            CommonElementsAction.SendKeys_InputText("CssSelector", CalendarsPage.CalendarName, CalendarName);
        }

        [When(@"Edito nombre de calendario")]
        public void WhenEditoNombreDeCalendario()
        {
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarTabCalendarInformation);
            EditCalendarName = EditCalendarName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", CalendarsPage.CalendarName, EditCalendarName);
        }

        [When(@"Diligencio descripción de calendario")]
        public void WhenDiligencioDescripcionDeCalendario()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CalendarsPage.CalendarDescription, "Description calendar ipsum dolor sit amet");
        }

        [When(@"Selecciono el Tab de Horas laborales de calendario")]
        public void WhenSeleccionoElTabDeHorasLaboralesDeCalendario()
        {
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarTabWorkingHours);
        }

        [Then(@"Se registra el calendario modificado en la tabla AFLS_CALENDAR")]
        public void ThenSeRegistraElCalendarioModificadoEnLaTablaAFLS_CALENDAR()
        {
            CommonQuery.DBSelectAValue("SELECT cale_name FROM AFLS_CALENDAR WHERE cale_name = '" + EditCalendarName + "';", 1);
        }

        [When(@"Selecciono disponibilidad de siete días en calendario")]
        public void WhenSeleccionoDisponibilidadDeSieteDiasEnCalendario()
        {
            Actions Sunday = new Actions(CommonHooks.driver);
            Sunday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath(CalendarsPage.CalendarSunday)), 0, 200).Build().Perform();
            Thread.Sleep(500);

            Actions Monday = new Actions(CommonHooks.driver);
            Monday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath(CalendarsPage.CalendarMonday)), 0, 200).Build().Perform();
            Thread.Sleep(500);

            Actions Tuesday = new Actions(CommonHooks.driver);
            Tuesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath(CalendarsPage.CalendarTuesday)), 0, 200).Build().Perform();
            Thread.Sleep(500);

            Actions Wednesday = new Actions(CommonHooks.driver);
            Wednesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath(CalendarsPage.CalendarWednesday)), 0, 200).Build().Perform();
            Thread.Sleep(500);

            Actions Thursday = new Actions(CommonHooks.driver);
            Thursday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath(CalendarsPage.CalendarThursday)), 0, 200).Build().Perform();
            Thread.Sleep(500);

            Actions Friday = new Actions(CommonHooks.driver);
            Friday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath(CalendarsPage.CalendarFriday)), 0, 200).Build().Perform();
            Thread.Sleep(500);

            Actions Saturday = new Actions(CommonHooks.driver);
            Saturday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath(CalendarsPage.CalendarSaturday)), 0, 200).Build().Perform();
            Thread.Sleep(500);
        }

        [When(@"Selecciono el Tab de Días no laborales")]
        public void WhenSeleccionoElTabDeDiasNoLaborales()
        {
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarTabNonWorkingDays);
        }

        [When(@"Selecciono día no laboral")]
        public void WhenSeleccionoDiaNoLaboral()
        {
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarFieldHoliday);

            Functions.CalendarDaySelection();

            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarAddDay);

            CommonElementsAction.Click("XPath", CalendarsPage.CalendarLoadHolidays);
        }

        [When(@"Doy click en Guardar calendario")]
        public void WhenDoyClickEnGuardarCalendario()
        {
            CommonElementsAction.Click("CssSelector", CalendarsPage.CalendarSubmit);
        }

        [Then(@"Se registra el calendario en la tabla AFLS_CALENDAR")]
        public void ThenSeRegistraElCalendarioEnLaTablaAFLS_CALENDAR()
        {
            CommonQuery.DBSelectAValue("SELECT cale_name FROM AFLS_CALENDAR WHERE cale_name = '" + CalendarName + "';", 1);
        }

        [Given(@"El calendario existe")]
        public void GivenElCalendarioExiste()
        {
            CalendarName = CommonQuery.DBSelectAValue("SELECT TOP 1 cale_name FROM AFLS_CALENDAR WHERE cale_id > 2 ORDER BY NEWID();", 1);
        }
    }
}