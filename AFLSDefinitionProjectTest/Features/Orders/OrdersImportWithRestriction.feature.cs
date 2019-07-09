﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AFLSDefinitionProjectTest.Features.Orders
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("OrdersImportWithRestriction")]
    public partial class OrdersImportWithRestrictionFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "OrdersImportWithRestriction.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "OrdersImportWithRestriction", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CP_AFLS: Ordenes > Importación > Importación exitosa de ordenes sin restricción d" +
            "e especialista")]
        public virtual void CP_AFLSOrdenesImportacionImportacionExitosaDeOrdenesSinRestriccionDeEspecialista()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CP_AFLS: Ordenes > Importación > Importación exitosa de ordenes sin restricción d" +
                    "e especialista", null, ((string[])(null)));
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
 testRunner.Given("Tengo usuario con rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.And("Realizo Login con usuario rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("Accedo a ítem Ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.And("Selecciono importación de ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("Cargo archivo configurado con datos diligenciados sin diligenciar restricción de " +
                    "especialista", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("Realizo click en botón importar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("Se importan las ordenes de trabajo exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.And("Se muestra una barra de progreso con los registros importados, fallidos y restant" +
                    "es", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("Al terminar la importación se muestra un mapa centrado con las coordenadas valida" +
                    "das correctamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("Al revisar la orden de trabajo se muestra con los datos diligenciados en el archi" +
                    "vo y sin restricción", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("Al revisar la tabla AFLS_WORKORDERS, el campo work_restriction_info no refleja in" +
                    "formación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CP_AFLS: Ordenes > Importación > Importación exitosa de ordenes con restricción d" +
            "e especialista")]
        public virtual void CP_AFLSOrdenesImportacionImportacionExitosaDeOrdenesConRestriccionDeEspecialista()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CP_AFLS: Ordenes > Importación > Importación exitosa de ordenes con restricción d" +
                    "e especialista", null, ((string[])(null)));
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
 testRunner.Given("Tengo usuario con rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.And("tengo especialistas activos, con licencia y con habilidades para el servicio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("Realizo Login con usuario rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("Accedo a ítem Ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("Selecciono importación de ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("Cargo archivo configurado con datos diligenciados diligenciando nombre de especia" +
                    "lista en restricción", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("Realizo click en botón importar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.Then("Se importan las ordenes de trabajo exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.And("Se muestra una barra de progreso con los registros importados, fallidos y restant" +
                    "es", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("Al terminar la importación se muestra un mapa centrado con las coordenadas valida" +
                    "das correctamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("Al revisar la orden de trabajo se muestra con los datos diligenciados en el archi" +
                    "vo, proveedor y con restricción", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("Al revisar la tabla AFLS_WORKORDERS, el campo work_restriction_info refleja arreg" +
                    "lo de restricción con nombre de especialista y Id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción d" +
            "e especialista inexistente")]
        public virtual void CP_AFLSOrdenesImportacionImportacionFallidaDeOrdenesConRestriccionDeEspecialistaInexistente()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción d" +
                    "e especialista inexistente", null, ((string[])(null)));
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 33
 testRunner.Given("Tengo usuario con rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.And("Realizo Login con usuario rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("Accedo a ítem Ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("Selecciono importación de ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("Cargo archivo configurado con datos diligenciados diligenciando nombre de especia" +
                    "lista inexistente en restricción", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("Realizo click en botón importar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then("No se importan las ordenes de trabajo exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.And("Se muestra una barra de progreso con los registros importados, fallidos y restant" +
                    "es", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("Al terminar la importación se muestra un mapa centrado con las coordenadas valida" +
                    "das correctamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("Se muestra un botón para descargar el archivo si contiene registro con error y un" +
                    " botón para cerrar el mapa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("Al descargar el archivo y abrirlo se muestran los registros no importados con men" +
                    "saje de especialista inexistente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción d" +
            "e especialista inactivo")]
        public virtual void CP_AFLSOrdenesImportacionImportacionFallidaDeOrdenesConRestriccionDeEspecialistaInactivo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción d" +
                    "e especialista inactivo", null, ((string[])(null)));
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 47
 testRunner.Given("Tengo usuario con rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.And("tengo especialistas inactivos, con licencia y con habilidades para el servicio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.And("Realizo Login con usuario rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("Accedo a ítem Ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("Selecciono importación de ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("Cargo archivo configurado con datos diligenciados diligenciando nombre de especia" +
                    "lista inactivo en restricción", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("Realizo click en botón importar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.Then("No importan las ordenes de trabajo exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.And("Se muestra una barra de progreso con los registros importados, fallidos y restant" +
                    "es", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("Al terminar la importación se muestra un mapa centrado con las coordenadas valida" +
                    "das correctamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("Se muestra un botón para descargar el archivo si contiene registro con error y un" +
                    " botón para cerrar el mapa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("Al descargar el archivo y abrirlo se muestran los registros no importados con men" +
                    "saje de especialista inactivo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción d" +
            "e especialista sin licencia")]
        public virtual void CP_AFLSOrdenesImportacionImportacionFallidaDeOrdenesConRestriccionDeEspecialistaSinLicencia()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción d" +
                    "e especialista sin licencia", null, ((string[])(null)));
#line 61
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 62
 testRunner.Given("Tengo usuario con rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
 testRunner.And("tengo especialistas activos, sin licencia y con habilidades para el servicio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.And("Realizo Login con usuario rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("Accedo a ítem Ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("Selecciono importación de ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("Cargo archivo configurado con datos diligenciados diligenciando nombre de especia" +
                    "lista sin licencia en restricción", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("Realizo click en botón importar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.Then("No importan las ordenes de trabajo exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.And("Se muestra una barra de progreso con los registros importados, fallidos y restant" +
                    "es", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("Al terminar la importación se muestra un mapa centrado con las coordenadas valida" +
                    "das correctamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("Se muestra un botón para descargar el archivo si contiene registro con error y un" +
                    " botón para cerrar el mapa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("Al descargar el archivo y abrirlo se muestran los registros no importados con men" +
                    "saje de especialista sin licencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción d" +
            "e especialista sin habilidades para el servicio")]
        public virtual void CP_AFLSOrdenesImportacionImportacionFallidaDeOrdenesConRestriccionDeEspecialistaSinHabilidadesParaElServicio()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción d" +
                    "e especialista sin habilidades para el servicio", null, ((string[])(null)));
#line 76
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 77
 testRunner.Given("Tengo usuario con rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
 testRunner.And("tengo especialistas activos, con licencia y sin habilidades para el servicio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.And("Realizo Login con usuario rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("Accedo a ítem Ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("Selecciono importación de ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("Cargo archivo configurado con datos diligenciados diligenciando nombre de especia" +
                    "lista sin habilidades en restricción", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("Realizo click en botón importar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.Then("No importan las ordenes de trabajo exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.And("Se muestra una barra de progreso con los registros importados, fallidos y restant" +
                    "es", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("Al terminar la importación se muestra un mapa centrado con las coordenadas valida" +
                    "das correctamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("Se muestra un botón para descargar el archivo si contiene registro con error y un" +
                    " botón para cerrar el mapa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("Al descargar el archivo y abrirlo se muestran los registros no importados con men" +
                    "saje de especialista invalido para el servicio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("CP_AFLS: Ordenes > Importación > Importación exitosa de ordenes con restricción d" +
            "e especialista y campos adicionales")]
        public virtual void CP_AFLSOrdenesImportacionImportacionExitosaDeOrdenesConRestriccionDeEspecialistaYCamposAdicionales()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CP_AFLS: Ordenes > Importación > Importación exitosa de ordenes con restricción d" +
                    "e especialista y campos adicionales", null, ((string[])(null)));
#line 91
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 92
 testRunner.Given("Tengo usuario con rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 93
 testRunner.And("tengo especialistas activos, con licencia y con habilidades para el servicio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("Tengo campos adicionales de ordenes y modelos configurados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.And("Realizo Login con usuario rol despachador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("Accedo a ítem Ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("Selecciono importación de ordenes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("Cargo archivo configurado con datos diligenciados diligenciando nombre de especia" +
                    "lista en restricción y campos adicionales", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("Realizo click en botón importar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.Then("Se importan las ordenes de trabajo exitosamente con restricción de especialista y" +
                    " campos adicionales diligenciados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.And("Se muestra una barra de progreso con los registros importados, fallidos y restant" +
                    "es", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("Al terminar la importación se muestra un mapa centrado con las coordenadas valida" +
                    "das correctamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And("Al revisar la orden de trabajo se muestra con los datos diligenciados en el archi" +
                    "vo, proveedor y con restricción", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And("Al revisar la tabla AFLS_WORKORDERS, el campo work_restriction_info refleja arreg" +
                    "lo de restricción con nombre de especialista y Id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

