using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration;
using AFLSUIProjectTest.UIMap.Messages;

using CommonTest.CommonTest;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class AssistMeBasicConfigurationSteps
    {
        
        
        private readonly ElementsAssistMe ElementsAssistMe = new ElementsAssistMe();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Configuración exitosa de AssistMe")]
        public void WhenConfiguracionExitosaDeAssistMe()
        {
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
           // CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.AssistMeOption,"//a[contains(@href, '#admin/channels/assistme')]");

            ///     And Activo el switch de estado
            CommonElementsAction.Click("XPath",ElementsAssistMe.AssistMeSwitchState);

            ///     And ingreso datos en la URL de conexión
            CommonElementsAction.SendKeys_InputText("Id",ElementsAssistMe.AssistMeInputURL,"http://192.168.1.114/AssistMe");

            ///     And ingreso datos en la URL de About
            CommonElementsAction.SendKeys_InputText("Id",ElementsAssistMe.AssistMeInputAboutUsURL,"http://xdeamx.com");

            ///     And ingreso datos en el campo de mensaje de bienvenida
            CommonElementsAction.SendKeys_InputText("Id",ElementsAssistMe.AssistMeInputWelcomeMessage,"Bienveido a AssistMe");

            ///     And ingreso datos en el campo de nombe de especialista para AssistMe
            CommonElementsAction.SendKeys_InputText("Id",ElementsAssistMe.AssistMeInputAttendant,"Agente de campo");

            ///     And ingreso datos en el campo de nombre de servicios para AssistMe
            CommonElementsAction.SendKeys_InputText("Id",ElementsAssistMe.AssistMeInputNeeded,"Orden de trabajo");

            ///     And pulso el botón guardar
            CommonElementsAction.Click("XPath",ElementsAssistMe.AssistMeButtonSave);

            

            //LogOut.
            
            //End LogOut.
        }
    }
}