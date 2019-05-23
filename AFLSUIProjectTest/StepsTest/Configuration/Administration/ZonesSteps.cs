using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.ElementsConfiguration;
using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
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
    public class ZonesSteps
    {
        private readonly ZonesPage ZonesPage = new ZonesPage();
        private readonly PageMessages PageMessages = new PageMessages();
        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        private string ZoneName;
        private int ZoneId;

        private string ZoneNameEdit = "UI Edit Zone ";
        private string ZoneNameDefault = "UI Zone ";
        private string ProviderName;
        private int ProviderId;

        [Given(@"No existe la zona")]
        public void GivenNoExisteLaZona()
        {
            ZoneName = ZoneNameDefault + Functions.RandomText();
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_ZONES WHERE zone_name = '" + ZoneName + "';", 0);
        }

        [When(@"Diligencio descripción de zona")]
        public void WhenDiligencioDescripcionDeZona()
        {
            UtilAction.SendKeys(ZonesPage.ZoneDescription, "Description lorem ipsum des", "CssSelector");
        }

        [When(@"Selecciono prioridad Máxima")]
        public void WhenSeleccionoPrioridadMaxima()
        {
            IWebElement PriorityZone = CommonHooks.driver.FindElement(By.XPath("//div[@class='coverageZones']//input[@name='Priority']"));
            Actions ac = new Actions(CommonHooks.driver);
            ac.MoveToElement(PriorityZone).Release().Click().SendKeys(Keys.ArrowRight);
            ac.MoveToElement(PriorityZone).Release().Click().SendKeys(Keys.ArrowRight);
            ac.Build().Perform();
        }

        [When(@"Selecciono el tab Zona")]
        public void WhenSeleccionoElTabZona()
        {
            UtilAction.Click(ZonesPage.ZoneTabZone, "CssSelector");
        }

        [When(@"Doy click en Nueva zona")]
        public void WhenDoyClickEnNuevaZona()
        {
            UtilAction.Click(ZonesPage.ZoneButtonNew, "CssSelector");
        }

        [When(@"Diligencio nombre de zona")]
        public void WhenDiligencioNombreDeZona()
        {
            UtilAction.SendKeys(ZonesPage.ZoneName, ZoneName, "CssSelector");
        }

        [When(@"Doy click en crear zona")]
        public void WhenDoyClickEnCrearZona()
        {
            Thread.Sleep(3000);
            UtilAction.Click("//div[@class='coverageZones']//div[@id='tabs-2']//span[@class='zs-pencilButton']");
        }

        [When(@"Dibujo polígono de zona")]
        public void WhenDibujoPoligonoDeZona()
        {
            Thread.Sleep(3000);
            new Actions(CommonHooks.driver).MoveByOffset(-20, 0).Click().Build().Perform();
            Thread.Sleep(3000);
            new Actions(CommonHooks.driver).MoveByOffset(-300, 0).Click().Build().Perform();
            Thread.Sleep(3000);
            new Actions(CommonHooks.driver).MoveByOffset(0, 100).Click().Build().Perform();
            Thread.Sleep(3000);
            new Actions(CommonHooks.driver).MoveByOffset(280, 0).Click().Build().Perform();
            Thread.Sleep(3000);
        }

        [When(@"Doy click en cerrar zona")]
        public void WhenDoyClickEnCerrarZona()
        {
            UtilAction.Click("span.zs-closePolygonButton", "CssSelector");
        }

        [When(@"Selecciono el tab Proveedores")]
        public void WhenSeleccionoElTabProveedores()
        {
            UtilAction.Click(ZonesPage.ZoneTabProviders, "CssSelector");
        }

        [When(@"Diligencio y selecciono proveedor para zona")]
        public void WhenDiligencioYSeleccionoProveedorParaZona()
        {
            ProviderName = CommonQuery.DBSelectAValue("SELECT TOP 1 Name FROM AFLS_PROVIDERS WHERE IsActive = 1 ORDER BY NEWID();", 1);
            UtilAction.Select_ComboboxAutocomplete(ZonesPage.ZoneProvider, ProviderName, "a");
        }

        [When(@"Selecciono el tab Información de zona")]
        public void WhenSeleccionoElTabInformacionDeZona()
        {
            UtilAction.Click(ZonesPage.ZoneTabZoneInfo, "CssSelector");
        }

        [When(@"Doy click en Guardar zona")]
        public void WhenDoyClickEnGuardarZona()
        {
            UtilAction.Click(ZonesPage.ZoneSubmit, "CssSelector");
        }

        [Then(@"Se registra la zona en la tabla AFLS_ZONES")]
        public void ThenSeRegistraLaZonaEnLaTablaAFLS_ZONES()
        {
            ZoneId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT zone_id FROM AFLS_ZONES WHERE zone_name = '" + ZoneName + "';", 1));
        }

        [Then(@"Se registra el polígono de la zona en la tabla AFLS_ZONE_POLYGON")]
        public void ThenSeRegistraElPoligonoDeLaZonaEnLaTablaAFLS_ZONE_POLYGON()
        {
            int Polygon = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFLS_ZONE_POLYGON WHERE datazone_id = " + ZoneId + "; ", 1));
            Assert.AreEqual(Polygon, 4);
        }

        [Then(@"Se registra la relación de proveedor con zona en la tabla AFLS_PROVIDER_ZONE")]
        public void ThenSeRegistraLaRelacionDeProveedorConZonaEnLaTablaAFLS_PROVIDER_ZONE()
        {
            ProviderId = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT ProviderId FROM AFLS_PROVIDERS WHERE Name = '" + ProviderName + "';", 1));
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_PROVIDER_ZONE WHERE ZoneId = " + ZoneId + " AND ProviderId = " + ProviderId + ";", 1);
        }

        [Given(@"Existe la zona")]
        public void GivenExisteLaZona()
        {
            ZoneName = CommonQuery.DBSelectAValue("SELECT TOP 1 zone_name FROM AFLS_ZONES ORDER BY NEWID();", 1);
        }

        [When(@"Busco y selecciono la zona")]
        public void WhenBuscoYSeleccionoLaZona()
        {
            CommonElementsAction.SendKeys_InputText("CssSelector", ZonesPage.ZoneFieldSearch, ZoneName);
            CommonElementsAction.Click("CssSelector", ZonesPage.ZoneButtonSearch);

            UtilAction.Click(ZonesPage.ZoneView);
            Thread.Sleep(3000);
        }

        [Then(@"Se muestra la tarjeta de la zona y el detalle del mismo")]
        public void ThenSeMuestraLaTarjetaDeLaZonaYElDetalleDelMismo()
        {
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ZonesPage.ZoneName)).GetAttribute("value");
            Assert.AreEqual(ZoneName, Value);
        }

        [When(@"modifico el polígono de la zona")]
        public void WhenModificoElPoligonoDeLaZona()
        {
            Thread.Sleep(5000);
            IWebElement PolygonPoint = CommonHooks.driver.FindElement(By.XPath("//div[@class='map zs-mapZone']/div/div/div/div[3]/div/div[3]/div/div"));
            Actions PointerAction = new Actions(CommonHooks.driver);
            PointerAction.MoveToElement(PolygonPoint);

            PointerAction.DragAndDropToOffset(PolygonPoint, 300, 200).Build().Perform();
        }

        [When(@"Modificación exitosa de Zonas")]
        public void WhenModificacionExitosaDeZonas()
        {
            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", ZonesPage.ZoneFieldSearch, "Zona Bogota Sur General");
            CommonElementsAction.Click("CssSelector", ZonesPage.ZoneButtonSearch);

            CommonElementsAction.Click("CssSelector", ZonesPage.ZoneView);

            CommonElementsAction.SendKeys_InputText("CssSelector", ZonesPage.ZoneName, "Zona Bogota Sur General WTUpdate");

            CommonElementsAction.SendKeys_InputText("CssSelector", ZonesPage.ZoneDescription, "Description Zone Update");

            //Save
            CommonElementsAction.Click("CssSelector", ZonesPage.ZoneSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.

            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", ZonesPage.ZoneFieldSearch, "Zona Bogota Sur General WTUpdate");
            CommonElementsAction.Click("CssSelector", ZonesPage.ZoneButtonSearch);

            CommonElementsAction.Click("CssSelector", ZonesPage.ZoneView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ZonesPage.ZoneName)).GetAttribute("value");
            Assert.AreEqual("Zona Bogota Sur General WTUpdate", Value);

            //LogOut.

            //End LogOut.
        }

        [When(@"Borrado exitoso de Zonas")]
        public void WhenBorradoExitosoDeZonas()
        {
            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector", ZonesPage.ZoneFieldSearch, "Zona Bogota Oriente General WT");
            CommonElementsAction.Click("CssSelector", ZonesPage.ZoneButtonSearch);

            CommonElementsAction.Click("CssSelector", ZonesPage.ZoneView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath", ZonesPage.ZoneIconRemoved);

            //End Delete element of List

            //Validate response.

            //End Validate response.

            //LogOut.

            //End LogOut.
        }
    }
}