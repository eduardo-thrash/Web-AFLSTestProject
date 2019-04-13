
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.UIMap.Configuration;
using CommonTest.CommonTest;
using AFLSUIProjectTest.UIMap.Messages;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class AFCompaniesSteps
    {
        
        
        private readonly AFCompaniesPage AFCompaniesPage = new AFCompaniesPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de campos adicionales compañias")]
        public void WhenCreacionExitosaDeCamposAdicionalesCompanias()
        {
            

            //

            /// And Pulso el botón de Nuevo
            CommonElementsAction.Click("XPath",AFCompaniesPage.AFCompaniesButtonNew);

            ///     And diligencio el campo de nombre

            CommonElementsAction.SendKeys_InputText("XPath",AFCompaniesPage.AFCompaniesInputLabel,"Nombre completo");

            ///     And diligencio el campo de tipo
            //CommonElementsAction.ClickAndSelect_DropDownIndex("XPath",AFCompaniesPage.SelectAFCompaniesListType,1,"Option");

            ///     And pulso el botón aceptar
            CommonElementsAction.Click("CssSelector",AFCompaniesPage.AFCompaniesAccept);

            ///     And pulso el botón guardar
            CommonElementsAction.Click("CssSelector",AFCompaniesPage.AFCompaniesSubmit);

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de campos adicionales compañias")]
        public void WhenModificacionExitosaDeCamposAdicionalesCompanias()
        {
            

            

            Thread.Sleep(3000);
            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-company']/div/div[2]/ul/li/div/div[2]/div/label"));
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
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-company']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");

            ///     modifco nombre
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.ClearAndSendKeys_InputText("XPath",AFCompaniesPage.AFCompaniesInputLabel,"Cantidad de empleados Update");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            CommonElementsAction.Click("CssSelector",AFCompaniesPage.AFCompaniesAccept);

            ///     pulso guardar
            CommonElementsAction.Click("CssSelector",AFCompaniesPage.AFCompaniesSubmit);
        }

        [When(@"Eliminación exitosa de campos adicionales compañias")]
        public void WhenEliminacionExitosaDeCamposAdicionalesCompanias()
        {
            

            

            Thread.Sleep(3000);
            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-company']/div/div[2]/ul/li/div/div[2]/div/label"));
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

            CommonElementsAction.Click("CssSelector",AFCompaniesPage.AFCompaniesYes);

            ///     pulso guardar
            CommonElementsAction.Click("CssSelector",AFCompaniesPage.AFCompaniesSubmit);

            //Validate response.
            
            //End Validate response.
        }
    }
}