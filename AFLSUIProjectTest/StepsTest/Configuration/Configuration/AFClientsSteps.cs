



using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.UIMap.Messages;
using AFLSUIProjectTest.UIMap.Configuration;
using CommonTest.CommonTest;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class AFClientsSteps
    {
        
        
        private readonly AFClientsPage AFClientsPage = new AFClientsPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de campos adicionales clientes")]
        public void WhenCreacionExitosaDeCamposAdicionalesClientes()
        {
           
            /// And Pulso el botón de Nuevo
            CommonElementsAction.Click("XPath",AFClientsPage.AFClientsButtonNew);

            ///     And diligencio el campo de nombre

            CommonElementsAction.SendKeys_InputText("XPath",AFClientsPage.AFClientsInputLabel,"Nombre completo");

            ///     And diligencio el campo de tipo
           

            ///     And pulso el botón aceptar
            CommonElementsAction.Click("CssSelector",AFClientsPage.AFClientsAccept);

            ///     And pulso el botón guardar
            CommonElementsAction.Click("CssSelector",AFClientsPage.AFClientsSubmit);

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de campos adicionales clientes")]
        public void WhenModificacionExitosaDeCamposAdicionalesClientes()
        {
           

            Thread.Sleep(3000);
            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonEdit = 0;
            for(int count = 0;count < all.Count;count++)
            {
                string Locat = all[count].Text;
                if(Locat == "Cantidad de empleados")
                {
                    IndexButtonEdit = count + 1;
                }
            }
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0,IndexButtonEdit);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + "Cantidad de empleados");
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");

            ///     modifco nombre
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.ClearAndSendKeys_InputText("XPath",AFClientsPage.AFClientsInputLabel,"Cantidad de empleados Update");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            CommonElementsAction.Click("CssSelector",AFClientsPage.AFClientsAccept);

            ///     pulso guardar
            CommonElementsAction.Click("XPath",AFClientsPage.AFClientsSubmit);
        }

        [When(@"Eliminación exitosa de campos adicionales clientes")]
        public void WhenEliminacionExitosaDeCamposAdicionalesClientes()
        {
            

            

            Thread.Sleep(3000);
            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-client']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonDelete = 0;
            for(int count = 0;count < all.Count;count++)
            {
                string Locat = all[count].Text;
                if(Locat == "Campo prueba 1")
                {
                    IndexButtonDelete = count + 1;
                }
            }
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0,IndexButtonDelete);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + "Campo prueba 1");
            }
            ///     Selecciono el botón eliminar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li[" + IndexButtonDelete + "]/div/div/button[@class='delete-button secondary_bg js-delete-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            ///     pulso Si

            CommonElementsAction.Click("CssSelector",AFClientsPage.AFClientsYes);

            ///     pulso guardar
            CommonElementsAction.Click("XPath",AFClientsPage.AFClientsSubmit);

            //Validate response.
            //CommonAFLS.CommonAflsValidateMessages.ValidateMessageComponent(PageMessages.SuccessElementConfigurationDelete);
            //End Validate response.
        }
    }
}