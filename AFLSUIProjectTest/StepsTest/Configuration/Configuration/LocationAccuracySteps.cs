using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class LocationAccuracySteps
    {
        


        private readonly ElementsAccuracy ElementsAccuracy = new ElementsAccuracy();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Configuración exitosa de precisión de ubicación alta")]
        public void WhenConfiguracionExitosaDePrecisionDeUbicacionAlta()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar reglas de asignación
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And selecciono la opción "Precisión alta"
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",ElementsAccuracy.HighAccuracy);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",ElementsAccuracy.AccuracySave);

            

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de precisión de ubicación media")]
        public void WhenConfiguracionExitosaDePrecisionDeUbicacionMedia()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar reglas de asignación
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And selecciono la opción "Precisión media"
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",ElementsAccuracy.AverageAccuracy);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",ElementsAccuracy.AccuracySave);

            

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Configuración exitosa de precisión de ubicación baja")]
        public void WhenConfiguracionExitosaDePrecisionDeUbicacionBaja()
        {
            ///     Given tengo un usuario con rol administrador
            ///     And Quiero configurar reglas de asignación
            ///     When realizo login en la aplicación
            

            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General
            

            ///     And selecciono la opción "Precisión baja"
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",ElementsAccuracy.LowAccuracy);

            ///     And pulso el botón Guardar
            CommonElementsAction.Click("XPath",ElementsAccuracy.AccuracySave);

            

            //LogOut.
            
            //End LogOut.
        }
    }
}