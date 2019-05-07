using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class ProvidersSteps
    {
        private readonly ElementsProvider ElementsProvider = new ElementsProvider();
        private readonly PageMessages PageMessages = new PageMessages();
        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();

        [Given(@"El proveedor no existe")]
        public void GivenElProveedorNoExiste()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono la opción de Proveedores")]
        public void WhenSeleccionoLaOpcionDeProveedores()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en Nuevo proveedor")]
        public void WhenDoyClickEnNuevoProveedor()
        {
            CommonElementsAction.Click("CssSelector", ElementsProvider.ProviderButtonNew);
        }

        [When(@"Selecciono el Tab de Proveedores")]
        public void WhenSeleccionoElTabDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ElementsProvider.ProviderTabProviders);
        }

        [When(@"Diligencio nombre de proveedor")]
        public void WhenDiligencioNombreDeProveedor()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ElementsProvider.ProviderName, "UI-Prov Popayan General medium Create");
        }

        [When(@"Diligencio descripción de proveedor")]
        public void WhenDiligencioDescripcionDeProveedor()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ElementsProvider.ProviderDescription, "Descripcion provider");
        }

        [When(@"Selecciono tipo de proveedor interno")]
        public void WhenSeleccionoTipoDeProveedorInterno()
        {
            CommonElementsAction.Click("XPath", ElementsProvider.ProviderCheckIntern);
        }

        [When(@"Selecciono tipo de proveedor externo")]
        public void WhenSeleccionoTipoDeProveedorExterno()
        {
            CommonElementsAction.Click("XPath", ElementsProvider.ProviderCheckExtern);
        }

        [When(@"Selecciono asignación manualmente")]
        public void WhenSeleccionoAsignacionManualmente()
        {
            CommonElementsAction.Click("XPath", ElementsProvider.ProviderCheckAssignManual);
        }

        [When(@"Selecciono asignación al mejor especialista")]
        public void WhenSeleccionoAsignacionAlMejorEspecialista()
        {
            CommonElementsAction.Click("XPath", ElementsProvider.ProviderCheckAssignBest);
        }

        [When(@"Selecciono importancia Alta")]
        public void WhenSeleccionoImportanciaAlta()
        {
            CommonElementsAction.Click("XPath", ElementsProvider.ProviderRadioHighPriority);
        }

        [When(@"Selecciono importancia Media")]
        public void WhenSeleccionoImportanciaMedia()
        {
            CommonElementsAction.Click("XPath", ElementsProvider.ProviderRadioMediumPriority);
        }

        [When(@"Selecciono importancia Baja")]
        public void WhenSeleccionoImportanciaBaja()
        {
            CommonElementsAction.Click("XPath", ElementsProvider.ProviderRadioLowPriority);
        }

        [When(@"Doy click en switch de estado de proveedor")]
        public void WhenDoyClickEnSwitchDeEstadoDeProveedor()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono el Tab de Servicios de proveedores")]
        public void WhenSeleccionoElTabDeServiciosDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ElementsProvider.ProviderTabServices);
        }

        [When(@"Diligencio y selecciono un servicio para el proveedor")]
        public void WhenDiligencioYSeleccionoUnServicioParaElProveedor()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", ElementsProvider.ProviderServices, "Servicio Auditoria WT", "a");
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", ElementsProvider.ProviderServiceAgreement, "ANS General", "label");
        }

        [When(@"Selecciono el Tab de Zonas de Proveedores")]
        public void WhenSeleccionoElTabDeZonasDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ElementsProvider.ProviderTabZones);
        }

        [When(@"Diligencio y selecciono una zona para el proveedor")]
        public void WhenDiligencioYSeleccionoUnaZonaParaElProveedor()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", ElementsProvider.ProviderZoneList, "Bogot", "a");
        }

        [When(@"Selecciono el Tab de Especialistas de Proveedores")]
        public void WhenSeleccionoElTabDeEspecialistasDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ElementsProvider.ProviderTabSpecialist);
        }

        [When(@"Selecciono el Tab de Monitores de Proveedores")]
        public void WhenSeleccionoElTabDeMonitoresDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ElementsProvider.ProviderTabMonitors);
        }

        [When(@"Diligencio y selecciono un monitor para el proveedor")]
        public void WhenDiligencioYSeleccionoUnMonitorParaElProveedor()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", ElementsProvider.ProviderMonitors, "Monit", "a");
        }

        [When(@"Doy click en Guardar proveedor")]
        public void WhenDoyClickEnGuardarProveedor()
        {
            CommonElementsAction.Click("CssSelector", ElementsProvider.ProviderSubmit);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERS()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el servicio relacionado a proveedor en la tabla AFLS_PROVIDER_SERVICES")]
        public void ThenSeRegistraElServicioRelacionadoAProveedorEnLaTablaAFLS_PROVIDER_SERVICES()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra la zona relacionada a proveedor en la tabla AFLS_PROVIDER_ZONE")]
        public void ThenSeRegistraLaZonaRelacionadaAProveedorEnLaTablaAFLS_PROVIDER_ZONE()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el proveedor relacionado al usuario móvil en la tabla AFLS_USERS_SPECIALISTS")]
        public void ThenSeRegistraElProveedorRelacionadoAlUsuarioMovilEnLaTablaAFLS_USERS_SPECIALISTS()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el monitor relacionado a proveedor en la tabla AFLS_PROVIDER_MONITORS")]
        public void ThenSeRegistraElMonitorRelacionadoAProveedorEnLaTablaAFLS_PROVIDER_MONITORS()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad media")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConPrioridadMedia()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad alta")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConPrioridadAlta()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad baja")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConPrioridadBaja()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS de tipo externo")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSDeTipoExterno()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS de tipo interno")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSDeTipoInterno()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con asignación manual")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConAsignacionManual()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con asignación automática")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConAsignacionAutomatica()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"No Se registra el proveedor en la tabla AFLS_PROVIDERS")]
        public void ThenNoSeRegistraElProveedorEnLaTablaAFLS_PROVIDERS()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"El proveedor existe")]
        public void GivenElProveedorExiste()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Busco y selecciono el proveedor")]
        public void WhenBuscoYSeleccionoElProveedor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ElementsProvider.ProviderFieldSearch, "Especialistas Bogota Sur General WT");
            CommonElementsAction.Click("CssSelector", ElementsProvider.ProviderButtonSearch);

            CommonElementsAction.Click("CssSelector", ElementsProvider.ProviderView);
        }

        [When(@"Edito nombre de proveedor")]
        public void WhenEditoNombreDeProveedor()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", ElementsProvider.ProviderName, "Especialistas Bogota Sur Updaate");
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con nombre editado")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConNombreEditado()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Edito prioridad de proveedor")]
        public void WhenEditoPrioridadDeProveedor()
        {
            if (CommonHooks.driver.FindElement(By.XPath("//*[@id='highImportance']")).Selected)
            {
                LastPriority = 3;
                CommonElementsAction.Click("XPath", ElementsProvider.ProviderRadioMediumPriority);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath", ElementsProvider.ProviderName, "Especialistas Bogota Medium Sur Updaate");
            }
            else if (CommonHooks.driver.FindElement(By.XPath("//*[@id='mediumImportance']")).Selected)
            {
                LastPriority = 2;
                CommonElementsAction.Click("XPath", ElementsProvider.ProviderRadioLowPriority);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath", ElementsProvider.ProviderName, "Especialistas Bogota Sur Low Updaate");
            }
            else if (CommonHooks.driver.FindElement(By.XPath("//*[@id='lowImportance']")).Selected)
            {
                LastPriority = 1;
                CommonElementsAction.Click("XPath", ElementsProvider.ProviderRadioHighPriority);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath", ElementsProvider.ProviderName, "Especialistas Bogota Sur High Updaate");
            }
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad editado")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConPrioridadEditado()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Edito asignación de proveedor")]
        public void WhenEditoAsignacionDeProveedor()
        {
            if (CommonHooks.driver.FindElement(By.XPath("//*[@id='AssignBest']")).Selected)
            {
                LastAssigment = "Automatic";
                CommonElementsAction.Click("XPath", ElementsProvider.ProviderCheckAssignManual);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath", ElementsProvider.ProviderName, "Proveedor interno Manual Medio Update");
            }
            else if (CommonHooks.driver.FindElement(By.XPath("//*[@id='AssignManual']")).Selected)
            {
                LastAssigment = "Manual";
                CommonElementsAction.Click("XPath", ElementsProvider.ProviderCheckAssignBest);
                CommonElementsAction.ClearAndSendKeys_InputText("XPath", ElementsProvider.ProviderName, "Proveedor interno Best Medio Update");
            }
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con asignación editada")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConAsignacionEditada()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se muestra la tarjeta del proveedor y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelProveedorYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ElementsProvider.ProviderName)).GetAttribute("value");
            Assert.AreEqual("Especialistas Bogota Sur Updaate", Value);
        }

        [When(@"Doy click en eliminar proveedor")]
        public void WhenDoyClickEnEliminarProveedor()
        {
            CommonElementsAction.Click("XPath", ElementsProvider.ProviderIconRemoved);
        }

        [Then(@"Al buscar el proveedor en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElProveedorEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            ScenarioContext.Current.Pending();
        }
    }
}