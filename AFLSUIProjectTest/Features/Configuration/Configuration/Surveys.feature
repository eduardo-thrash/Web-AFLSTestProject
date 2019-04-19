Feature: Surveys


Scenario: 1 Configuración completa exitosa de encuestas
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo a ítem Configuración
	And Selecciono la opción Encuestas general
	When Configuración completa exitosa de encuestas
	Then Finaliza exitosa la prueba
