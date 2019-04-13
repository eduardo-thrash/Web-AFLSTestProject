

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AFLSUIProjectTest.UIMap.Configuration;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class ClientsSteps
    {

        private readonly ClientsPage ClientsPage = new ClientsPage();
        private readonly PageMessages PageMessages = new PageMessages();
        LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();


        [When(@"Creación exitosa de cliente")]
        public void WhenCreacionExitosaDeCliente()
        {
            LoginLogoutSteps.WhenRealizoLoginConUsuarioRolAdministrador();

            ////CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.ClientOption,"");

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientButtonNew);

            CommonElementsAction.SendKeys_InputText("CssSelector",ClientsPage.ClientName,"Juliana Vega Motntenegro UI");

            CommonElementsAction.SendKeys_InputText("CssSelector",ClientsPage.ClientUniqueReference,"103089786");

            CommonElementsAction.SendKeys_InputText("CssSelector",ClientsPage.ClientPhone,"3008657473");

            CommonElementsAction.SendKeys_InputText("CssSelector",ClientsPage.ClientEmail,"reyes@company.com");

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",ClientsPage.ClientComapny,"Riddlectronics WT","label");

            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector",ClientsPage.ClientAddress,"calle 59 # 35a-68,Of 567");

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientTabServices);

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientTabServices);

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientTabServices);

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientTabServices);

            //Save
            CommonElementsAction.Click("CssSelector",ClientsPage.ClientSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de cliente existente")]
        public void WhenBusquedaExitosaDeClienteExistente()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.ClientOption,"");

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ClientsPage.ClientFieldSearch,"Biel Muñoz Gomez");
            CommonElementsAction.Click("CssSelector",ClientsPage.ClientButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ClientsPage.ClientName)).GetAttribute("value");
            Assert.AreEqual("Biel Muñoz Gomez",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de cliente")]
        public void WhenModificacionExitosaDeCliente()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.ClientOption,"");

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ClientsPage.ClientFieldSearch,"Mateo Ramos Ramos");
            CommonElementsAction.Click("CssSelector",ClientsPage.ClientButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientView);

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientTabClient);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ClientsPage.ClientName,"Mateo update Ramos");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ClientsPage.ClientUniqueReference,"52893423");

            //Save
            CommonElementsAction.Click("CssSelector",ClientsPage.ClientSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ClientsPage.ClientFieldSearch,"Mateo update Ramos");
            CommonElementsAction.Click("CssSelector",ClientsPage.ClientButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ClientsPage.ClientName)).GetAttribute("value");
            Assert.AreEqual("Mateo update Ramos",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"orrado exitoso de cliente existente")]
        public void WhenOrradoExitosoDeClienteExistente()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.ClientOption,"");

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ClientsPage.ClientFieldSearch,"Pau Vargas Gallardo");
            CommonElementsAction.Click("CssSelector",ClientsPage.ClientButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ClientsPage.ClientView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",ClientsPage.ClientIconRemoved);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}