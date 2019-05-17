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
    public class AFOrdersSteps
    {
        private readonly AFOrdersPage AFOrdersPage = new AFOrdersPage();
        private readonly PageMessages PageMessages = new PageMessages();

        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesElements Messages = new MessagesElements();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private ResponseValidation Validation = new ResponseValidation();
        private AFLSUIProjectTest.UIMap.ConfigurationMenuPage Menu = new AFLSUIProjectTest.UIMap.ConfigurationMenuPage();
        private string AFOrderName;
        private string LabelAFOrderName;
        private string DefaultAFOrderName = "UI AFOrder Simple";
        private string EditLabelAFOrderName = "UI Edit AFOrder Simple";

        [When(@"Edito nombre de etiqueta de campo adicional de orden de tipo simple")]
        public void WhenEditoNombreDeEtiquetaDeCampoAdicionalDeOrdenDeTipoSimple()
        {
            EditLabelAFOrderName = EditLabelAFOrderName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", AFOrdersPage.ETag, EditLabelAFOrderName);
        }

        [Then(@"Se registra el campo adicional de orden modificado en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraElCampoAdicionalDeOrdenModificadoEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34005 AND type_id = 1 AND name = '" + AFOrderName + "' AND label = '" + EditLabelAFOrderName + "';", 1);
        }

        [When(@"Doy click en Si de mensaje de confirmación de borrado de campo adicional")]
        public void WhenDoyClickEnSiDeMensajeDeConfirmacionDeBorradoDeCampoAdicional()
        {
            CommonElementsAction.Click("CssSelector", "button.bkgColor1.js-button-yes");
        }

        [Then(@"Se borra el registro de el campo adicional de orden en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeBorraElRegistroDeElCampoAdicionalDeOrdenEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34005 AND type_id = 1 AND name = '" + AFOrderName + "';", 0);
        }

        [Given(@"No existe el campo adicional de orden de tipo simple")]
        public string GivenNoExisteElCampoAdicionalDeOrdenDeTipoSimple()
        {
            AFOrderName = DefaultAFOrderName + Functions.RandomText(4);

            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34005 AND name = '" + AFOrderName + "';", 0);
            return AFOrderName;
        }

        [When(@"Selecciono la opción Campos adicionales de ordenes")]
        public void WhenSeleccionoLaOpcionCamposAdicionalesDeOrdenes()
        {
            CommonElementsAction.Click("XPath", AFOrdersPage.AFOrdersModulePath);
            CommonElementsAction.Click("XPath", Menu.AFOrdersOption);
        }

        [When(@"Doy click en Nuevo campo adicional de orden")]
        public void WhenDoyClickEnNuevoCampoAdicionalDeOrden()
        {
            CommonElementsAction.Click("XPath", AFOrdersPage.ENew);
        }

        [When(@"Diligencio etiqueta de campo adicional de orden")]
        public void WhenDiligencioEtiquetaDeCampoAdicionalDeOrden()
        {
            LabelAFOrderName = AFOrderName;
            CommonElementsAction.SendKeys_InputText("XPath", AFOrdersPage.ETag, LabelAFOrderName);
        }

        [When(@"Selecciono tipo de campo adicional de orden simple")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeOrdenSimple()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", "//div[@id='addtional-fields-workorders-general']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "simple", "option");
        }

        [When(@"Diligencio texto de ayuda de campo adicional de orden")]
        public void WhenDiligencioTextoDeAyudaDeCampoAdicionalDeOrden()
        {
            CommonElementsAction.SendKeys_InputText("XPath", "//div[@id='addtional-fields-workorders-general']/div/div[2]/ul/li/form/div[2]/div/div[2]/div/textarea", "Descriptontext help message");
        }

        [When(@"Doy click en opciones avanzadas de campo adicional de oren")]
        public void WhenDoyClickEnOpcionesAvanzadasDeCampoAdicionalDeOren()
        {
            CommonElementsAction.Click("XPath", "//div[@id='addtional-fields-workorders-general']/div[1]/div[2]/ul/li/form/div[2]/div[3]/div[1]");
        }

        [When(@"Diligencio nombre de campo adicional de orden")]
        public void WhenDiligencioNombreDeCampoAdicionalDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input", AFOrderName);
            AFOrderName = CommonElementsAction.VallueExtract("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input");
        }

        [Then(@"Se registra campo adicional de orden de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeOrdenDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34005 AND type_id = 1 AND name = '" + AFOrderName + "';", 1);
        }

        [Then(@"Se muestra un mensaje indicando que se creo que campo adicional de orden correctamente")]
        public void ThenSeMuestraUnMensajeIndicandoQueSeCreoQueCampoAdicionalDeOrdenCorrectamente()
        {
            string Message = CommonElementsAction.TextExtract("XPath", Messages.ResponseSuccessAFClient);
            Validation.ValidationSuccessAFCreate(Messages.ResponseSuccessAFClient);
        }

        [When(@"Doy click en Aceptar campo adicional de orden")]
        public void WhenDoyClickEnAceptarCampoAdicionalDeOrden()
        {
            CommonElementsAction.Click("XPath", AFOrdersPage.EAccept);
        }

        [When(@"Doy click en Guardar campo adicional de orden")]
        public void WhenDoyClickEnGuardarCampoAdicionalDeOrden()
        {
            CommonElementsAction.Click("XPath", AFOrdersPage.ESave);
        }

        [Given(@"Existe el campo adicional de orden de tipo simple")]
        public string GivenExisteElCampoAdicionalDeOrdenDeTipoSimple()
        {
            AFOrderName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34005 AND type_id = 1 ORDER BY NEWID();", 1);
            return AFOrderName;
        }

        [When(@"Doy click en editar el campo adicional de orden de tipo simple")]
        public void WhenDoyClickEnEditarElCampoAdicionalDeOrdenDeTipoSimple()
        {
            Thread.Sleep(3000);
            LabelAFOrderName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34005 AND name = '" + AFOrderName + "';", 1);

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-workorders-general']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonEdit = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == LabelAFOrderName)
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
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + LabelAFOrderName);
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-workorders-general']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
        }

        [When(@"Modifico etiqueta de campo adicional de orden de tipo simple")]
        public void WhenModificoEtiquetaDeCampoAdicionalDeOrdenDeTipoSimple()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Modifico nombre de campo adicional de orden de tipo simple")]
        public void WhenModificoNombreDeCampoAdicionalDeOrdenDeTipoSimple()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se modifican datos de campo adicional de orden de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeModificanDatosDeCampoAdicionalDeOrdenDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en eliminar el campo adicional de orden de tipo simple")]
        public void WhenDoyClickEnEliminarElCampoAdicionalDeOrdenDeTipoSimple()
        {
            Thread.Sleep(3000);
            LabelAFOrderName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34005 AND name = '" + AFOrderName + "';", 1);

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-workorders-general']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonDelete = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == LabelAFOrderName)
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
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + LabelAFOrderName);
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-workorders-general']/div/div[2]/ul/li[" + IndexButtonDelete + "]/div/div/button[@class='delete-button secondary_bg js-delete-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
        }

        [When(@"Doy click en Aceptar de mensaje de confirmación de campo adicional de orden")]
        public void WhenDoyClickEnAceptarDeMensajeDeConfirmacionDeCampoAdicionalDeOrden()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se elimina el registro de campo adicional de orden de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeEliminaElRegistroDeCampoAdicionalDeOrdenDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Crear campo adicional de orden de tipo simple")]
        public void WhenCrearCampoAdicionalDeOrdenDeTipoSimple()
        {
            // And Yo ingreso a la pantalla de campos adicionales de ordenes

            // AFLSUIProjectTest.CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,AFOrdersPage.EOption,AFOrdersPage.AFOrdersModulePath);

            // When Cuando pulso nuevo campo adicional
            CommonElementsAction.Click("XPath", AFOrdersPage.ENew);

            // And diligencio etiqueta de campo adicional
            CommonElementsAction.SendKeys_InputText("XPath", AFOrdersPage.ETag, "Campo texto automation simple");

            // And selecciono campo tipo simple
            CommonElementsAction.SendKeys_InputText("XPath", AFOrdersPage.ETag, "Campo texto automation simple");

            // CommonElementsAction.ClickAndSelect_DropDownIndex("XPath",AFOrdersPage.ETypeOption,1,"Option");

            // And Diligencio descripción de OLA del campo adicional
            CommonElementsAction.SendKeys_InputText("XPath", AFOrdersPage.EHelpText, "Texto de ayuda de automatización");

            // And pulso Aceptar en campo adicional de orden
            CommonElementsAction.Click("XPath", AFOrdersPage.EAccept);

            // And pulso Guardar en control general de campos adicionales de ordenes
            CommonElementsAction.Click("XPath", AFOrdersPage.ESave);

            //Validate response.

            //End Validate response.

            // And se refleja el registro de campo adicional de ordenes almacenado en base de datos
            CommonQuery.DBSelectAValue("SELECT Label  FROM AFW_ADDITIONAL_FIELD  where Label = 'Campo texto automation simple'  and TypeId = 1  and HelpMessage = 'Texto de ayuda de automatización'", 1);
        }

        [When(@"Editar campo adicional de orden de tipo simple")]
        public void WhenEditarCampoAdicionalDeOrdenDeTipoSimple()
        {
            // Given Tengo rol administrador
            CommonQuery.DBSelectAValue("SELECT USER_NICK_NAME FROM AFW_USERS WHERE user_nick_name = 'ADMINISTRATOR';", 1);

            // And existe un campo adicional de tipo simple
            string NameEdit = CommonQuery.DBSelectAValue("SELECT Label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34005 AND TypeId = 1;", 1);

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,AFOrdersPage.EOption,AFOrdersPage.AFOrdersModulePath);

            // When Yo pulso editar sobre el campo adicional de tipo simple
            string Option = "Nombre orden";

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-workorders-general']/div/div[2]/ul/li/div/div[2]/div/label"));

            String[] allText = new String[all.Count];
            int IndexButtonEdit = 0;

            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == Option)
                {
                    IndexButtonEdit = count + 1;
                }
            }

            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);

            CommonElementsAction.SendKeys_InputText("XPath", AFOrdersPage.ETag, "Edita automation field");

            // And pulso Aceptar en campo adicional de orden
            CommonElementsAction.Click("XPath", AFOrdersPage.EAccept);

            // And pulso Guardar en control general de campos adicionales de ordenes
            CommonElementsAction.Click("XPath", AFOrdersPage.ESave);

            //Validate response.

            //End Validate response.

            // And se refleja modificado el registro de campo adicionalsimple  de ordenes almacenado en base de datos
            CommonQuery.DBSelectAValue("SELECT Label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34005 AND TypeId = 1 and Label = 'Edita automation field'", 1);
        }
    }
}