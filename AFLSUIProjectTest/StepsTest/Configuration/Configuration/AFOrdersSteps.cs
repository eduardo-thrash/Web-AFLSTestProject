
using AFLSUIProjectTest.UIMap.Messages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using CommonTest.CommonTest;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class AFOrdersSteps
    {
        
        
        private readonly AFOrdersPage AFOrdersPage = new AFOrdersPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Crear campo adicional de orden de tipo simple")]
        public void WhenCrearCampoAdicionalDeOrdenDeTipoSimple()
        {

            // And Yo ingreso a la pantalla de campos adicionales de ordenes

           // AFLSUIProjectTest.CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,AFOrdersPage.EOption,AFOrdersPage.AFOrdersModulePath);

            // When Cuando pulso nuevo campo adicional
            CommonElementsAction.Click("XPath",AFOrdersPage.ENew);

            // And diligencio etiqueta de campo adicional
            CommonElementsAction.SendKeys_InputText("XPath",AFOrdersPage.ETag,"Campo texto automation simple");

            // And selecciono campo tipo simple
            CommonElementsAction.SendKeys_InputText("XPath",AFOrdersPage.ETag,"Campo texto automation simple");

           // CommonElementsAction.ClickAndSelect_DropDownIndex("XPath",AFOrdersPage.ETypeOption,1,"Option");

            // And Diligencio descripción de OLA del campo adicional
            CommonElementsAction.SendKeys_InputText("XPath",AFOrdersPage.EHelpText,"Texto de ayuda de automatización");

            // And pulso Aceptar en campo adicional de orden
            CommonElementsAction.Click("XPath",AFOrdersPage.EAccept);

            // And pulso Guardar en control general de campos adicionales de ordenes
            CommonElementsAction.Click("XPath",AFOrdersPage.ESave);

            //Validate response.
            
            //End Validate response.

            // And se refleja el registro de campo adicional de ordenes almacenado en base de datos
            CommonQuery.DBSelectAValue("SELECT Label  FROM AFW_ADDITIONAL_FIELD  where Label = 'Campo texto automation simple'  and TypeId = 1  and HelpMessage = 'Texto de ayuda de automatización'",1);
            
        }

        [When(@"Editar campo adicional de orden de tipo simple")]
        public void WhenEditarCampoAdicionalDeOrdenDeTipoSimple()
        {
            // Given Tengo rol administrador
            CommonQuery.DBSelectAValue("SELECT USER_NICK_NAME FROM AFW_USERS WHERE user_nick_name = 'ADMINISTRATOR';",1);

            // And existe un campo adicional de tipo simple
            string NameEdit = CommonQuery.DBSelectAValue("SELECT Label  FROM AFW_ADDITIONAL_FIELD  where TypeId = 1 and ConceptId = 5",1);

            
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,AFOrdersPage.EOption,AFOrdersPage.AFOrdersModulePath);

            // When Yo pulso editar sobre el campo adicional de tipo simple
            string Option = "Nombre orden";

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-workorders-general']/div/div[2]/ul/li/div/div[2]/div/label"));

            String[] allText = new String[all.Count];
            int IndexButtonEdit = 0;

            for(int count = 0;count < all.Count;count++)
            {
                string Locat = all[count].Text;
                if(Locat == Option)
                {
                    IndexButtonEdit = count + 1;
                }
            }

            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);

            CommonElementsAction.SendKeys_InputText("XPath",AFOrdersPage.ETag,"Edita automation field");

            // And pulso Aceptar en campo adicional de orden
            CommonElementsAction.Click("XPath",AFOrdersPage.EAccept);

            // And pulso Guardar en control general de campos adicionales de ordenes
            CommonElementsAction.Click("XPath",AFOrdersPage.ESave);

            //Validate response.
            
            //End Validate response.

            // And se refleja modificado el registro de campo adicionalsimple  de ordenes almacenado en base de datos
            CommonQuery.DBSelectAValue("SELECT Label  FROM AFW_ADDITIONAL_FIELD  where TypeId = 1 and ConceptId = 5 and Label = 'Edita automation field'",1);
            
        }
    }
}