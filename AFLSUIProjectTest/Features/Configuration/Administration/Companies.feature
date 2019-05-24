Feature: Companies
	Configuración de compañías para asociar a clientes

@Automation
Scenario: 1 Creación exitosa de compañía
	Given Tengo un usuario con rol administrador
	And No existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Doy click en Nueva compañía
	And Selecciono el Tab Compañía
	And Diligencio nombre de compañía
	And Diligencio código único de compañía
	And Diligencio nombre de contacto de compañía
	And Diligencio teléfono de contacto de compañía
	And Diligencio correo de contacto de compañía
	And Diligencio dirección de compañía
	And Doy click en switch de estado de compañía
	And Selecciono el Tab Servicios
	And Diligencio y selecciono el servicio para la compañía
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES
	And Se registra el servicio asociado a compañía en la tabla AFLS_COMPANY_SERVICES
	And se registran campos adicionales de compañía diligenciados en la tabla AFW_ADDITIONAL_FIELD_VALUE
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Búsqueda exitosa de compañía
	Given Tengo un usuario con rol administrador
	And Existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Busco y selecciono la compañía
	Then Se muestra la tarjeta de la compañía y el detalle de la misma
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Modificación exitosa de compañías
	Given Tengo un usuario con rol administrador
	And Existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Busco y selecciono la compañía
	And Edito nombre de compañía
	And Edito código único de compañía
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía modificada en la tabla AFLS_COMPANIES
	And Cierro Sesión en la aplicación
@Automation
Scenario: 4 Borrado exitoso de compañía existente
	Given Tengo un usuario con rol administrador
	And Existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Busco y selecciono la compañía
	And Doy click en eliminar compañía
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se borra compañía de la tabla AFLS_COMPANIES
	And Al buscar la compañía en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación