using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Messages;
using AFLSUIProjectTest.UIMap.Orders;
using CommonTest;
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
        private int ServiceId;
        private int Product_Id;
        private int TicketId;
        private int WorkId;
        private int AdditionalFieldFound = 0;

        private int UserSpecialistId;
        private string UserSpecialistName;
        private int ProviderId;
        private string ProviderName;
        private int ZoneId;
        private int SkillId;

        private DateTime MoreDays;

        private int IdTypeRelation;

        private int RelationTicketId;

        [Given(@"Tengo un usuario con rol despachador")]
        public void GivenTengoUnUsuarioConRolDespachador()
        {
            UserDispatcher = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = 'thrash'", 1);
        }

        [Given(@"Existe un cliente sin email, teléfono y compañía asociada")]
        public void GivenExisteUnClienteSinEmailTelefonoYCompaniaAsociada()
        {
            ClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 URS.user_name FROM AFLS_USERS_CLIENTS CLI JOIN AFW_USERS URS ON CLI.user_id = URS.user_id WHERE URS.user_active = 1 AND urs.user_phone1 IS NULL AND URS.user_email IS NULL AND  CLI.comp_id IS NULL ORDER BY NEWID();", 1);
        }

        [Given(@"Existe un cliente")]
        public void GivenExisteUnCliente()
        {
            ClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 URS.user_name FROM AFLS_USERS_CLIENTS CLI JOIN AFW_USERS URS ON CLI.user_id = URS.user_id WHERE URS.user_active = 1 ORDER BY NEWID();", 1);
        }

        [Given(@"Existe un cliente con compañía asociada")]
        public void GivenExisteUnClienteConCompaniaAsociada()
        {
            ClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 URS.user_name FROM AFLS_USERS_CLIENTS CLI JOIN AFW_USERS URS ON CLI.user_id = URS.user_id WHERE URS.user_active = 1 AND CLI.comp_id IS NOT NULL ORDER BY NEWID();", 1);
        }

        [Given(@"Existe un cliente sin compañía asociada")]
        public void GivenExisteUnClienteSinCompaniaAsociada()
        {
            ClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 URS.user_name FROM AFLS_USERS_CLIENTS CLI JOIN AFW_USERS URS ON CLI.user_id = URS.user_id WHERE URS.user_active = 1 AND CLI.comp_id IS NULL ORDER BY NEWID();", 1);
        }

        [Given(@"Existen servicios asociados al cliente")]
        public void GivenExistenServiciosAsociadosAlCliente()
        {
            try
            {
                ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 ORDER BY NEWID();", 1);
            }
            catch
            {
                Assert.Fail("Error en consulta SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 ORDER BY NEWID();");
            }
        }

        [Given(@"existen ordenes en estado abierto para relacionar")]
        public void GivenExistenOrdenesEnEstadoAbiertoParaRelacionar()
        {
            RelationTicketId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 ticket_id FROM AFLS_WORKORDERS WHERE stat_id = 1 AND work_id <> (SELECT TOP 1 ari_source FROM AFLS_RELATION_ITEMS) AND work_id <> (SELECT TOP 1 ari_target FROM AFLS_RELATION_ITEMS) ORDER BY NEWID();", 1));
        }

        [Given(@"Existen servicios asociados al cliente con inventario completo y tareas")]
        public void GivenExistenServiciosAsociadosAlClienteConInventarioCompletoYTareas()
        {
            try
            {
                ServiceName = CommonQuery.DBSelectMoreValue("SELECT SER.serv_name, COUNT(TIPOCERO.prod_id) AS [COUNT_TIPOCERO],COUNT(TIPOUNO.prod_id) AS [COUNT_TIPOUNO] FROM AFLS_SERVICES SER INNER JOIN AFLS_STOCK_SERVICE_PRODUCTS PRO ON SER.serv_id = PRO.serv_id INNER JOIN AFLS_SERVICE_TASKS ST ON ST.stask_service_id= SER.serv_id LEFT OUTER JOIN ( SELECT PROD_ID, PROD_DESCRIPTION FROM AFLS_STOCK_PRODUCTS WHERE prod_TYPE=0 ) TIPOCERO ON PRO.prod_id= TIPOCERO.PROD_ID LEFT OUTER JOIN ( SELECT PROD_ID, PROD_DESCRIPTION FROM AFLS_STOCK_PRODUCTS WHERE prod_TYPE=1 ) TIPOUNO ON PRO.prod_id= TIPOUNO.PROD_ID GROUP BY SER.serv_name HAVING COUNT(TIPOUNO.prod_id) <>0 AND COUNT(TIPOCERO.prod_id) <>0;", 0);
                ServiceId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 1));
            }
            catch
            {
                if (ServiceName == null)
                {
                    ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 ORDER BY NEWID();", 1);
                    ServiceId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 1));
                }
                //Identifico si tiene inventario único. si no, relaciono producto único al servicio
                try
                {
                    CommonQuery.DBSelectAValue("SELECT TOP 1 SER.serv_name FROM AFLS_SERVICES SER INNER JOIN AFLS_STOCK_SERVICE_PRODUCTS PRO ON SER.serv_id = PRO.serv_id WHERE PRO.prod_id = (SELECT TOP 1 prod_id FROM AFLS_STOCK_PRODUCTS WHERE prod_type = 1) AND SER.serv_name = '" + ServiceName + "' ORDER BY NEWID();", 1);
                }
                catch
                {
                    Product_Id = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 prod_id FROM AFLS_STOCK_PRODUCTS WHERE prod_type = 1", 1));
                    Functions.DBInsert("INSERT INTO AFLS_STOCK_SERVICE_PRODUCTS (srsp_quantity,srsp_required,serv_id,prod_id) VALUES (1,1," + ServiceId + "," + Product_Id + ");");
                    CommonQuery.DBSelectAValue("SELECT TOP 1 SER.serv_name FROM AFLS_SERVICES SER INNER JOIN AFLS_STOCK_SERVICE_PRODUCTS PRO ON SER.serv_id = PRO.serv_id WHERE PRO.prod_id = (SELECT TOP 1 prod_id FROM AFLS_STOCK_PRODUCTS WHERE prod_type = 1) AND SER.serv_name = '" + ServiceName + "' ORDER BY NEWID();", 1);
                }
                //Identifico si tiene inventario cantidad. si no, relaciono producto cantidad al servicio
                try
                {
                    CommonQuery.DBSelectAValue("SELECT TOP 1 SER.serv_name FROM AFLS_SERVICES SER INNER JOIN AFLS_STOCK_SERVICE_PRODUCTS PRO ON SER.serv_id = PRO.serv_id WHERE PRO.prod_id = (SELECT TOP 1 prod_id FROM AFLS_STOCK_PRODUCTS WHERE prod_type = 0) AND SER.serv_name = '" + ServiceName + "' ORDER BY NEWID();", 1);
                }
                catch
                {
                    Product_Id = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 prod_id FROM AFLS_STOCK_PRODUCTS WHERE prod_type = 0", 1));
                    Functions.DBInsert("INSERT INTO AFLS_STOCK_SERVICE_PRODUCTS (srsp_quantity,srsp_required,serv_id,prod_id) VALUES (1,1," + ServiceId + "," + Product_Id + ");");
                    CommonQuery.DBSelectAValue("SELECT TOP 1 SER.serv_name FROM AFLS_SERVICES SER INNER JOIN AFLS_STOCK_SERVICE_PRODUCTS PRO ON SER.serv_id = PRO.serv_id WHERE PRO.prod_id = (SELECT TOP 1 prod_id FROM AFLS_STOCK_PRODUCTS WHERE prod_type = 0) AND SER.serv_name = '" + ServiceName + "' ORDER BY NEWID();", 1);
                }
                //Identifico si tiene tareas. si no, relaciono tarea al servicio
                try
                {
                    CommonQuery.DBSelectAValue("SELECT TOP 1 SER.serv_name FROM AFLS_SERVICES SER INNER JOIN AFLS_SERVICE_TASKS TAS ON SER.serv_id = TAS.stask_service_id AND SER.serv_name = '" + ServiceName + "' ORDER BY NEWID();", 1);
                }
                catch
                {
                    Functions.DBInsert("INSERT INTO AFLS_SERVICE_TASKS (stask_description, stask_service_id, stask_order) VALUES ('tarea de servicio inicial'," + ServiceId + ",1);");
                    CommonQuery.DBSelectAValue("SELECT TOP 1 SER.serv_name FROM AFLS_SERVICES SER INNER JOIN AFLS_SERVICE_TASKS TAS ON SER.serv_id = TAS.stask_service_id AND SER.serv_name = '" + ServiceName + "' ORDER BY NEWID();", 1);
                }
            }
        }

        [Given(@"Existen servicios asociados al cliente de tipo estándar")]
        public void GivenExistenServiciosAsociadosAlClienteDeTipoEstandar()
        {
            try
            {
                ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_type = 2 ORDER BY NEWID();", 1);
            }
            catch
            {
                Assert.Fail("Error en consulta SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_type = 2 ORDER BY NEWID();");
            }
        }

        [Given(@"Existen servicios asociados al cliente habilitados para ordenes de emergencia")]
        public void GivenExistenServiciosAsociadosAlClienteHabilitadosParaOrdenesDeEmergencia()
        {
            try
            {
                ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 and serv_is_priority_or_emregency = 1 ORDER BY NEWID();", 1);
            }
            catch
            {
                try
                {
                    ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES;", 1);
                    Functions.DBUpdate("UPDATE AFLS_SERVICES SET serv_is_priority_or_emregency = 1 WHERE serv_name = '" + ServiceName + "';");
                    ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 ORDER BY NEWID();", 1);
                }
                catch
                {
                    Assert.Fail("Error en script UPDATE AFLS_SERVICES SET serv_is_priority_or_emregency = 1 WHERE serv_name = '" + ServiceName + "';");
                }
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
                CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USER_SKILLS WHERE aus_user_id = " + UserSpecialistId + " AND aus_skll_id = " + SkillId + ";", 1);
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
            }
            catch
            {
                Assert.Fail("Error en consulta SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_type = 2 ORDER BY NEWID();");
            }
        }

        [Given(@"Existen servicios de tipo asignación directa asociados al cliente")]
        public void GivenExistenServiciosDeTipoAsignacionDirectaAsociadosAlCliente()
        {
            try
            {
                ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_provider_assignment_type = 1 ORDER BY NEWID();", 1);
            }
            catch
            {
                Assert.Fail("Error en consulta SELECT SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_provider_assignment_type = 1 ORDER BY NEWID();");
            }
        }

        [Given(@"Existen servicios de tipo distribución publica asociados al cliente")]
        public void GivenExistenServiciosDeTipoDistribucionPublicaAsociadosAlCliente()
        {
            try
            {
                ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_provider_assignment_type = 2 ORDER BY NEWID();", 1);
            }
            catch
            {
                Assert.Fail("Error en consulta SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 AND serv_provider_assignment_type = 2 ORDER BY NEWID();");
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

        [When(@"Diligencio Dirección de destino de orden")]
        public void WhenDiligencioDireccionDeDestinoDeOrden()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("XPath", WorkordersPage.AddressEndPoint, "calle 49 # 9 - 53 Bogota Colombia");
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

        [When(@"Diligencio y selecciono servicio de tipo estándar")]
        public void WhenDiligencioYSeleccionoServicioDeTipoEstandar()
        {
            UtilAction.Select_ComboboxAutocomplete(WorkordersPage.ServiceName, ServiceName, "a");
            Thread.Sleep(2000);
        }

        [When(@"Diligencio y selecciono servicio de tipo desplazamiento")]
        public void WhenDiligencioYSeleccionoServicioDeTipoDesplazamiento()
        {
            UtilAction.Select_ComboboxAutocomplete(WorkordersPage.ServiceName, ServiceName, "a");
            Thread.Sleep(2000);
        }

        [When(@"Diligencio y selecciono servicio de orden de tipo asignación directa")]
        public void WhenDiligencioYSeleccionoServicioDeOrdenDeTipoAsignacionDirecta()
        {
            UtilAction.Select_ComboboxAutocomplete(WorkordersPage.ServiceName, ServiceName, "a");
            Thread.Sleep(2000);
        }

        [When(@"Diligencio y selecciono servicio de orden de tipo distribución publica")]
        public void WhenDiligencioYSeleccionoServicioDeOrdenDeTipoDistribucionPublica()
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
                Thread.Sleep(1000);

                UtilAction.Click("//div[@class='workOrder contentWO']//a[@class='jcarousel-control-next']");
                UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-9']");
            }
        }

        [When(@"Doy click en Tab Relaciones de orden")]
        public void WhenDoyClickEnTabRelacionesDeOrden()
        {
            try
            {
                UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-13']");
            }
            catch
            {
                Thread.Sleep(1000);
                try
                {
                    UtilAction.Click("//div[@class='workOrder contentWO']//a[@class='jcarousel-control-next']");
                    UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-13']");
                }
                catch
                {
                    Thread.Sleep(1000);
                    UtilAction.Click("//div[@class='workOrder contentWO']//a[@class='jcarousel-control-next']");
                    UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-13']");
                }
            }
        }

        [When(@"Doy click en nueva relación en orden")]
        public void WhenDoyClickEnNuevaRelacionEnOrden()
        {
            UtilAction.Click(WorkordersPage.RelationNew);
        }

        [When(@"Selecciono relación de tipo sucesión")]
        public void WhenSeleccionoRelacionDeTipoSucesion()
        {
            UtilAction.SelectDropDownList(WorkordersPage.RelationType, CommonQuery.DBSelectAValue("SELECT TOP 1 ar_name FROM AFLS_RELATIONSHIP WHERE art_id = 1 ORDER BY NEWID();", 1), "label");
        }

        [When(@"Selecciono relación de tipo vinculo")]
        public void WhenSeleccionoRelacionDeTipoVinculo()
        {
            try
            {
                UtilAction.SelectDropDownList(WorkordersPage.RelationType, CommonQuery.DBSelectAValue("SELECT TOP 1 ar_name FROM AFLS_RELATIONSHIP WHERE art_id = 2 ORDER BY NEWID();", 1), "label");
            }
            catch
            {
            }
        }

        [When(@"Diligencio y selecciono orden a relacionar")]
        public void WhenDiligencioYSeleccionoOrdenARelacionar()
        {
            try
            {
                UtilAction.Click(WorkordersPage.RelationOrder);
                UtilAction.SendKeys(WorkordersPage.RelationOrder, RelationTicketId.ToString());

                CommonHooks.driver.FindElement(By.XPath("//ul/li/a[@class='item ui-corner-all']/span[@class='row ticketId']"));
                Thread.Sleep(1);
                Thread.Sleep(1);
                UtilAction.Click("//ul[2]/li/a/span[3]");
                Thread.Sleep(1);
                Thread.Sleep(1);
            }
            catch (Exception e)
            {
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
            WorkId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT work_id FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + ";", 1));
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con información de proveedor en campo work_restriction_info")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConInformacionDeProveedorEnCampoWork_Restriction_Info()
        {
            CommonQuery.DBSelectAValue("SELECT work_restriction_info FROM AFLS_WORKORDERS WHERE work_restriction_info = '{\"ProviderId\":" + ProviderId + ",\"ProviderName\":\"" + ProviderName + "\",\"WorkCenterName\":null,\"WorkCenterId\":null,\"AttentionStartDate\":null,\"WorkDayId\":null}' AND ticket_id = " + TicketId + ";", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con información de especialista en campo work_restriction_info")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConInformacionDeEspecialistaEnCampoWork_Restriction_Info()
        {
            CommonQuery.DBSelectAValue("SELECT work_restriction_info FROM AFLS_WORKORDERS WHERE work_restriction_info = '{\"ProviderId\":null,\"ProviderName\":null,\"WorkCenterName\":\"" + UserSpecialistName + "\",\"WorkCenterId\":" + UserSpecialistId + ",\"AttentionStartDate\":null,\"WorkDayId\":null}' AND ticket_id = " + TicketId + ";", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con información de fecha en campo work_restriction_info y fecha en campo work_restriction_assignment_start_date")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConInformacionDeFechaEnCampoWork_Restriction_InfoYFechaEnCampoWork_Restriction_Assignment_Start_Date()
        {
            string Date = MoreDays.ToString("yyyy-MM-dd") + "T05:00:00.000Z";
            CommonQuery.DBSelectAValue("SELECT work_restriction_info FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_restriction_info = '{\"ProviderId\":null,\"ProviderName\":null,\"WorkCenterName\":null,\"WorkCenterId\":null,\"AttentionStartDate\":\"" + Date + "\",\"WorkDayId\":null}' AND work_restriction_assignment_start_date IS NOT NULL", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con información de jornada mañana en campo work_restriction_info")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConInformacionDeJornadaEnCampoWork_Restriction_Info()
        {
            CommonQuery.DBSelectAValue("SELECT work_restriction_info FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_restriction_info = '{\"ProviderId\":null,\"ProviderName\":null,\"WorkCenterName\":null,\"WorkCenterId\":null,\"AttentionStartDate\":null,\"WorkDayId\":\"1\"}';", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con información de jornada tarde en campo work_restriction_info")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConInformacionDeJornadaTardeEnCampoWork_Restriction_Info()
        {
            CommonQuery.DBSelectAValue("SELECT work_restriction_info FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_restriction_info = '{\"ProviderId\":null,\"ProviderName\":null,\"WorkCenterName\":null,\"WorkCenterId\":null,\"AttentionStartDate\":null,\"WorkDayId\":\"2\"}';", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con información de jornada noche en campo work_restriction_info")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConInformacionDeJornadaNocheEnCampoWork_Restriction_Info()
        {
            CommonQuery.DBSelectAValue("SELECT work_restriction_info FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_restriction_info = '{\"ProviderId\":null,\"ProviderName\":null,\"WorkCenterName\":null,\"WorkCenterId\":null,\"AttentionStartDate\":null,\"WorkDayId\":\"3\"}';", 1);
        }

        [Then(@"Se registra en la tabla AFLS_RELATION_ITEMS el campo ari_source con ticket de orden creada y ari_target con ticket de orden relacionada de tipo sucesión")]
        public void ThenSeRegistraEnLaTablaAFLS_RELATION_ITEMSElCampoAri_SourceConTicketDeOrdenCreadaYAri_TargetConTicketDeOrdenRelacionadaDeTipoSucesion()
        {
            IdTypeRelation = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT ar_id FROM AFLS_RELATION_ITEMS WHERE ari_source = " + TicketId + " AND ari_target = " + RelationTicketId + ";", 1));
            CommonQuery.DBSelectAValue("SELECT ar_id FROM AFLS_RELATIONSHIP WHERE art_id = 1 AND ar_id = " + IdTypeRelation + ";", 1);
        }

        [Then(@"Se registra en la tabla AFLS_RELATION_ITEMS el campo ari_source con ticket de orden creada y ari_target con ticket de orden relacionada de tipo vinculo\.")]
        public void ThenSeRegistraEnLaTablaAFLS_RELATION_ITEMSElCampoAri_SourceConTicketDeOrdenCreadaYAri_TargetConTicketDeOrdenRelacionadaDeTipoVinculo_()
        {
            IdTypeRelation = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT ar_id FROM AFLS_RELATION_ITEMS WHERE ari_source = " + TicketId + " AND ari_target = " + RelationTicketId + ";", 1));
            CommonQuery.DBSelectAValue("SELECT ar_id FROM AFLS_RELATIONSHIP WHERE art_id = 2 AND ar_id = " + IdTypeRelation + ";", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDER_TASKS las tareas del servicio relacionadas a la orden")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDER_TASKSLasTareasDelServicioRelacionadasALaOrden()
        {
            int CantTaskWO = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_WORKORDER_TASKS WHERE wtask_work_id = " + WorkId + ";", 1));
            int CantTaskService = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_SERVICE_TASKS WHERE stask_service_id = " + ServiceId + ";", 1));
            Assert.AreEqual(CantTaskWO, CantTaskService);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS_STOCK_PRODUCTS los productos del servicio relacionadas a la orden")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERS_STOCK_PRODUCTSLosProductosDelServicioRelacionadasALaOrden()
        {
            int CantProductWO = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_WORKORDERS_STOCK_PRODUCTS WHERE work_id = " + WorkId + ";", 1));
            int CantProductServ = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT SUM(srsp_quantity) FROM AFLS_STOCK_SERVICE_PRODUCTS WHERE serv_id = " + ServiceId + ";", 1));
            Assert.AreEqual(CantProductWO, CantProductServ);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección de cita y longitud, latitud y dirección de destino")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConTicket_IdLongitudLatitudYDireccionDeCitaYLongitudLatitudYDireccionDeDestino()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_longitude IS NOT NULL AND work_latitude IS NOT NULL AND work_address IS NOT NULL AND work_end_longitude IS NOT NULL AND work_end_latitude IS NOT NULL AND work_end_address IS NOT NULL;", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con prioridad de emergencia y especialista asignado")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConPrioridadDeEmergenciaYEspecialistaAsignado()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_attendant IS NOT NULL AND work_priority = 1;", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con asignación manual y especialista asignado")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConAsignacionManualYEspecialistaAsignado()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_attendant IS NOT NULL AND work_assignment_type = 1;", 1);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con prioridad de prioridad y especialista asignado")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConPrioridadDePrioridadYEspecialistaAsignado()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_attendant IS NOT NULL AND work_priority = 2;", 1);
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

        [When(@"Selecciono Tipo de Orden Prioritaria de orden")]
        public void WhenSeleccionoTipoDeOrdenPrioritariaDeOrden()
        {
            UtilAction.Click(WorkordersPage.OptionOrderPriority);
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
        }

        [When(@"Selecciono tab Asignación por Restricción")]
        public void WhenSeleccionoTabAsignacionPorRestriccion()
        {
            UtilAction.Click(WorkordersPage.RestrictionAssigmentTab);
            Thread.Sleep(5000);
        }

        [When(@"Selecciono check Proveedor en restricción")]
        public void WhenSeleccionoCheckProveedorEnRestriccion()
        {
            ElementsUtilAction.Click(WorkordersPage.CheckProviderRestriction);
        }

        [When(@"Selecciono check Especialista en restricción")]
        public void WhenSeleccionoCheckEspecialistaEnRestriccion()
        {
            ElementsUtilAction.Click(WorkordersPage.CheckSpecialistRestriction);
        }

        [When(@"Selecciono check Fecha Inicial en restricción")]
        public void WhenSeleccionoCheckFechaInicialEnRestriccion()
        {
            ElementsUtilAction.Click(WorkordersPage.CheckStartDateRestriction);
        }

        [When(@"Selecciono check Jornada en restricción")]
        public void WhenSeleccionoCheckJornadaEnRestriccion()
        {
            ElementsUtilAction.Click(WorkordersPage.CheckTimeofDayRestriction);
        }

        [When(@"Selecciono un especialista del listado resultante")]
        public void WhenSeleccionoUnEspecialistaDelListadoResultante()
        {
            ElementsUtilAction.Click(WorkordersPage.ManualSpecialistCard);
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

        [When(@"Diligencio y selecciono un proveedor para restricción")]
        public void WhenDiligencioYSeleccionoUnProveedorParaRestriccion()
        {
            ProviderName = CommonQuery.DBSelectAValue("SELECT Name FROM AFLS_PROVIDERS WHERE ProviderId = " + ProviderId + ";", 1);
            ElementsUtilAction.SelectDropDownList(WorkordersPage.ProviderRestrictionList, ProviderName, "label");
        }

        [When(@"Diligencio y selecciono un especialista para restricción")]
        public void WhenDiligencioYSeleccionoUnEspecialistaParaRestriccion()
        {
            UserSpecialistName = CommonQuery.DBSelectAValue("SELECT user_name FROM AFW_USERS WHERE user_id = " + UserSpecialistId + ";", 1);
            ElementsUtilAction.Select_ComboboxAutocomplete(WorkordersPage.SpecialistRestrictionList, UserSpecialistName, "a");
        }

        [When(@"Diligencio y selecciono una fecha para restricción")]
        public void WhenDiligencioYSeleccionoUnaFechaParaRestriccion()
        {
            ElementsUtilAction.Click(WorkordersPage.StartDateRestrictionControl);
            Thread.Sleep(2000);

            DateTime Now = DateTime.Now;
            MoreDays = Now.AddDays(2);

            string NewDay = MoreDays.Day.ToString();

            IList<IWebElement> list = CommonHooks.driver.FindElements(By.XPath("//div[@class='xdsoft_datepicker active']/div[@class='xdsoft_calendar']/table/tbody/tr/td/div[contains(text(),'17')]"));
            foreach (IWebElement item in list)
            {
                string TextDay = item.Text;
                if (TextDay == NewDay)
                    item.Click();
            }
        }

        [When(@"Diligencio y selecciono jornada mañana para restricción")]
        public void WhenDiligencioYSeleccionoJornadaMananaParaRestriccion()
        {
            ElementsUtilAction.Click(WorkordersPage.TimeofDayRestrictionMorning);
        }

        [When(@"Diligencio y selecciono jornada tarde para restricción")]
        public void WhenDiligencioYSeleccionoJornadaTardeParaRestriccion()
        {
            ElementsUtilAction.Click(WorkordersPage.TimeofDayRestrictionAfternoon);
        }

        [When(@"Diligencio y selecciono jornada noche para restricción")]
        public void WhenDiligencioYSeleccionoJornadaNocheParaRestriccion()
        {
            ElementsUtilAction.Click(WorkordersPage.TimeofDayRestrictionNight);
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