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
    public class AFClientsSteps
    {
        private readonly AFClientsPage AFClientsPage = new AFClientsPage();
        private readonly PageMessages PageMessages = new PageMessages();
        private string AFClientName;
        private int CountOptions;
        private string DefaultAFClientName = "UI AFClient ";
        private string EditAFClientName = "UI Edit AFClient ";
        private string EditLabelAFClientName = "Edit UI AFClient ";
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private string Label;
        private string LabelAFClientName;
        private AFLSUIProjectTest.UIMap.ConfigurationMenuPage Menu = new AFLSUIProjectTest.UIMap.ConfigurationMenuPage();
        private MessagesElements Messages = new MessagesElements();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private int OrderField;
        private ResponseValidation Validation = new ResponseValidation();

        [Given(@"Existe el campo adicional de cliente de tipo simple")]
        public string GivenExisteElCampoAdicionalDeClienteDeTipoSimple()

        {
            AFClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 1 ORDER BY NEWID();", 1);
            return AFClientName;
        }

        [Given(@"Existe mas de un campo adicional de cliente")]
        public void GivenExisteMasDeUnCampoAdicionalDeCliente()
        {
            int FieldCount = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003;", 1));
            Assert.IsTrue(FieldCount > 1);
        }

        [Given(@"No existe el campo adicional de cliente de tipo fecha")]
        public void GivenNoExisteElCampoAdicionalDeClienteDeTipoFecha()
        {
            AFClientName = DefaultAFClientName + Functions.RandomText(4);
            LabelAFClientName = AFClientName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 4 AND name = '" + AFClientName + "';", 0);
        }

        [Given(@"No existe el campo adicional de cliente de tipo listado")]
        public void GivenNoExisteElCampoAdicionalDeClienteDeTipoListado()
        {
            AFClientName = DefaultAFClientName + Functions.RandomText(4);
            LabelAFClientName = AFClientName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 5 AND name = '" + AFClientName + "';", 0);
        }

        [Given(@"No existe el campo adicional de cliente de tipo numérico")]
        public string GivenNoExisteElCampoAdicionalDeClienteDeTipoNumerico()
        {
            AFClientName = DefaultAFClientName + Functions.RandomText(4);
            LabelAFClientName = AFClientName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 2 AND name = '" + AFClientName + "';", 0);
            return AFClientName;
        }

        [Given(@"No existe el campo adicional de cliente de tipo párrafo")]
        public string GivenNoExisteElCampoAdicionalDeClienteDeTipoParrafo()
        {
            AFClientName = DefaultAFClientName + Functions.RandomText(4);
            LabelAFClientName = AFClientName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 6 AND name = '" + AFClientName + "';", 0);
            return AFClientName;
        }

        [Given(@"No existe el campo adicional de cliente de tipo simple")]
        public string GivenNoExisteElCampoAdicionalDeClienteDeTipoSimple()
        {
            AFClientName = DefaultAFClientName + Functions.RandomText(4);
            LabelAFClientName = AFClientName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 1 AND name = '" + AFClientName + "';", 0);
            return AFClientName;
        }

        [Then(@"Se borra el registro de el campo adicional de cliente en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeBorraElRegistroDeElCampoAdicionalDeClienteEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 1 AND name = '" + AFClientName + "';", 0);
        }

        [Then(@"Se muestra un mensaje indicando que se creo que campo adicional de cliente correctamente")]
        public void ThenSeMuestraUnMensajeIndicandoQueSeCreoQueCampoAdicionalDeClienteCorrectamente()
        {
            Validation.ValidationSuccessAFCreate(Messages.ResponseSuccessAFClient);
        }

        [Then(@"Se registra campo adicional de cliente de tipo fecha en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeClienteDeTipoFechaEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 4 AND name = '" + AFClientName + "';", 1);
        }

        [Then(@"Se registra campo adicional de cliente de tipo listado en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeClienteDeTipoListadoEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 5 AND name = '" + AFClientName + "';", 1);
        }

        [Then(@"Se registra campo adicional de cliente de tipo numérico en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeClienteDeTipoNumericoEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 2 AND name = '" + AFClientName + "';", 1);
        }

        [Then(@"Se registra campo adicional de cliente de tipo párrafo en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeClienteDeTipoParrafoEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 6 AND name = '" + AFClientName + "';", 1);
        }

        [Then(@"Se registra campo adicional de cliente de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeClienteDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 1 AND name = '" + AFClientName + "';", 1);
        }

        [Then(@"Se registra el campo adicional de cliente modificado en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraElCampoAdicionalDeClienteModificadoEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 1 AND name = '" + AFClientName + "' AND label = '" + EditLabelAFClientName + "';", 1);
        }

        [Then(@"Se registra el campo adicional de cliente modificado en la tabla AFW_ADDiTIONAL_FIELDS con nuevo orden")]
        public void ThenSeRegistraElCampoAdicionalDeClienteModificadoEnLaTablaAFW_ADDiTIONAL_FIELDSConNuevoOrden()
        {
            int NewOrder = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT [order] FROM AFW_ADDITIONAL_FIELD WHERE label = '" + Label + "';", 1));
            Assert.AreNotEqual(OrderField, NewOrder);
        }

        [Then(@"Se registran las opciones de campo adicional de cliente de tipo listado en tabla AFW_ADDITIONAL_FIELD_LOOKUP")]
        public void ThenSeRegistranLasOpcionesDeCampoAdicionalDeClienteDeTipoListadoEnTablaAFW_ADDITIONAL_FIELD_LOOKUP()
        {
            int Options = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD_LOOKUP LP JOIN AFW_ADDITIONAL_FIELD AD ON LP.field_id = AD.id WHERE AD.name = '" + AFClientName + "';", 1));
            Assert.AreEqual(Options, CountOptions);
        }

        [When(@"Diligencio etiqueta de campo adicional de cliente")]
        public void WhenDiligencioEtiquetaDeCampoAdicionalDeCliente()
        {
            LabelAFClientName = DefaultAFClientName + Functions.RandomText(4);
            CommonElementsAction.SendKeys_InputText("XPath", AFClientsPage.AFClientsInputLabel, LabelAFClientName);
        }

        [When(@"Diligencio nombre de campo adicional de cliente")]
        public void WhenDiligencioNombreDeCampoAdicionalDeCliente()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input", AFClientName);
            AFClientName = CommonElementsAction.VallueExtract("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input");
        }

        [When(@"Diligencio texto de ayuda de campo adicional de cliente")]
        public void WhenDiligencioTextoDeAyudaDeCampoAdicionalDeCliente()
        {
            CommonElementsAction.SendKeys_InputText("XPath", "//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div/div[2]/div/textarea", "Descriptontext help message");
        }

        [When(@"Diligencio y confirmo las opciones de listado de cliente")]
        public void WhenDiligencioYConfirmoLasOpcionesDeListadoDeCliente()
        {
            Thread.Sleep(3000);
            IList<IWebElement> ListField = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li"));

            Random rdn = new Random();
            CountOptions = rdn.Next(3, 10);

            for (int i = 1; i <= CountOptions; i++)
            {
                try
                {
                    CommonHooks.driver.FindElement(By.XPath("//*[@id='addtional-fields-client']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/input"));
                    //CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/input[@class='new-option js-new-option k-valid']"));

                    UtilAction.SendKeys("//*[@id='addtional-fields-client']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/input", "OptionUI" + i.ToString());
                    Thread.Sleep(1000);
                    UtilAction.Click("//*[@id='addtional-fields-client']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/button");
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                }
            }
        }

        [When(@"Doy click en Aceptar campo adicional de cliente")]
        public void WhenDoyClickEnAceptarCampoAdicionalDeOrden()
        {
            CommonElementsAction.Click("CssSelector", AFClientsPage.AFClientsAccept);
        }

        [When(@"Doy click en editar el campo adicional de cliente de tipo simple")]
        public void WhenDoyClickEnEditarElCampoAdicionalDeClienteDeTipoSimple()
        {
            Thread.Sleep(3000);
            EditLabelAFClientName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND name = '" + AFClientName + "';", 1);

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

        [When(@"Doy click en eliminar el campo adicional de cliente de tipo simple")]
        public void WhenDoyClickEnEliminarElCampoAdicionalDeClienteDeTipoSimple()
        {
            Thread.Sleep(3000);
            LabelAFClientName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND name = '" + AFClientName + "';", 1);

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

        [When(@"Doy click en Guardar campo adicional de cliente")]
        public void WhenDoyClickEnGuardarCampoAdicionalDeOrden()
        {
            CommonElementsAction.Click("XPath", AFClientsPage.AFClientsSubmit);
        }

        [When(@"Doy click en Nuevo campo adicional de cliente")]
        public void WhenDoyClickEnNuevoCampoAdicionalDeCliente()
        {
            CommonElementsAction.Click("CssSelector", AFClientsPage.AFClientsButtonNew);
        }

        [When(@"Doy click en opciones avanzadas de campo adicional de cliente")]
        public void WhenDoyClickEnOpcionesAvanzadasDeCampoAdicionalDeCliente()
        {
            CommonElementsAction.Click("XPath", "//div[@id='addtional-fields-client']/div[1]/div[2]/ul/li/form/div[2]/div[3]/div[1]");
        }

        [When(@"Edito nombre de etiqueta de campo adicional de cliente de tipo simple")]
        public void WhenEditoNombreDeEtiquetaDeCampoAdicionalDeClienteDeTipoSimple()
        {
            EditLabelAFClientName = EditLabelAFClientName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", AFClientsPage.AFClientsInputLabel, EditLabelAFClientName);
        }

        [When(@"Selecciono el campo adicional y modifico su orden mediante drag and drop")]
        public void WhenSeleccionoElCampoAdicionalYModificoSuOrdenMedianteDragAndDrop()
        {
            Thread.Sleep(5000);
            CommonElementsAction.WaitElement("//div[@id='addtional-fields-client']//ul/li//div[@class='drag-button']", "XPath");

            int CountField = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003;", 1));
            OrderField = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 [order] FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 and [order] <> " + CountField + " ORDER BY NEWID();", 1));

            int count = 0;

            IList<IWebElement> AddFieldList = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-client']//ul/li//div[@class='drag-button']"));

            foreach (IWebElement Field in AddFieldList)
            {
                count++;
                if (count == OrderField)
                {
                    Actions Act = new Actions(CommonHooks.driver);
                    Label = CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-client']//ul/li[" + OrderField + "]//label[@class='additional-field-label primary_color']")).Text;

                    Act.MoveToElement(AddFieldList[OrderField]).DragAndDropToOffset(Field, 0, 180).Build().Perform();
                    Thread.Sleep(3000);
                }
            }
        }

        [When(@"Selecciono la opción Campos adicionales clientes")]
        public void WhenSeleccionoLaOpcionCamposAdicionalesClientes()
        {
            CommonElementsAction.Click("XPath", AFClientsPage.AFClientsModulePath);
            CommonElementsAction.Click("XPath", Menu.AFClientsOption);
        }

        [When(@"Selecciono tipo de campo adicional de cliente fecha")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeClienteFecha()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "3");
        }

        [When(@"Selecciono tipo de campo adicional de cliente listado")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeClienteListado()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "4");
        }

        [When(@"Selecciono tipo de campo adicional de cliente numérico")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeClienteNumerico()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "2");
        }

        [When(@"Selecciono tipo de campo adicional de cliente párrafo")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeClienteParrafo()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", "//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "párrafo", "option");
        }

        [When(@"Selecciono tipo de campo adicional de cliente simple")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeClienteSimple()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", "//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "simple", "option");
        }
    }
}