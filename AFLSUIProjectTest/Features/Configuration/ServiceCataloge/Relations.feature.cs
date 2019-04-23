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
namespace AFLSUIProjectTest.Features.Configuration.ServiceCataloge
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Relations")]
    public partial class RelationsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Relations.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Relations", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("1 Creación exitosa de relación")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void _1CreacionExitosaDeRelacion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1 Creación exitosa de relación", null, new string[] {
                        "regression"});
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("Tengo un usuario con rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("La relación no existe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.And("Realizo Login con usuario rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("Accedo a ítem Configuración", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("selecciono la opción Relaciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("Doy click en Nueva relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("Diligencio nombre de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("Selecciono tipo de relación Vinculo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("Diligencio campo origen de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("Diligencio campo destino de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("Doy click en Guardar relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.Then("Se muestra mensaje indicando que se guardo el registro exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("Se registra la relación en la tabla AFLS_RELATIONSHIP de tipo vinculo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("Cierro Sesión en la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1 Creación fallida de relación con nombre repetido de tipo vinculo")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void _1CreacionFallidaDeRelacionConNombreRepetidoDeTipoVinculo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1 Creación fallida de relación con nombre repetido de tipo vinculo", null, new string[] {
                        "regression"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
 testRunner.Given("Tengo un usuario con rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.And("La relación existe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("Realizo Login con usuario rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("Accedo a ítem Configuración", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("selecciono la opción Relaciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("Doy click en Nueva relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("Diligencio nombre de relación existente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("Selecciono tipo de relación Vinculo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("Diligencio campo origen de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("Diligencio campo destino de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("Doy click en Guardar relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then("Se muestra mensaje indicando que el elemento ya existe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.And("Cierro Sesión en la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1 Cancelación exitosa de creación de relación")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void _1CancelacionExitosaDeCreacionDeRelacion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1 Cancelación exitosa de creación de relación", null, new string[] {
                        "regression"});
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 40
 testRunner.Given("Tengo un usuario con rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
 testRunner.And("La relación no existe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.And("Realizo Login con usuario rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("Accedo a ítem Configuración", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("selecciono la opción Relaciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("Doy click en Nueva relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("Diligencio nombre de relación existente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("Selecciono tipo de relación Vinculo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("Diligencio campo origen de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("Diligencio campo destino de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("Doy click en Cancelar relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("Doy click en Si de mensaje de confirmación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then("No se registra la relación en la tabla AFLS_RELATIONSHIP de tipo vinculo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("Cierro Sesión en la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2 Consulta exitosa de relación por nombre")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void _2ConsultaExitosaDeRelacionPorNombre()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 Consulta exitosa de relación por nombre", null, new string[] {
                        "regression"});
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 58
 testRunner.Given("Tengo un usuario con rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
 testRunner.And("La relación existe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("Realizo Login con usuario rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("Accedo a ítem Configuración", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("selecciono la opción Relaciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("Busco y selecciono la relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then("Se muestra la tarjeta de la relación y el detalle del mismo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3 Modificación exitosa de relaciones editado nombre")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void _3ModificacionExitosaDeRelacionesEditadoNombre()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3 Modificación exitosa de relaciones editado nombre", null, new string[] {
                        "regression"});
#line 68
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 69
 testRunner.Given("Tengo un usuario con rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
 testRunner.And("La relación existe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.And("Realizo Login con usuario rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("Accedo a ítem Configuración", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("selecciono la opción Relaciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("Busco y selecciono la relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("Edito nombre de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("Edito campo origen de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("Edito campo destino de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("Doy click en Guardar relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("Se muestra mensaje indicando que se guardo el registro exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.And("Al buscar la relación con nuevo nombre se muestra exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("Se modifica la información de la relación en la tabla AFLS_RELATIONSHIP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3 Modificación fallida de relaciones dejando nombre o conectores vacíos")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void _3ModificacionFallidaDeRelacionesDejandoNombreOConectoresVacios()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3 Modificación fallida de relaciones dejando nombre o conectores vacíos", null, new string[] {
                        "regression"});
#line 85
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 86
 testRunner.Given("Tengo un usuario con rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 87
 testRunner.And("La relación existe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.And("Realizo Login con usuario rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("Accedo a ítem Configuración", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("selecciono la opción Relaciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("Busco y selecciono la relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("Edito nombre de relación dejándolo vacío", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("Edito campo origen de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("Edito campo destino de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("Doy click en Guardar relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.Then("Se muestra mensaje indicando que existen campos inválidos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.And("Al buscar la relación con anterior nombre se muestra exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("Cierro Sesión en la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3 Inactivación exitosa de relaciones")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void _3InactivacionExitosaDeRelaciones()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3 Inactivación exitosa de relaciones", null, new string[] {
                        "regression"});
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 103
    testRunner.Given("Tengo un usuario con rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
 testRunner.And("La relación existe activa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
 testRunner.And("Realizo Login con usuario rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("Accedo a ítem Configuración", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("selecciono la opción Relaciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("Busco y selecciono la relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("Doy click en switch de estado de relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("Doy click en Guardar relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.Then("Se muestra mensaje indicando que se guardo el registro exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.And("Se registra la relación en la tabla AFLS_RELATIONSHIP como inactiva", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("Cierro Sesión en la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4 Eliminación exitosa de relaciones")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void _4EliminacionExitosaDeRelaciones()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4 Eliminación exitosa de relaciones", null, new string[] {
                        "regression"});
#line 118
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 119
 testRunner.Given("Tengo un usuario con rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 120
 testRunner.And("La relación existe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.When("Accedo a la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.And("Realizo Login con usuario rol administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("Accedo a ítem Configuración", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And("selecciono la opción Relaciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("Busco y selecciono la relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("Doy click en eliminar relación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And("Selecciono Aceptar en mensaje de confirmación de borrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.When("Eliminación exitosa de relaciones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.Then("Se muestra mensaje indicando que se borro el registro exitosamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.And("Se borra la relación de la tabla AFLS_RELATIONSHIP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("Al buscar la relación en la aplicación, no se lista en la búsqueda", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("Cierro Sesión en la aplicación", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

