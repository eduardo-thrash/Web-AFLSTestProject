using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        private string AFCompanyName;
        private string DefaultAFCompanyName = "UI AFCompany Simple";
        private string EditAFCompanyName = "UI Edit AFCompany Simple";
        private string EditLabelAFCompanyName;
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private string LabelAFCompanyName;
        private AFLSUIProjectTest.UIMap.ConfigurationMenuPage Menu = new AFLSUIProjectTest.UIMap.ConfigurationMenuPage();
        private MessagesElements Messages = new MessagesElements();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private ResponseValidation Validation = new ResponseValidation();
        private int CountOptions;
        private int OrderField;
        private string Label;

        [Given(@"Existe el campo adicional de compañía de tipo simple")]
        public string GivenExisteElCampoAdicionalDeCompaniaDeTipoSimple()
        {
            AFCompanyName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 1 ORDER BY NEWID();", 1);
            return AFCompanyName;
        }

        [Given(@"No existe el campo adicional de compañía de tipo fecha")]
        public string GivenNoExisteElCampoAdicionalDeCompaniaDeTipoFecha()
        {
            AFCompanyName = DefaultAFCompanyName + Functions.RandomText(4);
            LabelAFCompanyName = AFCompanyName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 4 AND name = '" + AFCompanyName + "';", 0);
            return AFCompanyName;
        }

        [Given(@"No existe el campo adicional de compañía de tipo listado")]
        public string GivenNoExisteElCampoAdicionalDeCompaniaDeTipoListado()
        {
            AFCompanyName = DefaultAFCompanyName + Functions.RandomText(4);
            LabelAFCompanyName = AFCompanyName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 5 AND name = '" + AFCompanyName + "';", 0);
            return AFCompanyName;
        }

        [Given(@"No existe el campo adicional de compañía de tipo numérico")]
        public string GivenNoExisteElCampoAdicionalDeCompaniaDeTipoNumerico()
        {
            AFCompanyName = DefaultAFCompanyName + Functions.RandomText(4);
            LabelAFCompanyName = AFCompanyName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 2 AND name = '" + AFCompanyName + "';", 0);
            return AFCompanyName;
        }

        [Given(@"No existe el campo adicional de compañía de tipo párrafo")]
        public string GivenNoExisteElCampoAdicionalDeCompaniaDeTipoParrafo()
        {
            AFCompanyName = DefaultAFCompanyName + Functions.RandomText(4);
            LabelAFCompanyName = AFCompanyName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 6 AND name = '" + AFCompanyName + "';", 0);
            return AFCompanyName;
        }

        [Given(@"No existe el campo adicional de compañía de tipo simple")]
        public string GivenNoExisteElCampoAdicionalDeCompaniaDeTipoSimple()
        {
            AFCompanyName = DefaultAFCompanyName + Functions.RandomText(4);
            LabelAFCompanyName = AFCompanyName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND name = '" + AFCompanyName + "';", 0);
            return AFCompanyName;
        }

        [Then(@"Se borra el registro de el campo adicional de compañía en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeBorraElRegistroDeElCampoAdicionalDeCompaniaEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 1 AND name = '" + AFCompanyName + "';", 0);
        }

        [Then(@"Se muestra un mensaje indicando que se creo que campo adicional de compañía correctamente")]
        public void ThenSeMuestraUnMensajeIndicandoQueSeCreoQueCampoAdicionalDeCompaniaCorrectamente()
        {
            string Error = null;
            string Message = null;
            for (int second = 0; ; second++)
            {
                if (second >= 10) Assert.Fail(Error);
                try
                {
                    Message = CommonHooks.driver.FindElement(By.XPath("//div[@class='flag js-flag-box success']/p")).Text;
                    break;
                }
                catch (Exception e)
                {
                    Error = e.Message;
                    try
                    {
                        Message = CommonHooks.driver.FindElement(By.XPath("//div[@class='flag js-flag-box error']/p")).Text;
                        Assert.Fail(Message);
                    }
                    catch { Thread.Sleep(1000); }
                }
            }
        }

        [Then(@"Se registra el campo adicional de compañía modificado en la tabla AFW_ADDiTIONAL_FIELDS con nuevo orden")]
        public void ThenSeRegistraElCampoAdicionalDeCompaniaModificadoEnLaTablaAFW_ADDiTIONAL_FIELDSConNuevoOrden()
        {
            int NewOrder = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT [order] FROM AFW_ADDITIONAL_FIELD WHERE label = '" + Label + "';", 1));
            Assert.AreNotEqual(OrderField, NewOrder);
        }

        [Then(@"Se registra campo adicional de compañía de tipo fecha en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeCompaniaDeTipoFechaEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 4 AND name = '" + AFCompanyName + "';", 1);
        }

        [Then(@"Se registra campo adicional de compañía de tipo listado en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeCompaniaDeTipoListadoEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 5 AND name = '" + AFCompanyName + "';", 1);
        }

        [Then(@"Se registra campo adicional de compañía de tipo numérico en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeCompaniaDeTipoNumericoEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 2 AND name = '" + AFCompanyName + "';", 1);
        }

        [Then(@"Se registra campo adicional de compañía de tipo párrafo en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeCompaniaDeTipoParrafoEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 6 AND name = '" + AFCompanyName + "';", 1);
        }

        [Then(@"Se registra campo adicional de compañía de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeCompaniaDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 1 AND name = '" + AFCompanyName + "';", 1);
        }

        [Then(@"Se registra el campo adicional de compañía modificado en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraElCampoAdicionalDeCompaniaModificadoEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 AND type_id = 1 AND name = '" + AFCompanyName + "' AND label = '" + EditLabelAFCompanyName + "';", 1);
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

        [When(@"Diligencio etiqueta de campo adicional de compañía")]
        public void WhenDiligencioEtiquetaDeCampoAdicionalDeCompania()
        {
            LabelAFCompanyName = DefaultAFCompanyName + Functions.RandomText(4);
            CommonElementsAction.SendKeys_InputText("XPath", AFCompaniesPage.AFCompaniesInputLabel, LabelAFCompanyName);
        }

        [When(@"Diligencio nombre de campo adicional de compañía")]
        public void WhenDiligencioNombreDeCampoAdicionalDeCompania()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input", AFCompanyName);
            AFCompanyName = CommonElementsAction.VallueExtract("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input");
        }

        [When(@"Diligencio texto de ayuda de campo adicional de compañía")]
        public void WhenDiligencioTextoDeAyudaDeCampoAdicionalDeCompania()
        {
            CommonElementsAction.SendKeys_InputText("XPath", "//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div/div[2]/div/textarea", "Descriptontext help message");
        }

        [When(@"Diligencio y confirmo las opciones de listado de compañía")]
        public void WhenDiligencioYConfirmoLasOpcionesDeListadoDeCompania()
        {
            Thread.Sleep(3000);
            IList<IWebElement> ListField = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-company']/div/div[2]/ul/li"));

            Random rdn = new Random();
            CountOptions = rdn.Next(3, 10);

            for (int i = 1; i <= CountOptions; i++)
            {
                try
                {
                    CommonHooks.driver.FindElement(By.XPath("//*[@id='addtional-fields-company']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/input"));

                    UtilAction.SendKeys("//*[@id='addtional-fields-company']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/input", "OptionUI" + i.ToString());
                    Thread.Sleep(1000);
                    UtilAction.Click("//*[@id='addtional-fields-company']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/button");
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                }
            }
        }

        [Given(@"Existe mas de un campo adicional de compañía")]
        public void GivenExisteMasDeUnCampoAdicionalDeCompania()
        {
            int FieldCount = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004;", 1));
            Assert.IsTrue(FieldCount > 1);
        }

        [When(@"Selecciono el campo adicional de compañía y modifico su orden mediante drag and drop")]
        public void WhenSeleccionoElCampoAdicionalDeCompaniaYModificoSuOrdenMedianteDragAndDrop()
        {
            Thread.Sleep(5000);
            CommonElementsAction.WaitElement("//div[@id='addtional-fields-company']//ul/li//div[@class='drag-button']", "XPath");

            int CountField = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004;", 1));
            OrderField = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 [order] FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34004 and [order] <> " + CountField + " ORDER BY NEWID();", 1));

            int count = 0;

            IList<IWebElement> AddFieldList = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-company']//ul/li//div[@class='drag-button']"));

            foreach (IWebElement Field in AddFieldList)
            {
                count++;
                if (count == OrderField)
                {
                    Actions Act = new Actions(CommonHooks.driver);
                    Label = CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-company']//ul/li[" + OrderField + "]//label[@class='additional-field-label primary_color']")).Text;

                    Act.MoveToElement(AddFieldList[OrderField]).DragAndDropToOffset(Field, 0, 180).Build().Perform();
                    Thread.Sleep(3000);
                }
            }
        }

        [When(@"Doy click en Aceptar campo adicional de compañía")]
        public void WhenDoyClickEnAceptarCampoAdicionalDeCompania()
        {
            CommonElementsAction.Click("CssSelector", AFCompaniesPage.AFCompaniesAccept);
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

        [When(@"Doy click en Guardar campo adicional de compañía")]
        public void WhenDoyClickEnGuardarCampoAdicionalDeCompania()
        {
            CommonElementsAction.Click("XPath", AFCompaniesPage.AFCompaniesSubmit);
        }

        [When(@"Doy click en Nuevo campo adicional de compañía")]
        public void WhenDoyClickEnNuevoCampoAdicionalDeCompania()
        {
            CommonElementsAction.Click("CssSelector", AFCompaniesPage.AFCompaniesButtonNew);
        }

        [When(@"Doy click en opciones avanzadas de campo adicional de compañía")]
        public void WhenDoyClickEnOpcionesAvanzadasDeCampoAdicionalDeCompania()
        {
            CommonElementsAction.Click("XPath", "//div[@id='addtional-fields-company']/div[1]/div[2]/ul/li/form/div[2]/div[3]/div[1]");
        }

        [When(@"Edito nombre de etiqueta de campo adicional de compañía de tipo simple")]
        public void WhenEditoNombreDeEtiquetaDeCampoAdicionalDeCompaniaDeTipoSimple()
        {
            EditLabelAFCompanyName = EditLabelAFCompanyName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", AFCompaniesPage.AFCompaniesInputLabel, EditLabelAFCompanyName);
        }

        [When(@"Selecciono tipo de campo adicional de compañía fecha")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeCompaniaFecha()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "3");
        }

        [When(@"Selecciono tipo de campo adicional de compañía listado")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeCompaniaListado()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "4");
        }

        [When(@"Selecciono tipo de campo adicional de compañía numérico")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeCompaniaNumerico()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "2");
        }

        [When(@"Selecciono tipo de campo adicional de compañía párrafo")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeCompaniaParrafo()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "5");
        }

        [When(@"Selecciono tipo de campo adicional de compañía simple")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeCompaniaSimple()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "1");
        }
    }
}