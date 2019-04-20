Feature: AssistMe Basic Configuration


Scenario: Configuración exitosa de AssistMe
	Given Tengo un usuario con rol administrador
	And No tengo configurado canal de AssistMe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Canal AssistMe
	When Configuración exitosa de AssistMe
	Then Finaliza exitosa la prueba