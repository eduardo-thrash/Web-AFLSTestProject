using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class AFClientsSteps
    {
        private readonly AFClientsPage AFClientsPage = new AFClientsPage();
        private readonly PageMessages PageMessages = new PageMessages();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesElements Messages = new MessagesElements();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private ResponseValidation Validation = new ResponseValidation();
        private AFLSUIProjectTest.UIMap.ConfigurationMenuPage Menu = new AFLSUIProjectTest.UIMap.ConfigurationMenuPage();
        private string AFClientName;
        private string LabelAFClientName;
        private string EditLabelAFClientName = "Edit UI AFClient Simple";
        private string DefaultAFClientName = "UI AFClient Simple";
        private string EditAFClientName = "UI Edit AFClient Simple";

        [Given(@"No existe el campo adicional de cliente de tipo simple")]
        public string GivenNoExisteElCampoAdicionalDeClienteDeTipoSimple()
        {
            AFClientName = DefaultAFClientName + Functions.RandomText(4);
            LabelAFClientName = AFClientName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD WHERE definition_id = 3 AND name = '" + AFClientName + "';", 0);
            return AFClientName;
        }

        [When(@"Selecciono la opción Campos adicionales clientes")]
        public void WhenSeleccionoLaOpcionCamposAdicionalesClientes()
        {
            try
            {
                CommonElementsAction.Click("XPath", Menu.AFClientsOption);
            }
            catch
            {
                CommonElementsAction.Click("XPath", AFClientsPage.AFClientsModulePath);
                CommonElementsAction.Click("XPath", Menu.AFClientsOption);
            }
        }

        [Given(@"Existe el campo adicional de cliente de tipo simple")]
        public string GivenExisteElCampoAdicionalDeClienteDeTipoSimple()
        {
            AFClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFW_ADDITIONAL_FIELD WHERE definition_id = 3 AND type_id = 1 ORDER BY NEWID();", 1);
            return AFClientName;
        }

        [When(@"Doy click en Nuevo campo adicional de cliente")]
        public void WhenDoyClickEnNuevoCampoAdicionalDeCliente()
        {
            CommonElementsAction.Click("CssSelector", AFClientsPage.AFClientsButtonNew);
        }

        [When(@"Diligencio etiqueta de campo adicional de cliente")]
        public void WhenDiligencioEtiquetaDeCampoAdicionalDeCliente()
        {
            LabelAFClientName = DefaultAFClientName + Functions.RandomText(4);
            CommonElementsAction.SendKeys_InputText("XPath", AFClientsPage.AFClientsInputLabel, LabelAFClientName);
        }

        [When(@"Selecciono tipo de campo adicional de cliente simple")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeClienteSimple()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", "//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "simple", "option");
        }

        [When(@"Diligencio texto de ayuda de campo adicional de cliente")]
        public void WhenDiligencioTextoDeAyudaDeCampoAdicionalDeCliente()
        {
            CommonElementsAction.SendKeys_InputText("XPath", "//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div/div[2]/div/textarea", "Descriptontext help message");
        }

        [When(@"Doy click en opciones avanzadas de campo adicional de cliente")]
        public void WhenDoyClickEnOpcionesAvanzadasDeCampoAdicionalDeCliente()
        {
            CommonElementsAction.Click("XPath", "//div[@id='addtional-fields-client']/div[1]/div[2]/ul/li/form/div[2]/div[3]/div[1]");
        }

        [When(@"Diligencio nombre de campo adicional de cliente")]
        public void WhenDiligencioNombreDeCampoAdicionalDeCliente()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input", AFClientName);
            AFClientName = CommonElementsAction.VallueExtract("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input");
        }

        [When(@"Doy click en Aceptar campo adicional de cliente")]
        public void WhenDoyClickEnAceptarCampoAdicionalDeOrden()
        {
            CommonElementsAction.Click("CssSelector", AFClientsPage.AFClientsAccept);
        }

        [When(@"Doy click en Guardar campo adicional de cliente")]
        public void WhenDoyClickEnGuardarCampoAdicionalDeOrden()
        {
            CommonElementsAction.Click("XPath", AFClientsPage.AFClientsSubmit);
        }

        [Then(@"Se muestra un mensaje indicando que se creo que campo adicional de cliente correctamente")]
        public void ThenSeMuestraUnMensajeIndicandoQueSeCreoQueCampoAdicionalDeClienteCorrectamente()
        {
            string Message = CommonElementsAction.TextExtract("XPath", Messages.ResponseSuccessAFClient);
            try
            {
                Validation.ValidationSuccessAFCreate(Messages.ResponseSuccessAFClient);
            }
            catch
            {
                string MessageError = CommonElementsAction.TextExtract("XPath", Messages.ResponseErrorAFClient);
                Assert.Fail(MessageError);
            }
        }

        [Then(@"Se registra campo adicional de cliente de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeClienteDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD WHERE definition_id = 3 AND type_id = 1 AND name = '" + AFClientName + "';", 1);
        }

        [When(@"Doy click en editar el campo adicional de cliente de tipo simple")]
        public void WhenDoyClickEnEditarElCampoAdicionalDeClienteDeTipoSimple()
        {
            Thread.Sleep(3000);
            EditLabelAFClientName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD WHERE definition_id = 3 AND name = '" + AFClientName + "';", 1);

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonEdit = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == EditLabelAFClientName)
                {
                    IndexButtonEdit = count + 1;
                }
            }
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0, IndexButtonEdit);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + EditLabelAFClientName);
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
        }

        [When(@"Edito nombre de etiqueta de campo adicional de cliente de tipo simple")]
        public void WhenEditoNombreDeEtiquetaDeCampoAdicionalDeClienteDeTipoSimple()
        {
            EditLabelAFClientName = EditLabelAFClientName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", AFClientsPage.AFClientsInputLabel, EditLabelAFClientName);
        }

        [Then(@"Se registra el campo adicional de cliente modificado en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraElCampoAdicionalDeClienteModificadoEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD WHERE definition_id = 3 AND type_id = 1 AND name = '" + AFClientName + "' AND label = '" + EditLabelAFClientName + "';", 1);
        }

        [When(@"Doy click en eliminar el campo adicional de cliente de tipo simple")]
        public void WhenDoyClickEnEliminarElCampoAdicionalDeClienteDeTipoSimple()
        {
            Thread.Sleep(3000);
            LabelAFClientName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD WHERE definition_id = 3 AND name = '" + AFClientName + "';", 1);

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonDelete = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == LabelAFClientName)
                {
                    IndexButtonDelete = count + 1;
                }
            }
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0, IndexButtonDelete);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + LabelAFClientName);
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li[" + IndexButtonDelete + "]/div/div/button[@class='delete-button secondary_bg js-delete-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
        }

        [Then(@"Se borra el registro de el campo adicional de cliente en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeBorraElRegistroDeElCampoAdicionalDeClienteEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD WHERE definition_id = 3 AND type_id = 1 AND name = '" + AFClientName + "';", 0);
        }

        [When(@"Eliminación exitosa de campos adicionales clientes")]
        public void WhenEliminacionExitosaDeCamposAdicionalesClientes()
        {
            Thread.Sleep(3000);
            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonDelete = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == "Campo prueba 1")
                {
                    IndexButtonDelete = count + 1;
                }
            }
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0, IndexButtonDelete);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + "Campo prueba 1");
            }
            ///     Selecciono el botón eliminar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li[" + IndexButtonDelete + "]/div/div/button[@class='delete-button secondary_bg js-delete-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            ///     pulso Si

            CommonElementsAction.Click("CssSelector", AFClientsPage.AFClientsYes);

            ///     pulso guardar
            CommonElementsAction.Click("XPath", AFClientsPage.AFClientsSubmit);

            //Validate response.
            //CommonAFLS.CommonAflsValidateMessages.ValidateMessageComponent(PageMessages.SuccessElementConfigurationDelete);
            //End Validate response.
        }
    }
}