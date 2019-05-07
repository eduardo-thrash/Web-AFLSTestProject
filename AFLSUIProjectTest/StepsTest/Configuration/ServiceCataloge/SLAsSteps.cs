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
    public sealed class SLAsSteps
    {
        private SLAsPage SLAsPage = new SLAsPage();

        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();
        private string DefaultANSName = "UI ANS ";
        private string ANSName = null;
        private string EditANSName = "UI edit ANS ";
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        [Given(@"El ANS no existe")]
        public void GivenElANSNoExiste()
        {
            ANSName = DefaultANSName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SLA WHERE agreement_type = 1 AND name = '" + ANSName + "';", 0);
        }

        [When(@"Doy click en Nuevo ANS")]
        public void WhenDoyClickEnNuevoANS()
        {
            CommonElementsAction.Click("CssSelector", SLAsPage.SLAButtonNew);
        }

        [When(@"Diligencio nombre de ANS")]
        public void WhenDiligencioNombreDeANS()
        {
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector", SLAsPage.TabSLADetail);

            CommonElementsAction.SendKeys_InputText("CssSelector", SLAsPage.SLAName, ANSName);
        }

        [When(@"Diligencio descripción de ANS")]
        public void WhenDiligencioDescripcionDeANS()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", SLAsPage.SLADescription, "Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur. Nunc et dolor vitae libero rutrum eleifend.");
        }

        [When(@"Selecciono fecha de inicio de ANS")]
        public void WhenSeleccionoFechaDeInicioDeANS()
        {
            CommonElementsAction.Click("Id", SLAsPage.SLAStartDate);
            Functions.CalendarDaySelection(false);
        }

        [When(@"Selecciono fecha de finalización de ANS")]
        public void WhenSeleccionoFechaDeFinalizacionDeANS()
        {
            CommonElementsAction.Click("Id", SLAsPage.SLAFinishDate);
            Functions.CalendarDaySelection();
            Thread.Sleep(3000);
        }

        [When(@"Doy click en switch de finalización de alarma de ANS")]
        public void WhenDoyClickEnSwitchDeFinalizacionDeAlarmaDeANS()
        {
            CommonElementsAction.Click("CssSelector", SLAsPage.CheckEndDate);
        }

        [When(@"Diligencio días de alarma de finalización de ANS")]
        public void WhenDiligencioDiasDeAlarmaDeFinalizacionDeANS()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", SLAsPage.LimitDaysFinishAlarm, "2");
        }

        [When(@"Selecciono fecha de revisión de ANS")]
        public void WhenSeleccionoFechaDeRevisionDeANS()
        {
            CommonElementsAction.Click("Id", SLAsPage.SLADateReview);
            Functions.CalendarDaySelection();
            Thread.Sleep(3000);
        }

        [When(@"Doy click en switch de revisión de alarma de ANS")]
        public void WhenDoyClickEnSwitchDeRevisionDeAlarmaDeANS()
        {
            CommonElementsAction.Click("CssSelector", SLAsPage.CheckReviewDate);
        }

        [When(@"Diligencio días de alarma de revisión de ANS")]
        public void WhenDiligencioDiasDeAlarmaDeRevisionDeANS()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", SLAsPage.LimitDaysReviewAlarm, "2");
        }

        [When(@"Diligencio costo relacionado al ANS")]
        public void WhenDiligencioCostoRelacionadoAlANS()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("Name", SLAsPage.Cost, "20000000");
        }

        [When(@"Diligencio costo por incumplimiento del ANS")]
        public void WhenDiligencioCostoPorIncumplimientoDelANS()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("Name", SLAsPage.Penality, "500000000");
        }

        [When(@"Selecciono el Tab de Acuerdos de tiempos de ANS")]
        public void WhenSeleccionoElTabDeAcuerdosDeTiemposDeANS()
        {
            CommonElementsAction.Click("CssSelector", SLAsPage.TabTimeAgreements);
        }

        [When(@"Diligencio y selecciono el cronometro para ANS")]
        public void WhenDiligencioYSeleccionoElCronometroParaANS()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", SLAsPage.ChronometerAutocomplete, "Tiempo de Aten", "a");
            Thread.Sleep(2000);
        }

        [When(@"Diligencio horas minutos y porcentaje de cumplimiento de cronometro asociado a ANS")]
        public void WhenDiligencioHorasMinutosYPorcentajeDeCumplimientoDeCronometroAsociadoAANS()
        {
            CommonElementsAction.SendKeys_InputText("Name", SLAsPage.ChronometerHours, "24");

            CommonElementsAction.SendKeys_InputText("Name", SLAsPage.ChronometerMinutes, "0");

            CommonElementsAction.SendKeys_InputText("Name", SLAsPage.ChronometerCompilance, "90");
        }

        [When(@"Selecciono el Tab de Adjuntos de ANS")]
        public void WhenSeleccionoElTabDeAdjuntosDeANS()
        {
            CommonElementsAction.Click("CssSelector", SLAsPage.TabAttachedFiles);
        }

        [When(@"Doy click en Guardar ANS")]
        public void WhenDoyClickEnGuardarANS()
        {
            CommonElementsAction.Click("CssSelector", SLAsPage.SLASubmit);
        }

        [Then(@"Se registra el ANS en la tabla AFLS_SLA")]
        public void ThenSeRegistraElANSEnLaTablaAFLS_SLA()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SLA WHERE agreement_type = 1 AND name = '" + ANSName + "';", 1);
        }

        [Given(@"El ANS existe")]
        public void GivenElANSExiste()
        {
            ANSName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE agreement_type = 1 AND sla_id > 3 AND is_deleted = 0 ORDER BY NEWID();", 1);
        }

        [Given(@"El ANS existe sin relaciones")]
        public void GivenElANSExisteSinRelaciones()
        {
            ANSName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE sla_id NOT IN (SELECT TOP 1 sla_id FROM AFLS_SERVICES ORDER BY NEWID()) AND agreement_type = 1 ORDER BY NEWID();", 1);
        }

        [When(@"Busco y selecciono el ANS")]
        public void WhenBuscoYSeleccionoElANS()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", SLAsPage.SLAFieldSearch, ANSName);
            CommonElementsAction.Click("CssSelector", SLAsPage.SLAButtonSearch);

            CommonElementsAction.Click("XPath", SLAsPage.SLAView);
        }

        [Then(@"Se muestra la tarjeta del ANS y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelANSYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(SLAsPage.SLAName)).GetAttribute("value");
            Assert.AreEqual(ANSName, Value);
        }

        [When(@"Edito nombre de ANS")]
        public void WhenEditoNombreDeANS()
        {
            EditANSName = EditANSName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", SLAsPage.SLAName, EditANSName);
        }

        [Then(@"Se registra el ANS modificado en la tabla AFLS_SLA")]
        public void ThenSeRegistraElANSModificadoEnLaTablaAFLS_SLA()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SLA WHERE agreement_type = 1 AND name = '" + EditANSName + "';", 1);
        }

        [When(@"Doy click en eliminar ANS")]
        public void WhenDoyClickEnEliminarANS()
        {
            CommonElementsAction.Click("XPath", SLAsPage.SLAIconRemoved);
            Thread.Sleep(2000);
        }

        [Then(@"Se marca como eliminada la información del ANS en la tabla AFLS_SLA")]
        public void ThenSeMarcaComoEliminadaLaInformacionDelANSEnLaTablaAFLS_SLA()
        {
            CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE agreement_type = 1 AND name = '" + ANSName + "' AND is_deleted = 1;", 1);
        }

        [Then(@"Al buscar el ANS en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElANSEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", SLAsPage.SLAFieldSearch, ANSName);
            CommonElementsAction.Click("CssSelector", SLAsPage.SLAButtonSearch);

            CommonElementsAction.WaitElementNoFound(SLAsPage.SLAView);
        }
    }
}