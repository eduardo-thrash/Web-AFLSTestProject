Feature: Mobile Groups

@regression
Scenario: 1 Creación exitosa de grupo móvil
	Given Tengo un usuario con rol administrador
	And No existe el grupo móvil
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Grupos Móviles
	And Doy click en Nuevo grupo móvil
	And Selecciono el Tab de Grupos Móvil en grupos móviles
	And Diligencio nombre de grupo móvil
	And Diligencio descripción de grupo móvil
	And Selecciono un proveedor para grupo móvil
	And Doy click en switch de estado de grupo móvil
	And Selecciono el Tab de Usuarios en grupos móviles
	And Diligencio y selecciono un usuario para el grupo móvil
	And Selecciono el Tab de Habilidades en grupos móviles
	And Diligencio y selecciono la habilidad para el grupo móvil
	And Selecciono el Tab de Disponibilidad en grupos móviles
	And Selecciono disponibilidad de siete días a grupo móvil
	And Doy click en Guardar grupo móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el grupo móvil en la tabla AFW_GROUPS
	And Se registra el usuario móvil asociado al grupo móvil en la tabla AFW_GROUP_USER
	And Se registra disponibilidad de todos los días del grupo móvil en la tabla AFLS_USER_AVAILABILITIES
	And Se registra habilidad asociada al grupo móvil en la tabla AFLS_GROUP_SKILLS
	And Cierro Sesión en la aplicación



@regression
Scenario: 2 Búsqueda exitosa de grupo móvil existente
	Given Tengo un usuario con rol administrador
	And Existe el grupo móvil
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Grupos Móviles
	And Busco y selecciono el grupo móvil
	Then Se muestra la tarjeta del grupo móvil y el detalle del mismo
	And Cierro Sesión en la aplicación
@regression
Scenario: 3 Modificación exitosa de grupo móvil editando nombre
	Given Tengo un usuario con rol administrador
	And Existe el grupo móvil
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Grupos Móviles
	And Busco y selecciono el grupo móvil
	And Modifico nombre de grupo móvil
	And Doy click en Guardar grupo móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el cambio de nombre de grupo móvil en la tabla AFW_GROUPS
	And Cierro Sesión en la aplicación
@regression
Scenario: 3 Modificación exitosa de grupo móvil agregando usuarios móviles
	Given Tengo un usuario con rol administrador
	And Existe el usuario móvil sin asociar a grupos móviles
	And Existe el grupo móvil
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Grupos Móviles
	And Busco y selecciono el grupo móvil
	And Selecciono el Tab de Usuarios en grupos móviles
	And Diligencio y selecciono el usuario para el grupo móvil
	And Doy click en Guardar grupo móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el grupo móvil con usuario móvil asociado en la tabla AFW_GROUP_USER
	And Cierro Sesión en la aplicación
@regression
Scenario: 4 Borrado exitoso de grupo móvil existente
	Given Tengo un usuario con rol administrador
	And Existe el grupo móvil
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Grupos Móviles
	And Busco y selecciono el grupo móvil
	And Doy click en eliminar grupo móvil
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	Then se elimina el registro de usuario móvil de la tabla AFW_GROUPS
	And Cierro Sesión en la aplicación
