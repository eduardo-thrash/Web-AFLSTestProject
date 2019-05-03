Feature: Locations
	

Scenario: Creación exitosa de ubicación tipo sede
	Given Tengo un usuario con rol administrador
	And No existe la ubicación de tipo sede 
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Doy click en Nueva ubicación sede
	And Selecciono tipo de ubicación de sede
	And Diligencio nombre de ubicación
	And Diligencio descripción de ubicación
	And Diligencio dirección de ubicación
	And Diligencio detalle de dirección de ubicación
	And Doy click en switch de estado de ubicación
	And Selecciono el Tab de información de contacto de sede
	And Diligencio nombre de contacto de sede
	And Diligencio teléfono de contacto de sede
	And Diligencio email de contacto de sede
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO

Scenario: Creación exitosa de ubicación tipo transporte
	Given Tengo un usuario con rol administrador
	And No existe la ubicación de tipo transporte 
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Doy click en Nuevo transporte
	And Selecciono tipo de ubicación de transporte
	And Diligencio nombre de ubicación transporte
	And Diligencio descripción de ubicación transporte
	And Diligencio dirección de ubicación transporte
	And Diligencio detalle de dirección de ubicación transporte
	And Doy click en switch de estado de ubicación transporte
	And Selecciono el Tab información de contacto de transporte
	And Diligencio nombre de contacto de transporte
	And Diligencio teléfono de contacto de transporte
	And Diligencio email de contacto de transporte
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO

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
	And Modifico nombre de ubicación
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO

Scenario: Borrado exitoso de Ubicación existente
	Given Tengo un usuario con rol administrador
	And Existe la ubicación
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Ubico y selecciono la ubicación deseada
	And Doy click en eliminar ubicación
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se borra el registro de la ubicación en la tabla AFLS_STOCK_PRODUCTS
