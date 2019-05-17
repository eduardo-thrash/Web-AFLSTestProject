using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class ClientsSteps
    {
        private readonly ClientsPage ClientsPage = new ClientsPage();
        private readonly PageMessages PageMessages = new PageMessages();
        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        private string user_nickname;
        private string Edit_user_name;
        private string Edit_user_nickname;
        private int UserId;
        private int Service;
        private int ServId;
        private string Defaul_user_name = "UI Client";
        private int AdditionalFieldFound = 0;
        private string ClientCompany;

        [Given(@"El cliente no existe")]
        public void GivenElClienteNoExiste()
        {
            user_nickname = Functions.RandomText(8);
            CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = '" + user_nickname + "';", 0);
        }

        [Given(@"El cliente existe")]
        public void GivenElClienteExiste()
        {
            user_nickname = CommonQuery.DBSelectAValue("SELECT TOP 1 USR.user_nick_name FROM AFW_USERS USR JOIN AFLS_USERS_CLIENTS UCL ON USR.user_id = UCL.user_id WHERE USR.user_active = 1 ORDER BY NEWID();", 1);
        }

        [When(@"Doy click en Nuevo Cliente")]
        public void WhenDoyClickEnNuevoCliente()
        {
            Thread.Sleep(10000);
            CommonElementsAction.Click("CssSelector", ClientsPage.ClientButtonNew);
        }

        [Given(@"Existe al menos una compañía")]
        public void GivenExisteAlMenosUnaCompania()
        {
            try
            {
                ClientCompany = CommonQuery.DBSelectAValue("SELECT TOP 1 comp_name FROM AFLS_COMPANIES WHERE comp_active = 1 ORDER BY NEWID();", 1);
            }
            catch
            {
                Assert.Fail("No existen compañías. Se requieren para la prueba.");
            }
        }

        [Given(@"El cliente existe sin compañía asociada")]
        public void GivenElClienteExisteSinCompaniaAsociada()
        {
            try
            {
                UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 user_id FROM AFLS_USERS_CLIENTS WHERE comp_id IS NULL ORDER BY NEWID();", 1));
                user_nickname = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_id = " + UserId + ";", 1);
            }
            catch
            {
                Assert.Fail("No existen clientes sin compañía. Se requieren para la prueba.");
            }
        }

        [Then(@"Se registra el cliente modificado con compañía asociada en la tabla AFLS_USER_CLIENTS")]
        public void ThenSeRegistraElClienteModificadoConCompaniaAsociadaEnLaTablaAFLS_USER_CLIENTS()
        {
            try
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USERS_CLIENTS WHERE comp_id IS NOT NULL AND user_id = " + UserId + ";", 1);
            }
            catch
            {
                Assert.Fail("Compañía no asociada. Se requiere para la prueba.");
            }
        }

        [Given(@"El canal de AssistMe esta habilitado")]
        public void GivenElCanalDeAssistMeEstaHabilitado()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_ASSISTME_CONFIGURATION WHERE IsActive = 1;", 1);
        }

        [When(@"Busco y selecciono el cliente")]
        public void WhenBuscoYSeleccionoElCliente()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ClientsPage.ClientFieldSearch, user_nickname);
            CommonElementsAction.Click("XPath", ClientsPage.ClientButtonSearch);
            Thread.Sleep(5000);
            CommonElementsAction.Click("XPath", ClientsPage.ClientView);
        }

        [Then(@"Se muestra la tarjeta del cliente y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelClienteYElDetalleDelMismo()
        {
            Thread.Sleep(2000);
            string Value = CommonElementsAction.VallueExtract("XPath", ClientsPage.ClientUniqueReference);
            Assert.AreEqual(user_nickname, Value);
        }

        [When(@"Selecciono el Tab de Cliente")]
        public void WhenSeleccionoElTabDeCliente()
        {
            CommonElementsAction.Click("CssSelector", ClientsPage.ClientTabClient);
        }

        [When(@"Diligencio nombre de cliente")]
        public void WhenDiligencioNombreDeCliente()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ClientsPage.ClientName, Defaul_user_name + Functions.RandomText(3));
        }

        [When(@"Edito nombre de cliente")]
        public void WhenEditoNombreDeCliente()
        {
            Edit_user_name = "Edit client " + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", ClientsPage.ClientName, Edit_user_name);
        }

        [When(@"Edito código único de cliente")]
        public void WhenEditoCodigoUnicoDeCliente()
        {
            Edit_user_nickname = "Edit CU " + Functions.RandomText(6);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", ClientsPage.ClientUniqueReference, Edit_user_nickname);
        }

        [When(@"Diligencio código único de cliente")]
        public void WhenDiligencioCodigoUnicoDeCliente()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ClientsPage.ClientUniqueReference, user_nickname);
        }

        [When(@"Diligencio teléfono de cliente")]
        public void WhenDiligencioTelefonoDeCliente()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ClientsPage.ClientPhone, "3008657473");
        }

        [When(@"Diligencio correo electrónico de cliente")]
        public void WhenDiligencioCorreoElectronicoDeCliente()
        {
            CommonElementsAction.SendKeys_InputText("XPath", ClientsPage.ClientEmail, "reyes@company.com");
        }

        [When(@"Diligencio y selecciono una compañía para cliente")]
        public void WhenDiligencioYSeleccionoUnaCompaniaParaCliente()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ClientsPage.ClientComapny, CommonQuery.DBSelectAValue("SELECT TOP 1 comp_name FROM AFLS_COMPANIES WHERE comp_active = 1 ORDER BY NEWID();", 1), "a");
        }

        [When(@"Diligencio y selecciono una compañía para modificación de cliente")]
        public void WhenDiligencioYSeleccionoUnaCompaniaParaModificacionDeCliente()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ClientsPage.ClientComapny, ClientCompany, "a");
        }

        [When(@"Diligencio dirección de cliente")]
        public void WhenDiligencioDireccionDeCliente()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", ClientsPage.ClientAddress, "calle 59 # 35a-68,Of 567");
        }

        [When(@"Diligencio dirección de cliente dando click en cursor")]
        public void WhenDiligencioDireccionDeClienteDandoClickEnCursor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ClientsPage.ClientAddress, "calle 59 # 35a-68,Of 567");
            CommonElementsAction.Click("CssSelector", ClientsPage.ClientAddress);
        }

        [When(@"Diligencio dirección de cliente dando enter")]
        public void WhenDiligencioDireccionDeClienteDandoEnter()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", ClientsPage.ClientAddress, "calle 59 # 35a-68,Of 567");
        }

        [When(@"Diligencio dirección de cliente dando tab")]
        public void WhenDiligencioDireccionDeClienteDandoTab()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ClientsPage.ClientAddress, "calle 59 # 35a-68,Of 567");
            CommonHooks.driver.FindElement(By.CssSelector(ClientsPage.ClientAddress)).SendKeys(Keys.Tab);
        }

        [When(@"Diligencio detalle de dirección de cliente")]
        public void WhenDiligencioDetalleDeDireccionDeCliente()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ClientsPage.ClientAddressDetail, "Piso 74");
        }

        [When(@"Doy click en switch de estado de cliente")]
        public void WhenDoyClickEnSwitchDeEstadoDeCliente()
        {
            CommonElementsAction.Click("XPath", ClientsPage.ClientState);
        }

        [When(@"Selecciono el Tab de Servicios")]
        public void WhenSeleccionoElTabDeServicios()
        {
            CommonElementsAction.Click("CssSelector", ClientsPage.ClientTabServices);
        }

        [When(@"Diligencio y selecciono el servicio para cliente")]
        public int WhenDiligencioYSeleccionoElServicioParaCliente()
        {
            Actions action = new Actions(CommonHooks.driver);
            IWebElement ServicesClient = CommonHooks.driver.FindElement(By.XPath(ClientsPage.ClientServices));
            action.MoveToElement(ServicesClient);

            ServId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 serv_id FROM AFLS_SERVICES ORDER BY NEWID();", 1));
            string ServName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_id = " + ServId + ";", 1);
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", ClientsPage.ClientServices, ServName, "a");
            return ServId;
        }

        [When(@"Selecciono el Tab de Firma de cliente")]
        public void WhenSeleccionoElTabDeFirmaDeCliente()
        {
            CommonElementsAction.Click("CssSelector", ClientsPage.ClientTabSignature);
        }

        [When(@"Selecciono el Tab de Campos adicionales")]
        public void WhenSeleccionoElTabDeCamposAdicionales()
        {
            CommonElementsAction.Click("CssSelector", ClientsPage.ClientTabAdditionalFields);
        }

        [When(@"Diligencio campos adicionales de cliente")]
        public int WhenDiligencioCamposAdicionalesDeCliente()
        {
            try
            {
                IList<IWebElement> AFClientsListInputText = CommonHooks.driver.FindElements(By.XPath("//div[@class='clients']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@class='js-input-additional-field k-valid' and @type='text']"));
                foreach (IWebElement AFClient in AFClientsListInputText)
                {
                    AFClient.Clear();
                    AFClient.SendKeys(Functions.RandomText(10));
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFClientsListTextarea = CommonHooks.driver.FindElements(By.XPath("//div[@class='clients']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//textarea"));
                foreach (IWebElement AFClient in AFClientsListTextarea)
                {
                    AFClient.Clear();
                    AFClient.SendKeys("Texto parrafo");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFClientsListNumber = CommonHooks.driver.FindElements(By.XPath("//div[@class='clients']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@type='number']"));
                foreach (IWebElement AFClient in AFClientsListNumber)
                {
                    AFClient.Clear();
                    AFClient.SendKeys("123456");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFClientsListDate = CommonHooks.driver.FindElements(By.XPath("//div[@class='clients']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//span[@class='k-icon k-i-calendar']"));
                foreach (IWebElement AFClient in AFClientsListDate)
                {
                    AFClient.Click();
                    CommonElementsAction.Click("XPath", "//div[@class='k-widget k-calendar']/table/tbody/tr/td/a");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFClientsListSelect = CommonHooks.driver.FindElements(By.XPath("//div[@class='clients']//div[@id='tabs-6']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//select"));
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

        [Given(@"El cliente existe con canal de AssistMe habilitado")]
        public void GivenElClienteExisteConCanalDeAssistMeHabilitado()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT USR.user_id FROM AFLS_USERS_CHANNEL UCH JOIN AFW_USERS USR ON UCH.IdUser = USR.user_id WHERE USR.user_email IS NOT NULL AND UCH.IsActive = 1 ORDER BY NEWID();", 1));
            user_nickname = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_id = " + UserId + ";", 1);
        }

        [When(@"Selecciono el Tab de Canales")]
        public void WhenSeleccionoElTabDeCanales()
        {
            CommonElementsAction.Click("CssSelector", ClientsPage.ClientTabChannels);
        }

        [When(@"Doy click en botón de envío de correo a cliente")]
        public void WhenDoyClickEnBotonDeEnvioDeCorreoACliente()
        {
            CommonElementsAction.Click("XPath", "//div[@id='tabs-7']//button[@class='send-inv-btn']");
            Thread.Sleep(6000);
        }

        [When(@"Acepto el envío de correo")]
        public void WhenAceptoElEnvioDeCorreo()
        {
            CommonElementsAction.Click("XPath", "//div[3]/div/button/span");
        }

        [Then(@"Se registra el mensaje de correo en la tabla AFW_MAIL sin enviar a cliente aún")]
        public void ThenSeRegistraElMensajeDeCorreoEnLaTablaAFW_MAILSinEnviarAClienteAun()
        {
            string user_mail = CommonQuery.DBSelectAValue("SELECT user_email FROM  AFW_USERS WHERE user_id = " + UserId + ";", 1);
            try
            {
                CommonQuery.DBSelectAValue("SELECT TOP 1 mail_receiver FROM AFW_MAIL WHERE mail_receiver = '" + user_mail + "' ORDER BY 1 DESC;", 1);
            }
            catch
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFW_MAIL_HISTORY WHERE mahi_receiver = '" + user_mail + "';", 1);
            }
        }

        [When(@"Doy click en Guardar cliente")]
        public void WhenDoyClickEnGuardarCliente()
        {
            CommonElementsAction.Click("CssSelector", ClientsPage.ClientSubmit);
        }

        [Then(@"Se registra el usuario cliente en la tabla AFW_USERS")]
        public int ThenSeRegistraElUsuarioClienteEnLaTablaAFW_USERS()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT user_id FROM AFW_USERS WHERE user_nick_name = '" + user_nickname + "';", 1));
            return UserId;
        }

        [Then(@"Se registra el usuario cliente modificado en código único y nombre en la tabla AFW_USERS")]
        public void ThenSeRegistraElUsuarioClienteModificadoEnCodigoUnicoYNombreEnLaTablaAFW_USERS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_USERS WHERE user_nick_name = '" + Edit_user_nickname + "' AND user_name = '" + Edit_user_name + "';", 1);
        }

        [Then(@"Se muestra un mensaje indicando que se envío correo a email de cliente")]
        public void ThenSeMuestraUnMensajeIndicandoQueSeEnvioCorreoAEmailDeCliente()
        {
            Assert.IsTrue(CommonElementsAction.TextExtract("XPath", "//div[@id='growls']/div/div[@class='growl-message']").Contains(MessagesCopies.SuccessResponseClientEmailSend));
        }

        [Then(@"Se registra el cliente en la tabla AFLS_USER_CLIENTS")]
        public void ThenSeRegistraElClienteEnLaTablaAFLS_USER_CLIENTS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USERS_CLIENTS WHERE user_id = " + UserId + ";", 1);
        }

        [Then(@"Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección")]
        public void ThenSeRegistraElClienteEnLaTablaAFLS_USER_CLIENTSConLongitudLatitudYDireccion()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USERS_CLIENTS WHERE user_id = " + UserId + " AND clie_longitude IS NOT NULL AND clie_latitude IS NOT NULL AND clie_address IS NOT NULL;", 1);
        }

        [Then(@"Se registra la compañía asociada a cliente en la tabla AFLS_USER_CLIENTS")]
        public void ThenSeRegistraLaCompaniaAsociadaAClienteEnLaTablaAFLS_USER_CLIENTS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USERS_CLIENTS WHERE user_id = " + UserId + " AND comp_id IS NOT NULL;", 1);
        }

        [Then(@"Se registra el servicio asociado a cliente en la tabla AFLS_CLIENT_SERVICES")]
        public void ThenSeRegistraElServicioAsociadoAClienteEnLaTablaAFLS_CLIENT_SERVICES()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_CLIENT_SERVICES WHERE serv_id = " + ServId + " AND clie_id = " + UserId + ";", 1);
        }

        [Then(@"se registran campos adicionales de cliente diligenciados en la tabla AFW_ADDITIONAL_FIELD_VALUE")]
        public void ThenSeRegistranCamposAdicionalesDeClienteDiligenciadosEnLaTablaAFW_ADDITIONAL_FIELD_VALUE()
        {
            //int AdditionalFieldClientsExpect = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD WHERE is_active = 1 AND definition_id = 3;", 1));
            int AdditionalFieldClientsResult = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD_VALUE WHERE item_id = " + UserId + ";", 1));

            Assert.AreEqual(AdditionalFieldFound, AdditionalFieldClientsResult);
        }

        [Then(@"se muestra cliente con canal de AssistMe habilitado")]
        public void ThenSeMuestraClienteConCanalDeAssistMeHabilitado()
        {
        }

        [When(@"Búsqueda exitosa de cliente existente")]
        public void WhenBusquedaExitosaDeClienteExistente()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en eliminar cliente")]
        public void WhenDoyClickEnEliminarCliente()
        {
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", ClientsPage.ClientIconRemoved);
        }

        [Then(@"se elimina el registro de usuario cliente de la tabla AFW_USERS")]
        public void ThenSeEliminaElRegistroDeUsuarioClienteDeLaTablaAFW_USERS()
        {
            CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = '" + user_nickname + "';", 0);
        }

        [Then(@"Al buscar el cliente en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElClienteEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", ClientsPage.ClientFieldSearch, user_nickname);
            CommonElementsAction.Click("XPath", ClientsPage.ClientButtonSearch);
            Thread.Sleep(3000);
            CommonElementsAction.WaitElementNoFound(ClientsPage.ClientView);
        }
    }
}