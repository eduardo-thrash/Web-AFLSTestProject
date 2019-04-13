using System;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class QuickAnswersSteps
    {
        [When(@"Creación exitosa de respuesta rápida")]
        public void WhenCreacionExitosaDeRespuestaRapida()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Creación fallida de respuestas rápidas con nombre repetido")]
        public void WhenCreacionFallidaDeRespuestasRapidasConNombreRepetido()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Cancelación exitosa de creación de respuestas rápidas")]
        public void WhenCancelacionExitosaDeCreacionDeRespuestasRapidas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Modificación exitosa de respuestas rápidas")]
        public void WhenModificacionExitosaDeRespuestasRapidas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Modificación fallida de respuestas rápidas dejando nombre o descripción vacios")]
        public void WhenModificacionFallidaDeRespuestasRapidasDejandoNombreODescripcionVacios()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Inactivación exitosa de respuestas rápidas")]
        public void WhenInactivacionExitosaDeRespuestasRapidas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Eliminación exitosa de respuestas rápidas")]
        public void WhenEliminacionExitosaDeRespuestasRapidas()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
