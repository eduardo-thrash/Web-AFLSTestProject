
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class WebGroupsSteps
    {
        
        
        private readonly WebGroupsPage WebGroupsPage = new WebGroupsPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de grupo web")]
        public void WhenCreacionExitosaDeGrupoWeb()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.AdministrationMenu,SectionAdminLeftColumn.WebGroupOption,WebGroupsPage.WebGroupsModulePath);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupButtonNew);

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupTabWebGroup);

            CommonElementsAction.SendKeys_InputText("CssSelector",WebGroupsPage.WebGroupName,"Grupo FullAdmin UI");

            CommonElementsAction.SendKeys_InputText("CssSelector",WebGroupsPage.WebGroupDescription,"Descripcion de grupos web admin");

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupCheckRoleAdministrator);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupCheckRoleMonitor);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupCheckRoleDispatcher);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupCheckRoleInventory);

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Navigate from Secundary tab.
            Console.WriteLine("Navigate from Secundary tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupTabUsers);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",WebGroupsPage.WebGroupUsers,"Mike Hernandez WT","a");

            Console.WriteLine("\n" + "Navigate from Secundary tab.");
            //Navigate from Secundary tab.

            //Save
            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de Grupos web existente")]
        public void WhenBusquedaExitosaDeGruposWebExistente()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.AdministrationMenu,SectionAdminLeftColumn.WebGroupOption,WebGroupsPage.WebGroupsModulePath);

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",WebGroupsPage.WebGroupFieldSearch,"Grupo Administradores WT");
            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupButtonSearch);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(WebGroupsPage.WebGroupName)).GetAttribute("value");
            Assert.AreEqual("Grupo Administradores WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de grupos web")]
        public void WhenModificacionExitosaDeGruposWeb()
        {
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.AdministrationMenu,SectionAdminLeftColumn.WebGroupOption,WebGroupsPage.WebGroupsModulePath);

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",WebGroupsPage.WebGroupFieldSearch,"Grupo Monitores WT");
            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupButtonSearch);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupView);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupTabWebGroup);

            CommonElementsAction.SendKeys_InputText("CssSelector",WebGroupsPage.WebGroupName,"Grupo Monitores update WT");

            CommonElementsAction.SendKeys_InputText("CssSelector",WebGroupsPage.WebGroupDescription,"Description groups users.");

            //Save
            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",WebGroupsPage.WebGroupFieldSearch,"Grupo Monitores update WT");
            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupButtonSearch);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(WebGroupsPage.WebGroupName)).GetAttribute("value");
            Assert.AreEqual("Grupo Monitores update WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de grupo web existente")]
        public void WhenBorradoExitosoDeGrupoWebExistente()
        {
            

           // CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.AdministrationMenu,SectionAdminLeftColumn.WebGroupOption,WebGroupsPage.WebGroupsModulePath);

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",WebGroupsPage.WebGroupFieldSearch,"Grupo Monitores WT");
            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupButtonSearch);

            CommonElementsAction.Click("CssSelector",WebGroupsPage.WebGroupView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",WebGroupsPage.WebGroupIconRemoved);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}