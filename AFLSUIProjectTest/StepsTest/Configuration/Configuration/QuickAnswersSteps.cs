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
        public void WhenCreacionFallidaDeRespuestasrápidasConNombreRepetido()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Cancelación exitosa de creación de respuestas rápidas")]
        public void WhenCancelacionExitosaDeCreacionDeRespuestasrápidas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Modificación exitosa de respuestas rápidas")]
        public void WhenModificacionExitosaDeRespuestasrápidas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Modificación fallida de respuestas rápidas dejando nombre o descripción vacíos")]
        public void WhenModificacionFallidaDeRespuestasrápidasDejandoNombreODescripcionVacios()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Inactivación exitosa de respuestas rápidas")]
        public void WhenInactivacionExitosaDeRespuestasrápidas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Eliminación exitosa de respuestas rápidas")]
        public void WhenEliminacionExitosaDeRespuestasrápidas()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
