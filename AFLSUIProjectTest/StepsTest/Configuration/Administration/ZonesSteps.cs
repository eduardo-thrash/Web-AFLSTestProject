using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration;
using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.ElementsConfiguration;
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
        

        [When(@"Creación exitosa de Zonas")]
        public void WhenCreacionExitosaDeZonas()
        {
            

            

            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneButtonNew);

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneTabZoneInfo);

            CommonElementsAction.SendKeys_InputText("CssSelector",ZonesPage.ZoneName,"Zona Bogota UI");

            CommonElementsAction.SendKeys_InputText("CssSelector",ZonesPage.ZoneDescription,"Description lorem ipsum des");

            for(int second = 0;;second++)
            {
                if(second >= 15) Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Elements of Form WebUser no found");
                try
                {
                    if(CommonHooks.driver.FindElement(By.CssSelector("span.zs-pencilButton")).Displayed)
                        if(CommonHooks.driver.FindElement(By.CssSelector("span.zs-closePolygonButton")).Displayed)
                            break;
                }
                catch(Exception)
                { }
                Thread.Sleep(1000);
            }
            Thread.Sleep(2000);

            IWebElement element = CommonHooks.driver.FindElement(By.CssSelector("#tabs-2 > div.mapCoverageZonesPolygon.ui.maps.update.loaded.zs-mapContainer > div.map.zs-mapZone > div > div.gm-style"));

            CommonHooks.driver.FindElement(By.CssSelector("span.zs-pencilButton")).Click();
            Thread.Sleep(2000);

            //Interaction of coordinates on map
            new Actions(CommonHooks.driver).MoveByOffset(-20,0).Click().Build().Perform();
            Thread.Sleep(3000);
            new Actions(CommonHooks.driver).MoveByOffset(-300,0).Click().Build().Perform();
            Thread.Sleep(3000);
            new Actions(CommonHooks.driver).MoveByOffset(0,100).Click().Build().Perform();
            Thread.Sleep(3000);
            new Actions(CommonHooks.driver).MoveByOffset(280,0).Click().Build().Perform();
            //End interaction of coordinates on map

            Thread.Sleep(2000);
            CommonHooks.driver.FindElement(By.CssSelector("span.zs-closePolygonButton")).Click();

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Tab Providers
            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneTabProviders);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",ZonesPage.ZoneProvider,"Especialistas Internos","a");

            Console.WriteLine("\n" + "Navigate from Secundary tab.");
            //Navigate from Secundary tab.

            //Save
            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de zona existente")]
        public void WhenBusquedaExitosaDeZonaExistente()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ZonesPage.ZoneFieldSearch,"Zona Bogota Sur General WT");
            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneButtonSearch);

            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ZonesPage.ZoneName)).GetAttribute("value");
            Assert.AreEqual("Zona Bogota Sur General WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de Zonas")]
        public void WhenModificacionExitosaDeZonas()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ZonesPage.ZoneFieldSearch,"Zona Bogota Sur General");
            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneButtonSearch);

            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneView);

            CommonElementsAction.SendKeys_InputText("CssSelector",ZonesPage.ZoneName,"Zona Bogota Sur General WTUpdate");

            CommonElementsAction.SendKeys_InputText("CssSelector",ZonesPage.ZoneDescription,"Description Zone Update");

            //Save
            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ZonesPage.ZoneFieldSearch,"Zona Bogota Sur General WTUpdate");
            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneButtonSearch);

            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ZonesPage.ZoneName)).GetAttribute("value");
            Assert.AreEqual("Zona Bogota Sur General WTUpdate",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de Zonas")]
        public void WhenBorradoExitosoDeZonas()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ZonesPage.ZoneFieldSearch,"Zona Bogota Oriente General WT");
            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneButtonSearch);

            CommonElementsAction.Click("CssSelector",ZonesPage.ZoneView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",ZonesPage.ZoneIconRemoved);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}