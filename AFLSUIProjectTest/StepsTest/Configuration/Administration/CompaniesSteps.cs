
using CommonTest.CommonTest;
using AFLSUIProjectTest.UIMap.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AFLSUIProjectTest.UIMap.Configuration;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.StepsTest;
using AFLSUIProjectTest.StepsTest.Configuration.Administration;
using AFLSUIProjectTest.UIMap.Messages;
using AFLSUIProjectTest.StepsTest.AFLS;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class CompaniesSteps
    {
        
        
        private readonly CompaniesPage CompaniesPage = new CompaniesPage();
        private readonly PageMessages PageMessages = new PageMessages();
        
        LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        MobileUsersSteps MobileUsersSteps = new MobileUsersSteps();

        [When(@"Creación exitosa de compañía")]
        public void WhenCreacionExitosaDeCompania()
        {
            LoginLogoutSteps.WhenRealizoLoginConUsuarioRolAdministrador();

            MobileUsersSteps.WhenAccedoAItemConfiguracion();
            MobileUsersSteps.WhenAccedoAlMenuAdministracion();
           

            //

            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanyButtonNew);

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanyTabCompany);

            CommonElementsAction.SendKeys_InputText("CssSelector",CompaniesPage.CompanyName,"Styvar Enterprises UI");

            CommonElementsAction.SendKeys_InputText("CssSelector",CompaniesPage.CompanyUniqueReference,"8000897-3");

            CommonElementsAction.SendKeys_InputText("CssSelector",CompaniesPage.CompanyContactName,"Jimena Lopex Ruiz");

            CommonElementsAction.SendKeys_InputText("CssSelector",CompaniesPage.CompanyPhone,"980765689");

            CommonElementsAction.SendKeys_InputText("CssSelector",CompaniesPage.CompanyEmail,"company@companymail.com");

            CommonElementsAction.EnterAfterSendKeys_InputText("CssSelector",CompaniesPage.CompanyAddress,"calle 64 # 5 22");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Navigate from Secundary tab.
            Console.WriteLine("Navigate from Secundary tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanyTabServices);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",CompaniesPage.CompanyServices,"Servicio Auditoria WT","a");

            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanyTabAdditionalFields);

            Console.WriteLine("\n" + "Navigate from Secundary tab.");
            //Navigate from Secundary tab.

            //Save
            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanySubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de compañía")]
        public void WhenBusquedaExitosaDeCompania()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",CompaniesPage.CompanyFieldSearch,"Dynamic Networks WT");
            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanyButtonSearch);

            CommonElementsAction.Click("XPath",CompaniesPage.CompanyView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(CompaniesPage.CompanyName)).GetAttribute("value");
            Assert.AreEqual("Dynamic Networks WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de compañías")]
        public void WhenModificacionExitosaDeCompanias()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",CompaniesPage.CompanyFieldSearch,"Core Records WT");
            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanyButtonSearch);

            CommonElementsAction.Click("XPath",CompaniesPage.CompanyView);

            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanyTabCompany);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",CompaniesPage.CompanyName,"Core Records Update UI - WT");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",CompaniesPage.CompanyUniqueReference,"80045-389");

            //Save
            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanySubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",CompaniesPage.CompanyFieldSearch,"Core Records Update UI - WT");
            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanyButtonSearch);

            CommonElementsAction.Click("XPath",CompaniesPage.CompanyView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(CompaniesPage.CompanyName)).GetAttribute("value");
            Assert.AreEqual("Core Records Update UI - WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de cliente existente")]
        public void WhenBorradoExitosoDeClienteExistente()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",CompaniesPage.CompanyFieldSearch,"Biel Muñoz Gomez");
            CommonElementsAction.Click("CssSelector",CompaniesPage.CompanyButtonSearch);

            CommonElementsAction.Click("XPath",CompaniesPage.CompanyView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",CompaniesPage.CompanyIconRemoved);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}