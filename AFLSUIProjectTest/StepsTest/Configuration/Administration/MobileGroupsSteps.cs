
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.UIMap;
using CommonTest.CommonTest;
using AAFLSUIProjectTest.UIMap.Configuration;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class MobileGroupsSteps
    {
        
        
        private readonly MobileGroupPage MobileGroupPage = new MobileGroupPage();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de grupo movil")]
        public void WhenCreacionExitosaDeGrupoMovil()
        {
            

            

            //Navigate from Principal tab.
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupsTabMobileGroups);

            CommonElementsAction.SendKeys_InputText("CssSelector",MobileGroupPage.MobileGroupsName,"Grupo Disponibilidad Bogota UI");

            CommonElementsAction.SendKeys_InputText("CssSelector",MobileGroupPage.MobileGroupsDescription,"Descripcion grupo bogota");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",MobileGroupPage.MobileGroupsProvider,"Todos Los Proveedores","label");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");
            //End Navigate from Principal tab.

            //Navigate from Secundary tab.
            Console.WriteLine("Navigate from Secundary tab." + "\n");
            Thread.Sleep(3000);

            //Tab user mobile
            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupsTabUsers);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",MobileGroupPage.MobileGroupsUsers,"Freddy Vergara","a");

            //Tab Skills
            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupsTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",MobileGroupPage.MobileGroupsSkill,"Mantenimiento WT","a");

            //Tab availability
            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupsTabAvailability);
            CommonElementsAction.Click("XPath",MobileGroupPage.MobileGroupsAvailability);
            Console.WriteLine("     Click and selected of availability block.");

            Console.WriteLine("\n" + "Navigate from Secundary tab.");
            //Navigate from Secundary tab.

            //Save
            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de grupo movil existente")]
        public void WhenBusquedaExitosaDeGrupoMovilExistente()
        {
            

            
            CommonElementsAction.SendKeys_InputText("CssSelector",MobileGroupPage.MobileGroupFieldSearch,"Grupo Bogota General WT");
            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupButtonSearch);

            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(MobileGroupPage.MobileGroupsName)).GetAttribute("value");
            Assert.AreEqual("Grupo Bogota General WT",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de grupo movil")]
        public void WhenModificacionExitosaDeGrupoMovil()
        {
            

           
            CommonElementsAction.SendKeys_InputText("CssSelector",MobileGroupPage.MobileGroupFieldSearch,"Grupo Bogota Sur General WT");
            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupButtonSearch);

            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupView);

            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupsTabMobileGroups);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",MobileGroupPage.MobileGroupsName,"Grupo Bogota Sur General WT Update");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",MobileGroupPage.MobileGroupsDescription,"Description update");

            //Save
            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            CommonElementsAction.SendKeys_InputText("CssSelector",MobileGroupPage.MobileGroupFieldSearch,"Grupo Bogota Sur General WT Update");
            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupButtonSearch);

            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(MobileGroupPage.MobileGroupsName)).GetAttribute("value");
            Assert.AreEqual("Grupo Bogota Sur General WT Update",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de grupo movil existente")]
        public void WhenBorradoExitosoDeGrupoMovilExistente()
        {


            //AFLSUIProjectTest.CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.AdministrationMenu,SectionAdminLeftColumn.MobileGroupOption,MobileGroupPage.MobileGroupsModulePath);

            CommonElementsAction.SendKeys_InputText("CssSelector",MobileGroupPage.MobileGroupFieldSearch,"Grupo Bogota Oriente General WT");
            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupButtonSearch);

            CommonElementsAction.Click("CssSelector",MobileGroupPage.MobileGroupView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",MobileGroupPage.MobileGroupIconRemoved);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}