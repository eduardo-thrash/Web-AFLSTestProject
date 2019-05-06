using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.Configuration;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.AFLS

{
    [Binding]
    public class AFLSPagesSteps
    {
        private SLAsPage SLAsPage = new SLAsPage();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private Logout Logout = new Logout();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private AFCompaniesPage AFCompaniesPage = new AFCompaniesPage();
        private ConfigurationMenuPage Menu = new ConfigurationMenuPage();
        private MobileUsersPage MobileUsersPage = new MobileUsersPage();

        private string ErrorResult = null;

        [Given(@"Tengo un usuario con rol administrador")]
        public void GivenTengoUnUsuarioConRolAdministrador()
        {
            CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = 'administrator';", 1);
        }

        [When(@"Selecciono la opción ANS's")]
        public void WhenSeleccionoLaOpcionANSS()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.SLAOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal ANS's")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalANSS()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción OLA's")]
        public void WhenSeleccionoLaOpcionOLAS()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.OLAOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal OLA's")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalOLAS()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción UC's")]
        public void WhenSeleccionoLaOpcionUCS()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.UCOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal UC's")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalUCS()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Calendarios")]
        public void WhenSeleccionoLaOpcionCalendarios()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.CalendarOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Calendarios")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCalendarios()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Cronómetros")]
        public void WhenSeleccionoLaOpcionCronómetros()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ChronometerOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Cronómetros")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCronómetros()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Modelos")]
        public void WhenSeleccionoLaOpcionModelos()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ModelOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Modelos")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalModelos()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"selecciono la opción Servicios")]
        public void WhenSeleccionoLaOpcionServicios()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ServiceOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Servicios")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalServicios()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"selecciono la opción Relaciones")]
        public void WhenSeleccionoLaOpcionRelaciones()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.RelationOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Relaciones")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalRelaciones()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Compañias")]
        public void WhenSeleccionoLaOpcionComapnias()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.CompanyOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Comapñias")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalComapnias()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Clientes")]
        public void WhenSeleccionoLaOpcionClientes()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ClientOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Clientes")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalClientes()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Transportes")]
        public void WhenSeleccionoLaOpcionTransportes()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MeansTransportOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Transportes")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalTransportes()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Cargos")]
        public void WhenSeleccionoLaOpcionCargos()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.PositionOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Cargos")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCargos()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Proveedores")]
        public void WhenSeleccionoLaOpcionProveedores()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ProviderOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Proveedores")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalProveedores()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Habilidades")]
        public void WhenSeleccionoLaOpcionHabilidades()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.SkillOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Habilidades")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalHabilidades()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"selecciono la opción Usuarios Web")]
        public void WhenSeleccionoLaOpcionUsuariosWeb()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.WebUserOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Usuarios Web")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalUsuariosWeb()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"selecciono la opción Grupos Web")]
        public void WhenSeleccionoLaOpcionGruposWeb()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.WebGroupOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Grupos Web")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalGruposWeb()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"selecciono la opción Usuarios Movil")]
        public void WhenSeleccionoLaOpcionUsuariosMovil()
        {
            CommonElementsAction.Click("XPath", MobileUsersPage.MobileUsersModulePath);
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MobileUserOption);
        }

        [When(@"selecciono la opción Grupos Movil")]
        public void WhenSeleccionoLaOpcionGruposMovil()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MobileGroupOption);
        }

        [When(@"selecciono la opción Zonas")]
        public void WhenSeleccionoLaOpcionZonas()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ZoneOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Zonas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalZonas()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Accedo al menú Inventario")]
        public void WhenAccedoAlMenuInventario()
        {
            CommonElementsAction.Click("CssSelector", ConfigurationMenuPage.InventoryMenu);
        }

        [When(@"Selecciono la opción Medidas")]
        public void WhenSeleccionoLaOpcionMedidas()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MeasureOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Medidas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalMedidas()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Productos")]
        public void WhenSeleccionoLaOpcionProductos()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ProductOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Productos")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalProductos()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Ubicaciones")]
        public void WhenSeleccionoLaOpcionUbicaciones()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Ubicaciones")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalUbicaciones()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Accedo al menú Integración")]
        public void WhenAccedoAlMenuIntegracion()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono la opción LDAP")]
        public void WhenSeleccionoLaOpcionLDAP()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.LDAPOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal LDAP")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalLDAP()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción ASDK")]
        public void WhenSeleccionoLaOpcionASDK()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ASDKOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal ASDK")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalASDK()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Otras aplicaciones")]
        public void WhenSeleccionoLaOpcionOtrasAplicaciones()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ThirdPartyOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Otras aplicaciones")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalOtrasAplicaciones()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Accedo al menú Configuración")]
        public void WhenAccedoAlMenuConfiguracion()
        {
            CommonElementsAction.Click("CssSelector", ConfigurationMenuPage.ConfigurationMenu);
        }

        [When(@"Selecciono la opción Información básica")]
        public void WhenSeleccionoLaOpcionInformacionBasica()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.EstablishmentOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Información básica")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalInformacionBasica()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Campos adicionales compañías")]
        public void WhenSeleccionoLaOpcionCamposAdicionalesCompanias()
        {
            try
            {
                CommonElementsAction.Click("XPath", Menu.AFCompaniesOption);
            }
            catch
            {
                CommonElementsAction.Click("XPath", AFCompaniesPage.AFCompaniesModulePath);
                CommonElementsAction.Click("XPath", Menu.AFCompaniesOption);
            }
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Campos adicionales compañías")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCamposAdicionalesCompanias()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Campos adicionales clientes")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCamposAdicionalesClientes()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Campos adicionales servicios")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCamposAdicionalesServicios()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Campos adicionales ordenes")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCamposAdicionalesOrdenes()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Días no laborales")]
        public void WhenSeleccionoLaOpcionDiasNoLaborales()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.NonWorkingDaysOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Días no laborales")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalDiasNoLaborales()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Servidor de correo")]
        public void WhenSeleccionoLaOpcionServidorDeCorreo()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MailServerOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Servidor de correo")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalServidorDeCorreo()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Encuestas general")]
        public void WhenSeleccionoLaOpcionEncuestasGeneral()
        {
            try
            {
                CommonElementsAction.Click("XPath", ConfigurationMenuPage.SurveyGeneralConfigurationOption);
            }
            catch
            {
                CommonElementsAction.Click("XPath", "//div[contains(@class, 'icon iconsAd surveysconfig')]");
                CommonElementsAction.Click("XPath", ConfigurationMenuPage.SurveyGeneralConfigurationOption);
            }
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Encuestas general")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalEncuestasGeneral()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Plantillas de Encuestas")]
        public void WhenSeleccionoLaOpcionPlantillasDeEncuestas()
        {
            try
            {
                CommonElementsAction.Click("XPath", ConfigurationMenuPage.SurveyTemplateOption);
            }
            catch
            {
                CommonElementsAction.Click("XPath", "//div[contains(@class, 'icon iconsAd surveysconfig')]");
                CommonElementsAction.Click("XPath", ConfigurationMenuPage.SurveyTemplateOption);
            }
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Plantillas de Encuestas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalPlantillasDeEncuestas()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Respuestas rápidas")]
        public void WhenSeleccionoLaOpcionRespuestasrápidas()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.QuickAnswersOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Respuestas rápidas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalRespuestasrápidas()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Plantillas de correo")]
        public void WhenSeleccionoLaOpcionPlantillasDeCorreo()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.GeneralEmailTemplateOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Plantillas de correo")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalPlantillasDeCorreo()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Reglas de asignación")]
        public void WhenSeleccionoLaOpcionReglasDeAsignacion()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.AssigmentRulesOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Reglas de asignación")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalReglasDeAsignacion()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Precisión de ubicación")]
        public void WhenSeleccionoLaOpcionPrecisionDeUbicacion()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.AccuracyOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Precisión de ubicación")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalPrecisionDeUbicacion()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Licenciamiento")]
        public void WhenSeleccionoLaOpcionLicenciamiento()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.LicensingOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Licenciamiento")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalLicenciamiento()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Canal AssistMe")]
        public void WhenSeleccionoLaOpcionCanalAssistMe()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.AssistMeOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Canal AssistMe")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCanalAssistMe()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [When(@"Selecciono la opción Gestión de alertas")]
        public void WhenSeleccionoLaOpcionGestionDeAlertas()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Gestión de alertas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalGestionDeAlertas()
        {
            try
            {
                Functions.MissingKeyFind();
            }
            catch
            {
                string MissingText = CommonHooks.driver.FindElement(By.XPath("html")).Text;
                ErrorResult = ErrorResult + MissingText + " | ";
            }
        }

        [Then(@"Cierro Sesión en la aplicación")]
        public void ThenCierroSesionEnLaAplicacion()
        {
            Logout.AdministratorLogOff();
        }

        [Then(@"Valido si hay Missing Key localizados")]
        public void ThenValidoSiHayMissingKeyLocalizados()
        {
            try
            {
                Assert.AreEqual(ErrorResult, null);
            }
            catch
            {
                Assert.Fail(ErrorResult);
            }
        }
    }
}