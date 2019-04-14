Feature: Additional Field Services


Scenario: Creación exitosa de campos adicionales servicios
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	When Creación exitosa de campos adicionales servicios
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de campos adicionales servicios
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	When Modificación exitosa de campos adicionales servicios
	Then Finaliza exitosa la prueba

Scenario: Eliminación exitosa de campos adicionales servicios
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	When Eliminación exitosa de campos adicionales servicios
	Then Finaliza exitosa la prueba
