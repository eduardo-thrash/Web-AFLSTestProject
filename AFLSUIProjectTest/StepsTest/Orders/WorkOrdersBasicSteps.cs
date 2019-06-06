using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Messages;
using AFLSUIProjectTest.UIMap.Orders;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.Orders
{
    [Binding]
    public class WorkOrdersBasicSteps
    {
        private readonly PageMessages PageMessages = new PageMessages();

        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private WorkordersPage WorkordersPage = new WorkordersPage();

        private string ClientName;
        private string UserDispatcher;
        private string ServiceName;
        private int TicketId;
        private int AdditionalFieldFound = 0;

        private int UserSpecialistId;
        private int ProviderId;
        private int ZoneId;
        private int SkillId;

        [Given(@"Tengo un usuario con rol despachador")]
        public void GivenTengoUnUsuarioConRolDespachador()
        {
            UserDispatcher = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = 'thrash'", 1);
        }

        [Given(@"Existe un cliente sin email, teléfono y compañía asociada")]
        public void GivenExisteUnClienteSinEmailTelefonoYCompaniaAsociada()
        {
            ClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 URS.user_name FROM AFLS_USERS_CLIENTS CLI JOIN AFW_USERS URS ON CLI.user_id = URS.user_id WHERE URS.user_active = 1 AND urs.user_phone1 IS NULL AND URS.user_email IS NULL AND  CLI.comp_id IS NULL ORDER BY NEWID()", 1);
        }

        [Given(@"Existe un cliente")]
        public void GivenExisteUnCliente()
        {
            ClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 URS.user_name FROM AFLS_USERS_CLIENTS CLI JOIN AFW_USERS URS ON CLI.user_id = URS.user_id WHERE URS.user_active = 1 ORDER BY NEWID()", 1);
        }

        [Given(@"Existen servicios asociados al cliente")]
        public void GivenExistenServiciosAsociadosAlCliente()
        {
            try
            {
                ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 ORDER BY NEWID();", 1);
                //ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_is_priority_or_emregency = 1 ORDER BY NEWID();", 1);
                //int RemoveCar = ServiceName.Length - 2;
                //ServiceName = ServiceName.Remove(1, RemoveCar);
            }
            catch
            {
                Assert.Fail("Error en consulta SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 ORDER BY NEWID();");
            }
        }

        [Given(@"Existe relación del proveedor de especialista con zona")]
        public void GivenExisteRelacionDelProveedorDeEspecialistaConZona()
        {
            UserSpecialistId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 SP.user_id FROM AFLS_USERS_SPECIALISTS SP JOIN AFW_USERS US ON US.user_id = SP.user_id WHERE US.user_active = 1 ORDER BY NEWID();", 1));
            ProviderId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 spc_provider_id FROM AFLS_USERS_SPECIALISTS WHERE user_id = " + UserSpecialistId + ";", 1));

            try
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDER_ZONE WHERE ProviderId = " + ProviderId + " AND ZoneId = (SELECT zone_id FROM AFLS_ZONES WHERE zone_name = 'Bogota zone');", 1);
            }
            catch
            {
                try
                {
                    Functions.DBInsert("INSERT INTO AFLS_PROVIDER_ZONE (ProviderId ,ZoneId) VALUES (1, (SELECT zone_id FROM AFLS_ZONES WHERE zone_name = 'Bogota zone'));");
                }
                catch
                {
                    Assert.Fail("Error en script INSERT INTO AFLS_PROVIDER_ZONE (ProviderId ,ZoneId) VALUES (1, (SELECT zone_id FROM AFLS_ZONES WHERE zone_name = 'Bogota zone'));");
                }
            }
        }

        [Given(@"Existe especialista con disponibilidad, habilidad del servicio activa, licencia activa y estado activo")]
        public void GivenExisteEspecialistaConDisponibilidadHabilidadDelServicioActivaLicenciaActivaYEstadoActivo()
        {
            try
            {
                SkillId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 skill_id FROM AFLS_SERVICES_SKILLS WHERE service_id = (SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "');", 1));
            }
            catch
            {
                int ServiceId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 1));
                SkillId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 skll_id FROM AFLS_SKILLS WHERE skll_isActive = 1", 1));

                Functions.DBInsert("INSERT INTO AFLS_SERVICES_SKILLS (service_id, skill_id ,weight ,required) VALUES (" + ServiceId + ", " + SkillId + ", 2, 0);");
            }

            try
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USER_SKILLS WHERE aus_user_id " + UserSpecialistId + " = AND aus_skll_id = " + SkillId + ";", 1);
            }
            catch
            {
                Functions.DBInsert("INSERT INTO AFLS_USER_SKILLS (aus_user_id ,aus_skll_id ,aus_score ,aus_required) VALUES (" + UserSpecialistId + ", " + SkillId + " ,10, 0);");
            }

            try
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFW_LICENSES_NAMED WHERE user_id = " + UserSpecialistId + " AND lice_id = (SELECT TOP 1 lice_id FROM AFW_LICENSE ORDER BY 1 DESC);", 1);
            }
            catch
            {
                int LicenceId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 lice_id FROM AFW_LICENSE ORDER BY 1 DESC;", 1));
                Functions.DBInsert("INSERT INTO AFW_LICENSES_NAMED (lice_id ,user_id) VALUES (" + LicenceId + ", " + UserSpecialistId + ")");
            }

            int NumDay = Convert.ToInt32(Day());
            try
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USER_AVAILABILITIES WHERE user_id = " + UserSpecialistId + " AND avai_id = (SELECT TOP 1 avai_id FROM AFLS_AVAILABILITIES WHERE avai_day = " + NumDay + ");", 1);
            }
            catch
            {
                string InitDate = DateTime.Now.ToString("yyyy-MM-dd 08:00:00.000");
                string EndDate = DateTime.Now.AddHours(2.0).ToString("yyyy-MM-dd 14:00:00.000");

                Functions.DBInsert("INSERT INTO AFLS_AVAILABILITIES (avai_day, avai_hour_start, avai_hour_end) VALUES (" + NumDay + ",'" + InitDate + "','" + EndDate + "');");

                int AvalId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 avai_id FROM AFLS_AVAILABILITIES ORDER BY 1 DESC;", 1));
                Functions.DBInsert("INSERT INTO AFLS_USER_AVAILABILITIES (user_id ,avai_id) VALUES(" + UserSpecialistId + ", " + AvalId + ");");

                CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USER_AVAILABILITIES WHERE user_id = " + UserSpecialistId + " AND avai_id = (SELECT TOP 1 avai_id FROM AFLS_AVAILABILITIES WHERE avai_day = " + NumDay + " ORDER BY 1 DESC);", 1);
            }
        }

        [Given(@"Existen servicios asociados al cliente de tipo desplazamiento")]
        public void GivenExistenServiciosAsociadosAlClienteDeTipoDesplazamiento()
        {
            try
            {
                ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_type = 1 ORDER BY NEWID();", 1);
                //int RemoveCar = ServiceName.Length - 2;
                //ServiceName = ServiceName.Remove(RemoveCar, 2);
            }
            catch
            {
                Assert.Fail("Error en consulta SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_type = 2 ORDER BY NEWID();");
            }
        }

        [When(@"Accedo a ítem Nueva orden")]
        public void WhenAccedoAItemNuevaOrden()
        {
            CommonElementsAction.Click("XPath", PrincipalMenuPage.ItemNewOrder);
            Thread.Sleep(5000);
        }

        [When(@"Diligencio y selecciono un cliente de orden")]
        public void WhenDiligencioYSeleccionoUnClienteDeOrden()
        {
            Thread.Sleep(2000);
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", WorkordersPage.ClientName, ClientName, "a");
        }

        [When(@"Diligencio Dirección de cita de orden")]
        public void WhenDiligencioDireccionDeCitaDeOrden()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("XPath", WorkordersPage.Address, "calle 64 # 5-22 Bogota Colombia");
            Thread.Sleep(2000);
        }

        [When(@"Diligencio campo de solicitante de cita de orden")]
        public void WhenDiligencioCampoDeSolicitanteDeCitaDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.ContactName, "Rubiela Quintero");
        }

        [When(@"Diligencio Teléfono de Solicitante de orden")]
        public void WhenDiligencioTelefonoDeSolicitanteDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.ContactPhone, "3005869685");
        }

        [When(@"Diligencio Correo de Solicitante de orden")]
        public void WhenDiligencioCorreoDeSolicitanteDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.ContactEmail, "jose.montenegro@arandasoft.com");
        }

        [When(@"Diligencio Detalle de la dirección de cita de orden")]
        public void WhenDiligencioDetalleDeLaDireccionDeCitaDeOrden()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("XPath", WorkordersPage.AddlAddressInfo, "Apartamento 708");
        }

        [When(@"Diligencio y selecciono servicio de orden")]
        public void WhenDiligencioYSeleccionoServicioDeOrden()
        {
            UtilAction.Select_ComboboxAutocomplete(WorkordersPage.ServiceName, ServiceName, "a");
            Thread.Sleep(2000);
        }

        [When(@"Selecciono Tipo de Orden Normal de orden")]
        public void WhenSeleccionoTipoDeOrdenNormalDeOrden()
        {
            CommonElementsAction.Click("XPath", WorkordersPage.OptionOrderNormal);
            Thread.Sleep(2000);
        }

        [When(@"Diligencio Asunto de orden")]
        public void WhenDiligencioAsuntoDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.Subject, "Asunto orden de trabajo UI");
        }

        [When(@"Diligencio descripción de orden")]
        public void WhenDiligencioDescripcionDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.Description, "Descripción orden de trabajo UI Lorem ipsum dolor sit amet, consectetur adipiscing elit.Vestibulum massa elit, rutrum quis lacinia nec, eleifend eget diam.Vestibulum ante arcu, consequat at lacus sed, sollicitudin vulputate elit.");
        }

        [When(@"Selecciono el Tab de campos adicionales de orden de trabajo")]
        public void WhenSeleccionoElTabDeCamposAdicionalesDeOrdenDeTrabajo()
        {
            try
            {
                UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-9']");
            }
            catch
            {
                Thread.Sleep(2000);

                UtilAction.Click("//div[@class='workOrder contentWO']//a[@class='jcarousel-control-next']");
                UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-9']");
            }
        }

        [When(@"Diligencio campos adicionales de orden de trabajo")]
        public int WhenDiligencioCamposAdicionalesDeOrdenDeTrabajo()
        {
            try
            {
                IList<IWebElement> AFClientsListInputText = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@class='js-input-additional-field k-valid']"));
                foreach (IWebElement AFClient in AFClientsListInputText)
                {
                    AFClient.Clear();
                    AFClient.SendKeys(Functions.RandomText(10));
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }
                IList<IWebElement> AFClientsListTextarea = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//textarea"));
                foreach (IWebElement AFClient in AFClientsListTextarea)
                {
                    AFClient.Clear();
                    AFClient.SendKeys("Texto parrafo");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFClientsListNumber = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@type='number']"));
                foreach (IWebElement AFClient in AFClientsListNumber)
                {
                    AFClient.Clear();
                    AFClient.SendKeys("123456");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                int TableCalend = 0;
                IList<IWebElement> AFClientsListDate = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//span[@class='k-icon k-i-calendar']"));
                foreach (IWebElement AFClient in AFClientsListDate)
                {
                    TableCalend++;
                    AFClient.Click();
                    string IdCalendar = CommonHooks.driver.FindElement(By.XPath("(//div[@class='k-widget k-calendar'])[" + TableCalend + "]")).GetAttribute("id");
                    CommonElementsAction.Click("XPath", "//div[@id='" + IdCalendar + "']/table/tbody/tr/td/a");
                    Thread.Sleep(2000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFClientsListSelect = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//select"));
                foreach (IWebElement AFClient in AFClientsListSelect)
                {
                    new SelectElement(AFClient).SelectByIndex(1);
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

            return AdditionalFieldFound;
        }

        [When(@"Doy click en Crear orden")]
        public void WhenDoyClickEnCrearOrden()
        {
            CommonElementsAction.Click("XPath", WorkordersPage.Save);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConTicket_IdLongitudLatitudYDireccion()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_longitude IS NOT NULL AND work_latitude IS NOT NULL AND work_address IS NOT NULL;", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con prioridad de emergencia y especialista asignado")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConPrioridadDeEmergenciaYEspecialistaAsignado()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " ANDwork_attendant IS NOT NULL AND work_priority = 1;", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud de destino, latitud de destino y dirección de destino")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConTicket_IdLongitudDeDestinoLatitudDeDestinoYDireccionDeDestino()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_end_address IS NOT NULL AND work_end_longitude IS NOT NULL AND work_end_latitude IS NOT NULL;", 1);
        }

        [Then(@"se muestra mensaje indicando que se creo la orden de trabajo correctamente")]
        public void ThenSeMuestraMensajeIndicandoQueSeCreoLaOrdenDeTrabajoCorrectamente()
        {
            TicketId = Convert.ToInt32(ResponseValidation.ValidateSuccessOrdernCreate());
        }

        [When(@"Diligencio Dirección de cita de orden dando click en cursor")]
        public void WhenDiligencioDireccionDeCitaDeOrdenDandoClickEnCursor()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.Address, "calle 64 # 5-22 Bogota Colombia");
            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath", "//div[@class='workOrder contentWO']//input[@id='clientAddresCheck']");
        }

        [When(@"Diligencio y selecciono servicio de orden de tipo desplazamiento")]
        public void WhenDiligencioYSeleccionoServicioDeOrdenDeTipoDesplazamiento()
        {
            UtilAction.Select_ComboboxAutocomplete(WorkordersPage.ServiceName, ServiceName, "a");
            CommonHooks.driver.FindElement(By.XPath(WorkordersPage.ServiceName)).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
        }

        [When(@"Selecciono Tipo de Orden Emergencia de orden")]
        public void WhenSeleccionoTipoDeOrdenEmergenciaDeOrden()
        {
            UtilAction.Click(WorkordersPage.OptionOrderEmergency);
        }

        [When(@"Doy click en Tab Asignación de orden")]
        public void WhenDoyClickEnTabAsignacionDeOrden()
        {
            UtilAction.Click(WorkordersPage.AssigmentTab);
        }

        [When(@"Selecciono tab Asignación Automática")]
        public void WhenSeleccionoTabAsignacionAutomatica()
        {
            UtilAction.Click(WorkordersPage.AutomaticAssigmentTab);
        }

        [When(@"Selecciono tab Asignación Manual")]
        public void WhenSeleccionoTabAsignacionManual()
        {
            UtilAction.Click(WorkordersPage.ManualAssigmentTab);
        }

        [When(@"Doy click en Buscar especialista para asignación manual")]
        public void WhenDoyClickEnBuscarEspecialistaParaAsignacionManual()
        {
            UtilAction.Click(WorkordersPage.ManualSpecialistFilter);
            Thread.Sleep(1);
            Thread.Sleep(1);
            Thread.Sleep(1);
            Thread.Sleep(1);
            Thread.Sleep(1);
            Thread.Sleep(1);
        }

        [When(@"Diligencio Dirección de destino de orden dando click en cursor")]
        public void WhenDiligencioDireccionDeDestinoDeOrdenDandoClickEnCursor()
        {
            UtilAction.SendKeys(WorkordersPage.AddressEndPoint, "calle 38 sur Bogota Colombia");
            Thread.Sleep(2000);
            UtilAction.Click("//input[@id='EndPointAddresCheck']");
        }

        [When(@"Diligencio Dirección de destino de orden dando enter")]
        public void WhenDiligencioDireccionDeDestinoDeOrdenDandoEnter()
        {
            UtilAction.Click(WorkordersPage.AddressEndPoint);
            UtilAction.EnterAfter_SendKeys(WorkordersPage.AddressEndPoint, "calle 38 sur Bogota Colombia");
        }

        [When(@"Diligencio Dirección de destino de orden dando Tab")]
        public void WhenDiligencioDireccionDeDestinoDeOrdenDandoTab()
        {
            UtilAction.Click(WorkordersPage.AddressEndPoint);
            UtilAction.TabAfter_SendKeys(WorkordersPage.AddressEndPoint, "calle 38 sur Bogota Colombia");
        }

        [When(@"Diligencio Dirección de destino de orden dando click en mapa")]
        public void WhenDiligencioDireccionDeDestinoDeOrdenDandoClickEnMapa()
        {
            UtilAction.Click(WorkordersPage.AddressEndPoint);

            UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='woMapOrder ui maps']");
        }

        [When(@"Diligencio Dirección de cita de orden dando enter")]
        public void WhenDiligencioDireccionDeCitaDeOrdenDandoEnter()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("XPath", WorkordersPage.Address, "calle 64 # 5-22 Bogota Colombia");
        }

        [When(@"Diligencio Dirección de cita de orden dando tab")]
        public void WhenDiligencioDireccionDeCitaDeOrdenDandoTab()
        {
            CommonElementsAction.SendKeys_InputText("XPath", WorkordersPage.Address, "calle 64 # 5-22 Bogota Colombia");
            Thread.Sleep(2000);
            CommonHooks.driver.FindElement(By.XPath(WorkordersPage.Address)).SendKeys(Keys.Tab);
        }

        [When(@"Diligencio Dirección de cita de orden dando click en mapa")]
        public void WhenDiligencioDireccionDeCitaDeOrdenDandoClickEnMapa()
        {
            UtilAction.Click(WorkordersPage.Address);
            UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='woMapOrder ui maps']");
        }

        private string Day()
        {
            string dayName = DateTime.Now.DayOfWeek.ToString();
            string day = null;
            /*******************/
            switch (dayName)
            {
                case "Monday":
                    day = "2";
                    break;

                case "Tuesday":
                    day = "3";
                    break;

                case "Wenesday":
                    day = "4";
                    break;

                case "Thursday":
                    day = "5";
                    break;

                case "Friday":
                    day = "6";
                    break;

                case "Saturday":
                    day = "7";
                    break;

                case "Sunday":
                    day = "1";
                    break;
            }

            return day;
        }
    }
}