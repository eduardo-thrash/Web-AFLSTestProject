Feature: SurveyTemplates
	

Scenario: Configuración completa exitosa de encuestas
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo a ítem Configuración
	And Selecciono la opción plantillas de encuestas
	When Configuración completa exitosa de encuestas
	Then Finaliza exitosa la prueba
