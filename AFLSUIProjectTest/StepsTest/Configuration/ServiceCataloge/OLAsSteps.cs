using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Service_Catalogue
{
    [Binding]
    public class OLAsSteps
    {
        //private OLAsObjectData OLAsObjectData = new OLAsObjectData();
        private object ElementsMessages;

        private PageMessages PageMessages = new PageMessages();
        private ElementsOLA OLAsPage = new ElementsOLA();
        private static string DefaultOlaName = "IU OLA ";
        private static string OlaName;
        private static string EditOlaName = "Edit UI OLA ";
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        [Given(@"El OLA no existe")]
        public void GivenElOLANoExiste()
        {
            OlaName = DefaultOlaName + Functions.RandomText(5);
            CommonQuery.DBSelectAValue("SELECT name FROM AFLS_SLA WHERE agreement_type = 3 AND name = '" + OlaName + "';", 0);
        }

        [When(@"Diligencio nombre de OLA")]
        public void WhenDiligencioNombreDeOLA()
        {
            CommonElementsAction.Click("XPath", OLAsPage.OLATabDetail);

            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLAName, OlaName);
        }

        [When(@"Diligencio descripción")]
        public void WhenDiligencioDescripcion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLADescription, "Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur. Nunc et dolor vitae libero rutrum eleifend.");
        }

        [When(@"Selecciono fecha de inicio")]
        public void WhenSeleccionoFechaDeInicio()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLAStartDate);
            Functions.CalendarDaySelection(false);
        }

        [When(@"Selecciono fecha de finalización")]
        public void WhenSeleccionoFechaDeFinalizacion()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLAFinishDate);
            Functions.CalendarDaySelection();
        }

        [When(@"Doy click en switch de finalización de alarma")]
        public void WhenDoyClickEnSwitchDeFinalizacionDeAlarma()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLACheckEndDate);
        }

        [When(@"Diligencio días de alarma de finalización")]
        public void WhenDiligencioDiasDeAlarmaDeFinalizacion()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLALimitDaysFinishAlarm, "3");
        }

        [When(@"Selecciono fecha de revisión")]
        public void WhenSeleccionoFechaDeRevision()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLADateReview);
            Functions.CalendarDaySelection();
        }

        [When(@"Doy click en switch de revisión de alarma")]
        public void WhenDoyClickEnSwitchDeRevisionDeAlarma()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLACheckReviewDate);
        }

        [When(@"Diligencio días de alarma de revisión")]
        public void WhenDiligencioDiasDeAlarmaDeRevision()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLALimitDaysReviewAlarm, "3");
        }

        [When(@"Diligencio costo relacionado al OLA")]
        public void WhenDiligencioCostoRelacionadoAlOLA()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLACost, "20000000");
        }

        [When(@"Diligencio descripción de OLA")]
        public void WhenDiligencioDescripcionDeOLA()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLADescription, "Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur. Nunc et dolor vitae libero rutrum eleifend.");
        }

        [When(@"Selecciono fecha de inicio de OLA")]
        public void WhenSeleccionoFechaDeInicioDeOLA()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLAStartDate);
            Functions.CalendarDaySelection(false);
        }

        [When(@"Selecciono fecha de finalización de OLA")]
        public void WhenSeleccionoFechaDeFinalizacionDeOLA()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLAFinishDate);
            Functions.CalendarDaySelection();
        }

        [When(@"Doy click en switch de finalización de alarma de OLA")]
        public void WhenDoyClickEnSwitchDeFinalizacionDeAlarmaDeOLA()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLACheckEndDate);
        }

        [When(@"Diligencio días de alarma de finalización de OLA")]
        public void WhenDiligencioDiasDeAlarmaDeFinalizacionDeOLA()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLALimitDaysFinishAlarm, "3");
        }

        [When(@"Selecciono fecha de revisión de OLA")]
        public void WhenSeleccionoFechaDeRevisionDeOLA()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLADateReview);
            Functions.CalendarDaySelection();
        }

        [When(@"Doy click en switch de revisión de alarma de OLA")]
        public void WhenDoyClickEnSwitchDeRevisionDeAlarmaDeOLA()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLACheckReviewDate);
        }

        [When(@"Diligencio días de alarma de revisión de OLA")]
        public void WhenDiligencioDiasDeAlarmaDeRevisionDeOLA()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLALimitDaysReviewAlarm, "3");
        }

        [When(@"Diligencio horas minutos y porcentaje de cumplimiento de cronometro asociado a OLA")]
        public void WhenDiligencioHorasMinutosYPorcentajeDeCumplimientoDeCronometroAsociadoAOLA()
        {
            Thread.Sleep(2000);

            CommonElementsAction.SendKeys_InputText("XPath", OLAsPage.OLAChronometerHours, "48");

            CommonElementsAction.SendKeys_InputText("XPath", OLAsPage.OLAChronometerMinutes, "0");

            CommonElementsAction.SendKeys_InputText("XPath", OLAsPage.OLAChronometerCompilance, "90");
        }

        [When(@"Diligencio costo por incumplimiento del OLA")]
        public void WhenDiligencioCostoPorIncumplimientoDelOLA()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLAPenality, "400000000");
        }

        [When(@"Selecciono el Tab de Acuerdos de tiempos de OLA")]
        public void WhenSeleccionoElTabDeAcuerdosDeTiemposDeOLA()
        {
            CommonElementsAction.Click("XPath", OLAsPage.OLATabTimeAgreements);
        }

        [When(@"Diligencio y selecciono el cronometro para OLA")]
        public void WhenDiligencioYSeleccionoElCronometroParaOLA()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", OLAsPage.OLAChronometerAutocomplete, "Tiempo de Atención", "a");
        }

        [When(@"Diligencio horas minutos y porcentaje de cumplimiento")]
        public void WhenDiligencioHorasMinutosYPorcentajeDeCumplimiento()
        {
            Thread.Sleep(2000);

            CommonElementsAction.SendKeys_InputText("XPath", OLAsPage.OLAChronometerHours, "48");

            CommonElementsAction.SendKeys_InputText("XPath", OLAsPage.OLAChronometerMinutes, "0");

            CommonElementsAction.SendKeys_InputText("XPath", OLAsPage.OLAChronometerCompilance, "90");
        }

        [When(@"Selecciono el Tab de Adjuntos de OLA")]
        public void WhenSeleccionoElTabDeAdjuntosDeOLA()
        {
            CommonElementsAction.Click("XPath", OLAsPage.OLATabAttachedFiles);
        }

        [When(@"Doy click en Guardar OLA")]
        public void WhenDoyClickEnGuardarOLA()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLASubmit);
        }

        [Then(@"Se registra el OLA en la tabla AFLS_SLA")]
        public void ThenSeRegistraElOLAEnLaTablaAFLS_SLA()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFLS_SLA WHERE agreement_type = 3 AND name = '" + OlaName + "';", 1);
        }

        [Given(@"El OLA existe")]
        public void GivenElOLAExiste()
        {
            OlaName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE agreement_type = 3 AND sla_id > 3 AND is_deleted = 0 ORDER BY NEWID();", 1);
        }

        [Given(@"El OLA existe sin relaciones")]
        public void GivenElOLAExisteSinRelaciones()
        {
            OlaName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE sla_id NOT IN (SELECT TOP 1 sla_id FROM AFLS_SERVICES ORDER BY NEWID()) AND agreement_type = 3 ORDER BY NEWID();", 1);
        }

        [When(@"Busco y selecciono el OLA")]
        public void WhenBuscoYSeleccionoElOLA()
        {
            Thread.Sleep(2000);
            CommonElementsAction.SendKeys_InputText("CssSelector", OLAsPage.OLAFieldSearch, OlaName);
            CommonElementsAction.Click("CssSelector", OLAsPage.OLAButtonSearch);
            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath", OLAsPage.OLAView);
        }

        [Then(@"Se muestra la tarjeta del OLA y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelOLAYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(OLAsPage.OLAName)).GetAttribute("value");
            Assert.AreEqual(OlaName, Value);
        }

        [When(@"Doy click en Nuevo OLA")]
        public void WhenDoyClickEnNuevoOLA()
        {
            CommonElementsAction.Click("CssSelector", OLAsPage.OLAButtonNew);
        }

        [When(@"Edito nombre de OLA")]
        public void WhenEditoNombreDeOLA()
        {
            EditOlaName = EditOlaName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", OLAsPage.OLAName, EditOlaName);
        }

        [Then(@"Se registra el OLA modificado en la tabla AFLS_SLA")]
        public void ThenSeRegistraElOLAModificadoEnLaTablaAFLS_SLA()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFLS_SLA WHERE agreement_type = 3 AND name = '" + EditOlaName + "';", 1);
        }

        [When(@"Doy click en eliminar OLA")]
        public void WhenDoyClickEnEliminarOLA()
        {
            CommonElementsAction.Click("XPath", OLAsPage.OLAIconRemoved);
            Thread.Sleep(2000);
        }

        [Then(@"Se marca como eliminada la información del OLA en la tabla AFLS_SLA")]
        public void ThenSeMarcaComoEliminadaLaInformacionDelOLAEnLaTablaAFLS_SLA()
        {
            CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE agreement_type = 3 AND name = '" + OlaName + "' AND is_deleted = 1;", 1);
        }

        [Then(@"Al buscar el OLA en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElOLAEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            Thread.Sleep(1000);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", OLAsPage.OLAFieldSearch, OlaName);
            CommonElementsAction.Click("CssSelector", OLAsPage.OLAButtonSearch);
            CommonElementsAction.WaitElementNoFound(OLAsPage.OLAView);
        }
    }
}