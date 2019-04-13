using System;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Integration
{
    [Binding]
    public class ASDKSteps
    {
        [When(@"Configuración exitosa de Mesa de servicio ASDK con fuente Clientes")]
        public void WhenConfiguracionExitosaDeMesaDeServicioASDKConFuenteClientes()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Configuración exitosa de Mesa de servicio ASDK con fuente Compañías")]
        public void WhenConfiguracionExitosaDeMesaDeServicioASDKConFuenteCompanias()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
