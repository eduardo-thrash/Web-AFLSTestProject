Feature: Providers

@Automation
Scenario: 1 Creación exitosa completa de proveedores asociando servicio, zona y monitor
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio nombre de proveedor
	And Diligencio descripción de proveedor
	And Selecciono tipo de proveedor interno
	And Selecciono tipo de proveedor externo
	And Selecciono asignación manualmente
	And Selecciono asignación al mejor especialista
	And Selecciono importancia Alta
	And Selecciono importancia Media
	And Selecciono importancia Baja
	#And Doy click en switch de estado de proveedor
	And Selecciono el Tab de Servicios de proveedores
	And Diligencio y selecciono un servicio para el proveedor
	And Selecciono el Tab de Zonas de Proveedores
	And Diligencio y selecciono una zona para el proveedor
	And Selecciono el Tab de Especialistas de Proveedores
	And Selecciono el Tab de Monitores de Proveedores
	And Diligencio y selecciono un monitor para el proveedor
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS
	And Se registra el servicio relacionado a proveedor en la tabla AFLS_PROVIDER_SERVICES
	And Se registra la zona relacionada a proveedor en la tabla AFLS_PROVIDER_ZONE
	And Se registra el monitor relacionado a proveedor en la tabla AFLS_PROVIDER_MONITORS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de proveedor de prioridad media
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio nombre de proveedor
	And Diligencio descripción de proveedor
	And Selecciono tipo de proveedor interno
	And Selecciono tipo de proveedor externo
	And Selecciono asignación manualmente
	And Selecciono asignación al mejor especialista
	And Selecciono importancia Media
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad media
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de proveedor de prioridad alta
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio nombre de proveedor
	And Diligencio descripción de proveedor
	And Selecciono tipo de proveedor interno
	And Selecciono tipo de proveedor externo
	And Selecciono asignación manualmente
	And Selecciono asignación al mejor especialista
	And Selecciono importancia Alta
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad alta
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de proveedor de prioridad baja
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio nombre de proveedor
	And Diligencio descripción de proveedor
	And Selecciono tipo de proveedor interno
	And Selecciono tipo de proveedor externo
	And Selecciono asignación manualmente
	And Selecciono asignación al mejor especialista
	And Selecciono importancia Baja
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad baja
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de proveedor externo
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio nombre de proveedor
	And Diligencio descripción de proveedor
	And Selecciono tipo de proveedor externo
	And Selecciono asignación manualmente
	And Selecciono asignación al mejor especialista
	And Selecciono importancia Alta
	And Selecciono importancia Media
	And Selecciono importancia Baja	
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS de tipo externo
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de proveedor interno
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio nombre de proveedor
	And Diligencio descripción de proveedor
	And Selecciono tipo de proveedor interno
	And Selecciono asignación manualmente
	And Selecciono asignación al mejor especialista
	And Selecciono importancia Alta
	And Selecciono importancia Media
	And Selecciono importancia Baja	
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS de tipo interno
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de proveedor con asignación manual
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio nombre de proveedor
	And Diligencio descripción de proveedor
	And Selecciono tipo de proveedor interno
	And Selecciono tipo de proveedor externo
	And Selecciono asignación manualmente
	And Selecciono importancia Alta
	And Selecciono importancia Media
	And Selecciono importancia Baja
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS con asignación manual
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de proveedor con asignación automática
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio nombre de proveedor
	And Diligencio descripción de proveedor
	And Selecciono tipo de proveedor interno
	And Selecciono tipo de proveedor externo
	And Selecciono asignación al mejor especialista
	And Selecciono importancia Alta
	And Selecciono importancia Media
	And Selecciono importancia Baja
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS con asignación automática
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación fallida de proveedor sin nombre
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio descripción de proveedor
	And Selecciono tipo de proveedor externo
	And Selecciono asignación al mejor especialista
	And Selecciono importancia Alta
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que existen campos inválidos
	And No Se registra el proveedor en la tabla AFLS_PROVIDERS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación fallida de proveedor sin descripción
	Given Tengo un usuario con rol administrador
	And El proveedor no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Doy click en Nuevo proveedor
	And Selecciono el Tab de Proveedores
	And Diligencio nombre de proveedor
	And Selecciono tipo de proveedor externo
	And Selecciono asignación al mejor especialista
	And Selecciono importancia Baja
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que existen campos inválidos
	And No Se registra el proveedor en la tabla AFLS_PROVIDERS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Modificación exitosa de proveedor cambiando nombre
	Given Tengo un usuario con rol administrador
	And El proveedor existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Busco y selecciono el proveedor
	And Edito nombre de proveedor
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS con nombre editado
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Modificación exitosa de proveedor cambiando prioridad
	Given Tengo un usuario con rol administrador
	And El proveedor existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Busco y selecciono el proveedor
	And Edito prioridad de proveedor
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS con prioridad editado
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Modificación exitosa de proveedor cambiando asignación
	Given Tengo un usuario con rol administrador
	And El proveedor existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Busco y selecciono el proveedor
	And Edito asignación de proveedor
	And Doy click en Guardar proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el proveedor en la tabla AFLS_PROVIDERS con asignación editada
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Consulta exitosa de proveedor por nombre
	Given Tengo un usuario con rol administrador
	And El proveedor existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Busco y selecciono el proveedor
	Then Se muestra la tarjeta del proveedor y el detalle del mismo
	And Cierro Sesión en la aplicación
@Automation
Scenario: 4 Borrado exitoso de proveedor
	Given Tengo un usuario con rol administrador
	And El proveedor existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción de Proveedores
	And Busco y selecciono el proveedor
	And Doy click en eliminar proveedor
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se registra el proveedor como eliminado en la tabla AFLS_PROVIDERS
	And Al buscar el proveedor en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación