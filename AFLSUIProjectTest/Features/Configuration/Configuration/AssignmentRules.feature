Feature: Assigment Rules


Scenario: Configuración exitosa de reglas de asignación
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Reglas de asignación
	When Configuración exitosa de reglas de asignación
	Then Finaliza exitosa la prueba
