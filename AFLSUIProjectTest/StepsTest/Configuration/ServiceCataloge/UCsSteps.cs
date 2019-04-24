using AFLSUIProjectTest.CommonAFLS;
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
    public class UCsSteps
    {
        private ElementsUC ElementsUC = new ElementsUC();

        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();

        private string DefaultUCName = "UI UC ";
        private string UCName;
        private string EditUCName = "Edit UI UC ";
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        [Given(@"El UC no existe")]
        public void GivenElUCNoExiste()
        {
            UCName = DefaultUCName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SLA WHERE agreement_type = 2 AND name = '" + UCName + "';", 0);
        }

        [When(@"Doy click en Nuevo UC")]
        public void WhenDoyClickEnNuevoUC()
        {
            //Navigate Module Content
            CommonElementsAction.Click("CssSelector", ElementsUC.UCButtonNew);
            //End Navigate Module Content
        }

        [When(@"Diligencio nombre de UC")]
        public void WhenDiligencioNombreDeUC()
        {
            ////Navigate Module Details

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("XPath", ElementsUC.UCTabDetail);

            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsUC.UCName, UCName);
        }

        [When(@"Diligencio descripción de UC")]
        public void WhenDiligencioDescripcionDeUC()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsUC.UCDescription, "Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur.");
        }

        [When(@"Selecciono fecha de inicio de UC")]
        public void WhenSeleccionoFechaDeInicioDeUC()
        {
            CommonElementsAction.Click("CssSelector", ElementsUC.UCStartDate);
            Functions.CalendarDaySelection(false);
            CommonElementsAction.Click("CssSelector", ElementsUC.UCStartDate);
        }

        [When(@"Selecciono fecha de finalización de UC")]
        public void WhenSeleccionoFechaDeFinalizacionDeUC()
        {
            CommonElementsAction.Click("CssSelector", ElementsUC.UCFinishDate);
            Thread.Sleep(1000);
            Functions.CalendarDaySelection();
            CommonElementsAction.Click("CssSelector", ElementsUC.UCFinishDate);
        }

        [When(@"Doy click en switch de finalización de alarma de UC")]
        public void WhenDoyClickEnSwitchDeFinalizacionDeAlarmaDeUC()
        {
            CommonElementsAction.Click("CssSelector", ElementsUC.UCCheckEndDate);
            Thread.Sleep(1000);
        }

        [When(@"Diligencio días de alarma de finalización de UC")]
        public void WhenDiligencioDiasDeAlarmaDeFinalizacionDeUC()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsUC.UCLimitDaysFinishAlarm, "3");
        }

        [When(@"Selecciono fecha de revisión de UC")]
        public void WhenSeleccionoFechaDeRevisionDeUC()
        {
            Thread.Sleep(1000);
            CommonElementsAction.Click("CssSelector", ElementsUC.UCDateReview);
            Functions.CalendarDaySelection();
            CommonElementsAction.Click("CssSelector", ElementsUC.UCDateReview);
            Thread.Sleep(1000);
        }

        [When(@"Doy click en switch de revisión de alarma de UC")]
        public void WhenDoyClickEnSwitchDeRevisionDeAlarmaDeUC()
        {
            CommonElementsAction.Click("CssSelector", ElementsUC.UCCheckReviewDate);
            Thread.Sleep(1000);
        }

        [When(@"Diligencio días de alarma de revisión de UC")]
        public void WhenDiligencioDiasDeAlarmaDeRevisionDeUC()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsUC.UCLimitDaysReviewAlarm, "3");
            Thread.Sleep(1000);
        }

        [When(@"Diligencio costo relacionado al UC")]
        public void WhenDiligencioCostoRelacionadoAlUC()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsUC.UCCost, "20000000");
        }

        [When(@"Diligencio costo por incumplimiento del UC")]
        public void WhenDiligencioCostoPorIncumplimientoDelUC()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsUC.UCPenality, "200000000");
        }

        [When(@"Selecciono el Tab de Acuerdos de tiempos de UC")]
        public void WhenSeleccionoElTabDeAcuerdosDeTiemposDeUC()
        {
            CommonElementsAction.Click("XPath", ElementsUC.UCTabTimeAgreements);
        }

        [When(@"Diligencio y selecciono el cronometro para UC")]
        public void WhenDiligencioYSeleccionoElCronometroParaUC()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ElementsUC.UCChronometerAutocomplete, "Tiempo de Atenc", "a");
            Thread.Sleep(2000);
        }

        [When(@"Diligencio horas minutos y porcentaje de cumplimiento de cronometro asociado a UC")]
        public void WhenDiligencioHorasMinutosYPorcentajeDeCumplimientoDeCronometroAsociadoAUC()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ElementsUC.UCChronometerHours, "24");

            CommonElementsAction.SendKeys_InputText("XPath", ElementsUC.UCChronometerMinutes, "0");

            CommonElementsAction.SendKeys_InputText("XPath", ElementsUC.UCChronometerCompilance, "80");
        }

        [When(@"Selecciono el Tab de Adjuntos de UC")]
        public void WhenSeleccionoElTabDeAdjuntosDeUC()
        {
            CommonElementsAction.Click("XPath", ElementsUC.UCTabAttachedFiles);
        }

        [When(@"Doy click en Guardar UC")]
        public void WhenDoyClickEnGuardarUC()
        {
            Thread.Sleep(2000);
            CommonElementsAction.Click("CssSelector", ElementsUC.UCSubmit);
        }

        [Then(@"Se registra el UC en la tabla AFLS_SLA")]
        public void ThenSeRegistraElUCEnLaTablaAFLS_SLA()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFLS_SLA WHERE agreement_type = 2 AND name = '" + UCName + "';", 1);
        }

        [Given(@"El UC existe")]
        public void GivenElUCExiste()
        {
            UCName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE agreement_type = 2 AND sla_id > 3 AND is_deleted = 0 ORDER BY NEWID();", 1);
        }

        [When(@"Busco y selecciono el UC")]
        public void WhenBuscoYSeleccionoElUC()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsUC.UCFieldSearch, UCName);
            CommonElementsAction.Click("CssSelector", ElementsUC.UCButtonSearch);
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", ElementsUC.UCView);
        }

        [Then(@"Se muestra la tarjeta del UC y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelUCYElDetalleDelMismo()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsUC.UCName)).GetAttribute("value");
            Assert.AreEqual(UCName, Value);
        }

        [When(@"Edito nombre de UC")]
        public void WhenEditoNombreDeUC()
        {
            EditUCName = EditUCName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsUC.UCName, EditUCName);
        }

        [Then(@"Se registra el UC modificado en la tabla AFLS_SLA")]
        public void ThenSeRegistraElUCModificadoEnLaTablaAFLS_SLA()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFLS_SLA WHERE agreement_type = 2 AND name = '" + EditUCName + "';", 1);
        }

        [When(@"Doy click en eliminar UC")]
        public void WhenDoyClickEnEliminarUC()
        {
            CommonElementsAction.Click("XPath", ElementsUC.UCIconRemoved);
        }

        [Then(@"Se marca como eliminada la información del UC en la tabla AFLS_SLA")]
        public void ThenSeMarcaComoEliminadaLaInformacionDelUCEnLaTablaAFLS_SLA()
        {
            CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE agreement_type = 2 AND name = '" + UCName + "' AND is_deleted = 1", 1);
        }

        [Then(@"Al buscar el UC en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElUCEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ElementsUC.UCFieldSearch, UCName);
            CommonElementsAction.Click("CssSelector", ElementsUC.UCButtonSearch);

            CommonElementsAction.WaitElementNoFound(ElementsUC.UCView);
        }
    }
}