Feature: Locations
	

Scenario: Creación exitosa de ubicación tipo sede
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	When Creación exitosa de ubicaciones
	Then Finaliza exitosa la prueba

Scenario: Creación exitosa de ubicación tipo transporte
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	When Creación exitosa de ubicaciones
	Then Finaliza exitosa la prueba

Scenario: Búsqueda exitosa de Ubicación existente
	Given Tengo un usuario con rol administrador
	When Búsqueda exitosa de Ubicación existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de Ubicación
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de Ubicación
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de Ubicación existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de Ubicación existente
	Then Finaliza exitosa la prueba
