using System;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Inventory
{
    [Binding]
    public class LocationsSteps
    {
        [When(@"Creación exitosa de ubicaciones")]
        public void WhenCreacionExitosaDeUbicaciones()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Búsqueda exitosa de Ubicación existente")]
        public void WhenBusquedaExitosaDeUbicacionExistente()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Modificación exitosa de Ubicación")]
        public void WhenModificacionExitosaDeUbicacion()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Borrado exitoso de Ubicación existente")]
        public void WhenBorradoExitosoDeUbicacionExistente()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
