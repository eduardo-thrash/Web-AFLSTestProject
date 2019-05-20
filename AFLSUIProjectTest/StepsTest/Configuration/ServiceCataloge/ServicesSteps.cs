using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Service_Catalogue
{
    [Binding]
    public class ServicesSteps
    {
        private ServicesPage ServicesPage = new ServicesPage();
        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();

        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        private static string DefaultServiceName = "UI Service";
        private string ServiceName;
        private string EditServiceName;
        private int AdditionalFieldFound = 0;
        private int ServId;
        private int ServiceTypeOld;
        private int ServiceAssigmnetTypeOld;
        private int ServiceTypeNew;
        private int ServiceAssigmnetTypeNew;

        [Given(@"No existe el servicio")]
        public void GivenNoExisteElServicio()
        {
            ServiceName = DefaultServiceName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT serv_name FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 0);
        }

        [Given(@"Existe el servicio")]
        public void GivenExisteElServicio()
        {
            ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES ORDER BY NEWID();", 1);
            ServId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 1));
            ServiceTypeOld = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_type FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 1));
            ServiceAssigmnetTypeOld = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_provider_assignment_type FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 1));
        }

        [When(@"Doy Click en nuevo Servicio")]
        public void WhenDoyClickEnNuevoServicio()
        {
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceButtonNew);
        }

        [When(@"Diligencio nombre de servicio")]
        public void WhenDiligencioNombreDeServicio()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceName, ServiceName);
        }

        [When(@"Selecciono Modelo de servicio")]
        public void WhenSeleccionoModeloDeServicio()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", ServicesPage.ServiceModel, "//div[@id='Model']/ul/li/a/label");
        }

        [When(@"Diligencio descripción del servicio")]
        public void WhenDiligencioDescripcionDelServicio()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceDescription, "description completo");
        }

        [When(@"Diligencio Asunto del servicio")]
        public void WhenDiligencioAsuntoDelServicio()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceSubject, "Asunto completo");
        }

        [When(@"Selecciono Calendario del servicio")]
        public void WhenSeleccionoCalendarioDelServicio()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", ServicesPage.ServiceCalendar, CommonQuery.DBSelectAValue("SELECT TOP 1 cale_name FROM AFLS_CALENDAR WHERE cale_enable = 1 ORDER BY NEWID();", 1), "label");
        }

        [When(@"Selecciono ANS del servicio")]
        public void WhenSeleccionoANSDelServicio()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceSLA, CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE is_deleted = 0 AND agreement_type = 1 ORDER BY NEWID();", 1), "label");
        }

        [When(@"Selecciono UC del servicio")]
        public void WhenSeleccionoUCDelServicio()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceUC, CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE is_deleted = 0 AND agreement_type = 2 ORDER BY NEWID();", 1), "label");
        }

        [When(@"Selecciono OLA del servicio")]
        public void WhenSeleccionoOLADelServicio()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceOLA, CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFLS_SLA WHERE is_deleted = 0 AND agreement_type = 3 ORDER BY NEWID();", 1), "label");
        }

        [When(@"Diligencio Costo base del servicio")]
        public void WhenDiligencioCostoBaseDelServicio()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceCost, "12400");
        }

        [When(@"Selecciono Tipo de servicio Estándar")]
        public void WhenSeleccionoTipoDeServicioEstandar()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceType, "Est", "label");
        }

        [When(@"Selecciono Tipo de servicio Desplazamiento")]
        public void WhenSeleccionoTipoDeServicioDesplazamiento()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceType, "Desplazami", "label");
        }

        [When(@"Selecciono Tipo de asignación servicio de distribución publica")]
        public void WhenSeleccionoTipoDeAsignacionServicioDeDistribucionPublica()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceAssigmentType, "Distr", "label");
        }

        [When(@"Selecciono Tipo de asignación servicio de asignación directa")]
        public void WhenSeleccionoTipoDeAsignacionServicioDeAsignacionDirecta()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceAssigmentType, "Asignac", "label");
        }

        [When(@"Doy click en switch de estado de servicio")]
        public void WhenDoyClickEnSwitchDeEstadoDeServicio()
        {
            CommonElementsAction.Click("XPath", ServicesPage.ServiceState);
        }

        [When(@"Selecciono check de brindar el servicio a todos los clientes")]
        public void WhenSeleccionoCheckDeBrindarElServicioATodosLosClientes()
        {
            CommonElementsAction.Click("XPath", ServicesPage.ServiceCheckIsDefault);
        }

        [When(@"Selecciono check de Habilitar ordenes de emergencia para este servicio")]
        public void WhenSeleccionoCheckDeHabilitarOrdenesDeEmergenciaParaEsteServicio()
        {
            CommonElementsAction.Click("XPath", ServicesPage.ServiceCheckIsPriorityOrEmergency);
        }

        [When(@"Diligencio Horas de servicio")]
        public void WhenDiligencioHorasDeServicio()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceHours, "1");
        }

        [When(@"Diligencio Minutos de servicio")]
        public void WhenDiligencioMinutosDeServicio()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceMinutes, "30");
        }

        [When(@"Selecciono el Tab de Inventario de servicio")]
        public void WhenSeleccionoElTabDeInventarioDeServicio()
        {
            CommonElementsAction.Click("XPath", ServicesPage.ServiceTabInventory);
        }

        [When(@"Selecciono el Tab de Habilidades de servicio")]
        public void WhenSeleccionoElTabDeHabilidadesDeServicio()
        {
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceTabSkills);
        }

        [When(@"Selecciono el Tab de Proveedores de servicio")]
        public void WhenSeleccionoElTabDeProveedoresDeServicio()
        {
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceTabProviders);
        }

        [When(@"Selecciono el Tab de Tareas de servicio")]
        public void WhenSeleccionoElTabDeTareasDeServicio()
        {
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceTabTasks);
        }

        [When(@"Selecciono el Tab de Campos adicionales de servicio")]
        public void WhenSeleccionoElTabDeCamposAdicionalesDeServicio()
        {
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceTabAdditionalFields);
        }

        [When(@"Selecciono el Tab de Servicio de servicio")]
        public void WhenSeleccionoElTabDeServicioDeServicio()
        {
            CommonElementsAction.Click("XPath", ServicesPage.ServiceTabService);
        }

        [When(@"Doy click en Guardar servicio")]
        public void WhenDoyClickEnGuardarServicio()
        {
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceSubmit);
            Thread.Sleep(3000);
        }

        [When(@"Diligencio y selecciono producto tipo cantidad para servicio")]
        public void WhenDiligencioYSeleccionoProductoTipoCantidadParaServicio()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ServicesPage.ServiceInventorySearch, CommonQuery.DBSelectAValue("SELECT TOP 1 prod_name FROM AFLS_STOCK_PRODUCTS WHERE prod_type = 0 ORDER BY NEWID();", 1), "a");
        }

        [When(@"Diligencio y selecciono producto tipo único para servicio")]
        public void WhenDiligencioYSeleccionoProductoTipoUnicoParaServicio()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ServicesPage.ServiceInventorySearch, CommonQuery.DBSelectAValue("SELECT TOP 1 prod_name FROM AFLS_STOCK_PRODUCTS WHERE prod_type = 1 ORDER BY NEWID();", 1), "a");
        }

        [When(@"Diligencio y selecciono Habilidad para servicio")]
        public void WhenDiligencioYSeleccionoHabilidadParaServicio()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ServicesPage.ServiceInputSkillsSearch, CommonQuery.DBSelectAValue("SELECT TOP 1 skll_name FROM AFLS_SKILLS WHERE skll_isActive = 1 ORDER BY NEWID();", 1), "a");
        }

        [When(@"Diligencio y selecciono proveedor para servicio")]
        public void WhenDiligencioYSeleccionoProveedorParaServicio()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", ServicesPage.ServiceProvidersSearch, CommonQuery.DBSelectAValue("SELECT TOP 1 Name FROM AFLS_PROVIDERS WHERE IsActive = 1 AND IsDeleted = 0 ORDER BY NEWID();", 1), "a");
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", ServicesPage.ServiceProviderAgreement, ServicesPage.ServiceProviderAgreementList);
        }

        [When(@"Diligencio nombre de nueva tarea para servicio")]
        public void WhenDiligencioNombreDeNuevaTareaParaServicio()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ServicesPage.ServiceTasksSearch, "Tarea de instalacion");
        }

        [When(@"Doy click en Agregar tarea para servicio")]
        public void WhenDoyClickEnAgregarTareaParaServicio()
        {
            CommonElementsAction.Click("XPath", ServicesPage.ServiceButtonTaskAdd);
        }

        [When(@"Diligencio campos adicionales de servicio")]
        public int WhenDiligencioCamposAdicionalesDeServicio()
        {
            try
            {
                IList<IWebElement> AFServicesListInputText = CommonHooks.driver.FindElements(By.XPath("//div[@class='services']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@class='js-input-additional-field k-valid' and @type='text']"));
                foreach (IWebElement AFService in AFServicesListInputText)
                {
                    AFService.Clear();
                    AFService.SendKeys(Functions.RandomText(10));
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFServicesListTextarea = CommonHooks.driver.FindElements(By.XPath("//div[@class='services']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//textarea"));
                foreach (IWebElement AFService in AFServicesListTextarea)
                {
                    AFService.Clear();
                    AFService.SendKeys("Texto parrafo");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFServicesListNumber = CommonHooks.driver.FindElements(By.XPath("//div[@class='services']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@type='number']"));
                foreach (IWebElement AFService in AFServicesListNumber)
                {
                    AFService.Clear();
                    AFService.SendKeys("123456");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFServicesListDate = CommonHooks.driver.FindElements(By.XPath("//div[@class='services']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//span[@class='k-icon k-i-calendar']"));
                foreach (IWebElement AFService in AFServicesListDate)
                {
                    AFService.Click();
                    CommonElementsAction.Click("XPath", "//div[@class='k-widget k-calendar']/table/tbody/tr/td/a");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFServicesListSelect = CommonHooks.driver.FindElements(By.XPath("//div[@class='services']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//select"));
                foreach (IWebElement AFService in AFServicesListSelect)
                {
                    new SelectElement(AFService).SelectByIndex(1);
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

        [Then(@"Se registra el servicio en la tabla AFLS_SERVICES")]
        public void ThenSeRegistraElServicioEnLaTablaAFLS_SERVICES()
        {
            ServId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 1));
        }

        [Then(@"Se registra el servicio en la tabla AFLS_SERVICES de tipo estándar")]
        public void ThenSeRegistraElServicioEnLaTablaAFLS_SERVICESDeTipoEstandar()
        {
            ServId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "' AND serv_type = 2;", 1));
        }

        [Then(@"Se registra el servicio en la tabla AFLS_SERVICES de tipo desplazamiento")]
        public void ThenSeRegistraElServicioEnLaTablaAFLS_SERVICESDeTipoDesplazamiento()
        {
            ServId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "' AND serv_type = 1;", 1));
        }

        [Then(@"Se registra el servicio en la tabla AFLS_SERVICES de asignación directa")]
        public void ThenSeRegistraElServicioEnLaTablaAFLS_SERVICESDeAsignacionDirecta()
        {
            ServId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "' AND serv_provider_assignment_type = 1;", 1));
        }

        [Then(@"Se registra el servicio en la tabla AFLS_SERVICES de distribución publica")]
        public void ThenSeRegistraElServicioEnLaTablaAFLS_SERVICESDeDistribucionPublica()
        {
            ServId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_id FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "' AND serv_provider_assignment_type = 2;", 1));
        }

        [Then(@"Se registra el producto de tipo cantidad asociado al servicio en la tabla AFLS_STOCK_SERVICE_PRODUCTS")]
        public void ThenSeRegistraElProductoDeTipoCantidadAsociadoAlServicioEnLaTablaAFLS_STOCK_SERVICE_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_SERVICE_PRODUCTS SEP JOIN AFLS_STOCK_PRODUCTS STP ON SEP.prod_id = STP.prod_id WHERE SEP.serv_id = " + ServId + " AND STP.prod_type = 0", 1);
        }

        [Then(@"Se registra el producto de tipo único asociado al servicio en la tabla AFLS_STOCK_SERVICE_PRODUCTS")]
        public void ThenSeRegistraElProductoDeTipoUnicoAsociadoAlServicioEnLaTablaAFLS_STOCK_SERVICE_PRODUCTS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_STOCK_SERVICE_PRODUCTS SEP JOIN AFLS_STOCK_PRODUCTS STP ON SEP.prod_id = STP.prod_id WHERE SEP.serv_id = " + ServId + " AND STP.prod_type = 1", 1);
        }

        [Then(@"Se registra la habilidad asociada al servicio en la tabla AFLS_SERVICES_SKILLS")]
        public void ThenSeRegistraLaHabilidadAsociadaAlServicioEnLaTablaAFLS_SERVICES_SKILLS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SERVICES_SKILLS WHERE service_id = " + ServId + ";", 1);
        }

        [Then(@"Se registra el proveedor asociado al servicio en la tabla AFLS_PROVIDER_SERVICES")]
        public void ThenSeRegistraElProveedorAsociadoAlServicioEnLaTablaAFLS_PROVIDER_SERVICES()
        {
            try
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDER_SERVICES WHERE ServiceId = " + ServId + ";", 1);
            }
            catch
            {
                Assert.Fail("Sin resultados en SELECT * FROM AFLS_PROVIDER_SERVICES WHERE ServiceId = " + ServId + ".");
            }
        }

        [Then(@"se registran campos adicionales de servicio diligenciados en la tabla AFW_ADDITIONAL_FIELD_VALUE")]
        public void ThenSeRegistranCamposAdicionalesDeServicioDiligenciadosEnLaTablaAFW_ADDITIONAL_FIELD_VALUE()
        {
            int AdditionalFieldServicesResult = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_VALUE AFV ON AFV.field_id = AF.id WHERE AF.definition_id = 4 AND AFV.item_id = " + ServId + ";", 1));

            Assert.AreEqual(AdditionalFieldFound, AdditionalFieldServicesResult);
        }

        [Then(@"Se registra la tarea asociada al servicio en la tabla AFLS_SERVICE_TASKS")]
        public void ThenSeRegistraLaTareaAsociadaAlServicioEnLaTablaAFLS_SERVICE_TASKS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SERVICE_TASKS WHERE stask_service_id = " + ServId + ";", 1);
        }

        [When(@"Creación exitosa de servicio, asociación de inventario, tareas, proveedores, habilidades y diligenciamiento de campos adicionales")]
        public void WhenCreacionExitosaDeServicioAsociacionDeInventarioTareasProveedoresHabilidadesYDiligenciamientoDeCamposAdicionales()
        {
            CommonElementsAction.Click("XPath", ServicesPage.ServiceCheckIsDefault);

            ///     And accedo al tab Inventario y asocio un producto

            ///     And accedo al tab Habilidades y asocio una habilidad

            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ServicesPage.ServiceInputSkillsSearch, "Automatizacion", "a");

            ///     And accedo al tab Proveedores y asocio un proveedor

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", ServicesPage.ServiceProvidersSearch, "Especialistas Internos", "a");

            CommonElementsAction.ClickAndSelect_DropDownList("XPath", ServicesPage.ServiceProviderAgreement, "General", "label");

            ///     And accedo al tab Tareas y asocio una Tarea

            ///     And accedo al tab Campo adicionales y diligencio un campo adicional

            CommonElementsAction.SendKeys_InputText("XPath", ServicesPage.ServiceAdditionalFieldInputDefault, "Campo de tipo texto simple");

            //Save
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"Creación exitosa de servicio tipo estandar")]
        public void WhenCreacionExitosaDeServicioTipoEstandar()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceButtonNew);
            //End Navigate Module Content

            ///     And diligencio los datos del tab Servicio
            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceName, "Servicio estandar");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceModel, "Modelo Principal", "label");

            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceDescription, "description estandar");

            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceSubject, "Asunto estandar");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceCalendar, "AFLS 5x8", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceSLA, "ANS General", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceUC, "UC General", "label");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceOLA, "OLA General", "label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceCost, "12400");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceType, "Est", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceAssigmentType, "Asignac", "label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceHours, "1");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceMinutes, "30");

            ///     And accedo al tab Habilidades y asocio una habilidad
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ServicesPage.ServiceInputSkillsSearch, "Automatizacion", "a");

            //Save
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"Creación exitosa de servicio tipo desplazamiento")]
        public void WhenCreacionExitosaDeServicioTipoDesplazamiento()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceButtonNew);
            //End Navigate Module Content

            ///     And diligencio los datos del tab Servicio
            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceName, "Servicio desplazamiento");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceModel, "Modelo Principal", "label");

            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceDescription, "description desplazamiento");

            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceSubject, "Asunto desplazamiento");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceCalendar, "AFLS 5x8", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceSLA, "ANS General", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceUC, "UC General", "label");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceOLA, "OLA General", "label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceCost, "12400");

            CommonElementsAction.Click("XPath", ServicesPage.ServiceCheckIsDefault);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceHours, "1");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceMinutes, "30");

            ///     And accedo al tab Habilidades y asocio una habilidad
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ServicesPage.ServiceInputSkillsSearch, "Automatizacion", "a");

            //Save
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"Creación exitosa de servicios tipo asignación directa")]
        public void WhenCreacionExitosaDeServiciosTipoAsignacionDirecta()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceButtonNew);
            //End Navigate Module Content

            ///     And diligencio los datos del tab Servicio
            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceName, "Servicio asignación directa");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceModel, "Modelo Principal", "label");

            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceDescription, "description asignación directa");

            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceSubject, "Asunto asignación directa");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceCalendar, "AFLS 5x8", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceSLA, "ANS General", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceUC, "UC General", "label");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceOLA, "OLA General", "label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceCost, "12400");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceType, "Desplazami", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceAssigmentType, "Asignac", "label");
            CommonElementsAction.Click("XPath", ServicesPage.ServiceCheckIsDefault);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceHours, "1");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceMinutes, "30");

            ///     And accedo al tab Habilidades y asocio una habilidad
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ServicesPage.ServiceInputSkillsSearch, "Automatizacion", "a");

            //Save
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"Creación exitosa de servicios tipo distribución publica")]
        public void WhenCreacionExitosaDeServiciosTipoDistribucionPublica()
        {
            //Login.

            //End Login.

            //Navigate SubMenu and selected option.

            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceButtonNew);
            //End Navigate Module Content

            ///     And diligencio los datos del tab Servicio
            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceName, "Servicio Distribución publica");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceModel, "Modelo Principal", "label");

            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceDescription, "description Distribución publica");

            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceSubject, "Asunto Distribución publica");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceCalendar, "AFLS 7X24", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceSLA, "ANS General", "label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceUC, "UC General", "label");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceOLA, "OLA General", "label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceCost, "12400");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceType, "Desplazami", "label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceHours, "1");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceMinutes, "30");

            ///     And accedo al tab Habilidades y asocio una habilidad
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ServicesPage.ServiceInputSkillsSearch, "Automatizacion", "a");

            //Save
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }

        [When(@"Busco y selecciono el servicio")]
        public void WhenBuscoYSeleccionoElServicio()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceFieldSearch, ServiceName);
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceButtonSearch);
            Thread.Sleep(3000);

            UtilAction.Click(ServicesPage.ServiceView);
        }

        [Then(@"Se muestra la tarjeta del servicio y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelServicioYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ServicesPage.ServiceName)).GetAttribute("value");
            Assert.AreEqual(ServiceName, Value);
        }

        [When(@"Edito nombre de servicio")]
        public void WhenEditoNombreDeServicio()
        {
            EditServiceName = EditServiceName + Functions.RandomText(4);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", ServicesPage.ServiceName, EditServiceName);
        }

        [When(@"Edito tipo de servicio")]
        public void WhenEditoTipoDeServicio()
        {
            ///     And modifico el tipo de servicio
            string GetServiceType = CommonHooks.driver.FindElement(By.CssSelector(ServicesPage.ServiceType)).Text;

            if (GetServiceType.Contains("Est"))
            {
                //CommonElementsAction.Click("CssSelector", ServicesPage.ServiceType);
                CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceType, "Despl", "label");
            }
            if (GetServiceType.Contains("Despl"))
            {
                //CommonElementsAction.Click("CssSelector", ServicesPage.ServiceType);
                CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceType, "Est", "label");
            }
        }

        [When(@"Edito tipo de asignación de servicio")]
        public void WhenEditoTipoDeAsignacionDeServicio()
        {
            ///     And modifico el tipo de asignación
            string GetAssigmentType = CommonHooks.driver.FindElement(By.CssSelector(ServicesPage.ServiceAssigmentType)).Text;

            if (GetAssigmentType.Contains("Asign"))
            {
                //CommonElementsAction.Click("CssSelector", ServicesPage.ServiceAssigmentType);
                CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceAssigmentType, "Distr", "label");
            }
            if (GetAssigmentType.Contains("Dist"))
            {
                //CommonElementsAction.Click("CssSelector", ServicesPage.ServiceAssigmentType);
                CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", ServicesPage.ServiceAssigmentType, "Asign", "label");
            }
        }

        [Then(@"Se registra el servicio modificado en nombre, tipo de servicio y tipo de asignación de servicio en la tabla AFLS_SERVICES")]
        public void ThenSeRegistraElServicioModificadoEnNombreTipoDeServicioYTipoDeAsignacionDeServicioEnLaTablaAFLS_SERVICES()
        {
            ServiceTypeNew = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_type FROM AFLS_SERVICES WHERE serv_name = '" + EditServiceName + "';", 1));
            ServiceAssigmnetTypeNew = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT serv_provider_assignment_type FROM AFLS_SERVICES WHERE serv_name = '" + EditServiceName + "';", 1));

            Assert.AreNotEqual(ServiceTypeOld, ServiceTypeNew);
            Assert.AreNotEqual(ServiceAssigmnetTypeOld, ServiceAssigmnetTypeNew);
        }

        [When(@"Doy click en eliminar Servicio")]
        public void WhenDoyClickEnEliminarServicio()
        {
            CommonElementsAction.Click("XPath", ServicesPage.ServiceIconRemoved);

            Thread.Sleep(2000);
        }

        [Then(@"Se borra el registro del servicio en la tabla AFLS_SERVICES")]
        public void ThenSeBorraElRegistroDelServicioEnLaTablaAFLS_SERVICES()
        {
            CommonQuery.DBSelectAValue("SELECT serv_name FROM AFLS_SERVICES WHERE serv_name = '" + ServiceName + "';", 0);
        }

        [Then(@"Al buscar el servicio en la aplicación no se lista")]
        public void ThenAlBuscarElServicioEnLaAplicacionNoSeLista()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ServicesPage.ServiceFieldSearch, ServiceName);
            CommonElementsAction.Click("CssSelector", ServicesPage.ServiceButtonSearch);
            Thread.Sleep(3000);

            CommonElementsAction.WaitElementNoFound(ServicesPage.ServiceView, "CssSelector");
        }
    }
}