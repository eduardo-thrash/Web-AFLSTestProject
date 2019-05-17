using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class AFCompaniesSteps
    {
        private readonly AFCompaniesPage AFCompaniesPage = new AFCompaniesPage();
        private readonly PageMessages PageMessages = new PageMessages();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesElements Messages = new MessagesElements();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private ResponseValidation Validation = new ResponseValidation();
        private AFLSUIProjectTest.UIMap.ConfigurationMenuPage Menu = new AFLSUIProjectTest.UIMap.ConfigurationMenuPage();
        private string EditLabelAFCompanyName;
        private string AFCompanyName;
        private string LabelAFCompanyName;
        private string DefaultAFCompanyName = "UI AFCompany Simple";
        private string EditAFCompanyName = "UI Edit AFCompany Simple";

        [Given(@"Existe el campo adicional de compañía de tipo simple")]
        public string GivenExisteElCampoAdicionalDeCompaniaDeTipoSimple()
        {
            AFCompanyName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 1 ORDER BY NEWID();", 1);
            return AFCompanyName;
        }

        [When(@"Doy click en editar el campo adicional de compañía de tipo simple")]
        public void WhenDoyClickEnEditarElCampoAdicionalDeCompaniaDeTipoSimple()
        {
            Thread.Sleep(3000);
            EditLabelAFCompanyName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND name = '" + AFCompanyName + "';", 1);

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-company']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonEdit = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == EditLabelAFCompanyName)
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
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + EditLabelAFCompanyName);
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-company']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
        }

        [When(@"Edito nombre de etiqueta de campo adicional de compañía de tipo simple")]
        public void WhenEditoNombreDeEtiquetaDeCampoAdicionalDeCompaniaDeTipoSimple()
        {
            EditLabelAFCompanyName = EditLabelAFCompanyName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", AFCompaniesPage.AFCompaniesInputLabel, EditLabelAFCompanyName);
        }

        [Then(@"Se registra el campo adicional de compañía modificado en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraElCampoAdicionalDeCompaniaModificadoEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 1 AND name = '" + AFCompanyName + "' AND label = '" + EditLabelAFCompanyName + "';", 1);
        }

        [When(@"Doy click en eliminar el campo adicional de compañía de tipo simple")]
        public void WhenDoyClickEnEliminarElCampoAdicionalDeCompaniaDeTipoSimple()
        {
            Thread.Sleep(3000);
            LabelAFCompanyName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND name = '" + AFCompanyName + "';", 1);

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-company']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonDelete = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == LabelAFCompanyName)
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
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + LabelAFCompanyName);
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-company']/div/div[2]/ul/li[" + IndexButtonDelete + "]/div/div/button[@class='delete-button secondary_bg js-delete-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
        }

        [Then(@"Se borra el registro de el campo adicional de compañía en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeBorraElRegistroDeElCampoAdicionalDeCompaniaEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 1 AND name = '" + AFCompanyName + "';", 0);
        }

        [Given(@"No existe el campo adicional de compañía de tipo simple")]
        public string GivenNoExisteElCampoAdicionalDeCompaniaDeTipoSimple()
        {
            AFCompanyName = DefaultAFCompanyName + Functions.RandomText(4);
            LabelAFCompanyName = AFCompanyName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND name = '" + AFCompanyName + "';", 0);
            return AFCompanyName;
        }

        [When(@"Doy click en Nuevo campo adicional de compañía")]
        public void WhenDoyClickEnNuevoCampoAdicionalDeCompania()
        {
            CommonElementsAction.Click("CssSelector", AFCompaniesPage.AFCompaniesButtonNew);
        }

        [When(@"Diligencio etiqueta de campo adicional de compañía")]
        public void WhenDiligencioEtiquetaDeCampoAdicionalDeCompania()
        {
            LabelAFCompanyName = DefaultAFCompanyName + Functions.RandomText(4);
            CommonElementsAction.SendKeys_InputText("XPath", AFCompaniesPage.AFCompaniesInputLabel, LabelAFCompanyName);
        }

        [When(@"Selecciono tipo de campo adicional de compañía simple")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeCompaniaSimple()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", "//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "simple", "option");
        }

        [When(@"Diligencio texto de ayuda de campo adicional de compañía")]
        public void WhenDiligencioTextoDeAyudaDeCampoAdicionalDeCompania()
        {
            CommonElementsAction.SendKeys_InputText("XPath", "//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div/div[2]/div/textarea", "Descriptontext help message");
        }

        [When(@"Doy click en opciones avanzadas de campo adicional de compañía")]
        public void WhenDoyClickEnOpcionesAvanzadasDeCampoAdicionalDeCompania()
        {
            CommonElementsAction.Click("XPath", "//div[@id='addtional-fields-company']/div[1]/div[2]/ul/li/form/div[2]/div[3]/div[1]");
        }

        [When(@"Diligencio nombre de campo adicional de compañía")]
        public void WhenDiligencioNombreDeCampoAdicionalDeCompania()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input", AFCompanyName);
            AFCompanyName = CommonElementsAction.VallueExtract("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input");
        }

        [When(@"Doy click en Aceptar campo adicional de compañía")]
        public void WhenDoyClickEnAceptarCampoAdicionalDeCompania()
        {
            CommonElementsAction.Click("CssSelector", AFCompaniesPage.AFCompaniesAccept);
        }

        [When(@"Doy click en Guardar campo adicional de compañía")]
        public void WhenDoyClickEnGuardarCampoAdicionalDeCompania()
        {
            CommonElementsAction.Click("XPath", AFCompaniesPage.AFCompaniesSubmit);
        }

        [Then(@"Se muestra un mensaje indicando que se creo que campo adicional de compañía correctamente")]
        public void ThenSeMuestraUnMensajeIndicandoQueSeCreoQueCampoAdicionalDeCompaniaCorrectamente()
        {
            string Message = CommonElementsAction.TextExtract("XPath", Messages.ResponseSuccessAFClient);
            Validation.ValidationSuccessAFCreate(Messages.ResponseSuccessAFClient);
        }

        [Then(@"Se registra campo adicional de compañía de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeCompaniaDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 1 AND name = '" + AFCompanyName + "';", 1);
        }

        [Given(@"No existe el campo adicional de compañía")]
        public void GivenNoExisteElCampoAdicionalDeCompania()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Modificación exitosa de campos adicionales compañías")]
        public void WhenModificacionExitosaDeCamposAdicionalesCompanias()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Eliminación exitosa de campos adicionales compañías")]
        public void WhenEliminacionExitosaDeCamposAdicionalesCompanias()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Creación exitosa de campos adicionales compañias")]
        public void WhenCreacionExitosaDeCamposAdicionalesCompanias()
        {
            //

            /// And Pulso el botón de Nuevo
            CommonElementsAction.Click("XPath", AFCompaniesPage.AFCompaniesButtonNew);

            ///     And diligencio el campo de nombre

            CommonElementsAction.SendKeys_InputText("XPath", AFCompaniesPage.AFCompaniesInputLabel, "Nombre completo");

            ///     And diligencio el campo de tipo
            //CommonElementsAction.ClickAndSelect_DropDownIndex("XPath",AFCompaniesPage.SelectAFCompaniesListType,1,"Option");

            ///     And pulso el botón aceptar
            CommonElementsAction.Click("CssSelector", AFCompaniesPage.AFCompaniesAccept);

            ///     And pulso el botón guardar
            CommonElementsAction.Click("CssSelector", AFCompaniesPage.AFCompaniesSubmit);

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }
    }
}