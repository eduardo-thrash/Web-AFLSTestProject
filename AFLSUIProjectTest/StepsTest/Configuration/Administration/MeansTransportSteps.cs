using AFLSUIProjectTest.UIMap.Messages;

using CommonTest.CommonTest;
using AFLSUIProjectTest.UIMap.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.StepsTest.AFLS;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class MeansTransportSteps
    {

        LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private readonly MeansTransportPage MeansTransportPage = new MeansTransportPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de Transportes")]
        public void WhenCreacionExitosaDeTransportes()
        {
            LoginLogoutSteps.WhenRealizoLoginConUsuarioRolAdministrador();
                

            CommonElementsAction.Click("CssSelector",MeansTransportPage.MeansTransportButtonNew);

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);
            CommonElementsAction.Click("CssSelector",MeansTransportPage.MeansTransportTabInfo);

            CommonElementsAction.SendKeys_InputText("CssSelector",MeansTransportPage.MeansTransportName,"Automóvil UI");
            CommonElementsAction.SendKeys_InputText("CssSelector",MeansTransportPage.MeansTransportDescription,"Description ipsum dolor sit amet. consectetur adipiscing elit. Duis lobortis turpis ut sagittis consectetur. Nunc et dolor vitae libero rutrum eleifend.");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",MeansTransportPage.MeansTransportInitialcost,"0");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",MeansTransportPage.MeansTransportCostByKilometer,"890");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",MeansTransportPage.MeansTransportsInfoTransport,"Automóvil","label");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",MeansTransportPage.MeansTransportSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de un transporte existente")]
        public void WhenBusquedaExitosaDeUnTransporteExistente()
        {
            LoginLogoutSteps.WhenRealizoLoginConUsuarioRolAdministrador();

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",MeansTransportPage.TransportFieldSearch,"Automovil WT");
            CommonElementsAction.Click("CssSelector",MeansTransportPage.TransportButtonSearch);

            CommonElementsAction.Click("CssSelector",MeansTransportPage.TransportView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(MeansTransportPage.MeansTransportName)).GetAttribute("value");
            Assert.AreEqual("Automovil WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"odificación exitosa de un transporte")]
        public void WhenOdificacionExitosaDeUnTransporte()
        {
            LoginLogoutSteps.WhenRealizoLoginConUsuarioRolAdministrador();

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",MeansTransportPage.TransportFieldSearch,"Moto WT");
            CommonElementsAction.Click("CssSelector",MeansTransportPage.TransportButtonSearch);

            CommonElementsAction.Click("CssSelector",MeansTransportPage.TransportView);

            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);
            CommonElementsAction.Click("CssSelector",MeansTransportPage.MeansTransportTabInfo);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",MeansTransportPage.MeansTransportName,"Moto WT Update");
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",MeansTransportPage.MeansTransportDescription,"Lorem update ipsum dolor sit amet consectetur adipiscing elit.");

            //Save
            CommonElementsAction.Click("CssSelector",MeansTransportPage.MeansTransportSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",MeansTransportPage.TransportFieldSearch,"Moto WT Update");
            CommonElementsAction.Click("CssSelector",MeansTransportPage.TransportButtonSearch);

            CommonElementsAction.Click("CssSelector",MeansTransportPage.TransportView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(MeansTransportPage.MeansTransportName)).GetAttribute("value");
            Assert.AreEqual("Moto WT Update",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de transporte existente")]
        public void WhenBorradoExitosoDeTransporteExistente()
        {
            LoginLogoutSteps.WhenRealizoLoginConUsuarioRolAdministrador();

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",MeansTransportPage.TransportFieldSearch,"Bus WT");
            CommonElementsAction.Click("CssSelector",MeansTransportPage.TransportButtonSearch);

            CommonElementsAction.Click("CssSelector",MeansTransportPage.TransportView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",MeansTransportPage.TransportIconRemoved);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}