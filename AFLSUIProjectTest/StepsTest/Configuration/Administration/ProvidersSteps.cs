using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class ProvidersSteps
    {
        #region General Class

        private readonly LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private readonly PageMessages PageMessages = new PageMessages();
        private readonly ProvidersPage ProvidersPage = new ProvidersPage();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private MessagesElements MessagesElements = new MessagesElements();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();

        private ResponseValidation ResponseValidation = new ResponseValidation();

        #endregion General Class

        #region Provider variables

        private string ProviderName;
        private string ProviderFieldName;
        private string DefaulltProviderName = "UI Provider ";
        private string EditProviderName = "UI Provider Edit";

        private int ProviderId;
        private int ProviderMonitorId;
        private int ProviderServiceId;
        private int ProviderZoneId;
        private int ProviderSpecialistCount;
        private int NewAssigment;
        private int NewPriority;

        #endregion Provider variables

        [Then(@"No Se registra el proveedor en la tabla AFLS_PROVIDERS")]
        public void ThenNoSeRegistraElProveedorEnLaTablaAFLS_PROVIDERS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "';", 0);
        }

        [Then(@"Se registra el proveedor como eliminado en la tabla AFLS_PROVIDERS")]
        public void ThenSeRegistraElProveedorComoEliminadoEnLaTablaAFLS_PROVIDERS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND IsDeleted = 1;", 1);
        }

        [Then(@"Se registra el monitor relacionado a proveedor en la tabla AFLS_PROVIDER_MONITORS")]
        public void ThenSeRegistraElMonitorRelacionadoAProveedorEnLaTablaAFLS_PROVIDER_MONITORS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDER_MONITORS WHERE ProviderId = " + ProviderId + " AND UserId = " + ProviderMonitorId + ";", 1);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con asignación editada")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConAsignacionEditada()
        {
            CommonQuery.DBSelectAValue("SELECT Priority FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND AssingType = " + NewAssigment + ";", 1);
        }

        [Then(@"Se registra el servicio relacionado a proveedor en la tabla AFLS_PROVIDER_SERVICES")]
        public void ThenSeRegistraElServicioRelacionadoAProveedorEnLaTablaAFLS_PROVIDER_SERVICES()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDER_SERVICES WHERE ProviderId = " + ProviderId + " AND ServiceId = " + ProviderServiceId + ";", 1);
        }

        [Then(@"Se registra la zona relacionada a proveedor en la tabla AFLS_PROVIDER_ZONE")]
        public void ThenSeRegistraLaZonaRelacionadaAProveedorEnLaTablaAFLS_PROVIDER_ZONE()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDER_ZONE WHERE ProviderId = " + ProviderId + " AND ZoneId = " + ProviderZoneId + ";", 1);
        }

        #region Module

        [Then(@"Se muestra la tarjeta del proveedor y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelProveedorYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.XPath(ProvidersPage.ProviderName)).GetAttribute("value");
            Assert.AreEqual(ProviderName, Value);
        }

        [When(@"Busco y selecciono el proveedor")]
        public void WhenBuscoYSeleccionoElProveedor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ProvidersPage.ProviderFieldSearch, ProviderName);
            CommonElementsAction.Click("CssSelector", ProvidersPage.ProviderButtonSearch);
            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderView);
        }

        [When(@"Doy click en eliminar proveedor")]
        public void WhenDoyClickEnEliminarProveedor()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderIconRemoved);
        }

        [When(@"Doy click en Nuevo proveedor")]
        public void WhenDoyClickEnNuevoProveedor()
        {
            CommonElementsAction.Click("CssSelector", ProvidersPage.ProviderButtonNew);
        }

        [Then(@"Al buscar el proveedor en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElProveedorEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ProvidersPage.ProviderFieldSearch, ProviderName);
            CommonElementsAction.Click("CssSelector", ProvidersPage.ProviderButtonSearch);
            Thread.Sleep(3000);
            CommonElementsAction.WaitElementNoFound(ProvidersPage.ProviderView);
        }

        [When(@"Selecciono la opción de Proveedores")]
        public void WhenSeleccionoLaOpcionDeProveedores()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ProviderOption);
        }

        #endregion Module

        #region Tab Provider Info

        [When(@"Doy click en Guardar proveedor")]
        public void WhenDoyClickEnGuardarProveedor()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderSubmit);
        }

        [When(@"Edito asignación de proveedor")]
        public void WhenEditoAsignacionDeProveedor()
        {
            ProviderFieldName = CommonElementsAction.VallueExtract("XPath", ProvidersPage.ProviderName);

            if (CommonHooks.driver.FindElement(By.XPath("//*[@id='AssignBest']")).Selected)
            {
                CommonElementsAction.Click("XPath", ProvidersPage.ProviderCheckAssignManual);
                NewAssigment = 1;
            }
            else if (CommonHooks.driver.FindElement(By.XPath("//*[@id='AssignManual']")).Selected)
            {
                CommonElementsAction.Click("XPath", ProvidersPage.ProviderCheckAssignBest);
                NewAssigment = 0;
            }
        }

        [When(@"Edito nombre de proveedor")]
        public void WhenEditoNombreDeProveedor()
        {
            Thread.Sleep(2000);
            EditProviderName = EditProviderName + Functions.RandomText(4);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", ProvidersPage.ProviderName, EditProviderName);
        }

        [When(@"Doy click en switch de estado de proveedor")]
        public void WhenDoyClickEnSwitchDeEstadoDeProveedor()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderState);
        }

        [When(@"Diligencio descripción de proveedor")]
        public void WhenDiligencioDescripcionDeProveedor()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ProvidersPage.ProviderDescription, "Descripcion provider");
        }

        [When(@"Diligencio nombre de proveedor")]
        public void WhenDiligencioNombreDeProveedor()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ProvidersPage.ProviderName, ProviderName);
        }

        [When(@"Selecciono asignación al mejor especialista")]
        public void WhenSeleccionoAsignacionAlMejorEspecialista()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderCheckAssignBest);
        }

        [When(@"Selecciono asignación manualmente")]
        public void WhenSeleccionoAsignacionManualmente()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderCheckAssignManual);
        }

        [When(@"Selecciono el Tab de Proveedores")]
        public void WhenSeleccionoElTabDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ProvidersPage.ProviderTabProviders);
        }

        [When(@"Selecciono importancia Alta")]
        public void WhenSeleccionoImportanciaAlta()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderRadioHighPriority);
        }

        [When(@"Selecciono importancia Baja")]
        public void WhenSeleccionoImportanciaBaja()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderRadioLowPriority);
        }

        [When(@"Selecciono importancia Media")]
        public void WhenSeleccionoImportanciaMedia()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderRadioMediumPriority);
        }

        [When(@"Selecciono tipo de proveedor externo")]
        public void WhenSeleccionoTipoDeProveedorExterno()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderCheckExtern);
        }

        [When(@"Selecciono tipo de proveedor interno")]
        public void WhenSeleccionoTipoDeProveedorInterno()
        {
            CommonElementsAction.Click("XPath", ProvidersPage.ProviderCheckIntern);
        }

        [When(@"Edito prioridad de proveedor")]
        public void WhenEditoPrioridadDeProveedor()
        {
            ProviderFieldName = CommonElementsAction.VallueExtract("XPath", ProvidersPage.ProviderName);

            if (CommonHooks.driver.FindElement(By.XPath("//*[@id='highImportance']")).Selected)
            {
                CommonElementsAction.Click("XPath", ProvidersPage.ProviderRadioMediumPriority);
                NewPriority = 2;
            }
            else if (CommonHooks.driver.FindElement(By.XPath("//*[@id='mediumImportance']")).Selected)
            {
                CommonElementsAction.Click("XPath", ProvidersPage.ProviderRadioLowPriority);
                NewPriority = 1;
            }
            else if (CommonHooks.driver.FindElement(By.XPath("//*[@id='lowImportance']")).Selected)
            {
                CommonElementsAction.Click("XPath", ProvidersPage.ProviderRadioHighPriority);
                NewPriority = 3;
            }
        }

        #endregion Tab Provider Info

        #region Tab Services

        [When(@"Diligencio y selecciono un servicio para el proveedor")]
        public void WhenDiligencioYSeleccionoUnServicioParaElProveedor()
        {
            string ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_active = 1 ORDER BY NEWID();", 1);
            string UCName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE is_deleted = 0 AND agreement_type = 2 ORDER BY NEWID();", 1);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", ProvidersPage.ProviderServices, ServiceName, "a");
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", ProvidersPage.ProviderServiceAgreement, UCName, "label");

            ProviderServiceId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 1));
        }

        [When(@"Selecciono el Tab de Servicios de proveedores")]
        public void WhenSeleccionoElTabDeServiciosDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ProvidersPage.ProviderTabServices);
        }

        #endregion Tab Services

        #region Tab Zones

        [When(@"Diligencio y selecciono una zona para el proveedor")]
        public void WhenDiligencioYSeleccionoUnaZonaParaElProveedor()
        {
            string ZoneName = CommonQuery.DBSelectAValue("SELECT TOP 1 zone_name FROM AFLS_ZONES WHERE zone_is_active = 1 ORDER BY NEWID();", 1);
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ProvidersPage.ProviderZoneSearch, ZoneName, "a");
            ProviderZoneId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT zone_id FROM AFLS_ZONES WHERE zone_name = '" + ZoneName + "' ;", 1));
        }

        [When(@"Selecciono el Tab de Zonas de Proveedores")]
        public void WhenSeleccionoElTabDeZonasDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ProvidersPage.ProviderTabZones);
        }

        #endregion Tab Zones

        #region Tab Specialist

        [When(@"Selecciono el Tab de Especialistas de Proveedores")]
        public void WhenSeleccionoElTabDeEspecialistasDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ProvidersPage.ProviderTabSpecialist);
        }

        #endregion Tab Specialist

        #region Tab Monitors

        [When(@"Diligencio y selecciono un monitor para el proveedor")]
        public void WhenDiligencioYSeleccionoUnMonitorParaElProveedor()
        {
            string MonitorName = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_id = (SELECT TOP 1 WEB.user_id FROM AFLS_USERS_WEB WEB JOIN AFW_ROLE_ACCESS ROL ON WEB.user_id = ROL.roac_user_id WHERE roac_role_id = 34005 ORDER BY NEWID());", 1);
            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", ProvidersPage.ProviderMonitors, MonitorName, "a");
            ProviderMonitorId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT user_id FROM AFW_USERS WHERE user_nick_name = '" + MonitorName + "';", 1));
        }

        [When(@"Selecciono el Tab de Monitores de Proveedores")]
        public void WhenSeleccionoElTabDeMonitoresDeProveedores()
        {
            CommonElementsAction.Click("CssSelector", ProvidersPage.ProviderTabMonitors);
        }

        #endregion Tab Monitors

        #region Validate BD

        [Given(@"El proveedor existe")]
        public void GivenElProveedorExiste()
        {
            ProviderName = CommonQuery.DBSelectAValue("SELECT TOP 1 Name FROM AFLS_PROVIDERS WHERE IsActive = 1 AND Name LIKE '%UI Provider%' AND IsDeleted = 0 ORDER BY NEWID();", 1);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con asignación manual")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConAsignacionManual()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND AssingType = 1;", 1);
            ProviderId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT ProviderId FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "';", 1));
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "';", 1);
            ProviderId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT ProviderId FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "';", 1));
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con asignación automática")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConAsignacionAutomatica()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND AssingType = 0;", 1);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con nombre editado")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConNombreEditado()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDERS WHERE Name = '" + EditProviderName + "';", 1);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad alta")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConPrioridadAlta()
        {
            CommonQuery.DBSelectAValue("SELECT Priority FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND Priority = 3;", 1);
        }

        [Given(@"El proveedor no existe")]
        public void GivenElProveedorNoExiste()
        {
            ProviderName = DefaulltProviderName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "';", 0);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad baja")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConPrioridadBaja()
        {
            CommonQuery.DBSelectAValue("SELECT Priority FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND Priority = 1;", 1);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad editado")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConPrioridadEditado()
        {
            CommonQuery.DBSelectAValue("SELECT Priority FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND Priority = " + NewPriority + ";", 1);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad media")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSConPrioridadMedia()
        {
            CommonQuery.DBSelectAValue("SELECT Priority FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND Priority = 2;", 1);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS de tipo externo")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSDeTipoExterno()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND Type = 1;", 1);
        }

        [Then(@"Se registra el proveedor en la tabla AFLS_PROVIDERS de tipo interno")]
        public void ThenSeRegistraElProveedorEnLaTablaAFLS_PROVIDERSDeTipoInterno()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "' AND Type = 0;", 1);
        }

        #endregion Validate BD
    }
}