using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.AFLS
{
    [Binding]
    public sealed class AFLSCommonSteps
    {
        [Then(@"Finaliza exitosa la prueba")]
        public void ThenFinalizaExitosaLaPrueba()
        {
            ScenarioContext.Current.Pending();
        }
    }
}