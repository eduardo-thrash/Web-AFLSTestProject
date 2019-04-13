



using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class AFServicesSteps
    {
        
        
        private readonly AFServicesPage AFServicesPage = new AFServicesPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de campos adicionales servicios")]
        public void WhenCreacionExitosaDeCamposAdicionalesServicios()
        {
            ///     Given Existe un usuario administrador
            ///     And Requiero campos adicionales servicios
            ///     When Accedo a la pantalla de campos adicionales servicios
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.AFServicesOption,AFServicesPage.AFServicesModulePath);

            /// And Pulso el botón de Nuevo
           // CommonElementsAction.Click("XPath",AFServicesPage.AFServicesButtonNew);

            ///     And diligencio el campo de nombre

            //CommonElementsAction.SendKeys_InputText("XPath",AFServicesPage.AFServicesInputLabel,"Encargado del servicio");

            ///     And diligencio el campo de tipo
            //CommonElementsAction.ClickAndSelect_DropDownIndex("XPath",AFServicesPage.SelectAFServicesListType,1,"Option");

            ///     And pulso el botón aceptar
            //CommonElementsAction.Click("CssSelector",AFServicesPage.AFServicesAccept);

            ///     And pulso el botón guardar
            //CommonElementsAction.Click("XPath",AFServicesPage.AFServicesSubmit);

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de campos adicionales servicios")]
        public void WhenModificacionExitosaDeCamposAdicionalesServicios()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.AFServicesOption,AFServicesPage.AFServicesModulePath);

            Thread.Sleep(3000);
            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li/div/div[2]/div/label"));
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
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");

            ///     modifco nombre
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.ClearAndSendKeys_InputText("XPath",AFServicesPage.AFServicesInputLabel,"Cantidad de empleados Update");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            CommonElementsAction.Click("CssSelector",AFServicesPage.AFServicesAccept);

            ///     pulso guardar
            CommonElementsAction.Click("XPath",AFServicesPage.AFServicesSubmit);
        }

        [When(@"Eliminación exitosa de campos adicionales servicios")]
        public void WhenEliminacionExitosaDeCamposAdicionalesServicios()
        {
            

           // CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.AFServicesOption,AFServicesPage.AFServicesModulePath);

            Thread.Sleep(3000);
            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li/div/div[2]/div/label"));
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

            CommonElementsAction.Click("CssSelector",AFServicesPage.AFServicesYes);

            ///     pulso guardar
            CommonElementsAction.Click("XPath",AFServicesPage.AFServicesSubmit);

            //Validate response.
           // CommonAFLS.CommonAflsValidateMessages.ValidateMessageComponent(PageMessages.SuccessElementConfigurationDelete);
            //End Validate response.
        }
    }
}