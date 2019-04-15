Feature: MobileUsers

@regression
@Bug111712
Scenario: Creación exitosa completa de usuario móvil con grupos móvil, disponibilidad y habilidades
	Given No existe el usuario móvil
	And Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Doy click en Nuevo usuario móvil
	And Diligencio nombre de usuario móvil
	And Diligencio usuario de usuario móvil
	And diligencio correo electrónico valido de usuario móvil
	And Diligencio teléfono de usuario móvil
	And diligencio contraseña de usuario móvil
	And selecciono cargo de usuario móvil
	And diligencio dirección valida de usuario móvil
	And selecciono sede de inventario
	And selecciono tipo de transporte de usuario móvil
	And selecciono proveedor de usuario móvil
	And Doy click en switch de estado de usuario móvil
	And Selecciono el Tab de grupos móvil de usuario móvil
	And Diligencio y selecciono un grupo móvil para usuario móvil
	And Selecciono el Tab de disponibilidad de usuario móvil
	And Selecciono disponibilidad de siete días a usuario móvil
	And Selecciono el Tab de habilidades de usuario móvil
	And Diligencio y selecciono una habilidad para usuario móvil
	And Selecciono el tab Información de usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS
	And Se registra disponibilidad de todos los días en la tabla AFLS_USER_AVAILABILITIES
	And Se registra habilidad de usuario móvil en la tabla AFLS_USER_SKILLS
	And Se registra usuario móvil asociado a grupo móvil en la tabla AFW_GROUP_USER
	And Realizo cierre de sesión de la aplicación con usuario administrador

@regression
@Bug108915
Scenario: Generación exitosa de correo de vinculación a usuario móvil
	Given El usuario móvil existe
	And El servidor de correo esta configurado como activo
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Busco y selecciono el usuario móvil
	And Selecciono el tab Información de usuario móvil
	And Doy click en link de envío de correo de vinculación
	Then Se muestra mensaje indicando que el correo se envió satisfactoriamente
	And Se registra el mensaje de correo en la tabla AFW_MAIL sin enviar a destinatario aún
	And Realizo cierre de sesión de la aplicación con usuario administrador


@regression
@Bug108519
Scenario: Asociación exitosa de disponibilidad y habilidades a especialista básico por asociación de grupo móvil
	Given El usuario móvil existe sin disponibilidad y habilidades
	And Existe un grupo móvil con habilidades y disponibilidad
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Busco y selecciono el usuario móvil
	And Selecciono el Tab de grupos móvil de usuario móvil
	And Diligencio y selecciono un grupo móvil para usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra usuario móvil asociado a grupo móvil en la tabla AFW_GROUP_USER 
	And Se registra disponibilidad de todos los días en la tabla AFLS_USER_AVAILABILITIES
	And Se registra habilidad de usuario móvil en la tabla AFLS_USER_SKILLS 
	And Realizo cierre de sesión de la aplicación con usuario administrador

