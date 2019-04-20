Feature: Additional Field Companies


Scenario: Creación exitosa de campos adicionales compañías
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías  de tipo simple
	When Creación exitosa de campos adicionales compañías
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de campos adicionales compañías  de tipo simple
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	When Modificación exitosa de campos adicionales compañías
	Then Finaliza exitosa la prueba

Scenario: Eliminación exitosa de campos adicionales compañías de tipo simple
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	When Eliminación exitosa de campos adicionales compañías
	Then Finaliza exitosa la prueba
