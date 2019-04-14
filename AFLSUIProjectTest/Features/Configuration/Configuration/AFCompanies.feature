Feature: Additional Field Companies


Scenario: Creación exitosa de campos adicionales compañias
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	When Creación exitosa de campos adicionales compañias
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de campos adicionales compañias
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	When Modificación exitosa de campos adicionales compañias
	Then Finaliza exitosa la prueba

Scenario: Eliminación exitosa de campos adicionales compañias
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	When Eliminación exitosa de campos adicionales compañias
	Then Finaliza exitosa la prueba
