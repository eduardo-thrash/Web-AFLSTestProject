using AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration;
using AFLSUIProjectTest.UIMap.Configuration;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Administration
{
    [Binding]
    public class SkillsSteps
    {
        
        
        SkillsPage SkillsPage = new SkillsPage();
        //private readonly PageMessages PageMessages = new PageMessages();
        

        [When(@"Creación exitosa de habilidad")]
        public void WhenCreacionExitosaDeHabilidad()
        {
            

            

            CommonElementsAction.Click("CssSelector",SkillsPage.ButtonNew);

            ///     And diligencio el campo de nombre
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.SkillInputSkillName,"Skill Automat");

            ///     And diligencio el campo de descripción
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.SkillTextareaSkillDescription,"Skill Automat Description");

            //Save
            CommonElementsAction.Click("CssSelector",SkillsPage.SkillButtonSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.
        }

        [When(@"Creación fallida de habilidad con nombre repetido")]
        public void WhenCreacionFallidaDeHabilidadConNombreRepetido()
        {
            

            

            CommonElementsAction.Click("CssSelector",SkillsPage.ButtonNew);

            ///     And diligencio el campo de nombre
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.SkillInputSkillName,"Backend");

            ///     And diligencio el campo de descripción
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.SkillTextareaSkillDescription,"Skill Automat Description");

            //Save
            CommonElementsAction.Click("CssSelector",SkillsPage.SkillButtonSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.
        }

        [When(@"Cancelación exitosa de creación de habilidad")]
        public void WhenCancelacionExitosaDeCreacionDeHabilidad()
        {
            

            

            CommonElementsAction.Click("CssSelector",SkillsPage.ButtonNew);

            ///     And diligencio el campo de nombre
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.SkillInputSkillName,"Backend");

            ///     And diligencio el campo de descripción
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.SkillTextareaSkillDescription,"Skill Automat Description");

            //Save
            CommonElementsAction.Click("CssSelector",SkillsPage.SkillButtonCancel);

            
            //End Save
        }

        [When(@"Consulta exitosa de habilidad por nombre")]
        public void WhenConsultaExitosaDeHabilidadPorNombre()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.InputSearch,"Trabajo en equipo");
            CommonElementsAction.Click("CssSelector",SkillsPage.ButtonSearch);

            CommonElementsAction.Click("CssSelector",SkillsPage.SkillTitleItemView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(SkillsPage.SkillInputSkillName)).GetAttribute("value");
            Assert.AreEqual("Trabajo en equipo",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación exitosa de habilidades")]
        public void WhenModificacionExitosaDeHabilidades()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.InputSearch,"Instalador WT");
            CommonElementsAction.Click("CssSelector",SkillsPage.ButtonSearch);

            CommonElementsAction.Click("CssSelector",SkillsPage.SkillTitleItemView);

            CommonElementsAction.Click("XPath",SkillsPage.SkillTabSkills);

            ///     And diligencio el campo de nombre
            CommonElementsAction.ClearAndSendKeys_InputText("CssSelector",SkillsPage.SkillInputSkillName,"Up-Capacidad crítica Update");

            //Save
            CommonElementsAction.Click("CssSelector",SkillsPage.SkillButtonSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.InputSearch,"Up-Capacidad crítica Update");
            CommonElementsAction.Click("CssSelector",SkillsPage.ButtonSearch);

            CommonElementsAction.Click("CssSelector",SkillsPage.SkillTitleItemView);

            Thread.Sleep(3000);
            string Value = CommonHooks.driver.FindElement(By.CssSelector(SkillsPage.SkillInputSkillName)).GetAttribute("value");
            Assert.AreEqual("Up-Capacidad crítica Update",Value);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Modificación fallida de habilidades dejando nombre o descripción vacios")]
        public void WhenModificacionFallidaDeHabilidadesDejandoNombreODescripcionVacios()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.InputSearch,"Up-Capacidad crítica");
            CommonElementsAction.Click("CssSelector",SkillsPage.ButtonSearch);

            CommonElementsAction.Click("CssSelector",SkillsPage.SkillTitleItemView);

            CommonElementsAction.Click("XPath",SkillsPage.SkillTabSkills);

            ///     And diligencio el campo de nombre
            CommonElementsAction.Clear("CssSelector",SkillsPage.SkillInputSkillName);

            //Save
            CommonElementsAction.Click("CssSelector",SkillsPage.SkillButtonSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.
        }

        [When(@"Inactivación exitosa de habilidades")]
        public void WhenInactivacionExitosaDeHabilidades()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.InputSearch,"Instalador WT");
            CommonElementsAction.Click("CssSelector",SkillsPage.ButtonSearch);

            CommonElementsAction.Click("CssSelector",SkillsPage.SkillTitleItemView);

            ///     And pulso el switch de estado de habilidad
            CommonElementsAction.Click("XPath",SkillsPage.SkillTabSkills);

            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath",SkillsPage.SkillState);

            string Active = CommonHooks.driver.FindElement(By.XPath(SkillsPage.SkillState)).GetAttribute("before").ToUpper();
            string Inactive = CommonHooks.driver.FindElement(By.XPath(SkillsPage.SkillState)).GetAttribute("after").ToUpper();

            //Save
            CommonElementsAction.Click("CssSelector",SkillsPage.SkillButtonSubmit);
            //End Save

            ////End Navigate Module Details

            //Validate response.
            
            //End Validate response.

            //     And Se muestra inactiva la habilidad en tarjeta y detalles.
            string NewState = CommonHooks.driver.FindElement(By.XPath("//div[@class='skills']/div/div[2]/div/div/div[@class='itemView selected']/div[@class='itemRight']/div/span")).Text;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Inactive,NewState);

            //LogOut.
            
            //End LogOut.
        }

        [When(@"Eliminación exitosa de habilidades")]
        public void WhenEliminacionExitosaDeHabilidades()
        {
            

            

            //Navigate Module List Content
            CommonElementsAction.SendKeys_InputText("CssSelector",SkillsPage.InputSearch,"Instalador WT");
            CommonElementsAction.Click("CssSelector",SkillsPage.ButtonSearch);

            CommonElementsAction.Click("CssSelector",SkillsPage.SkillTitleItemView);

            //Delete element of List
            Thread.Sleep(3000);
            CommonElementsAction.Click("XPath",SkillsPage.SkillIconRemoved);

            
            //End Delete element of List

            //Validate response.
            
            //End Validate response.

            //LogOut.
            
            //End LogOut.
        }
    }
}