using AFLSTestProjectUI.UIMap.Configuration;
using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.AFLS;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class SurveysSteps
    {
        private ElementsSurvey ElementsSurvey = new ElementsSurvey();
        private MessagesElements Messages = new MessagesElements();
        private ResponseValidation Validation = new ResponseValidation();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        [When(@"Configuración completa exitosa de encuestas")]
        public void WhenConfiguracionCompletaExitosaDeEncuestas()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"DIligencio nivel de satisfacción global")]
        public void WhenDIligencioNivelDeSatisfaccionGlobal()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("Id", ElementsSurvey.SurveyInputLevel, "4");
        }

        [When(@"Selecciono tiempo de medición")]
        public void WhenSeleccionoTiempoDeMedicion()
        {
            Random rnd = new Random();
            int NumRandom = rnd.Next(1, 3);
            new SelectElement(CommonHooks.driver.FindElement(By.Id("satisfaction_level_time_period"))).SelectByIndex(NumRandom);
        }

        [When(@"Diligencio y selecciono usuario monitor")]
        public void WhenDiligencioYSeleccionoUsuarioMonitor()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ElementsSurvey.SurveyInputInternalMonitor, CommonQuery.DBSelectAValue("SELECT USR.user_name FROM AFW_ROLE_ACCESS ROL JOIN AFW_USERS USR ON ROL.roac_user_id = USR.user_id AND roac_role_id = 34005 AND USER_ID <> 2 ORDER BY NEWID();", 1));
            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath", "//ul[@id='internalTargetsFinder_listbox']/li[@class='k-item']");
            Thread.Sleep(2000);
        }

        [When(@"Diligencio y selecciono correo de monitor externo")]
        public void WhenDiligencioYSeleccionoCorreoDeMonitorExterno()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ElementsSurvey.SurveyInputExternalMonitor, Functions.RandomText(5) + "@mailer.com");
            CommonElementsAction.Click("XPath", ElementsSurvey.SurveyButtonExternalMonitorAdd);
        }

        [When(@"Doy click en Guardar configuración general de encuestas")]
        public void WhenDoyClickEnGuardarConfiguracionGeneralDeEncuestas()
        {
            CommonElementsAction.Click("XPath", ElementsSurvey.ButtonSurveySave);
        }

        [Then(@"Se muestra mensaje indicando que se actualizo correctamente")]
        public void ThenSeMuestraMensajeIndicandoQueSeActualizoCorrectamente()
        {
            try
            {
                string Message = CommonElementsAction.TextExtract("XPath", "//div[@class='surveysConfig col row cgarandaCommonSurveyComponentContainer']//div[@class='flag _flagBox success']/p");
                Assert.IsTrue(Message.Contains(MessagesCopies.SuccessSurveyConfig));
            }
            catch
            {
                string Message = CommonElementsAction.TextExtract("XPath", "//div[@class='surveysConfig col row cgarandaCommonSurveyComponentContainer']//div[@class='flag _flagBox error']/p");
                Assert.Fail(Message);
            }
        }
    }
}