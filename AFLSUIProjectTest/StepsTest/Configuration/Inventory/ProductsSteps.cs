using System;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Inventory
{
    [Binding]
    public class ProductsSteps
    {
        [When(@"Creación exitosa de productos")]
        public void WhenCreacionExitosaDeProductos()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Busqueda exitosa de un producto existente")]
        public void WhenBusquedaExitosaDeUnProductoExistente()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Modificación exitosa de un producto")]
        public void WhenModificacionExitosaDeUnProducto()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Borrado exitoso de producto existente")]
        public void WhenBorradoExitosoDeProductoExistente()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
