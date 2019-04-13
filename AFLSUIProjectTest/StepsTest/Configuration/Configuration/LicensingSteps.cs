
using AFLSUIProjectTest.UIMap.Configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using CommonTest.CommonTest;
using AFLSUIProjectTest.UIMap.Messages;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class LicensingSteps
    {
        
        
        private readonly ElementsLicensing ElementsLicensing = new ElementsLicensing();
        private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Configuración exitosa de Licenciamiento")]
        public void WhenConfiguracionExitosaDeLicenciamiento()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Licenciar especialistas móviles")]
        public void WhenLicenciarEspecialistasMoviles()
        {
            ///     When Accedo a la opción de Licenciamiento
            

            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.LicensingOption,"");

            ///     agrego el nombre de un especialista
            Console.WriteLine("Navigate from Principal tab." + "\n");
            CommonElementsAction.Click("CssSelector",ElementsLicensing.SpecialistTab);

            CommonElementsAction.Select_ComboboxAutocomplete("XPath",ElementsLicensing.SpecialistSearch,"Harold","a");

            Thread.Sleep(3000);

            ///     Se muestra el especialista en el listado

            #region LicensedSpecialistValidation

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[3]/div/div[2]/div/div/div/div/div/div/div/div[@class='block Name value']"));

            bool x = false;
            int index = 0;

            String[] allText = new String[all.Count];

            foreach(IWebElement element in all)
            {
                string Locat = element.Text;
                string SearchText = "Harold";
                if(Locat.Contains(SearchText))
                {
                    x = true;
                    //saveindex = index;
                }
                index++;
            }

            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(x,true);
                Console.WriteLine("\t Success Test ✔");
            }
            catch
            {
                Console.WriteLine("\t Failed: specialist not added X");
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Failed: specialist not added");
            }

            #endregion

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Eliminar licencia de especialistas móviles")]
        public void WhenEliminarLicenciaDeEspecialistasMoviles()
        {
            ///     When Accedo a la opción de Licenciamiento
            

           // CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.LicensingOption,"");

            ///     busco el especialista a eliminar
            CommonElementsAction.Click("CssSelector",ElementsLicensing.SpecialistTab);

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[3]/div/div[2]/div/div/div/div/div/div/div/div[@class='block Name value']"));

            String[] allText = new String[all.Count];

            int IndexButtonDelete = 0;

            for(int count = 0;count < all.Count;count++)
            {
                string Locat = all[count].Text;
                if(Locat.Contains("Julian Paz"))
                {
                    IndexButtonDelete = count + 1;
                }
            }

            ///     elimino el nombre del especialista
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(IndexButtonDelete,0);
                CommonHooks.driver.FindElement(By.XPath("(//div[@class='itemView']/div/div[2]/div/div/input)[" + IndexButtonDelete + "]")).Click();
            }
            catch
            {
                Console.WriteLine("\t Failed: Specialist " + "Julian Paz" + " not found X");
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Failed: Specialist not found X");
            }
            ///     se quita el especialista en el listado

            //LogOut.
           //
            //End LogOut.
        }
    }
}