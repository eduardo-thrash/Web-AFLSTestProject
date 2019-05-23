using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.AssistMe;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.AssistMe
{
    [Binding]
    public class AssistMeRegisterSteps
    {
        private readonly PageMessages PageMessages = new PageMessages();
        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private ElementsAssistMeLogIn AssistMeLogInPage = new ElementsAssistMeLogIn();
        private ElementsAssistMeRegister AssistMeRegisterPage = new ElementsAssistMeRegister();

        private string RegisterUserName;
        private string RegisterNameDefault = "UI client reg ";

        [Given(@"El cliente para registro en AssitMe no existe")]
        public void GivenElClienteParaRegistroEnAssitMeNoExiste()
        {
            RegisterUserName = RegisterNameDefault + Functions.RandomText(8);
            CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = '" + RegisterUserName + "';", 0);
        }

        [Given(@"Tengo usuario cliente con canal AssistMe activo para realizar Login en AssistMe")]
        public void GivenTengoUsuarioClienteConCanalAssistMeActivoParaRealizarLoginEnAssistMe()
        {
            CommonQuery.DBSelectAValue("SELECT TOP 1 IdUser FROM AFLS_USERS_CHANNEL ORDER BY NEWID();", 1);
        }

        [Given(@"Tengo configurado registro de cliente en Configuración de AssistMe")]
        public void GivenTengoConfiguradoRegistroDeClienteEnConfiguracionDeAssistMe()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_ASSISTME_CONFIGURATION WHERE EnableRegisterClient = 1", 1);
        }

        [When(@"Accedo a la aplicación de AssistMe")]
        public void WhenAccedoALaAplicacionDeAssistMe()
        {
            CommonElementsAction.AccessPage(ConfigurationManager.AppSettings["UrlAssistMe"]);
        }

        [When(@"Pulso el link de registro de AssistMe")]
        public void WhenPulsoElLinkDeRegistroDeAssistMe()
        {
            UtilAction.Click(AssistMeRegisterPage.LinkRegisterClient, "CssSelector");
        }

        [When(@"Diligencio campo nombre para registro en AssistMe")]
        public void WhenDiligencioCampoNombreParaRegistroEnAssistMe()
        {
            UtilAction.SendKeys(AssistMeRegisterPage.InputNameRegisterClient, RegisterUserName, "Id");
        }

        [When(@"Diligencio campo dirección para registro en AssistMe")]
        public void WhenDiligencioCampoDireccionParaRegistroEnAssistMe()
        {
            UtilAction.Click(AssistMeRegisterPage.InputAddressRegisterClient, "Id");
            UtilAction.SendKeys(AssistMeRegisterPage.InputControldAddressRegisterClient, "carrera 64 # 5-22 bogota colombia", "Id");
            UtilAction.Click(AssistMeRegisterPage.ButtontControldAddressRegisterClient, "Id");
        }

        [When(@"Diligencio campo detalle de dirección para registro en AssistMe")]
        public void WhenDiligencioCampoDetalleDeDireccionParaRegistroEnAssistMe()
        {
            UtilAction.SendKeys(AssistMeRegisterPage.InputAddressDetailRegisterClient, "Piso 45", "Id");
        }

        [When(@"Diligencio campo número de teléfono móvil para registro en AssistMe")]
        public void WhenDiligencioCampoNumeroDeTelefonoMovilParaRegistroEnAssistMe()
        {
            UtilAction.SendKeys(AssistMeRegisterPage.InputPhoneRegisterClient, "3008425830", "Id");
        }

        [When(@"Diligencio campo correo electrónico para registro en AssistMe")]
        public void WhenDiligencioCampoCorreoElectronicoParaRegistroEnAssistMe()
        {
            UtilAction.SendKeys(AssistMeRegisterPage.InputEmailRegisterClient, "mailer@mailer.com", "Id");
        }

        [When(@"Diligencio campo usuario para registro en AssistMe")]
        public void WhenDiligencioCampoUsuarioParaRegistroEnAssistMe()
        {
            UtilAction.SendKeys(AssistMeRegisterPage.InputUserIdRegisterClient, "ui.client" + Functions.RandomText(3), "Id");
        }

        [When(@"Diligencio campo contraseña para registro en AssistMe")]
        public void WhenDiligencioCampoContrasenaParaRegistroEnAssistMe()
        {
            UtilAction.SendKeys(AssistMeRegisterPage.InputPasswordRegisterClient, "123456", "Id");
        }

        [When(@"Diligencio campo confirmar contraseña para registro en AssistMe")]
        public void WhenDiligencioCampoConfirmarContrasenaParaRegistroEnAssistMe()
        {
            UtilAction.SendKeys(AssistMeRegisterPage.InputPasswordConfirmRegisterClient, "123456", "Id");
        }

        [When(@"Pulso el botón registrarse")]
        public void WhenPulsoElBotonRegistrarse()
        {
            UtilAction.Click(AssistMeRegisterPage.ButtonSubmit, "Id");
        }

        [Then(@"Se muestra un mensaje indicando que el registro se realizo exitosamente\.")]
        public void ThenSeMuestraUnMensajeIndicandoQueElRegistroSeRealizoExitosamente_()
        {
            IWebElement ElementIcon = CommonHooks.driver.FindElement(By.XPath("//div[@id='MessageBoxResponse']/div/div/span[@class='ValidSpan']"));
            IWebElement ElementToLogin = CommonHooks.driver.FindElement(By.XPath("//div[@id='MessageBoxResponse']//a[@href='#/login']"));

            Thread.Sleep(2000);

            for (int second = 0; ; second++)
            {
                if (second >= 10) Assert.Fail("No found Element");
                try
                {
                    Assert.IsTrue(ElementIcon.Enabled);
                    Assert.IsTrue(ElementIcon.Displayed);
                    Assert.AreNotEqual(ElementIcon.Size, 0);
                    ElementIcon.Click();
                    break;
                }
                catch (Exception)
                { Thread.Sleep(1000); }
            }

            string Message = CommonHooks.driver.FindElement(By.Id("Greatting")).Text;

            for (int second = 0; ; second++)
            {
                if (second >= 10) Assert.Fail("No found Element");
                try
                {
                    Assert.IsTrue(ElementToLogin.Enabled);
                    Assert.IsTrue(ElementToLogin.Displayed);
                    Assert.AreNotEqual(ElementToLogin.Size, 0);
                    ElementToLogin.Click();
                    break;
                }
                catch (Exception)
                { Thread.Sleep(1000); }
            }
        }
    }
}