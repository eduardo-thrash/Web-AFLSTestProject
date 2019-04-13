
using AFLSUIProjectTest.UIMap.ConfigurationMenuServiceCatalogue;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Service_Catalogue
{
    [Binding]
    public class RelationsSteps
    {
        
        
        private RelationsPage RelationsPage = new RelationsPage();
        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de relación")]
        public void WhenCreacionExitosaDeRelacion()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
           // CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.RelationOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationButtonNew);
            //End Navigate Module Content

            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationTab);

            ///     And diligencio el campo de nombre
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputName,"Relacion Principal");

            ///     And diligencio el campo de conector de origen
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputSource,"se conecta con");

            ///     And diligencio el campo de conector de destino
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputTarget,"se vincula desde");
            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            //Save
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creación fallida de relación con nombre repetido")]
        public void WhenCreacionFallidaDeRelacionConNombreRepetido()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.RelationOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationButtonNew);
            //End Navigate Module Content

            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputName,"Relacion Principal");

            ///     And diligencio el campo de conector de origen
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputSource,"se conecta con");

            ///     And diligencio el campo de conector de destino
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputTarget,"se vincula desde");

            //Save
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Cancelación exitosa de creación de relación")]
        public void WhenCancelacionExitosaDeCreacionDeRelacion()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.RelationOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationButtonNew);
            //End Navigate Module Content

            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputName,"Relacion contingencia");

            ///     And diligencio el campo de conector de origen
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputSource,"se conecta con");

            ///     And diligencio el campo de conector de destino
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputTarget,"se vincula desde");

            ///     And Pulso el botón cancelar
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationCancel);

            ///     And Pulso el botón Si
            Thread.Sleep(3000);
           
            //LogOut.
            
            //End LogOut.
        }

        [When(@"Consulta exitosa de relación por nombre")]
        public void WhenConsultaExitosaDeRelacionPorNombre()
        {
            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationFieldSearch,"Relacion Principal");
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",RelationsPage.RelationView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(RelationsPage.RelationInputName)).GetAttribute("value");
            Assert.AreEqual("Relacion Principal",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de relaciones")]
        public void WhenModificacionExitosaDeRelaciones()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.RelationOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationFieldSearch,"Relacion Principal");
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",RelationsPage.RelationView);

            CommonElementsAction.Click("CssSelector",RelationsPage.RelationTab);

            ///     And diligencio el campo de nombre
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputName,"Relacion Principal Update");

            ///     And diligencio el campo de conector de origen
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputSource,"se conecta con update");

            ///     And diligencio el campo de conector de destino
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationInputTarget,"se vincula desde update");
            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            //Save
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationSubmit);
            //End Save

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationFieldSearch,"Relacion Principal Update");
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",RelationsPage.RelationView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(RelationsPage.RelationInputName)).GetAttribute("value");
            Assert.AreEqual("Relacion Principal Update",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación fallida de relaciones dejando nombre o conectores vacios")]
        public void WhenModificacionFallidaDeRelacionesDejandoNombreOConectoresVacios()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
           // CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.RelationOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationFieldSearch,"Relacion Principal Update");
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",RelationsPage.RelationView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            ///     And diligencio el campo de nombre
            CommonElementsAction.Clear("CssSelector",RelationsPage.RelationInputName);

            ///     And diligencio el campo de conector de origen
            CommonElementsAction.Clear("CssSelector",RelationsPage.RelationInputSource);

            ///     And diligencio el campo de conector de destino
            CommonElementsAction.Clear("CssSelector",RelationsPage.RelationInputTarget);
            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            //Save
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationSubmit);
            //End Save

            //Validate response.
            
            //End Validate response.
        }

        [When(@"Inactivación exitosa de relaciones")]
        public void WhenInactivacionExitosaDeRelaciones()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.RelationOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationFieldSearch,"Relacion Principal Update");
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",RelationsPage.RelationView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            ///And pulso el switch de estado de relación
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationTab);

            CommonElementsAction.Click("XPath",RelationsPage.RelationState);

            //Save
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationSubmit);
            //End Save

            //Validate response.
            
            //End Validate response.
        }

        [When(@"Eliminación exitosa de relaciones")]
        public void WhenEliminacionExitosaDeRelaciones()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ServiceCatalogueMenu,SectionAdminLeftColumn.RelationOption,"");
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",RelationsPage.RelationFieldSearch,"Relacion Principal Update");
            CommonElementsAction.Click("CssSelector",RelationsPage.RelationButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",RelationsPage.RelationView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Delete element of List
            CommonElementsAction.Click("XPath",RelationsPage.RelationIconRemoved);

            Thread.Sleep(2000);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}