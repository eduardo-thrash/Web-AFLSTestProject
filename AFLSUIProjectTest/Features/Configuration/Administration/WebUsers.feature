Feature: Web Users

@Automation
Scenario: 1 Creación exitosa de usuario web
	Given Tengo un usuario con rol administrador
    And No existe el usuario web
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Usuarios Web
	And Doy click en Nuevo Usuario Web
	And Diligencio nombre de usuario web
	And Diligencio usuario de usuario web
	And Diligencio correo electrónico de usuario web
	And Diligencio teléfono de usuario web
	And Diligencio contraseña de usuario web
	And Selecciono rol administrador de usuario web
	And Selecciono rol monitor de usuario web
	And Selecciono rol despachador de usuario web
	And Selecciono rol gestor de inventario de usuario web
	And Selecciono el Tab Grupos Web de usuarios web
	And Diligencio y selecciono el grupo para el usuario web
	And Selecciono el Tab Información de usuario
	And Doy click en Guardar usuario web
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario web en la tabla AFW_USERS
	And Se registra el usuario web en la tabla AFLS_USERS_WEB
	And Se registra el grupo web asociado al usuario web en la tabla AFW_GROUP_USER
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Búsqueda exitosa de usuario web existente
	Given Tengo un usuario con rol administrador
    And Existe el usuario web
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Usuarios Web
	And Busco y selecciono el usuario web
	Then Se muestra la tarjeta del usuario web y el detalle del mismo
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Modificación exitosa de usuario web
	Given Tengo un usuario con rol administrador
    And Existe el usuario web
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Usuarios Web
	And Busco y selecciono el usuario web
	And Edito nombre de usuario web
	And Doy click en Guardar usuario web
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 4 Borrado exitoso de usuario web existente
	Given Tengo un usuario con rol administrador
    And Existe el usuario web
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Usuarios Web
	And Busco y selecciono el usuario web
	And Doy click en eliminar usuario web
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And No se registra el usuario en la tabla AFW_USERS
	And Cierro Sesión en la aplicación