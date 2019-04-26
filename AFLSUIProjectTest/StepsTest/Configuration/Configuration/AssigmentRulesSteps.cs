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

        [When(@"pulso el tab ""(.*)""")]
        public void WhenPulsoElTab(string p0)
        {
            ///     When pulso el tab "Variables del negocio"
            CommonElementsAction.Click("XPath", AssignmentRulesPage.TabAssigmentRulesBussinessRules);
        }

        [When(@"aumento estrellas \((.*)\) a la variable Costo")]
        public void WhenAumentoEstrellasALaVariableCosto(int p0)
        {
            ///     And aumento estrellas (1) a la variable Costo
            CommonElementsAction.Click("XPath", AssignmentRulesPage.CostUp);
        }

        [When(@"aumento estrellas \((.*)\) a la variable Distancia")]
        public void WhenAumentoEstrellasALaVariableDistancia(int p0)
        {
            ///     And aumento estrellas (1) a la variable Distancia
            CommonElementsAction.Click("XPath", AssignmentRulesPage.DistanceUp);
        }

        [When(@"aumento estrellas \((.*)\) a la variable Habilidades")]
        public void WhenAumentoEstrellasALaVariableHabilidades(int p0)
        {
            ///     And aumento estrellas (1) a la variable Habilidades
            CommonElementsAction.Click("XPath", AssignmentRulesPage.SkillUp);
        }

        [When(@"aumento estrellas \((.*)\) a la variable ANS")]
        public void WhenAumentoEstrellasALaVariableANS(int p0)
        {
            ///     And aumento estrellas (1) a la variable ANS
            CommonElementsAction.Click("XPath", AssignmentRulesPage.SLAUp);
        }

        [When(@"aumento estrellas \((.*)\) a la variable Distribución de carga")]
        public void WhenAumentoEstrellasALaVariableDistribucionDeCarga(int p0)
        {
            ///     And aumento estrellas (1) a la variable Distribución de carga
            CommonElementsAction.Click("XPath", AssignmentRulesPage.DistributionUp);
        }

        [When(@"modifico datos en el campo cantidad de procesos")]
        public void WhenModificoDatosEnElCampoCantidadDeProcesos()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"modifico datos en el campo Uso máximo de CPU")]
        public void WhenModificoDatosEnElCampoUsoMaximoDeCPU()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"pulso en el tab ""(.*)""")]
        public void WhenPulsoEnElTab(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono la opción Rango de tiempo")]
        public void WhenSeleccionoLaOpcionRangoDeTiempo()
        {
            ///     And Selecciono la opción Rango de tiempo
            CommonElementsAction.Click("XPath", AssignmentRulesPage.RadioButtonTimeRange);
        }

        [When(@"pulso en el tab Rango de tiempo")]
        public void WhenPulsoEnElTabRangoDeTiempo()
        {
            ///     And pulso en el tab "Rango de tiempo"
            CommonElementsAction.Click("XPath", AssignmentRulesPage.TabAssigmentRulesTimeRange);
        }

        [When(@"pulso en el tab Proveedores")]
        public void WhenPulsoEnElTabProveedores()
        {
            ///     And pulso en el tab "Proveedores"
            CommonElementsAction.Click("XPath", AssignmentRulesPage.TabAssigmentRulesProviders);
        }

        [When(@"selecciono la opción Asignar al proveedor con menos carga de trabajo por servicio")]
        public void WhenSeleccionoLaOpcionAsignarAlProveedorConMenosCargaDeTrabajoPorServicio()
        {
            ///     And selecciono la opción Asignar al proveedor con menos carga de trabajo por servicio
            CommonElementsAction.Click("XPath", AssignmentRulesPage.RadioButtonlessWorkLoad);
        }

        [When(@"modifico los datos del campo Tiempo máximo para asignación de proveedor")]
        public void WhenModificoLosDatosDelCampoTiempoMaximoParaAsignacionDeProveedor()
        {
            //     And and modifico los datos del campo Tiempo máximo para asignación de proveedor
            CommonElementsAction.SendKeys_InputText("Name", AssignmentRulesPage.ResponseTime, "10");
        }

        [When(@"adiciono puntare \((.*)\) a la variable Calificación")]
        public void WhenAdicionoPuntareALaVariableCalificacion(int p0)
        {
            ///     And adiciono puntaje (1) a la variable Calificación
            CommonElementsAction.Click("XPath", AssignmentRulesPage.QualificationUp);
        }

        [When(@"adiciono puntare \((.*)\) a la variable Cumplimiento")]
        public void WhenAdicionoPuntareALaVariableCumplimiento(int p0)
        {
            //     And adiciono puntaje (1) a la variable Cumplimiento
            CommonElementsAction.Click("XPath", AssignmentRulesPage.FulfillmentUp);
        }

        [When(@"adiciono puntare \((.*)\) a la variable Respuesta")]
        public void WhenAdicionoPuntareALaVariableRespuesta(int p0)
        {
            ///     And adiciono puntaje (1) a la variable Respuesta
            CommonElementsAction.Click("XPath", AssignmentRulesPage.AnswerUp);
        }

        [When(@"Configuración exitosa de reglas de asignación")]
        public void WhenConfiguracionExitosaDeReglasDeAsignacion()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar reglas de asignación
            ///     When realizo login en la aplicación

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General

            ///     And modifico datos en el campo cantidad de procesos
            ///     And modifico datos en el campo Uso maximo de CPU

            //LogOut.

            //End LogOut.
        }
    }
}