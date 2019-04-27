Feature: Locations
	

Scenario: Creación exitosa de ubicación tipo sede
	Given Tengo un usuario con rol administrador
	And No existe la ubicación de tipo sede 
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Doy click en Nueva ubicación
	When Creación exitosa de ubicaciones
	Then Finaliza exitosa la prueba

Scenario: Creación exitosa de ubicación tipo transporte
	Given Tengo un usuario con rol administrador
	And No existe la ubicación de tipo transporte 
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	When Creación exitosa de ubicaciones
	Then Finaliza exitosa la prueba

Scenario: Búsqueda exitosa de Ubicación existente
	Given Tengo un usuario con rol administrador
	And Existe la ubicación
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Ubico y selecciono la ubicación deseada
	Then Se muestra el detalle de la ubicación

Scenario: Modificación exitosa de Ubicación
	Given Tengo un usuario con rol administrador
	And Existe la ubicación
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Ubico y selecciono la ubicación deseada
	And modifico nombre de ubicación
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente

Scenario: Borrado exitoso de Ubicación existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de Ubicación existente
	Then Finaliza exitosa la prueba
