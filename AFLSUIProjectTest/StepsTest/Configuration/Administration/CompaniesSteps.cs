using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class CompaniesSteps
    {
        private readonly CompaniesPage CompaniesPage = new CompaniesPage();
        private readonly PageMessages PageMessages = new PageMessages();

        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        private string DefaultCompanyName = "Company";
        private string EditCompanyName = "Edit company";
        private string CompanyName;
        private string CompanyUniqueReference;
        private string EditCompanyUniqueReference;
        private int ServId;
        private int AdditionalFieldFound = 0;
        private int CompId;

        [Given(@"No existe la compañía")]
        public void GivenNoExisteLaCompania()
        {
            CompanyName = DefaultCompanyName + Functions.RandomText(5);
            CompanyUniqueReference = Functions.RandomText(8);
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_COMPANIES WHERE comp_name = '" + CompanyName + "' AND comp_unique_reference = '" + CompanyUniqueReference + "';", 0);
        }

        [Given(@"Existe la compañía")]
        public void GivenExisteLaCompania()
        {
            CompanyUniqueReference = CommonQuery.DBSelectAValue("SELECT TOP 1 comp_unique_reference FROM AFLS_COMPANIES WHERE comp_active = 1 ORDER BY NEWID();", 1);
            CompanyName = CommonQuery.DBSelectAValue("SELECT comp_name FROM AFLS_COMPANIES WHERE comp_unique_reference = '" + CompanyUniqueReference + "';", 1);
        }

        [When(@"Doy click en Nueva compañía")]
        public void WhenDoyClickEnNuevaCompania()
        {
            CommonElementsAction.Click("CssSelector", CompaniesPage.CompanyButtonNew);
        }

        [When(@"Busco y selecciono la compañía")]
        public void WhenBuscoYSeleccionoLaCompania()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CompaniesPage.CompanyFieldSearch, CompanyName);
            CommonElementsAction.Click("CssSelector", CompaniesPage.CompanyButtonSearch);
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", CompaniesPage.CompanyView);

            Thread.Sleep(3000);
        }

        [Then(@"Se muestra la tarjeta de la compañía y el detalle de la misma")]
        public void ThenSeMuestraLaTarjetaDeLaCompaniaYElDetalleDeLaMisma()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(CompaniesPage.CompanyName)).GetAttribute("value");
            Assert.AreEqual(CompanyName, Value);
        }

        [When(@"Selecciono el Tab Compañía")]
        public void WhenSeleccionoElTabCompania()
        {
            CommonElementsAction.Click("CssSelector", CompaniesPage.CompanyTabCompany);
        }

        [When(@"Edito nombre de compañía")]
        public void WhenEditoNombreDeCompania()
        {
            EditCompanyName = EditCompanyName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", CompaniesPage.CompanyName, EditCompanyName);
        }

        [When(@"Edito código único de compañía")]
        public void WhenEditoCodigoUnicoDeCompania()
        {
            EditCompanyUniqueReference = EditCompanyUniqueReference + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", CompaniesPage.CompanyUniqueReference, EditCompanyUniqueReference);
        }

        [When(@"Diligencio nombre de compañía")]
        public void WhenDiligencioNombreDeCompania()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CompaniesPage.CompanyName, CompanyName);
        }

        [When(@"Diligencio código único de compañía")]
        public void WhenDiligencioCodigoUnicoDeCompania()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CompaniesPage.CompanyUniqueReference, CompanyUniqueReference);
        }

        [When(@"Diligencio dirección de compañía dando click en cursor")]
        public void WhenDiligencioDireccionDeCompaniaDandoClickEnCursor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CompaniesPage.CompanyAddress, "calle 64 # 5 22");
            CommonElementsAction.Click("XPath", CompaniesPage.CompanyAddressValidate);
        }

        [When(@"Diligencio nombre de contacto de compañía")]
        public void WhenDiligencioNombreDeContactoDeCompania()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CompaniesPage.CompanyContactName, "Jimena Lopex Ruiz");
        }

        [When(@"Diligencio teléfono de contacto de compañía")]
        public void WhenDiligencioTelefonoDeContactoDeCompania()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CompaniesPage.CompanyPhone, "980765689");
        }

        [When(@"Diligencio correo de contacto de compañía")]
        public void WhenDiligencioCorreoDeContactoDeCompania()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CompaniesPage.CompanyEmail, "company@companymail.com");
        }

        [When(@"Diligencio dirección de compañía")]
        public void WhenDiligencioDireccionDeCompania()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", CompaniesPage.CompanyAddress, "calle 64 # 5 22");
        }

        [When(@"Diligencio dirección de compañía dando enter")]
        public void WhenDiligencioDireccionDeCompaniaDandoEnter()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", CompaniesPage.CompanyAddress, "calle 64 # 5 22");
        }

        [When(@"Diligencio dirección de compañía dando tab")]
        public void WhenDiligencioDireccionDeCompaniaDandoTab()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", CompaniesPage.CompanyAddress, "calle 64 # 5 22");
            CommonHooks.driver.FindElement(By.CssSelector(CompaniesPage.CompanyAddress)).SendKeys(Keys.Tab);
        }

        [When(@"Doy click en switch de estado de compañía")]
        public void WhenDoyClickEnSwitchDeEstadoDeCompania()
        {
            CommonElementsAction.Click("XPath", CompaniesPage.CompanyState);
        }

        [When(@"Selecciono el Tab Servicios")]
        public void WhenSeleccionoElTabServicios()
        {
            CommonElementsAction.Click("CssSelector", CompaniesPage.CompanyTabServices);
        }

        [When(@"Diligencio y selecciono el servicio para la compañía")]
        public int WhenDiligencioYSeleccionoElServicioParaLaCompania()
        {
            Actions action = new Actions(CommonHooks.driver);
            IWebElement ServicesCompany = CommonHooks.driver.FindElement(By.CssSelector(CompaniesPage.CompanyServices));
            action.MoveToElement(ServicesCompany);

            ServId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 serv_id FROM AFLS_SERVICES ORDER BY NEWID();", 1));
            string ServName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_id = " + ServId + ";", 1);
            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector", CompaniesPage.CompanyServices, ServName, "a");
            return ServId;
        }

        [When(@"Selecciono el Tab Campos adicionales")]
        public void WhenSeleccionoElTabCamposAdicionales()
        {
            CommonElementsAction.Click("CssSelector", CompaniesPage.CompanyTabAdditionalFields);
        }

        [When(@"Diligencio campos adicionales de compañía")]
        public int WhenDiligencioCamposAdicionalesDeCompania()
        {
            try
            {
                IList<IWebElement> AFCompaniesListInputText = CommonHooks.driver.FindElements(By.XPath("//div[@class='companies']//div[@id='tabs-3']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@class='js-input-additional-field k-valid' and @type='text']"));
                foreach (IWebElement AFClient in AFCompaniesListInputText)
                {
                    AFClient.Clear();
                    AFClient.SendKeys(Functions.RandomText(10));
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFCompaniesListTextarea = CommonHooks.driver.FindElements(By.XPath("//div[@class='companies']//div[@id='tabs-3']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//textarea"));
                foreach (IWebElement AFClient in AFCompaniesListTextarea)
                {
                    AFClient.Clear();
                    AFClient.SendKeys("Texto parrafo");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFCompaniesListNumber = CommonHooks.driver.FindElements(By.XPath("//div[@class='companies']//div[@id='tabs-3']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@type='number']"));
                foreach (IWebElement AFClient in AFCompaniesListNumber)
                {
                    AFClient.Clear();
                    AFClient.SendKeys("123456");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFCompaniesListDate = CommonHooks.driver.FindElements(By.XPath("//div[@class='companies']//div[@id='tabs-3']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//span[@class='k-icon k-i-calendar']"));
                foreach (IWebElement AFClient in AFCompaniesListDate)
                {
                    AFClient.Click();
                    CommonElementsAction.Click("XPath", "//div[@class='k-widget k-calendar']/table/tbody/tr/td/a");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFCompaniesListSelect = CommonHooks.driver.FindElements(By.XPath("//div[@class='companies']//div[@id='tabs-3']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//select"));
                foreach (IWebElement AFClient in AFCompaniesListSelect)
                {
                    new SelectElement(AFClient).SelectByIndex(1);
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

            return AdditionalFieldFound;
        }

        [When(@"Doy click en Guardar compañía")]
        public void WhenDoyClickEnGuardarCompania()
        {
            CommonElementsAction.Click("CssSelector", CompaniesPage.CompanySubmit);
        }

        [Then(@"Se registra la compañía en la tabla AFLS_COMPANIES")]
        public void ThenSeRegistraLaCompaniaEnLaTablaAFLS_COMPANIES()
        {
            CompId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT * FROM AFLS_COMPANIES WHERE comp_name = '" + CompanyName + "' AND comp_unique_reference = '" + CompanyUniqueReference + "';", 1));
        }

        [Then(@"Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección")]
        public void ThenSeRegistraLaCompaniaEnLaTablaAFLS_COMPANIESConLongitudLatitudYDireccion()
        {
            try
            {
                CompId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT * FROM AFLS_COMPANIES WHERE comp_name = '" + CompanyName + "' AND comp_unique_reference = '" + CompanyUniqueReference + "' AND comp_contact_longitude IS NOT NULL AND comp_contact_latitude IS NOT NULL AND comp_contact_address IS NOT NULL;", 1));
            }
            catch
            {
                Assert.Fail("Fallo en consulta " + "SELECT * FROM AFLS_COMPANIES WHERE comp_name = '" + CompanyName + "' AND comp_unique_reference = '" + CompanyUniqueReference + "' AND comp_contact_longitude IS NOT NULL AND comp_contact_latitude IS NOT NULL AND comp_contact_address IS NOT NULL;");
            }
        }

        [Then(@"Se registra la compañía modificada en la tabla AFLS_COMPANIES")]
        public void ThenSeRegistraLaCompaniaModificadaEnLaTablaAFLS_COMPANIES()
        {
            CompId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT * FROM AFLS_COMPANIES WHERE comp_name = '" + EditCompanyName + "' AND comp_unique_reference = '" + EditCompanyUniqueReference + "';", 1));
        }

        [Then(@"Se registra el servicio asociado a compañía en la tabla AFLS_COMPANY_SERVICES")]
        public void ThenSeRegistraElServicioAsociadoACompaniaEnLaTablaAFLS_COMPANY_SERVICES()
        {
            try
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFLS_COMPANY_SERVICES WHERE serv_id = " + ServId + "  AND comp_id = " + CompId + ";", 1);
            }
            catch
            {
                Assert.Fail("No se registra relación de servicios y compañía. Requisito para prueba.");
            }
        }

        [Then(@"se registran campos adicionales de compañía diligenciados en la tabla AFW_ADDITIONAL_FIELD_VALUE")]
        public void ThenSeRegistranCamposAdicionalesDeCompaniaDiligenciadosEnLaTablaAFW_ADDITIONAL_FIELD_VALUE()
        {
            int AdditionalFieldCompanyResult = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_VALUE AFV ON AFV.field_id = AF.id WHERE AF.definition_id = 5 AND AFV.item_id = " + CompId + ";", 1));

            Assert.AreEqual(AdditionalFieldFound, AdditionalFieldCompanyResult);
        }

        [When(@"Doy click en eliminar compañía")]
        public void WhenDoyClickEnEliminarCompania()
        {
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", CompaniesPage.CompanyIconRemoved);
        }

        [Then(@"Se borra compañía de la tabla AFLS_COMPANIES")]
        public void ThenSeBorraCompaniaDeLaTablaAFLS_COMPANIES()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_COMPANIES WHERE comp_name = '" + CompanyName + "' AND comp_unique_reference = '" + CompanyUniqueReference + "';", 0);
        }

        [Then(@"Al buscar la compañía en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarLaCompaniaEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", CompaniesPage.CompanyFieldSearch, CompanyName);
            CommonElementsAction.Click("CssSelector", CompaniesPage.CompanyButtonSearch);

            CommonElementsAction.WaitElementNoFound(CompaniesPage.CompanyView);
        }
    }
}