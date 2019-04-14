Feature: AF Orders



Scenario: Creación exitosa de campo adicional de orden de tipo simple
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales de ordenes
	When Crear campo adicional de orden de tipo simple
	Then Finaliza exitosa la prueba





