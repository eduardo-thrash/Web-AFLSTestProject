using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class EmailTemplatesSteps
    {
        private readonly ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private readonly EmailTemplatesPage EmailTemplatesPage = new EmailTemplatesPage();
        private readonly PageMessages PageMessages = new PageMessages();

        [When(@"Doy click en el Tab Alerta de Nivel de Satisfacción al Cliente")]
        public void WhenDoyClickEnElTabAlertaDeNivelDeSatisfaccionAlCliente()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabSurveySatisAlert);
        }

        [When(@"Doy click en el Tab Asignación")]
        public void WhenDoyClickEnElTabAsignacion()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabGeneralAssigment);
        }

        [When(@"Doy click en el Tab Cambio de especialista")]
        public void WhenDoyClickEnElTabCambioDeEspecialista()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabGeneralChangeOfSpecialist);
        }

        [When(@"Doy click en el Tab Cancelación")]
        public void WhenDoyClickEnElTabCancelacion()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabGeneralCancellation);
        }

        [When(@"Doy click en el Tab Ejecutada")]
        public void WhenDoyClickEnElTabEjecutada()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabGeneralExecuted);
        }

        [When(@"Doy click en el Tab Encuesta de satisfacción al cliente")]
        public void WhenDoyClickEnElTabEncuestaDeSatisfaccionAlCliente()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabSurveySatisSurvey);
        }

        [When(@"Doy click en el Tab Finalización de ANS")]
        public void WhenDoyClickEnElTabFinalizacionDeANS()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabSLAEnding);
        }

        [When(@"Doy click en el Tab Finalización de OLA")]
        public void WhenDoyClickEnElTabFinalizacionDeOLA()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabOLAEnding);
        }

        [When(@"Doy click en el Tab Finalización de UC")]
        public void WhenDoyClickEnElTabFinalizacionDeUC()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabUCEnding);
        }

        [When(@"Doy click en el Tab Notificación de cuenta de usuarios Assistme")]
        public void WhenDoyClickEnElTabNotificacionDeCuentaDeUsuariosAssistme()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabAssistMeNotifyUserAssistMe);
        }

        [When(@"Doy click en el Tab Notificación de medición de encuesta")]
        public void WhenDoyClickEnElTabNotificacionDeMedicionDeEncuesta()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabSurveyNotifySurvey);
        }

        [When(@"Doy click en el Tab Notificación de resumen de encuesta")]
        public void WhenDoyClickEnElTabNotificacionDeResumenDeEncuesta()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabSurveySummarySurvey);
        }

        [When(@"Doy click en el Tab Notificación orden registrada desde Assistme")]
        public void WhenDoyClickEnElTabNotificacionOrdenRegistradaDesdeAssistme()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabAssistMeNotifyOrderAssistMe);
        }

        [When(@"Doy click en el Tab Proveedores")]
        public void WhenDoyClickEnElTabProveedores()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabGeneralProviders);
        }

        [When(@"Doy click en el Tab Registro")]
        public void WhenDoyClickEnElTabRegistro()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabGeneralRecord);
        }

        [When(@"Doy click en el Tab Retraso")]
        public void WhenDoyClickEnElTabRetraso()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabGeneralDelay);
        }

        [When(@"Doy click en el Tab Revisión de ANS")]
        public void WhenDoyClickEnElTabRevisionDeANS()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabSLAReview);
        }

        [When(@"Doy click en el Tab Revisión de OLA")]
        public void WhenDoyClickEnElTabRevisionDeOLA()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabOLAReview);
        }

        [When(@"Doy click en el Tab Revisión de UC")]
        public void WhenDoyClickEnElTabRevisionDeUC()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabUCReview);
        }

        [When(@"Doy click en el Tab Verificación datos de usuario")]
        public void WhenDoyClickEnElTabVerificacionDatosDeUsuario()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabAssistMeVerifyUserAssistMe);
        }

        [When(@"Doy click en el Tab Vinculación")]
        public void WhenDoyClickEnElTabVinculacion()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabGeneralEnrollment);
        }

        [When(@"Pulso Guardar plantilla de ANS's")]
        public void WhenPulsoGuardarPlantillaDeANSS()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.SaveTemplateSLA);
        }

        [When(@"Pulso Guardar plantilla de AssistMe")]
        public void WhenPulsoGuardarPlantillaDeAssistMe()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.SaveTemplateAssistMe);
        }

        [When(@"Pulso Guardar plantilla de encuestas")]
        public void WhenPulsoGuardarPlantillaDeEncuestas()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.SaveTemplateSurvey);
        }

        [When(@"Pulso Guardar plantilla de OLA's")]
        public void WhenPulsoGuardarPlantillaDeOLAS()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.SaveTemplateOLA);
        }

        [When(@"Pulso Guardar plantilla de UC's")]
        public void WhenPulsoGuardarPlantillaDeUCS()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.SaveTemplateUC);
        }

        [When(@"Pulso Guardar plantilla general")]
        public void WhenPulsoGuardarPlantillaGeneral()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.SaveTemplateGeneral);
        }

        [When(@"Selecciono la opción plantillas de ANS's")]
        public void WhenSeleccionoLaOpcionPlantillasDeANSS()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.EmailTemplateModulePath);
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.SLAEmailTemplateOption);
        }

        [When(@"Selecciono la opción plantillas de AssistMe")]
        public void WhenSeleccionoLaOpcionPlantillasDeAssistMe()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.EmailTemplateModulePath);

            Thread.Sleep(1000);

            IWebElement ScrollConfiguracionMenu = CommonHooks.driver.FindElement(By.XPath("//div[@id='mCSB_1_dragger_vertical']/div"));

            Actions ScrollDown = new Actions(CommonHooks.driver);
            ScrollDown.MoveToElement(ScrollConfiguracionMenu);
            ScrollDown.DragAndDropToOffset(ScrollConfiguracionMenu, 0, 200);
            ScrollDown.Build().Perform();

            Thread.Sleep(1000);

            CommonElementsAction.Click("XPath", ConfigurationMenuPage.AssistMeEmailTemplateOption);
        }

        [When(@"Selecciono la opción plantillas de encuestas")]
        public void WhenSeleccionoLaOpcionPlantillasDeEncuestas()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.EmailTemplateModulePath);
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.SurveysEmailTemplateOption);
        }

        [When(@"Selecciono la opción plantillas de OLA's")]
        public void WhenSeleccionoLaOpcionPlantillasDeOLAS()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.EmailTemplateModulePath);

            Thread.Sleep(1000);

            IWebElement ScrollConfiguracionMenu = CommonHooks.driver.FindElement(By.XPath("//div[@id='mCSB_1_dragger_vertical']/div"));

            Actions ScrollDown = new Actions(CommonHooks.driver);
            ScrollDown.MoveToElement(ScrollConfiguracionMenu);
            ScrollDown.DragAndDropToOffset(ScrollConfiguracionMenu, 0, 200);
            ScrollDown.Build().Perform();

            Thread.Sleep(1000);

            CommonElementsAction.Click("XPath", ConfigurationMenuPage.OLAEmailTemplateOption);
        }

        [When(@"Selecciono la opción plantillas de UC's")]
        public void WhenSeleccionoLaOpcionPlantillasDeUCS()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.EmailTemplateModulePath);

            Thread.Sleep(1000);

            IWebElement ScrollConfiguracionMenu = CommonHooks.driver.FindElement(By.XPath("//div[@id='mCSB_1_dragger_vertical']/div"));

            Actions ScrollDown = new Actions(CommonHooks.driver);
            ScrollDown.MoveToElement(ScrollConfiguracionMenu);
            ScrollDown.DragAndDropToOffset(ScrollConfiguracionMenu, 0, 200);
            ScrollDown.Build().Perform();

            Thread.Sleep(1000);

            CommonElementsAction.Click("XPath", ConfigurationMenuPage.UCEmailTemplateOption);
        }

        [When(@"Selecciono la opción plantillas generales")]
        public void WhenSeleccionoLaOpcionPlantillasGenerales()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.EmailTemplateModulePath);
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.GeneralEmailTemplateOption);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Alerta de Nivel de satisfacción")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeAlertaDeNivelDeSatisfaccion()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionSurveySatisAlert, EmailTemplatesPage.ListSurveySatisAlert);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddSurveySatisAlert);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de asignación")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeAsignacion()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionGeneralAssigment, EmailTemplatesPage.ListGeneralAssigment);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddGeneralAssigment);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de cambio de especialista")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeCambioDeEspecialista()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionGeneralChangeOfSpecialist, EmailTemplatesPage.ListGeneralChangeOfSpecialist);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddGeneralChangeOfSpecialist);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de cancelación")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeCancelacion()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionGeneralCancellation, EmailTemplatesPage.ListGeneralCancellation);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddGeneralCancellation);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de ejecutada")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeEjecutada()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionGeneralExecuted, EmailTemplatesPage.ListGeneralExecuted);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddGeneralExecuted);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Finalización de ANS")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeFinalizacionDeANS()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionSLAEnding, EmailTemplatesPage.ListSLAEnding);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddSLAEnding);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Finalización de OLA")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeFinalizacionDeOLA()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionOLAEnding, EmailTemplatesPage.ListOLAEnding);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddOLAEnding);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Finalización de UC")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeFinalizacionDeUC()
        {
            CommonElementsAction.Click("XPath", EmailTemplatesPage.TabUCEnding);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.SaveTemplateUC);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Notificación de cuenta de usuarios Assistme")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeNotificacionDeCuentaDeUsuariosAssistme()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionAssistMeNotifyUserAssistMe, EmailTemplatesPage.ListAssistMeNotifyUserAssistMe);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddAssistMeNotifyUserAssistMe);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Notificación de medición de encuesta")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeNotificacionDeMedicionDeEncuesta()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionSurveyNotifySurvey, EmailTemplatesPage.ListSurveyNotifySurvey);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddSurveyNotifySurvey);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Notificación de resumen de encuesta")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeNotificacionDeResumenDeEncuesta()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionSurveySummarySurvey, EmailTemplatesPage.ListSurveySummarySurvey);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddSurveySummarySurvey);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Notificación orden registrada desde Assistme")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeNotificacionOrdenRegistradaDesdeAssistme()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionAssistMeNotifyOrderAssistMe, EmailTemplatesPage.ListAssistMeNotifyOrderAssistMe);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddAssistMeNotifyOrderAssistMe);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de plantillas de UC")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDePlantillasDeUC()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionUCEnding, EmailTemplatesPage.ListUCEnding);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddUCEnding);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de proveedores")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeProveedores()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionGeneralProviders, EmailTemplatesPage.ListGeneralProviders);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddGeneralProviders);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de registro")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeRegistro()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionGeneralRecord, EmailTemplatesPage.ListGeneralRecord);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddGeneralRecord);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de retraso")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeRetraso()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionGeneralDelay, EmailTemplatesPage.ListGeneralDelay);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddGeneralDelay);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Revisión de ANS")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeRevisionDeANS()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionSLAReview, EmailTemplatesPage.ListSLAReview);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddSLAReview);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Revisión de OLA")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeRevisionDeOLA()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionOLAReview, EmailTemplatesPage.ListOLAReview);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddOLAReview);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Revisión de UC")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeRevisionDeUC()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionUCReview, EmailTemplatesPage.ListUCReview);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddUCReview);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de satisfacción al cliente")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeSatisfaccionAlCliente()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionSurveySatisSurvey, EmailTemplatesPage.ListSurveySatisSurvey);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddSurveySatisSurvey);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de Verificación datos de usuario")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeVerificacionDatosDeUsuario()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionAssistMeVerifyUserAssistMe, EmailTemplatesPage.ListAssistMeVerifyUserAssistMe);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddAssistMeNVerifyUserAssistMe);
        }

        [When(@"Selecciono y agrego una etiqueta a la plantilla de vinculación")]
        public void WhenSeleccionoYAgregoUnaEtiquetaALaPlantillaDeVinculacion()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", EmailTemplatesPage.OptionGeneralEnrollment, EmailTemplatesPage.ListGeneralEnrollment);
            CommonElementsAction.Click("XPath", EmailTemplatesPage.ButtonAddGeneralEnrollment);
        }
    }
}