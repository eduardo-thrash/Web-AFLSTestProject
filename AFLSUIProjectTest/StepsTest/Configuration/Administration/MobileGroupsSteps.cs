using AAFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class MobileGroupsSteps
    {
        private readonly MobileGroupPage MobileGroupPage = new MobileGroupPage();
        private readonly PageMessages PageMessages = new PageMessages();

        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        private string DefaultGroupName = "UI Group Mob";
        private string EditGroupName = "UI Edit Group Mob";
        private string GroupName;
        private string GroupSkillName;
        private string GroupUserName;
        private int GroupId;
        private int UserId;

        [Given(@"No existe el grupo móvil")]
        public void GivenNoExisteElGrupoMovil()
        {
            GroupName = DefaultGroupName + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT grou_name FROM AFW_GROUPS WHERE grou_name = '" + GroupName + "';", 0);
        }

        [When(@"Selecciono la opción Grupos Móviles")]
        public void WhenSeleccionoLaOpcionGruposMoviles()
        {
            CommonElementsAction.Click("XPath", MobileGroupPage.MobileGroupsModulePath);
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MobileGroupOption);
        }

        [When(@"Doy click en Nuevo grupo móvil")]
        public void WhenDoyClickEnNuevoGrupoMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileGroupPage.MobileGroupButtonNew);
        }

        [When(@"Selecciono el Tab de Grupos Móvil en grupos móviles")]
        public void WhenSeleccionoElTabDeGruposMovilEnGruposMoviles()
        {
            CommonElementsAction.Click("CssSelector", MobileGroupPage.MobileGroupsTabMobileGroups);
        }

        [When(@"Diligencio nombre de grupo móvil")]
        public void WhenDiligencioNombreDeGrupoMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileGroupPage.MobileGroupsName, GroupName);
        }

        [When(@"Diligencio descripción de grupo móvil")]
        public void WhenDiligencioDescripcionDeGrupoMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileGroupPage.MobileGroupsDescription, "Descripcion UI Mobile group Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean posuere egestas cursus. Pellentesque maximus risus et elit fermentum efficitur.");
        }

        [When(@"Selecciono un proveedor para grupo móvil")]
        public void WhenSeleccionoUnProveedorParaGrupoMovil()
        {
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector", MobileGroupPage.MobileGroupsProvider, "Todos los provee", "label");
        }

        [When(@"Doy click en switch de estado de grupo móvil")]
        public void WhenDoyClickEnSwitchDeEstadoDeGrupoMovil()
        {
            CommonElementsAction.Click("XPath", MobileGroupPage.MobileGroupsState);
        }

        [When(@"Selecciono el Tab de Usuarios en grupos móviles")]
        public void WhenSeleccionoElTabDeUsuariosEnGruposMoviles()
        {
            CommonElementsAction.Click("CssSelector", MobileGroupPage.MobileGroupsTabUsers);
        }

        [When(@"Selecciono el Tab de Habilidades en grupos móviles")]
        public void WhenSeleccionoElTabDeHabilidadesEnGruposMoviles()
        {
            CommonElementsAction.Click("CssSelector", MobileGroupPage.MobileGroupsTabSkills);
        }

        [When(@"Selecciono el Tab de Disponibilidad en grupos móviles")]
        public void WhenSeleccionoElTabDeDisponibilidadEnGruposMoviles()
        {
            CommonElementsAction.Click("CssSelector", MobileGroupPage.MobileGroupsTabAvailability);
        }

        [When(@"Doy click en Guardar grupo móvil")]
        public void WhenDoyClickEnGuardarGrupoMovil()
        {
            CommonElementsAction.Click("CssSelector", MobileGroupPage.MobileGroupSubmit);
        }

        [When(@"Diligencio y selecciono un usuario para el grupo móvil")]
        public void WhenDiligencioYSeleccionoUnUsuarioParaElGrupoMovil()
        {
            string UserMobile = CommonQuery.DBSelectAValue("SELECT TOP 1 AFW.user_nick_name FROM AFW_USERS AFW JOIN AFLS_USERS_SPECIALISTS AFL ON AFW.user_id = AFL.user_id WHERE AFW.user_active = 1 ORDER BY NEWID();", 1);
            UtilAction.Select_ComboboxAutocomplete(MobileGroupPage.MobileGroupsUsersAutocomplete, UserMobile, "a");
        }

        [When(@"Diligencio y selecciono la habilidad para el grupo móvil")]
        public void WhenDiligencioYSeleccionoLaHabilidadParaElGrupoMovil()
        {
            GroupSkillName = CommonQuery.DBSelectAValue("SELECT TOP 1 skll_name FROM AFLS_SKILLS ORDER BY NEWID();", 1);
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", MobileGroupPage.MobileGroupsSkill, GroupSkillName, "a");
        }

        [When(@"Selecciono disponibilidad de siete días a grupo móvil")]
        public void WhenSeleccionoDisponibilidadDeSieteDiasAGrupoMovil()
        {
            Actions Sunday = new Actions(CommonHooks.driver);
            //Sunday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='groupsMovil']//div[@id='tabs-5']//div[@class='fc-view fc-agendaWeek-view fc-agenda-view]/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[2]")), 0, 200).Build().Perform();
            Sunday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='groupsMovil']//div[@id='tabs-5']/div/div[2]/div/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[2]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Monday = new Actions(CommonHooks.driver);
            Monday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='groupsMovil']//div[@id='tabs-5']/div/div[2]/div/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[3]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Tuesday = new Actions(CommonHooks.driver);
            Tuesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='groupsMovil']//div[@id='tabs-5']/div/div[2]/div/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[4]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Wednesday = new Actions(CommonHooks.driver);
            Wednesday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='groupsMovil']//div[@id='tabs-5']/div/div[2]/div/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[5]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Thursday = new Actions(CommonHooks.driver);
            Thursday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='groupsMovil']//div[@id='tabs-5']/div/div[2]/div/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[6]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Friday = new Actions(CommonHooks.driver);
            Friday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='groupsMovil']//div[@id='tabs-5']/div/div[2]/div/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[7]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);

            Actions Saturday = new Actions(CommonHooks.driver);
            Saturday.DragAndDropToOffset(CommonHooks.driver.FindElement(By.XPath("//div[@class='groupsMovil']//div[@id='tabs-5']/div/div[2]/div/div/div/table/tbody/tr/td/div/div/div[3]/table/tbody/tr/td[8]")), 0, 200).Build().Perform();
            Thread.Sleep(1000);
        }

        [Then(@"Se registra el grupo móvil en la tabla AFW_GROUPS")]
        public void ThenSeRegistraElGrupoMovilEnLaTablaAFW_GROUPS()
        {
            CommonQuery.DBSelectAValue("SELECT grou_name FROM AFW_GROUPS WHERE grou_name = '" + GroupName + "';", 1);
        }

        [Then(@"Se registra el usuario móvil asociado al grupo móvil en la tabla AFW_GROUP_USER")]
        public void ThenSeRegistraElUsuarioMovilAsociadoAlGrupoMovilEnLaTablaAFW_GROUP_USER()
        {
            GroupId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT grou_id FROM AFW_GROUPS WHERE grou_name = '" + GroupName + "';", 1));
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUP_USER WHERE grou_id = " + GroupId + ";", 1);
        }

        [Then(@"Se registra disponibilidad de todos los días del grupo móvil en la tabla AFLS_USER_AVAILABILITIES")]
        public void ThenSeRegistraDisponibilidadDeTodosLosDiasDelGrupoMovilEnLaTablaAFLS_USER_AVAILABILITIES()
        {
            int NumDays = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_GROUP_AVAILABILITIES WHERE grou_id = " + GroupId + ";", 1));
            Assert.AreEqual(7, NumDays);
        }

        [Then(@"Se registra habilidad asociada al grupo móvil en la tabla AFLS_GROUP_SKILLS")]
        public void ThenSeRegistraHabilidadAsociadaAlGrupoMovilEnLaTablaAFLS_GROUP_SKILLS()
        {
            CommonQuery.DBSelectAValue("SELECT grou_id FROM AFLS_GROUP_SKILLS WHERE grou_id = " + GroupId + ";", 1);
        }

        [Given(@"Existe el grupo móvil")]
        public void GivenExisteElGrupoMovil()
        {
            GroupName = CommonQuery.DBSelectAValue("SELECT TOP 1 GR.grou_name FROM AFLS_GROUPS_SPECIALISTS GP JOIN AFW_GROUPS GR ON GP.grou_id = GR.grou_id ORDER BY NEWID();", 1);
        }

        [When(@"Busco y selecciono el grupo móvil")]
        public void WhenBuscoYSeleccionoElGrupoMovil()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", MobileGroupPage.MobileGroupFieldSearch, GroupName);
            CommonElementsAction.Click("CssSelector", MobileGroupPage.MobileGroupButtonSearch);
            CommonElementsAction.Click("XPath", MobileGroupPage.MobileGroupView);
        }

        [When(@"Doy click en eliminar grupo móvil")]
        public void WhenDoyClickEnEliminarGrupoMovil()
        {
            CommonElementsAction.Click("XPath", MobileGroupPage.MobileGroupIconRemoved);
        }

        [Then(@"se elimina el registro de grupo móvil de la tabla AFW_GROUPS")]
        public void ThenSeEliminaElRegistroDeGrupoMovilDeLaTablaAFW_GROUPS()
        {
            CommonQuery.DBSelectAValue("SELECT grou_name FROM AFW_GROUPS WHERE grou_name = '" + GroupName + "';", 0);
        }

        [Then(@"Se muestra la tarjeta del grupo móvil y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDelGrupoMovilYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(MobileGroupPage.MobileGroupsName)).GetAttribute("value");
            Assert.AreEqual(GroupName, Value);
        }

        [When(@"Modifico nombre de grupo móvil")]
        public void WhenModificoNombreDeGrupoMovil()
        {
            EditGroupName = EditGroupName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector", MobileGroupPage.MobileGroupsName, EditGroupName);
        }

        [Then(@"Se registra el cambio de nombre de grupo móvil en la tabla AFW_GROUPS")]
        public void ThenSeRegistraElCambioDeNombreDeGrupoMovilEnLaTablaAFW_GROUPS()
        {
            CommonQuery.DBSelectAValue("SELECT grou_name FROM AFW_GROUPS WHERE grou_name = '" + EditGroupName + "';", 1);
        }

        [Given(@"Existe el usuario móvil sin asociar a grupos móviles")]
        public int GivenExisteElUsuarioMovilSinAsociarAGruposMoviles()
        {
            UserId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT user_id FROM AFLS_USERS_SPECIALISTS WHERE user_id NOT IN (SELECT user_id FROM AFW_GROUP_USER);", 1));
            return UserId;
        }

        [When(@"Diligencio y selecciono el usuario para el grupo móvil")]
        public void WhenDiligencioYSeleccionoElUsuarioParaElGrupoMovil()
        {
            GroupUserName = CommonQuery.DBSelectAValue("SELECT user_name FROM AFW_USERS WHERE USER_ID = " + UserId + ";", 1);
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", MobileGroupPage.MobileGroupsUsersAutocomplete, GroupUserName, "a");
        }

        [Then(@"Se registra el grupo móvil con usuario móvil asociado en la tabla AFW_GROUP_USER")]
        public void ThenSeRegistraElGrupoMovilConUsuarioMovilAsociadoEnLaTablaAFW_GROUP_USER()
        {
            GroupId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT grou_id FROM AFW_GROUPS WHERE grou_name = '" + GroupName + "';", 1));
            CommonQuery.DBSelectAValue("SELECT * FROM AFW_GROUP_USER WHERE grou_id = " + GroupId + " AND user_id = " + UserId + ";", 1);
        }
    }
}