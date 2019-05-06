using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class SkillsSteps
    {
        private SkillsPage SkillsPage = new SkillsPage();

        private readonly PageMessages PageMessages = new PageMessages();

        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        private string SkillName;
        private string DefaulltSkillName = "UI Skill ";
        private string EditSkillName = "UI Edit Skill ";

        [Given(@"No existe la habilidad")]
        public void GivenNoExisteLaHabilidad()
        {
            SkillName = DefaulltSkillName + Functions.RandomText(5);
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SKILLS WHERE skll_name = '" + SkillName + "';", 0);
        }

        [When(@"Doy click en Nueva habilidad")]
        public void WhenDoyClickEnNuevaHabilidad()
        {
            CommonElementsAction.Click("CssSelector", SkillsPage.ButtonNew);
        }

        [When(@"Diligencio nombre de habilidad")]
        public void WhenDiligencioNombreDeHabilidad()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", SkillsPage.SkillInputSkillName, SkillName);
        }

        [When(@"Diligencio descripción de habilidad")]
        public void WhenDiligencioDescripcionDeHabilidad()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", SkillsPage.SkillTextareaSkillDescription, "Skill Automat Description");
        }

        [When(@"Doy click en Guardar habilidad")]
        public void WhenDoyClickEnGuardarHabilidad()
        {
            CommonElementsAction.Click("CssSelector", SkillsPage.SkillButtonSubmit);
        }

        [Then(@"Se registra la habilidad en la tabla AFLS_SKILLS")]
        public void ThenSeRegistraLaHabilidadEnLaTablaAFLS_SKILLS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SKILLS WHERE skll_name = '" + SkillName + "';", 1);
        }

        [Given(@"Existe la habilidad")]
        public void GivenExisteLaHabilidad()
        {
            SkillName = CommonQuery.DBSelectAValue("SELECT TOP 1 skll_name FROM AFLS_SKILLS ORDER BY NEWID();", 1);
        }

        [Then(@"Se muestra una ventana emergente indicando que la habilidad ya existe")]
        public void ThenSeMuestraUnaVentanaEmergenteIndicandoQueLaHabilidadYaExiste()
        {
            Thread.Sleep(5000);
            CommonElementsAction.Click("XPath", "//div[3]/div/button/span");
        }

        [When(@"Diligencio nombre de habilidad existente")]
        public void WhenDiligencioNombreDeHabilidadExistente()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", SkillsPage.SkillInputSkillName, SkillName);
            CommonElementsAction.Click("CssSelector", SkillsPage.SkillTextareaSkillDescription);
        }

        [When(@"Doy click en Cancelar habilidad")]
        public void WhenDoyClickEnCancelarHabilidad()
        {
            CommonElementsAction.Click("CssSelector", SkillsPage.SkillButtonCancel);
        }

        [When(@"Selecciono Aceptar en mensaje de confirmación de cancelación de creación")]
        public void WhenSeleccionoAceptarEnMensajeDeConfirmacionDeCancelacionDeCreacion()
        {
            CommonElementsAction.Click("XPath", "//div[3]/div/button/span");
        }

        [Then(@"Se retorna a la pantalla de habilidades")]
        public void ThenSeRetorna()
        {
            CommonElementsAction.WaitElement(SkillsPage.SkillInputSkillName, "CssSelector");
        }

        [Then(@"No Se registra la habilidad en la tabla AFLS_SKILLS")]
        public void ThenNoSeRegistraLaHabilidadEnLaTablaAFLS_SKILLS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SKILLS WHERE skll_name = '" + SkillName + "';", 0);
        }

        [When(@"Busco y selecciono la habilidad")]
        public void WhenBuscoYSeleccionoLaHabilidad()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", SkillsPage.InputSearch, SkillName);
            CommonElementsAction.Click("CssSelector", SkillsPage.ButtonSearch);

            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath", SkillsPage.SkillTitleItemView);
        }

        [Then(@"Se muestra la tarjeta de la habilidad y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDeLaHabilidadYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(SkillsPage.SkillInputSkillName)).GetAttribute("value");
            Assert.AreEqual(SkillName, Value);
        }

        [When(@"Edito nombre de habilidad")]
        public void WhenEditoNombreDeHabilidad()
        {
            EditSkillName = EditSkillName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", SkillsPage.SkillInputSkillName, EditSkillName);
        }

        [Then(@"Se registra la habilidad modificada en la tabla AFLS_SKILLS")]
        public void ThenSeRegistraLaHabilidadModificadaEnLaTablaAFLS_SKILLS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SKILLS WHERE skll_name = '" + EditSkillName + "';", 1);
        }

        [When(@"Edito nombre de habilidad dejándolo vacío")]
        public void WhenEditoNombreDeHabilidadDejandoloVacio()
        {
            CommonElementsAction.Clear("CssSelector", SkillsPage.SkillInputSkillName);
        }

        [When(@"Edito descripción de habilidad dejándolo vacío")]
        public void WhenEditoDescripcionDeHabilidadDejandoloVacio()
        {
            CommonElementsAction.Clear("CssSelector", SkillsPage.SkillTextareaSkillDescription);
        }

        [Given(@"Existe la habilidad activa")]
        public void GivenExisteLaHabilidadActiva()
        {
            SkillName = CommonQuery.DBSelectAValue("SELECT TOP 1 skll_name FROM AFLS_SKILLS WHERE skll_isActive = 1 ORDER BY NEWID();", 1);
        }

        [Then(@"Se registra la habilidad sin modificar en la tabla AFLS_SKILLS")]
        public void ThenSeRegistraLaHabilidadSinModificarEnLaTablaAFLS_SKILLS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_SKILLS WHERE skll_name = '" + SkillName + "';", 1);
        }

        [When(@"Doy click en switch de estado de habilidad")]
        public void WhenDoyClickEnSwitchDeEstadoDeHabilidad()
        {
            CommonElementsAction.Click("XPath", SkillsPage.SkillState);
        }

        [Then(@"Se registra la habilidad modificada a inactiva en la tabla AFLS_SKILLS")]
        public void ThenSeRegistraLaHabilidadModificadaAInactivaEnLaTablaAFLS_SKILLS()
        {
            SkillName = CommonQuery.DBSelectAValue("SELECT TOP 1 skll_name FROM AFLS_SKILLS WHERE skll_isActive = 0 AND skll_name = '" + SkillName + "';", 1);
        }

        [Then(@"Al buscar la habilidad se lista como inactiva")]
        public void ThenAlBuscarLaHabilidadSeListaComoInactiva()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", SkillsPage.InputSearch, SkillName);
            CommonElementsAction.Click("CssSelector", SkillsPage.ButtonSearch);

            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath", SkillsPage.SkillTitleItemView);

            Thread.Sleep(2000);

            CommonElementsAction.WaitElement("//div[@class='itemView selected']//span[@class='value lblInactive']");
        }

        [When(@"Doy click en eliminar habilidad")]
        public void WhenDoyClickEnEliminarHabilidad()
        {
            CommonElementsAction.Click("XPath", SkillsPage.SkillIconRemoved);
        }

        [Then(@"Se borra la habilidad de la tabla AFLS_SKILLS")]
        public void ThenSeBorraLaHabilidadDeLaTablaAFLS_SKILLS()
        {
            CommonQuery.DBSelectAValue("SELECT TOP 1 skll_name FROM AFLS_SKILLS WHERE skll_isActive = 0 AND skll_name = '" + SkillName + "';", 0);
        }

        [Then(@"Al buscar la habilidad no se lista")]
        public void ThenAlBuscarLaHabilidadNoSeLista()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", SkillsPage.InputSearch, SkillName);
            CommonElementsAction.Click("CssSelector", SkillsPage.ButtonSearch);

            Thread.Sleep(2000);
            CommonElementsAction.WaitElementNoFound(SkillsPage.SkillTitleItemView);
        }

        [When(@"Eliminación exitosa de habilidades")]
        public void WhenEliminacionExitosaDeHabilidades()
        {
            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", SkillsPage.InputSearch, "Instalador WT");
            CommonElementsAction.Click("CssSelector", SkillsPage.ButtonSearch);

            CommonElementsAction.Click("CssSelector", SkillsPage.SkillTitleItemView);

            //Delete element of List
            Thread.Sleep(3000);

            //End Delete element of List

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }
    }
}