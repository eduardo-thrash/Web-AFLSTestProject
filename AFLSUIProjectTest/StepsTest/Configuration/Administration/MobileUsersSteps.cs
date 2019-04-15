using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.Configuration.Administration
{
    [Binding]
    public class MobileUsersSteps
    {
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private MobileUsersPage MobileUsersPage = new MobileUsersPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();

        private string user_nickname = "ui.eduardo.mobile";
        private string user_name = "Ui Eduardo Montenegro Mobile";
        private int UserId;
        private string user_mail;

        [Given(@"No existe el usuario móvil")]
        public void GivenNoExisteElUsuarioMovil()

        {
            CommonQuery.DBSelectAValue("SELECT * FROM  AFW_USERS WHERE user_nick_name = '" + user_nickname + "';", 0);
        }

        [When(@"Accedo a ítem Configuración")]
        public void WhenAccedoAItemConfiguracion()
        {
            CommonElementsAction.Click("XPath", PrincipalMenuPage.ItemConfiguration);
        }

        [When(@"Accedo al menú Administración")]
        public void WhenAccedoAlMenuAdministracion()
        {
            CommonElementsAction.Click("CssSelector", ConfigurationMenuPage.AdministrationMenu);
        }

        [When(@"Selecciono la opción Usuarios Móviles")]
        public void WhenSeleccionoLaOpcionUsuariosMoviles()
        {
            CommonElementsAction.Click("XPath", MobileUsersPage.MobileUsersModulePath);
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MobileUserOption);
        }

        [When(@"Doy click en Nuevo usuario móvil")]
        public void WhenDoyClickEnNuevoUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserButtonNew);
        }

        [When(@"Diligencio nombre de usuario móvil")]
        public void WhenDiligencioNombreDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserName, user_name);
        }

        [When(@"Diligencio usuario de usuario móvil")]
        public void WhenDiligencioUsuarioDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserUserName, user_nickname);
        }

        [When(@"diligencio correo electrónico valido de usuario móvil")]
        public void WhenDiligencioCorreoElectronicoValidoDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserEmail, "eduardo@mailer.com");
        }

        [When(@"Diligencio teléfono de usuario móvil")]
        public void WhenDiligencioTelefonoDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserPhone, "3008425830");
        }

        [When(@"diligencio contraseña de usuario móvil")]
        public void WhenDiligencioContrasenaDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserPassword, "123456");
        }

        [When(@"selecciono cargo de usuario móvil")]
        public void WhenSeleccionoCargoDeUsuarioMovil()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("CssSelector", MobileUsersPage.MobileUserPosition, MobileUsersPage.MobileUserPositionOption);
        }

        [When(@"diligencio dirección valida de usuario móvil")]
        public void WhenDiligencioDireccionValidaDeUsuarioMovil()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA");
        }

        [When(@"selecciono sede de inventario")]
        public void WhenSeleccionoSedeDeInventario()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("CssSelector", MobileUsersPage.MobileUserLocation, MobileUsersPage.MobileUserLocationOption);
        }

        [When(@"selecciono tipo de transporte de usuario móvil")]
        public void WhenSeleccionoTipoDeTransporteDeUsuarioMovil()
        {
            string Vehicle = CommonQuery.DBSelectAValue("SELECT TOP 1 vehi_name FROM AFLS_VEHICLE_TYPE ORDER BY NEWID();", 1);
            CommonElementsAction.ClickAndSelect_DropDownList("XPath", MobileUsersPage.MobileUserTransport, Vehicle, "label");
        }

        [When(@"selecciono proveedor de usuario móvil")]
        public void WhenSeleccionoProveedorDeUsuarioMovil()
        {
            CommonElementsAction.ClickAndSelect_Random_DropDownList("XPath", MobileUsersPage.MobileUserProvider, MobileUsersPage.MobileUserProviderOption);
        }

        [When(@"Doy click en switch de estado de usuario móvil")]
        public void WhenDoyClickEnSwitchDeEstadoDeUsuarioMovil()
        {
            CommonElementsAction.Click("XPath", MobileUsersPage.MobileUserState);
        }

        [When(@"Selecciono el Tab de grupos móvil de usuario móvil")]
        public void WhenSeleccionoElTabDeGruposMovilDeUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.TabMobileUserMobileGroups);
        }

        [When(@"Selecciono el Tab de disponibilidad de usuario móvil")]
        public void WhenSeleccionoElTabDeDisponibilidadDeUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.TabMobileUserAvilibily);
        }

        [When(@"Selecciono disponibilidad de siete días a usuario móvil")]
        public void WhenSeleccionoDisponibilidadDeSieteDiasAUsuarioMovil()
        {
            Actions Sunday = new Actions(CommonHooks.driver);
            Sunday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[2]")), 0, 500).Build().Perform();
            Thread.Sleep(500);

            Actions Monday = new Actions(CommonHooks.driver);
            Monday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[3]")), 0, 500).Build().Perform();
            Thread.Sleep(500);

            Actions Tuesday = new Actions(CommonHooks.driver);
            Tuesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[4]")), 0, 500).Build().Perform();
            Thread.Sleep(500);

            Actions Wednesday = new Actions(CommonHooks.driver);
            Wednesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[5]")), 0, 500).Build().Perform();
            Thread.Sleep(500);

            Actions Thursday = new Actions(CommonHooks.driver);
            Thursday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[6]")), 0, 500).Build().Perform();
            Thread.Sleep(500);

            Actions Friday = new Actions(CommonHooks.driver);
            Friday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[7]")), 0, 500).Build().Perform();
            Thread.Sleep(500);

            Actions Saturday = new Actions(CommonHooks.driver);
            Saturday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[8]")), 0, 100).Build().Perform();
            Thread.Sleep(500);
        }

        [When(@"Selecciono el Tab de habilidades de usuario móvil")]
        public void WhenSeleccionoElTabDeHabilidadesDeUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.TabMobileUserSkills);
        }

        [When(@"Diligencio y selecciono un grupo móvil para usuario móvil")]
        public void WhenDiligencioYSeleccionoUnGrupoMovilParaUsuarioMovil()
        {
            CommonElementsAction.ClickAndSelect_Random_ComboboxAutocomplete("XPath", MobileUsersPage.MobileUserMobileGroups, MobileUsersPage.MobileUserMobileGroupsOption);
        }

        [When(@"Diligencio y selecciono una habilidad para usuario móvil")]
        public void WhenDiligencioYSeleccionoUnaHabilidadParaUsuarioMovil()
        {
            CommonElementsAction.ClickAndSelect_Random_ComboboxAutocomplete("XPath", MobileUsersPage.MobileUserSkill, MobileUsersPage.MobileUserSkillOption);
        }

        [When(@"Selecciono el tab Información de usuario móvil")]
        public void WhenSeleccionoElTabInformacionDeUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserTabInfo);
        }

        [When(@"Doy click en Guardar usuario móvil")]
        public void WhenDoyClickEnGuardarUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserSubmit);
        }

        [Then(@"Se muestra mensaje indicando que se guardo el registro exitosamente")]
        public void ThenSeMuestraMensajeIndicandoQueSeGuardoElRegistroExitosamente()
        {
            ResponseValidation.ValidationSuccessCreate();
        }

        [Then(@"Se registra el usuario en la tabla AFW_USERS")]
        public void ThenSeRegistraElUsuarioEnLaTablaAFW_USERS()
        {
            CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = '" + user_nickname + "';", 1);
        }

        [Then(@"Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS")]
        public void ThenSeRegistraElUsuarioMovilConProveedorAsociadoEnLaTablaAFLS_USERS_SPECIALISTS()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT user_id FROM AFW_USERS WHERE user_nick_name = '" + user_nickname + "';", 1));
            CommonQuery.DBSelectAValue("SELECT user_id FROM AFLS_USERS_SPECIALISTS WHERE user_id = " + UserId + ";", 1);
        }

        [Then(@"Se registra disponibilidad de todos los días en la tabla AFLS_USER_AVAILABILITIES")]
        public void ThenSeRegistraDisponibilidadDeTodosLosDiasEnLaTablaAFLS_USER_AVAILABILITIES()
        {
            int NumDays = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_USER_AVAILABILITIES WHERE user_id = " + UserId + ";", 1));
            Assert.AreEqual(7, NumDays);
        }

        [Then(@"Se registra habilidad de usuario móvil en la tabla AFLS_USER_SKILLS")]
        public void ThenSeRegistraHabilidadDeUsuarioMovilEnLaTablaAFLS_USER_SKILLS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USER_SKILLS WHERE aus_user_id = " + UserId + ";", 1);
        }

        [Then(@"Se registra usuario móvil asociado a grupo móvil en la tabla AFW_GROUP_USER")]
        public void ThenSeRegistraUsuarioMovilAsociadoAGrupoMovilEnLaTablaAFW_GROUP_USER()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUP_USER WHERE user_id = " + UserId + ";", 1);
        }

        [Given(@"El usuario móvil existe")]
        public void GivenElUsuarioMovilExiste()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 user_id FROM AFLS_USERS_SPECIALISTS ORDER BY NEWID();", 1));
            user_name = CommonQuery.DBSelectAValue("SELECT user_name FROM  AFW_USERS WHERE user_id = '" + UserId + "';", 1);
        }

        [Given(@"El servidor de correo esta configurado como activo")]
        public void GivenElServidorDeCorreoEstaConfiguradoComoActivo()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_MAIL_ACCOUNT;", 1);
        }

        [When(@"Doy click en link de envío de correo de vinculación")]
        public void WhenDoyClickEnLinkDeEnvioDeCorreoDeVinculacion()
        {
            CommonElementsAction.Click("XPath", MobileUsersPage.MobileUserLinkMail);
        }

        [Then(@"Se muestra mensaje indicando que el correo se envió satisfactoriamente")]
        public void ThenSeMuestraMensajeIndicandoQueElCorreoSeEnvioSatisfactoriamente()
        {
            MessagesElements MessagesElements = new MessagesElements();
            MessagesCopies MessagesCopies = new MessagesCopies();

            IList<IWebElement> Messsages = CommonHooks.driver.FindElements(By.XPath(MessagesElements.ResponseElement));

            foreach (IWebElement Elements in Messsages)
            {
                string TextMessage = Elements.Text;
                try
                {
                    Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessMailSendToSpecialist));
                }
                catch
                {
                    Assert.Fail(TextMessage);
                }
            }
        }

        [Then(@"Se registra el mensaje de correo en la tabla AFW_MAIL sin enviar a destinatario aún")]
        public void ThenSeRegistraElMensajeDeCorreoEnLaTablaAFW_MAILSinEnviarADestinatarioAun()
        {
            user_mail = CommonQuery.DBSelectAValue("SELECT user_email FROM  AFW_USERS WHERE user_id = '" + UserId + "';", 1);
            CommonQuery.DBSelectAValue("SELECT mail_receiver FROM AFW_MAIL WHERE mail_receiver = '" + user_mail + "';", 1);
        }

        [When(@"Busco y selecciono el usuario móvil")]
        public void WhenBuscoYSeleccionoElUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserFieldSearch, CommonQuery.DBSelectAValue("SELECT user_nick_name FROM  AFW_USERS WHERE user_id = '" + UserId + "';", 1));
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserButtonSearch);
            Thread.Sleep(1000);
            CommonElementsAction.Click("XPath", MobileUsersPage.MobileUserView);
            Assert.AreEqual(user_name, CommonElementsAction.TextExtract("XPath", MobileUsersPage.MobileUserView));
        }

        [Given(@"El usuario móvil existe sin disponibilidad y habilidades")]
        public void GivenElUsuarioMovilExisteSinDisponibilidadYHabilidades()
        {
            CommonQuery.DBSelectAValue("SELECT TOP 1 usr.user_id FROM AFW_USERS usr left join AFLS_USER_SKILLS usk on usr.user_id = usk.aus_user_id left join AFLS_USER_AVAILABILITIES uav on usr.user_id = uav.user_id where usk.aus_user_id is null and uav.user_id is null order by NEWID();", 1);
        }

        [Given(@"Existe un grupo móvil con habilidades y disponibilidad")]
        public void GivenExisteUnGrupoMovilConHabilidadesYDisponibilidad()
        {
            ScenarioContext.Current.Pending();
        }
    }
}