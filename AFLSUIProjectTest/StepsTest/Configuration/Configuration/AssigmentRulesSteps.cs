using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class AssigmentRulesSteps
    {
        
        
        private readonly AssignmentRulesPage AssignmentRulesPage = new AssignmentRulesPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Configuración exitosa de reglas de asignación")]
        public void WhenConfiguracionExitosaDeReglasDeAsignacion()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar reglas de asignación
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     When pulso el tab "Variables del negocio"
            CommonElementsAction.Click("XPath",AssignmentRulesPage.TabAssigmentRulesBussinessRules);

            ///     And aumento estrellas (1) a la variable Costo
            CommonElementsAction.Click("XPath",AssignmentRulesPage.CostUp);

            ///     And aumento estrellas (1) a la variable Distancia
            CommonElementsAction.Click("XPath",AssignmentRulesPage.DistanceUp);

            ///     And aumento estrellas (1) a la variable Habilidades
            CommonElementsAction.Click("XPath",AssignmentRulesPage.SkillUp);

            ///     And aumento estrellas (1) a la variable ANS
            CommonElementsAction.Click("XPath",AssignmentRulesPage.SLAUp);

            ///     And aumento estrellas (1) a la variable Distribución de carga
            CommonElementsAction.Click("XPath",AssignmentRulesPage.DistributionUp);

            ///     And modifico datos en el campo cantidad de procesos
            ///     And modifico datos en el campo Uso maximo de CPU
            ///     And pulso en el tab "Rango de tiempo"
            CommonElementsAction.Click("XPath",AssignmentRulesPage.TabAssigmentRulesTimeRange);

            ///     And Selecciono la opción Rango de tiempo
            CommonElementsAction.Click("XPath",AssignmentRulesPage.RadioButtonTimeRange);

            ///     And pulso en el tab "Proveedores"
            CommonElementsAction.Click("XPath",AssignmentRulesPage.TabAssigmentRulesProviders);

            ///     And selecciono la opción Asignar al proveedor con menos carga de trabajo por servicio
            CommonElementsAction.Click("XPath",AssignmentRulesPage.RadioButtonlessWorkLoad);

            ///     And and modifico los datos del campo Tiempo máximo para asignación de proveedor
            CommonElementsAction.SendKeys_InputText("Name",AssignmentRulesPage.ResponseTime,"10");

            ///     And adiciono puntaje (1) a la variable Calificación
            CommonElementsAction.Click("XPath",AssignmentRulesPage.QualificationUp);

            ///     And adiciono puntaje (1) a la variable Cumplimiento
            CommonElementsAction.Click("XPath",AssignmentRulesPage.FulfillmentUp);

            ///     And adiciono puntaje (1) a la variable Respuesta
            CommonElementsAction.Click("XPath",AssignmentRulesPage.AnswerUp);

            CommonElementsAction.Click("XPath",AssignmentRulesPage.AssigmentRulesSave);

            

            //LogOut.
            
            //End LogOut.
        }
    }
}