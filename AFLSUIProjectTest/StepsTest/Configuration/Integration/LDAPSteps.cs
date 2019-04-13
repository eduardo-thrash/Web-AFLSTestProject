using System;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Integration
{
    [Binding]
    public class LDAPSteps
    {
        [When(@"Configuración exitosa de integración LDAP")]
        public void WhenConfiguracionExitosaDeIntegracionLDAP()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
