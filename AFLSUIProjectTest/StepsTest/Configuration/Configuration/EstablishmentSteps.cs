using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configurationonfiguration.MenuConfiguration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class EstablishmentSteps
    {
        private readonly EstablishmentPage EstablishmentPage = new EstablishmentPage();
        private readonly PageMessages PageMessages = new PageMessages();

        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        [When(@"Selecciono opción de Información básica")]
        public void WhenSeleccionoOpcionDeInformacionBasica()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.EstablishmentOption);
        }

        [When(@"Diligencio nombre de compañía en información básica")]
        public void WhenDiligencioNombreDeCompaniaEnInformacionBasica()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputName, "Aranda Software");
        }

        [When(@"Diligencio NIT de compañía en información básica")]
        public void WhenDiligencioNITDeCompaniaEnInformacionBasica()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputId, "9008756744-6");
        }

        [When(@"Diligencio dirección de compañía en información básica dando click en cursor")]
        public void WhenDiligencioDireccionDeCompaniaEnInformacionBasicaDandoClickEnCursor()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputAddress, "calle 45 # 45-23 bogota");
            CommonElementsAction.Click("XPath", EstablishmentPage.EstablishmentAddressValidate);
        }

        [When(@"Diligencio dirección de compañía en información básica dando tab")]
        public void WhenDiligencioDireccionDeCompaniaEnInformacionBasicaDandoTab()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputAddress, "calle 45 # 45-23 bogota");
            CommonHooks.driver.FindElement(By.CssSelector(EstablishmentPage.EstablishmentInputAddress)).SendKeys(Keys.Tab);
        }

        [Then(@"Se registra la configuración básica en la tabla AFLS_ESTABLISHMENT con longitud, latitud y dirección")]
        public void ThenSeRegistraLaConfiguracionBasicaEnLaTablaAFLS_ESTABLISHMENTConLongitudLatitudYDireccion()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_ESTABLISHMENT WHERE esta_latitude IS NOT NULL AND esta_longitude IS NOT NULL AND esta_address IS NOT NULL", 1);
        }

        [Then(@"Se registra por base de datos la zona geográfica de dos países")]
        public void ThenSeRegistraPorBaseDeDatosLaZonaGeograficaDeDosPaises()
        {
            Functions.DBEstablismentUpdate("UPDATE AFLS_ESTABLISHMENT set esta_country = 'CO - Colombia, BR - Brasil';");
        }

        [When(@"Diligencio dirección de compañía en información básica dando enter")]
        public void WhenDiligencioDireccionDeCompaniaEnInformacionBasicaDandoEnter()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputAddress, "calle 45 # 45-23 bogota");
        }

        [When(@"Doy click en Guardar información básica")]
        public void WhenDoyClickEnGuardarInformacionBasica()
        {
            CommonElementsAction.Click("CssSelector", EstablishmentPage.EstablishmentSubmit);
        }

        [When(@"Configuración exitosa de Información básica")]
        public void WhenConfiguracionExitosaDeInformacionBasica()
        {
            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General

            ///     And diligencio el campo de nombre
            Thread.Sleep(3000);

            ///     And diligencio el campo de identificación

            ///     And diligencio el campo de Ubicación
            IWebElement element = CommonHooks.driver.FindElement(By.XPath("//div[@id='mapEstablishmentAddress']/div/div/div/div/div"));
            Thread.Sleep(2000);

            CommonHooks.driver.FindElement(By.CssSelector(".container-app .container-module .admin .content.col.module .establishment .details .tabContent.svGeneral input[name='Address']")).Click();
            Thread.Sleep(2000);

            new Actions(CommonHooks.driver).MoveByOffset(-200, 100).Click().Build().Perform();
            Thread.Sleep(3000);

            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            CommonElementsAction.Click("CssSelector", EstablishmentPage.EstablishmentSubmit);

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.AppSettings["DatabaseConnection"];

                conn.Open();
                //Console.WriteLine("Open connection");

                SqlCommand commandUpdate = new SqlCommand("UPDATE AFLS_ESTABLISHMENT SET esta_country = 'CO - Colombia'", conn);
                using (SqlDataReader reader = commandUpdate.ExecuteReader())
                { }
            }

            //LogOut.

            //End LogOut.
        }

        [When(@"Cancelación exitosa configuración de Información básica")]
        public void WhenCancelacionExitosaConfiguracionDeInformacionBasica()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputName, "Aranda Software");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputId, "9008756744-6");

            IWebElement element = CommonHooks.driver.FindElement(By.XPath("//div[@id='mapEstablishmentAddress']/div/div/div/div/div"));

            CommonHooks.driver.FindElement(By.CssSelector(".container-app .container-module .admin .content.col.module .establishment .details .tabContent.svGeneral input[name='Address']")).Click();
            Thread.Sleep(1000);

            new Actions(CommonHooks.driver).MoveByOffset(-200, 100).Click().Build().Perform();
            Thread.Sleep(1000);

            CommonElementsAction.Click("CssSelector", EstablishmentPage.EstablishmentCancel);

            Thread.Sleep(1000);
            //CommonElementsAction.Click("CssSelector",ElementsDialogBoxes.SubmitButton);

            //LogOut.

            //End LogOut.
        }

        [When(@"Modificación exitosa de Información básica")]
        public void WhenModificacionExitosaDeInformacionBasica()
        {
            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General

            ///     And diligencio el campo de nombre
            Thread.Sleep(3000);

            CommonElementsAction.SendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputName, "Aranda Software");

            ///     And diligencio el campo de identificación
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputId, "900111234-6");

            CommonElementsAction.Clear("CssSelector", EstablishmentPage.EstablishmentInputAddress);
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputAddress, "calle 45 # 45-23 bogota");

            CommonElementsAction.Click("CssSelector", EstablishmentPage.EstablishmentSubmit);

            //LogOut.

            //End LogOut.
        }

        [When(@"Modificación fallida de información básica dejando nombre vacio")]
        public void WhenModificacionFallidaDeInformacionBasicaDejandoNombreVacio()
        {
            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General

            ///     And diligencio el campo de nombre
            Thread.Sleep(3000);

            CommonElementsAction.Clear("CssSelector", EstablishmentPage.EstablishmentInputName);

            CommonElementsAction.Click("CssSelector", EstablishmentPage.EstablishmentSubmit);

            //LogOut.

            //End LogOut.
        }
    }
}