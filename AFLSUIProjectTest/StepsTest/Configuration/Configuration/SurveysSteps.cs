using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class SurveysSteps
    {
        [When(@"Configuración completa exitosa de encuestas")]
        public void WhenConfiguracionCompletaExitosaDeEncuestas()
        {
            ScenarioContext.Current.Pending();
        }
    }
}