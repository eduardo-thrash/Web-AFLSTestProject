using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration;
using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class EmailTemplatesSteps
    {
        
        
        private readonly EmailTemplatesPage EmailTemplatesPage = new EmailTemplatesPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Configuración exitosa de plantilla de correo Registro")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoRegistro()
        {
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Registro"

            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabGeneralRecord);

            ///     And Selecciono la etiqueta Cliente

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionGeneralRecord,"Cliente","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddGeneralRecord);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateGeneral);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Asignación")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoAsignacion()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Asignación"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabGeneralAssigment);

            ///     And Selecciono la etiqueta Cliente

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionGeneralAssigment,"Cliente","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddGeneralAssigment);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateGeneral);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Retraso")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoRetraso()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Asignación"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabGeneralDelay);

            ///     And Selecciono la etiqueta Cliente

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionGeneralDelay,"Cliente","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddGeneralDelay);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateGeneral);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Cambio de especialista")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoCambioDeEspecialista()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Cambio de especialista"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabGeneralChangeOfSpecialist);

            ///     And Selecciono la etiqueta Cliente CommonElementsAction.Click("XPath",EmailTemplatesPage.ListGeneralChangeOfSpecialist,"List Specialist change");
            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionGeneralChangeOfSpecialist,"Cliente","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddGeneralChangeOfSpecialist);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateGeneral);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Cancelación")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoCancelacion()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Cancelación"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabGeneralCancellation);

            ///     And Selecciono la etiqueta Cliente

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionGeneralCancellation,"Cliente","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddGeneralCancellation);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateGeneral);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Ejecutada")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoEjecutada()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            
            ///     And pulso el tab "Ejecutada"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabGeneralExecuted);

            ///     And Selecciono la etiqueta Cliente
            ;
            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionGeneralExecuted,"Cliente","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddGeneralExecuted);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateGeneral);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Vinculación")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoVinculacion()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            
            ///     And pulso el tab "Vinculación"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabGeneralEnrollment);

            ///     And Selecciono la etiqueta Cliente

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionGeneralEnrollment,"Dominio","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddGeneralEnrollment);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateGeneral);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Proveedores")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoProveedores()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            
            ///     And pulso el tab "Proveedores"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabGeneralProviders);

            ///     And Selecciono la etiqueta Cliente

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionGeneralProviders,"Cliente","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddGeneralProviders);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateGeneral);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Encuesta de satisfacción al Cliente")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoEncuestaDeSatisfaccionAlCliente()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Encuesta de satisfacción al Cliente"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabSurveySatisSurvey);

            ///     And Selecciono la etiqueta "Enlace de la encuesta"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionSurveySatisSurvey,"cliente","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddSurveySatisSurvey);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateSurvey);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Alerta de Nivel de satisfacción")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoAlertaDeNivelDeSatisfaccion()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Configuración exitosa de plantilla de correo Alerta de Nivel de satisfacción"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabSurveySatisAlert);

            ///     And Selecciono la etiqueta "Enlace de la encuesta"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionSurveySatisAlert,"Enlace de la encuesta","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddSurveySatisAlert);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateSurvey);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Notificación de medición de encuesta")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoNotificacionDeMedicionDeEncuesta()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            
            ///     And pulso el tab "Notificación de medición de encuesta"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabSurveyNotifySurvey);

            ///     And Selecciono la etiqueta "Resultado de la encuesta"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionSurveyNotifySurvey,"Resultado de la encuesta","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddSurveyNotifySurvey);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateSurvey);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de correo Notificación de resumen de encuesta")]
        public void WhenConfiguracionExitosaDePlantillaDeCorreoNotificacionDeResumenDeEncuesta()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            
            ///     And pulso el tab "Notificación de resumen de encuesta"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabSurveySummarySurvey);

            ///     And Selecciono la etiqueta "Asunto de la orden de trabajo"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionSurveySummarySurvey,"Asunto de la orden de trabajo","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddSurveySummarySurvey);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateSurvey);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de ANS de correo Revisión")]
        public void WhenConfiguracionExitosaDePlantillaDeANSDeCorreoRevision()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Revisión"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabSLAReview);

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionSLAReview,"Nombre del administrador","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddSLAReview);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateSLA);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de ANS de correo Finalización")]
        public void WhenConfiguracionExitosaDePlantillaDeANSDeCorreoFinalizacion()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Finalización"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabSLAEnding);

            ///     And Selecciono la etiqueta "Nombre del administrador"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionSLAEnding,"Nombre del administrador","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddSLAEnding);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateSLA);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de UC de correo Revisión")]
        public void WhenConfiguracionExitosaDePlantillaDeUCDeCorreoRevision()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Revisión"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabUCReview);

            ///     And Selecciono la etiqueta "Fecha de revisión del UC"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionUCReview,"Fecha de revisión del UC","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddUCReview);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateUC);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de UC de correo Finalización")]
        public void WhenConfiguracionExitosaDePlantillaDeUCDeCorreoFinalizacion()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And pulso el tab "Finalización"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabUCEnding);

            ///     And Selecciono la etiqueta "Fecha de finalización del UC"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionUCEnding,"Fecha de finalización del UC","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddUCEnding);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateUC);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de OLA de correo Revisión")]
        public void WhenConfiguracionExitosaDePlantillaDeOLADeCorreoRevision()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.OLAEmailTemplateOption,EmailTemplatesPage.EmailTemplateModulePath);

            ///     And pulso el tab "Revisión"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabOLAReview);

            ///     And Selecciono la etiqueta "Nombre del OLA"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionOLAReview,"Nombre del OLA","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddOLAReview);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateOLA);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla de OLA de correo Finalización")]
        public void WhenConfiguracionExitosaDePlantillaDeOLADeCorreoFinalizacion()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.OLAEmailTemplateOption,EmailTemplatesPage.EmailTemplateModulePath);
            ///     And pulso el tab "Finalización"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabOLAEnding);

            ///     And Selecciono la etiqueta "Nombre del OLA"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionOLAEnding,"Nombre del OLA","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddOLAEnding);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateOLA);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla AssistMe de correo Notificación de cuenta de usuarios Assistme")]
        public void WhenConfiguracionExitosaDePlantillaAssistMeDeCorreoNotificacionDeCuentaDeUsuariosAssistme()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.AssistMeEmailTemplateOption,EmailTemplatesPage.EmailTemplateModulePath);

            ///     And selecciono el tab "Notificación orden registrada desde Assistme"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabAssistMeNotifyUserAssistMe);

            ///     And Selecciono la etiqueta "Descripción"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionAssistMeNotifyUserAssistMe,"Usuario","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddAssistMeNotifyUserAssistMe);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateAssistMe);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla AssistMe de correo Notificación orden registrada desde Assistme")]
        public void WhenConfiguracionExitosaDePlantillaAssistMeDeCorreoNotificacionOrdenRegistradaDesdeAssistme()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.AssistMeEmailTemplateOption,EmailTemplatesPage.EmailTemplateModulePath);
            ///     And selecciono el tab "Notificación orden registrada desde Assistme"
            CommonElementsAction.Click("XPath",EmailTemplatesPage.TabAssistMeNotifyOrderAssistMe);

            ///     And Selecciono la etiqueta "Descripción"

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",EmailTemplatesPage.OptionAssistMeNotifyOrderAssistMe,"Descripción","label");

            ///     And pulso el botón Agregar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.ButtonAddAssistMeNotifyOrderAssistMe);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",EmailTemplatesPage.SaveTemplateAssistMe);

            ///     Then se muestra un mensaje indicando que se guardo la configuración exitosamente.
            //LogOut.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de plantilla AssistMe de correo Verificación datos de usuario")]
        public void WhenConfiguracionExitosaDePlantillaAssistMeDeCorreoVerificacionDatosDeUsuario()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar plantillas de correo
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.AssistMeEmailTemplateOption,EmailTemplatesPage.EmailTemplateModulePath);
        }
    }
}