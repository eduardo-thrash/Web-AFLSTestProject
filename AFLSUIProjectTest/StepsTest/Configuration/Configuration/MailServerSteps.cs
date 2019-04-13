using System;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class MailServerSteps
    {
        [When(@"Configuración exitosa de servidor de correo")]
        public void WhenConfiguracionExitosaDeServidorDeCorreo()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
