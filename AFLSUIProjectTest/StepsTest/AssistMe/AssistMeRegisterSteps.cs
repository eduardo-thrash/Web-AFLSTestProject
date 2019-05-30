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
            int FindRow = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_ESTABLISHMENT", 1));
            int FindCOuntry = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_ESTABLISHMENT WHERE esta_country IS NOT NULL", 1));

            if (FindRow == 0)
            {
                Functions.DBInsert("INSERT INTO dbo.AFLS_ESTABLISHMENT(esta_id"
                                                        + ", esta_code"
                                                        + ", esta_name"
                                                        + ", esta_address"
                                                        + ", esta_latitude"
                                                        + ", esta_longitude"
                                                        + ", esta_country"
                                                        + ", esta_filter_address)"
                                                        + "VALUES"
                                                        + "(1"
                                                        + ", 90008736364 - 3"
                                                        + ", 'Aranda Software Automation'"
                                                        + ", 'Calle 64, Chapinero, 111221 Chapinero, Distrito Capital, Colombia'"
                                                        + ", 4.6507338"
                                                        + ", -74.0632001"
                                                        + ", 'CO- COlombia, BR - Brasil'"
                                                        + ", 1);");
            }

            if (FindCOuntry == 0)
            {
                Functions.DBEstablismentUpdate("UPDATE AFLS_ESTABLISHMENT SET esta_country = 'CO - Colombia'");
            }

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
            Thread.Sleep(2000);
            UtilAction.ClearBefore_SendKeys(AssistMeRegisterPage.InputControldAddressRegisterClient, "carrera 64 # 5-22 bogota colombia", "Id");
            UtilAction.Click("/html/body/div[1]/div[1]/div[3]/div[1]/div[3]/span");
            Thread.Sleep(4000);
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
            bool Validate = false;
            int Count = 0;

            while (!Validate)
            {
                try
                {
                    IWebElement ElementIcon = CommonHooks.driver.FindElement(By.XPath("//div[@id='MessageBoxResponse']/div/div/span[@class='ValidSpan']"));
                    IWebElement ElementToLogin = CommonHooks.driver.FindElement(By.XPath("//div[@id='MessageBoxResponse']//a[@href='#/login']"));

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
                        {
                        }
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
                    Validate = true;
                }
                catch
                {
                    try
                    {
                        string Error = CommonHooks.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/p")).Text;
                        if (Error != "")
                        {
                            Count = 10;
                            Assert.Fail(Error);
                        }
                    }
                    catch (Exception e)
                    {
                        Thread.Sleep(1000);
                        Count++;
                        if (Count >= 10)
                        {
                            Assert.Fail(e.Message);
                        }
                    }
                }
            }
        }
    }
}