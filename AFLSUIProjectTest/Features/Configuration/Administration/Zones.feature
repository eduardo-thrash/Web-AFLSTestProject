Feature: Zones

@regression
Scenario: Creación exitosa de Zonas
	Given Tengo un usuario con rol administrador
    And No existe la zona
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Zonas
	And Doy click en Nueva zona
	And Diligencio nombre de zona
	And Diligencio descripción de zona
	And Selecciono prioridad Máxima
	#And Doy click en switch de estado de zona
	And Selecciono el tab Zona
	And Doy click en crear zona
	And Dibujo polígono de zona
	And Doy click en cerrar zona
	And Selecciono el tab Proveedores
	And Diligencio y selecciono proveedor para zona
	And Selecciono el tab Información de zona
	And Doy click en Guardar zona
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la zona en la tabla AFLS_ZONES
	And Se registra el polígono de la zona en la tabla AFLS_ZONE_POLYGON
	And Se registra la relación de proveedor con zona en la tabla AFLS_PROVIDER_ZONE
	And Cierro Sesión en la aplicación

@regression
Scenario: Búsqueda exitosa de zona existente
	Given Tengo un usuario con rol administrador
    And Existe la zona
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Zonas
	And Busco y selecciono la zona
	Then Se muestra la tarjeta de la zona y el detalle del mismo

Scenario: Modificación exitosa de Zonas
	Given Tengo un usuario con rol administrador
    And No existe la zona
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Zonas
	And Busco y selecciono la zona
	And Edito nombre de zona
	And Doy click en Guardar zona
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la zona en la tabla AFLS_ZONES

Scenario: Borrado exitoso de Zonas
	Given Tengo un usuario con rol administrador
    And No existe la zona
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Zonas
	And Busco y selecciono la zona
	And Doy click en eliminar zona
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And No se registra la zona en la tabla AFLS_ZONES
	And Al buscar la zona en la aplicación, no se lista en la búsqueda
