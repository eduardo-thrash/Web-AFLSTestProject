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
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        private string Default_user_nickname = "ui.mobile.";
        private string user_nickname;
        private string user_name = "UI Eduardo Mobile";
        private int UserId;
        private string user_mail;
        private int GroupId;

        [Given(@"No existe el usuario móvil")]
        public void GivenNoExisteElUsuarioMovil()
        {
            user_nickname = Default_user_nickname + Functions.RandomText(3);
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
            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MobileUserOption);
            ResponseValidation.ValidateErrorAplication();
        }

        [When(@"Doy click en Nuevo usuario móvil")]
        public void WhenDoyClickEnNuevoUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserButtonNew);
        }

        [When(@"Diligencio nombre de usuario móvil")]
        public void WhenDiligencioNombreDeUsuarioMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserName, user_name + Functions.RandomText());
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

        [When(@"diligencio dirección valida de usuario móvil dando click en cursor")]
        public void WhenDiligencioDireccionValidaDeUsuarioMovilDandoClickEnCursor()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA");
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserAddressValidate);
        }

        [When(@"diligencio dirección valida de usuario móvil dando enter")]
        public void WhenDiligencioDireccionValidaDeUsuarioMovilDandoEnter()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector", MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA");
        }

        [When(@"diligencio dirección valida de usuario móvil dando tab")]
        public void WhenDiligencioDireccionValidaDeUsuarioMovilDandoTab()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserAddress, "CALLE 64 # 5-22 bOGOTA");
            CommonHooks.driver.FindElement(By.CssSelector(MobileUsersPage.MobileUserAddress)).SendKeys(Keys.Tab);
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
            Sunday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[2]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Monday = new Actions(CommonHooks.driver);
            Monday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[3]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Tuesday = new Actions(CommonHooks.driver);
            Tuesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[4]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Wednesday = new Actions(CommonHooks.driver);
            Wednesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[5]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Thursday = new Actions(CommonHooks.driver);
            Thursday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[6]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Friday = new Actions(CommonHooks.driver);
            Friday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[7]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Saturday = new Actions(CommonHooks.driver);
            Saturday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[8]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);
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

        [When(@"Diligencio y selecciono el grupo móvil para usuario móvil")]
        public void WhenDiligencioYSeleccionoElGrupoMovilParaUsuarioMovil()
        {
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", MobileUsersPage.MobileUserMobileGroups, CommonQuery.DBSelectAValue("SELECT TOP 1 grou_name FROM AFW_GROUPS WHERE grou_id = " + GroupId + ";", 1), "a");
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

        [Then(@"Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección")]
        public void ThenSeRegistraElUsuarioMovilConProveedorAsociadoEnLaTablaAFLS_USERS_SPECIALISTSConLongitudLatitudYDireccion()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT user_id FROM AFW_USERS WHERE user_nick_name = '" + user_nickname + "';", 1));
            CommonQuery.DBSelectAValue("SELECT user_id FROM AFLS_USERS_SPECIALISTS WHERE user_id = " + UserId + " AND spc_initial_longitude IS NOT NULL AND spc_initial_latitude IS NOT NULL AND spc_initial_address IS NOT NULL;", 1);
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
            try
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUP_USER WHERE user_id = " + UserId + ";", 1);
            }
            catch
            {
                Assert.Fail("No se generan resultado de consulta SELECT * FROM AFW_GROUP_USER WHERE user_id = " + UserId + ";");
            }
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
            try
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFW_MAIL_ACCOUNT;", 1);
            }
            catch
            {
                Assert.Fail("No hay servidor de correo activo.");
            }
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
            user_mail = CommonQuery.DBSelectAValue("SELECT user_email FROM  AFW_USERS WHERE user_id = " + UserId + ";", 1);
            try
            {
                CommonQuery.DBSelectAValue("SELECT TOP 1 mail_receiver FROM AFW_MAIL WHERE mail_receiver = '" + user_mail + "' ORDER BY 1 DESC;", 1);
            }
            catch
            {
                CommonQuery.DBSelectAValue("SELECT * FROM AFW_MAIL_HISTORY WHERE mahi_receiver = '" + user_mail + "';", 1);
            }
        }

        [When(@"Busco y selecciono el usuario móvil")]
        public void WhenBuscoYSeleccionoElUsuarioMovil()
        {
            user_nickname = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_id = " + UserId + ";", 1);
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileUsersPage.MobileUserFieldSearch, user_nickname);
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserButtonSearch);
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", MobileUsersPage.MobileUserView);
        }

        [Given(@"El usuario móvil existe sin disponibilidad y habilidades")]
        public void GivenElUsuarioMovilExisteSinDisponibilidadYHabilidades()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 usr.user_id FROM AFLS_USERS_SPECIALISTS usr left join AFLS_USER_SKILLS usk on usr.user_id = usk.aus_user_id left join AFLS_USER_AVAILABILITIES uav on usr.user_id = uav.user_id where usk.aus_user_id is null and uav.user_id is null  order by NEWID();", 1));
        }

        [Given(@"Existe un grupo móvil con habilidades y disponibilidad")]
        public void GivenExisteUnGrupoMovilConHabilidadesYDisponibilidad()
        {
            GroupId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 GRP.grou_id FROM AFW_GROUPS GRP INNER JOIN AFLS_GROUP_AVAILABILITIES GAV ON GRP.grou_id = GAV.grou_id INNER JOIN AFLS_GROUP_SKILLS GSK ON GRP.grou_id = GSK.grou_id WHERE GAV.grou_id IS NOT NULL AND GSK.grou_id IS NOT NULL AND grou_is_active = 1 ORDER BY NEWID();", 1));
        }

        [Then(@"Se registra disponibilidad en la tabla AFLS_USER_AVAILABILITIES")]
        public void ThenSeRegistraDisponibilidadEnLaTablaAFLS_USER_AVAILABILITIES()
        {
            CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_USER_AVAILABILITIES WHERE user_id = " + UserId + ";", 1);
        }

        [Then(@"Se registra disponibilidad heredada en la tabla AFLS_SPECIALIST_AVAILABILITY_CONSOLIDATED")]
        public void ThenSeRegistraDisponibilidadHeredadaEnLaTablaAFLS_SPECIALIST_AVAILABILITY_CONSOLIDATED()
        {
            int NumBlockGroup = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_GROUP_AVAILABILITIES WHERE grou_id = " + GroupId + ";", 1));
            int NumBlockUser = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_SPECIALIST_AVAILABILITY_CONSOLIDATED WHERE specialist_id = " + UserId + ";", 1));
            try
            {
                Assert.IsTrue(NumBlockUser >= NumBlockGroup);
            }
            catch
            {
                Assert.Fail("Failure in inheritance of availability of specialist.");
            }
        }

        [Then(@"Se muestra la habilidad asociada en el tab Habilidades del usuario móvil")]
        public void ThenSeMuestraLaHabilidadAsociadaEnElTabHabilidadesDelUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.TabMobileUserSkills);
            CommonElementsAction.WaitElement("//div[@class='users']//div[@id='tabs-5']//div[@class='itemView']//div[@class='block Name value label']");
            //CommonElementsAction.WaitElement("//div[@class='users']//div[@id='tabs-5']//div[@class='itemView']//span[@class='inherited-icon']");
        }

        [Then(@"Se muestra el grupo móvil asociado en el tab Habilidades del usuario móvil")]
        public void ThenSeMuestraElGrupoMovilAsociadoEnElTabHabilidadesDelUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.TabMobileUserMobileGroups);

            CommonElementsAction.WaitElement(MobileUsersPage.GroupCardView);
        }

        [Then(@"Se muestra la disponibilidad asociada en el tab disponibilidad del usuario móvil")]
        public void ThenSeMuestraLaDisponibilidadAsociadaEnElTabDisponibilidadDelUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.TabMobileUserAvilibily);
            Thread.Sleep(2000);

            CommonElementsAction.WaitElement(MobileUsersPage.AvailabilttyBlockInherited);
        }

        [Then(@"Se muestra la disponibilidad heredada asociada en el tab disponibilidad del usuario móvil")]
        public void ThenSeMuestraLaDisponibilidadHeredadaAsociadaEnElTabDisponibilidadDelUsuarioMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileUsersPage.TabMobileUserAvilibily);
            Thread.Sleep(2000);

            CommonElementsAction.WaitElement("//*[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td/div/a/div[@class='fc-bg']");
        }

        [Then(@"Se muestra la tarjeta de usuario móvil y se carga formulario de información básica")]
        public void ThenSeMuestraLaTarjetaDeUsuarioMovilYSeCargaFormularioDeInformacionBasica()
        {
            string Value = CommonHooks.driver.FindElement(By.CssSelector(MobileUsersPage.MobileUserName)).GetAttribute("value");
            Assert.AreEqual(user_name, Value);
        }

        [When(@"Selecciono disponibilidad de (.*) días a usuario móvil")]
        public void WhenSeleccionoDisponibilidadDeDiasAUsuarioMovil(int p0)
        {
            Actions Sunday = new Actions(CommonHooks.driver);
            Sunday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[2]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Monday = new Actions(CommonHooks.driver);
            Monday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[3]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Tuesday = new Actions(CommonHooks.driver);
            Tuesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[4]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Wednesday = new Actions(CommonHooks.driver);
            Wednesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[5]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);
        }

        [Then(@"Se registra disponibilidad de (.*) días en la tabla AFLS_USER_AVAILABILITIES")]
        public void ThenSeRegistraDisponibilidadDeDiasEnLaTablaAFLS_USER_AVAILABILITIES(int p0)
        {
            int NumDays = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_USER_AVAILABILITIES WHERE user_id = " + UserId + ";", 1));
            Assert.AreEqual(4, NumDays);
        }

        [Given(@"El usuario móvil existe sin disponibilidad, grupos móviles, habilidades y ordenes asociadas\.")]
        public void GivenElUsuarioMovilExisteSinDisponibilidadGruposMovilesHabilidadesYOrdenesAsociadas_()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 A.USER_ID FROM AFLS_USERS_SPECIALISTS A LEFT JOIN AFLS_WORKORDERS B ON A.user_id = B.work_attendant WHERE B.work_id IS NULL ORDER BY NEWID();", 1));
        }

        [When(@"Doy click en eliminar usuario móvil")]
        public void WhenDoyClickEnEliminarUsuarioMovil()
        {
            CommonElementsAction.Click("XPath", MobileUsersPage.MobileUserIconRemoved);
        }

        [When(@"Selecciono Aceptar en mensaje de confirmación de borrado")]
        public void WhenSeleccionoAceptarEnMensajeDeConfirmacion()
        {
            CommonElementsAction.Click("CssSelector", MessagesElements.SubmitButton);
        }

        [Then(@"Se muestra mensaje indicando que se borro el registro exitosamente")]
        public void ThenSeMuestraMensajeIndicandoQueSeBorroElRegistroExitosamente()
        {
            try
            {
            }
            catch
            {
                Assert.Fail();
            }

            ResponseValidation.ValidationSuccessDelete();
        }

        [Then(@"Se borra usuario de la tabla AFW_USERS")]
        public void ThenSeBorraUsuarioDeLaTablaAFW_USERS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_USERS WHERE user_id = '" + UserId + "';", 0);
        }

        [Then(@"Se borra usuario móvil de la tabla AFLS_USERS_SPECIALISTS")]
        public void ThenSeBorraUsuarioMovilDeLaTablaAFLS_USERS_SPECIALISTS()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_USERS_SPECIALISTS WHERE user_id = '" + UserId + "';", 0);
        }

        [Then(@"Al buscar el usuario móvil en la aplicación, no se lista en la búsqueda")]
        public void ThenAlBuscarElUsuarioMovilEnLaAplicacionNoSeListaEnLaBusqueda()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", MobileUsersPage.MobileUserFieldSearch, user_nickname);
            CommonElementsAction.Click("CssSelector", MobileUsersPage.MobileUserButtonSearch);
            Thread.Sleep(1000);
            CommonElementsAction.WaitElementNoFound(MobileUsersPage.MobileUserView);
        }
    }
}