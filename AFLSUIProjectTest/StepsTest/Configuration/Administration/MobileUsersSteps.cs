using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;

using CommonTest.CommonTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.Configuration.Administration
{
    [Binding]
    public class MobileUsersSteps
    {
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private MobileUsersPage MobileUsersPage = new MobileUsersPage();

        private string user_nickname = "ui.eduardo.mobile";
        private string user_name = "Ui Eduardo Montenegro Mobile";

        [Given(@"No existe el usuario móvil")]
        public void GivenNoExisteElUsuarioMovil()

        {
            CommonQuery.DBSelectAValue("SELECT * FROM  AFW_USERS WHERE user_nick_name = '" + user_nickname + "';",0);
        }

        [When(@"Accedo a ítem Configuración")]
        public void WhenAccedoAItemConfiguracion()
        {
            CommonElementsAction.Click("XPath",PrincipalMenuPage.ItemConfiguration);
        }

        [When(@"Accedo al menú Administración")]
        public void WhenAccedoAlMenuAdministracion()
        {
            CommonElementsAction.Click("CssSelector",ConfigurationMenuPage.AdministrationMenu);
        }

        [When(@"Selecciono la opción Usuarios Móviles")]
        public void WhenSeleccionoLaOpcionUsuariosMoviles()
        {
            CommonElementsAction.Click("XPath",MobileUsersPage.MobileUsersModulePath);
            CommonElementsAction.Click("XPath",ConfigurationMenuPage.MobileUserOption);
        }

        [When(@"Doy click en Nuevo usuario móvil")]
        public void WhenDoyClickEnNuevoUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector",MobileUsersPage.MobileUserButtonNew);
        }

        [When(@"Diligencio nombre de usuario móvil")]
        public void WhenDiligencioNombreDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector",MobileUsersPage.MobileUserName,user_name);
        }

        [When(@"Diligencio usuario de usuario móvil")]
        public void WhenDiligencioUsuarioDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector",MobileUsersPage.MobileUserUserName,user_nickname);
        }

        [When(@"diligencio correo electrónico valido de usuario móvil")]
        public void WhenDiligencioCorreoElectronicoValidoDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector",MobileUsersPage.MobileUserEmail,"eduardo@mailer.com");
        }

        [When(@"Diligencio teléfono de usuario móvil")]
        public void WhenDiligencioTelefonoDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector",MobileUsersPage.MobileUserPhone,"3008425830");
        }

        [When(@"diligencio contraseña de usuario móvil")]
        public void WhenDiligencioContrasenaDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector",MobileUsersPage.MobileUserPassword,"123456");
        }

        [When(@"selecciono cargo de usuario móvil")]
        public void WhenSeleccionoCargoDeUsuarioMovil()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("CssSelector",MobileUsersPage.MobileUserPosition,MobileUsersPage.MobileUserPositionOption);
        }

        [When(@"diligencio dirección valida de usuario móvil")]
        public void WhenDiligencioDireccionValidaDeUsuarioMovil()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector",MobileUsersPage.MobileUserAddress,"CALLE 64 # 5-22 bOGOTA");
        }

        [When(@"selecciono sede de inventario")]
        public void WhenSeleccionoSedeDeInventario()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("CssSelector",MobileUsersPage.MobileUserLocation,MobileUsersPage.MobileUserLocationOption);
        }

        [When(@"selecciono tipo de transporte de usuario móvil")]
        public void WhenSeleccionoTipoDeTransporteDeUsuarioMovil()
        {
            string Vehicle = CommonQuery.DBSelectAValue("SELECT TOP 1 vehi_name FROM AFLS_VEHICLE_TYPE ORDER BY NEWID();",1);
            CommonElementsAction.ClickAndSelect_DropDownList("XPath",MobileUsersPage.MobileUserTransport,Vehicle,"label");
        }

        [When(@"selecciono proveedor de usuario móvil")]
        public void WhenSeleccionoProveedorDeUsuarioMovil()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath",MobileUsersPage.MobileUserProvider,MobileUsersPage.MobileUserProviderOption);
        }

        [When(@"Doy click en switch de estado de usuario móvil")]
        public void WhenDoyClickEnSwitchDeEstadoDeUsuarioMovil()
        {
            CommonElementsAction.Click("XPath",MobileUsersPage.MobileUserState);
        }

        [When(@"Selecciono el Tab de grupos móvil de usuario móvil")]
        public void WhenSeleccionoElTabDeGruposMovilDeUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector",MobileUsersPage.TabMobileUserMobileGroups);
        }

        [When(@"Selecciono el Tab de disponibilidad de usuario móvil")]
        public void WhenSeleccionoElTabDeDisponibilidadDeUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector",MobileUsersPage.TabMobileUserAvilibily);
        }

        [When(@"Selecciono disponibilidad de siete días a usuario móvil")]
        public void WhenSeleccionoDisponibilidadDeSieteDiasAUsuarioMovil()
        {
            Actions Sunday = new Actions(CommonHooks.driver);
            Sunday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[2]")),0,100).Build().Perform();

            Actions Monday = new Actions(CommonHooks.driver);
            Monday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[3]")),0,100).Build().Perform();

            Actions Tuesday = new Actions(CommonHooks.driver);
            Tuesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[4]")),0,100).Build().Perform();

            Actions Wednesday = new Actions(CommonHooks.driver);
            Wednesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[5]")),0,100).Build().Perform();

            Actions Thursday = new Actions(CommonHooks.driver);
            Thursday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[6]")),0,100).Build().Perform();

            Actions Friday = new Actions(CommonHooks.driver);
            Friday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[7]")),0,100).Build().Perform();

            Actions Saturday = new Actions(CommonHooks.driver);
            Saturday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[8]")),0,100).Build().Perform();
        }

        [When(@"Selecciono el Tab de habilidades de usuario móvil")]
        public void WhenSeleccionoElTabDeHabilidadesDeUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector",MobileUsersPage.TabMobileUserSkills);
        }

        [When(@"Diligencio y selecciono un grupo móvil para usuario móvil")]
        public void WhenDiligencioYSeleccionoUnGrupoMovilParaUsuarioMovil()
        {
            CommonElementsAction.ClickAndSelect_Random_ComboboxAutocomplete("XPath",MobileUsersPage.MobileUserMobileGroups,MobileUsersPage.MobileUserMobileGroupsOption);
        }

        [When(@"Diligencio y selecciono una habilidad para usuario móvil")]
        public void WhenDiligencioYSeleccionoUnaHabilidadParaUsuarioMovil()
        {
            CommonElementsAction.ClickAndSelect_Random_ComboboxAutocomplete("XPath",MobileUsersPage.MobileUserSkill,MobileUsersPage.MobileUserSkillOption);
        }

        [When(@"Selecciono el tab Información de usuario móvil")]
        public void WhenSeleccionoElTabInformacionDeUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector",MobileUsersPage.MobileUserTabInfo);
        }
    }
}