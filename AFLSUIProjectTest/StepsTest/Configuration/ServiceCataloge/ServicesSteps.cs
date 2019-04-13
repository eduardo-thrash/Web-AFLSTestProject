
using AFLSUIProjectTest.UIMap.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;

namespace AFLSUITestProject.TestSuite.Configuration.Service_Catalogue
{
    [Binding]
    public class ServicesSteps
    {
        
        
        private ServicesPage ServicesPage = new ServicesPage();
        private object ElementsMessages;
        private PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de servicio, asociación de inventario, tareas, proveedores, habilidades y diligenciamiento de campos adicionales")]
        public void WhenCreacionExitosaDeServicioAsociacionDeInventarioTareasProveedoresHabilidadesYDiligenciamientoDeCamposAdicionales()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceButtonNew);
            //End Navigate Module Content

            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabService);

            ///     And diligencio los datos del tab Servicio
            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceName,"Servicio completo");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceModel,"Modelo Principal","label");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceDescription,"description completo");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceSubject,"Asunto completo");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceCalendar,"AFLS 5x8","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceSLA,"ANS General","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceUC,"UC General","label");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceOLA,"OLA General","label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceCost,"12400");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceType,"Est","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceAssigmentType,"Asignac","label");
            CommonElementsAction.Click("XPath",ServicesPage.ServiceCheckIsDefault);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceHours,"1");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceMinutes,"30");

            ///     And accedo al tab Inventario y asocio un producto
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabInventory);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",ServicesPage.ServiceInventorySearch,"Cable","a");

            ///     And accedo al tab Habilidades y asocio una habilidad
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath",ServicesPage.ServiceInputSkillsSearch,"Automatizacion","a");

            ///     And accedo al tab Proveedores y asocio un proveedor
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabProviders);

            CommonElementsAction.Select_ComboboxAutocomplete("CssSelector",ServicesPage.ServiceProvidersSearch,"Especialistas Internos","a");

            CommonElementsAction.ClickAndSelect_DropDownList("XPath",ServicesPage.ServiceProviderAgreement,"General","label");

            ///     And accedo al tab Tareas y asocio una Tarea
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabTasks);

            CommonElementsAction.SendKeys_InputText("XPath",ServicesPage.ServiceTasksSearch,"Tarea de instalacion");
            CommonElementsAction.Click("XPath",ServicesPage.ServiceButtonTaskAdd);

            ///     And accedo al tab Campo adicionales y diligencio un campo adicional
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabAdditionalFields);

            CommonElementsAction.SendKeys_InputText("XPath",ServicesPage.ServiceAdditionalFieldInputDefault,"Campo de tipo texto simple");

            //Save
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creación exitosa de servicio tipo estandar")]
        public void WhenCreacionExitosaDeServicioTipoEstandar()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceButtonNew);
            //End Navigate Module Content

            ///     And diligencio los datos del tab Servicio
            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceName,"Servicio estandar");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceModel,"Modelo Principal","label");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceDescription,"description estandar");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceSubject,"Asunto estandar");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceCalendar,"AFLS 5x8","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceSLA,"ANS General","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceUC,"UC General","label");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceOLA,"OLA General","label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceCost,"12400");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceType,"Est","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceAssigmentType,"Asignac","label");
            CommonElementsAction.Click("XPath",ServicesPage.ServiceCheckIsDefault);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceHours,"1");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceMinutes,"30");

            ///     And accedo al tab Habilidades y asocio una habilidad
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath",ServicesPage.ServiceInputSkillsSearch,"Automatizacion","a");

            //Save
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creación exitosa de servicio tipo desplazamiento")]
        public void WhenCreacionExitosaDeServicioTipoDesplazamiento()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceButtonNew);
            //End Navigate Module Content

            ///     And diligencio los datos del tab Servicio
            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceName,"Servicio desplazamiento");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceModel,"Modelo Principal","label");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceDescription,"description desplazamiento");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceSubject,"Asunto desplazamiento");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceCalendar,"AFLS 5x8","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceSLA,"ANS General","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceUC,"UC General","label");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceOLA,"OLA General","label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceCost,"12400");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceType,"Desplazami","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceAssigmentType,"Asignac","label");
            CommonElementsAction.Click("XPath",ServicesPage.ServiceCheckIsDefault);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceHours,"1");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceMinutes,"30");

            ///     And accedo al tab Habilidades y asocio una habilidad
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath",ServicesPage.ServiceInputSkillsSearch,"Automatizacion","a");

            //Save
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creación exitosa de servicios tipo asignación directa")]
        public void WhenCreacionExitosaDeServiciosTipoAsignacionDirecta()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceButtonNew);
            //End Navigate Module Content

            ///     And diligencio los datos del tab Servicio
            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceName,"Servicio asignación directa");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceModel,"Modelo Principal","label");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceDescription,"description asignación directa");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceSubject,"Asunto asignación directa");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceCalendar,"AFLS 5x8","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceSLA,"ANS General","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceUC,"UC General","label");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceOLA,"OLA General","label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceCost,"12400");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceType,"Desplazami","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceAssigmentType,"Asignac","label");
            CommonElementsAction.Click("XPath",ServicesPage.ServiceCheckIsDefault);

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceHours,"1");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceMinutes,"30");

            ///     And accedo al tab Habilidades y asocio una habilidad
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath",ServicesPage.ServiceInputSkillsSearch,"Automatizacion","a");

            //Save
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Creación exitosa de servicios tipo distribución publica")]
        public void WhenCreacionExitosaDeServiciosTipoDistribucionPublica()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module Content
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceButtonNew);
            //End Navigate Module Content

            ///     And diligencio los datos del tab Servicio
            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceName,"Servicio Distribución publica");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceModel,"Modelo Principal","label");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceDescription,"description Distribución publica");

            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceSubject,"Asunto Distribución publica");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceCalendar,"AFLS 7X24","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceSLA,"ANS General","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceUC,"UC General","label");
            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceOLA,"OLA General","label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceCost,"12400");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceType,"Desplazami","label");

            CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceAssigmentType,"Distr","label");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceHours,"1");

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceMinutes,"30");

            ///     And accedo al tab Habilidades y asocio una habilidad
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceTabSkills);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath",ServicesPage.ServiceInputSkillsSearch,"Automatizacion","a");

            //Save
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Busqueda exitosa de servicios por nombre")]
        public void WhenBusquedaExitosaDeServiciosPorNombre()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceFieldSearch,"Servicio Distribución publica");
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ServicesPage.ServiceName)).GetAttribute("value");
            Assert.AreEqual("Servicio Distribución public",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de servicios cambiando tipo de servicio y tipo de distribución")]
        public void WhenModificacionExitosaDeServiciosCambiandoTipoDeServicioYTipoDeDistribucion()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceFieldSearch,"Servicio Distribución publica");
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",ServicesPage.ServiceName,"Edit service Update");

            ///     And modifico el tipo de servicio
            string GetServiceType = CommonHooks.driver.FindElement(By.CssSelector(ServicesPage.ServiceType)).Text;

            if(GetServiceType.Contains("Est"))
            {
                CommonElementsAction.Click("CssSelector",ServicesPage.ServiceType);
                CommonElementsAction.ClickAndSelect_DropDownList("XPath",ServicesPage.ListType,"Despl","label");
            }
            if(GetServiceType.Contains("Despl"))
            {
                CommonElementsAction.Click("CssSelector",ServicesPage.ServiceType);
                CommonElementsAction.ClickAndSelect_DropDownList("XPath",ServicesPage.ListType,"Est","label");
            }

            ///     And modifico el tipo de asignación
            string GetAssigmentType = CommonHooks.driver.FindElement(By.CssSelector(ServicesPage.ServiceAssigmentType)).Text;

            if(GetAssigmentType.Contains("Asign"))
            {
                CommonElementsAction.Click("CssSelector",ServicesPage.ServiceAssigmentType);
                CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceType,"Distr","label");
            }
            if(GetAssigmentType.Contains("Dist"))
            {
                CommonElementsAction.Click("CssSelector",ServicesPage.ServiceAssigmentType);
                CommonElementsAction.ClickAndSelect_DropDownList("CssSelector",ServicesPage.ServiceAssigmentType,"Asign","label");
            }

            //Save
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceFieldSearch,"Edit service Update");
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceView);

            Console.WriteLine("\n" + "End Navigation and element search.");
            //End Object search to read

            //Validate response of search.
            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(ServicesPage.ServiceName)).GetAttribute("value");
            Assert.AreEqual("Edit service Update",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Borrado exitoso de servicios")]
        public void WhenBorradoExitosoDeServicios()
        {
            //Login.
            
            //End Login.

            //Navigate SubMenu and selected option.
            
            //End Navigate SubMenu and selected option.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",ServicesPage.ServiceFieldSearch,"Edit service Update");
            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceButtonSearch);

            //End Navigate Module List Content

            Thread.Sleep(3000);
            Console.WriteLine("Navigation and element search" + "\n");

            CommonElementsAction.Click("CssSelector",ServicesPage.ServiceView);

            //Delete element of List
            CommonElementsAction.Click("XPath",ServicesPage.ServiceIconRemoved);

            Thread.Sleep(2000);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}