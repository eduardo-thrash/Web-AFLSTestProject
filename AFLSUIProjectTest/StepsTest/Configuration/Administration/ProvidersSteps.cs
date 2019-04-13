
using AFLSUIProjectTest.UIMap.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using AFLSUIProjectTest.StepsTest.AFLS;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class ProvidersSteps
    {
        
        
        private readonly ElementsProvider ElementsProvider = new ElementsProvider();
        private readonly PageMessages PageMessages = new PageMessages();
        LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();


        [When(@"Creacion exitosa completa de proveedores asociando servicio, zona y monitor")]
        public void WhenCreacionExitosaCompletaDeProveedoresAsociandoServicioZonaYMonitor()
        {
            LoginLogoutSteps.WhenRealizoLoginConUsuarioRolAdministrador();

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Medellin Urbano Create");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion");

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderCheckExtern);

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderCheckAssignManual);

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderRadioMediumPriority);

            ///     And accedo al tab Servicios y asocio un servicio
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabServices);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",ElementsProvider.ProviderServices,"Servicio Auditoria WT","a");
            ;

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",ElementsProvider.ProviderServiceAgreement,"ANS General","label");

            ///     And accedo al tab Zonas y asocio una Zona
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabZones);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",ElementsProvider.ProviderZoneList,"Bogot","a");

            ///     And accedo al tab Especialistas
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabSpecialist);

            ///     And accedo al tab Monitores y asocio un monitor
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabMonitors);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",ElementsProvider.ProviderMonitors,"Monit","a");

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creacion exitosa basica de proveedores")]
        public void WhenCreacionExitosaBasicaDeProveedores()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Bucaramanga Urbano Create");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion");

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creacion exitosa de proveedor de prioridad media")]
        public void WhenCreacionExitosaDeProveedorDePrioridadMedia()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Popayan General medium Create");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion provider");

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderRadioMediumPriority);

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creacion exitosa de proveedor de prioridad alta")]
        public void WhenCreacionExitosaDeProveedorDePrioridadAlta()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Santa Marta General High Create");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion provider");

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderRadioHighPriority);

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creacion exitosa de proveedor de prioridad baja")]
        public void WhenCreacionExitosaDeProveedorDePrioridadBaja()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Neiva General Low Createe");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion provider");

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderRadioLowPriority);

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creacion exitosa de proveedor externo")]
        public void WhenCreacionExitosaDeProveedorExterno()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Neiva General Extern Createe");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion provider");

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderCheckExtern);

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creacion exitosa de proveedor interno")]
        public void WhenCreacionExitosaDeProveedorInterno()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Neiva General Intern Createe");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion provider");

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderCheckIntern);

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creacion exitosa de proveedor con asignación manual")]
        public void WhenCreacionExitosaDeProveedorConAsignacionManual()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Neiva General Manual Createe");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion provider");

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderCheckAssignManual);

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.;
        }

        [When(@"Creacion exitosa de proveedor con asignación automatica")]
        public void WhenCreacionExitosaDeProveedorConAsignacionAutomatica()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Neiva General Best Createe");

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion provider");

            CommonElementsAction.Click("XPath",ElementsProvider.ProviderCheckAssignBest);

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.;
        }

        [When(@"Creacion fallida de proveedor sin nombre")]
        public void WhenCreacionFallidaDeProveedorSinNombre()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderDescription,"Descripcion provider");

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut;
        }

        [When(@"Creacion fallida de proveedor sin descripción")]
        public void WhenCreacionFallidaDeProveedorSinDescripcion()
        {
            

            

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonNew);

            ///     And diligencio los datos del tab Proveedores
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.SendKeys_InputText("XPath",ElementsProvider.ProviderName,"UI-Prov Yopal General Create");

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.;
        }

        [When(@"Modificacion exitosa de proveedor cambiando nombre")]
        public void WhenModificacionExitosaDeProveedorCambiandoNombre()
        {
            

            

            // Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsProvider.ProviderFieldSearch,"Especialistas Bogota Sur General WT");
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderView);

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            CommonElementsAction.ClearAndSendKeys_InputText("XPath",ElementsProvider.ProviderName,"Especialistas Bogota Sur Updaate");

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsProvider.ProviderFieldSearch,"Especialistas Bogota Sur Updaate");
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsProvider.ProviderName)).GetAttribute("value");
            Assert.AreEqual("Especialistas Bogota Sur Updaate",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificacion exitosa de proveedor cambiando prioridad")]
        public void WhenModificacionExitosaDeProveedorCambiandoPrioridad()
        {
            

            

            // Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsProvider.ProviderFieldSearch,"Proveedor interno M alto");
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderView);

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            ///     And modifico la prioridad
            Thread.Sleep(3000);
            int LastPriority = 0;
            int NewPriority = 0;

            if(CommonHooks.driver.FindElement(By.XPath("//*[@id='highImportance']")).Selected)
            {
                LastPriority = 3;
                CommonElementsAction.Click("XPath",ElementsProvider.ProviderRadioMediumPriority);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath",ElementsProvider.ProviderName,"Especialistas Bogota Medium Sur Updaate");
            }
            else if(CommonHooks.driver.FindElement(By.XPath("//*[@id='mediumImportance']")).Selected)
            {
                LastPriority = 2;
                CommonElementsAction.Click("XPath",ElementsProvider.ProviderRadioLowPriority);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath",ElementsProvider.ProviderName,"Especialistas Bogota Sur Low Updaate");
            }
            else if(CommonHooks.driver.FindElement(By.XPath("//*[@id='lowImportance']")).Selected)
            {
                LastPriority = 1;
                CommonElementsAction.Click("XPath",ElementsProvider.ProviderRadioHighPriority);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath",ElementsProvider.ProviderName,"Especialistas Bogota Sur High Updaate");
            }

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            Thread.Sleep(3000);

            if(CommonHooks.driver.FindElement(By.XPath("//*[@id='highImportance']")).Selected)
            {
                NewPriority = 3;
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(LastPriority,NewPriority);
            }
            else if(CommonHooks.driver.FindElement(By.XPath("//*[@id='mediumImportance']")).Selected)
            {
                NewPriority = 2;
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(LastPriority,NewPriority);
            }
            else if(CommonHooks.driver.FindElement(By.XPath("//*[@id='lowImportance']")).Selected)
            {
                NewPriority = 1;
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(LastPriority,NewPriority);
            }

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificacion exitosa de proveedor cambiando asignación")]
        public void WhenModificacionExitosaDeProveedorCambiandoAsignacion()
        {
            

            

            // Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsProvider.ProviderFieldSearch,"Proveedor interno B Medio");
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderView);

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderTabProviders);

            ///     And modifico el tipo de asignaciòn
            string LastAssigment = "";
            string NewAssigment = "";

            if(CommonHooks.driver.FindElement(By.XPath("//*[@id='AssignBest']")).Selected)
            {
                LastAssigment = "Automatic";
                CommonElementsAction.Click("XPath",ElementsProvider.ProviderCheckAssignManual);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath",ElementsProvider.ProviderName,"Proveedor interno Manual Medio Update");
            }
            else if(CommonHooks.driver.FindElement(By.XPath("//*[@id='AssignManual']")).Selected)
            {
                LastAssigment = "Manual";
                CommonElementsAction.Click("XPath",ElementsProvider.ProviderCheckAssignBest);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath",ElementsProvider.ProviderName,"Proveedor interno Best Medio Update");
            }

            //Save
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            Thread.Sleep(3000);

            if(CommonHooks.driver.FindElement(By.XPath("//*[@id='AssignBest']")).Selected)
            {
                NewAssigment = "Automatic";
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(LastAssigment,NewAssigment);
            }

            if(CommonHooks.driver.FindElement(By.XPath("//*[@id='AssignManual']")).Selected)
            {
                NewAssigment = "Manual";
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(LastAssigment,NewAssigment);
            }

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Consulta exitosa de proveedor por nombre")]
        public void WhenConsultaExitosaDeProveedorPorNombre()
        {
            

            

            // Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsProvider.ProviderFieldSearch,"Especialistas Bogota Sur General WT");
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsProvider.ProviderName)).GetAttribute("value");
            Assert.AreEqual("Especialistas Bogota Sur General WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de proveedor")]
        public void WhenBorradoExitosoDeProveedor()
        {
            

            

            // Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ElementsProvider.ProviderFieldSearch,"Especialistas Bogota Oriente General WT");
            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderButtonSearch);

            CommonElementsAction.Click("CssSelector",ElementsProvider.ProviderView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",ElementsProvider.ProviderIconRemoved);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        
    }
}