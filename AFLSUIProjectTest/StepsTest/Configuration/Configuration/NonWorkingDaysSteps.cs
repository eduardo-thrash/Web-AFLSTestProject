using System;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class NonWorkingDaysSteps
    {
        [When(@"Adición exitosa de día no laboral")]
        public void WhenAdicionExitosaDeDiaNoLaboral()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
