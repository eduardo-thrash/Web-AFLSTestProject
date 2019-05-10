using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.Alerts
{
    [Binding]
    public class GeneralAlertsSteps
    {
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private MobileUsersPage MobileUsersPage = new MobileUsersPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        [Given(@"Tengo un usuario con rol monitor")]
        public void GivenTengoUnUsuarioConRolMonitor()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"El usuario monitor y administrador tiene proveedores asociados")]
        public void GivenElUsuarioMonitorYAdministradorTieneProveedoresAsociados()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Realizo Login con usuario rol monitor")]
        public void WhenRealizoLoginConUsuarioRolMonitor()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono la opción de ítem de Alertas General")]
        public void WhenSeleccionoLaOpcionDeItemDeAlertasGeneral()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se carga la pantalla principal de alertas generales")]
        public void ThenSeCargaLaPantallaPrincipalDeAlertasGenerales()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Tengo un usuario con rol monitor y despachador")]
        public void GivenTengoUnUsuarioConRolMonitorYDespachador()
        {
        }

        [When(@"Selecciono la opción de ítem de Alertas Proveedores")]
        public void WhenSeleccionoLaOpcionDeItemDeAlertasProveedores()
        {
            CommonElementsAction.Click("XPath", PrincipalMenuPage.ItemPrincipalAlerts);
        }

        [Then(@"Se carga la pantalla principal de alertas de proveedores")]
        public void ThenSeCargaLaPantallaPrincipalDeAlertasDeProveedores()
        {
            int secondFindText;
            for (secondFindText = 0; ; secondFindText++)
            {
                if (secondFindText >= 10) Assert.Fail("Error en carga de modulo");
                try
                {
                    WebDriverWait wait = new WebDriverWait(CommonHooks.driver, time).Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

                    //Assert.IsTrue(((IJavaScriptExecutor)CommonHooks.driver).ExecuteScript("return document.readyState").Equals("complete"));

                    break;
                }
                catch (Exception e)
                {
                    string Response = CommonElementsAction.TextExtract("XPath", MessagesElements.ResponseError);
                    try
                    {
                        Assert.IsTrue(Response.Contains(MessagesCopies.FailedElementConfigurationCreateOrUpdate));
                    }
                    catch
                    {
                        Assert.Fail(e.Message);
                    }
                }
            }
        }
    }
}