using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Messages;
using AFLSUIProjectTest.UIMap.Orders;
using CommonTest.CommonTest;
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
            ServiceName = CommonQuery.DBSelectAValue("SELECT SER.serv_name FROM AFLS_CLIENT_SERVICES CLS JOIN AFLS_SERVICES SER ON SER.serv_id = CLS.serv_id WHERE CLS.clie_id = (SELECT user_id FROM AFW_USERS WHERE user_name = '" + ClientName + "');", 1);
        }

        [When(@"Accedo a ítem Nueva orden")]
        public void WhenAccedoAItemNuevaOrden()
        {
            CommonElementsAction.Click("XPath", PrincipalMenuPage.ItemNewOrder);
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
            ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 SER.serv_name FROM AFLS_SERVICES SER JOIN AFLS_CLIENT_SERVICES CLS ON SER.serv_id = CLS.serv_id WHERE SER.serv_active = 1 AND CLS.clie_id = (SELECT TOP 1 USER_ID FROM AFW_USERS WHERE user_name = '" + ClientName + "') ORDER BY NEWID();", 1);
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", WorkordersPage.ServiceName, ServiceName, "a");
        }

        [When(@"Selecciono Tipo de Orden Normal de orden")]
        public void WhenSeleccionoTipoDeOrdenNormalDeOrden()
        {
            CommonElementsAction.Click("XPath", WorkordersPage.OptionOrderNormal);
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
    }
}