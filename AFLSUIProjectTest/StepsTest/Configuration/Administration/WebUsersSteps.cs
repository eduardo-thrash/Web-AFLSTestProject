
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using CommonTest.CommonTest;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.Messages;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class WebUsersSteps
    {
        
        
        private readonly WebUsersPage WebUsersPage = new WebUsersPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de usuario web")]
        public void WhenCreacionExitosaDeUsuarioWeb()
        {
            

            

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserButtonNew);

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserTabUserInfo);

            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserName,"Andersson Hernandez UI");

            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserUserName,"andersson.hernandez");

            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserEmail,"andersson.hernandez");

            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserPhone,"3115246985");

            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserPassword,"123456");

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserCheckAdministrator);

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserCheckMonitor);

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserCheckDispatcher);

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserCheckInventory);

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Save
            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de usuario web existente")]
        public void WhenBusquedaExitosaDeUsuarioWebExistente()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserFieldSearch,"Hector Neira WT");
            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserButtonSearch);

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(WebUsersPage.WebUserName)).GetAttribute("value");
            Assert.AreEqual("Hector Neira WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de usuario web")]
        public void WhenModificacionExitosaDeUsuarioWeb()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserFieldSearch,"Oscar Carillo WT");
            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserButtonSearch);

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserView);

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserTabUserInfo);

            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserName,"Oscar Carillo update WT");

            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserUserName,"carillo.update");

            //Save
            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserFieldSearch,"Oscar Carillo update WT");
            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserButtonSearch);

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(WebUsersPage.WebUserName)).GetAttribute("value");
            Assert.AreEqual("Oscar Carillo update WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de usuario web existente")]
        public void WhenBorradoExitosoDeUsuarioWebExistente()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",WebUsersPage.WebUserFieldSearch,"Oscar Carillo WT");
            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserButtonSearch);

            CommonElementsAction.Click("CssSelector",WebUsersPage.WebUserView);

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