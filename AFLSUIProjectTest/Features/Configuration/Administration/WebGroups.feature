Feature: Web Groups

@migrationAFLS
Scenario: Creación exitosa de grupo web
	Given Tengo un usuario con rol administrador
    And No existe el grupo web
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Grupos Web
	And Doy click en Nuevo grupo web
	And Diligencio nombre de grupo web
	And Diligencio descripción de grupo web
	And Selecciono rol administrador de grupo web
	And Selecciono rol monitor de grupo web
	And Selecciono rol despachador de grupo web
	And Selecciono rol gestor de inventario de grupo web
	And Selecciono el Tab Usuarios de grupos web
	And Diligencio y selecciono el usuario para el grupo web
	And Selecciono el Tab Grupos web
	And Doy click en Guardar grupo web
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el grupo en la tabla AFW_GROUPS
	And Se registra el grupo web en la tabla AFLS_GROUPS_WEB
	And Se registra el usuario asociado al grupo web en la tabla AFW_GROUP_USER

@migrationAFLS
Scenario: Búsqueda exitosa de Grupos web existente
	Given Tengo un usuario con rol administrador
	And El grupo web existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Grupos Web
	And Busco y selecciono el grupo web
	Then Se muestra la tarjeta del grupo web y el detalle del mismo

@migrationAFLS
Scenario: Modificación exitosa de grupos web
	Given Tengo un usuario con rol administrador
	And El grupo web existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Grupos Web
	And Busco y selecciono el grupo web
	And Edito nombre de grupo web
	And Doy click en Guardar grupo web
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el grupo editado en la tabla AFW_GROUPS

@migrationAFLS
Scenario: Borrado exitoso de grupo web existente
	Given Tengo un usuario con rol administrador
	And El grupo web existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Grupos Web
	And Busco y selecciono el grupo web
	And Doy click en eliminar grupo web
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And No se registra el grupo en la tabla AFW_GROUPS