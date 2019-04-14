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

        [When(@"Configuración exitosa de Información básica")]
        public void WhenConfiguracionExitosaDeInformacionBasica()
        {
            ///     And Ingreso al modulo de Configuración > Configuración > Plantillas de correo > General

            ///     And diligencio el campo de nombre
            Thread.Sleep(3000);

            CommonElementsAction.SendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputName, "Aranda Software");

            ///     And diligencio el campo de identificación
            CommonElementsAction.SendKeys_InputText("CssSelector", EstablishmentPage.EstablishmentInputId, "9008756744-6");

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