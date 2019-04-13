Feature: MobileUsers


@mytag
Scenario: Creación exitosa de usuario móvil con grupos móvil, disponibilidad y habilidades
	Given No existe el usuario móvil
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
	And Se registra el usuario móvil en la tabla AFLS_USERS_SPECIALISTS
	And Se registra disponibilidad de todos los días en la tabla AFLS_USER_AVAILABILITIES
	And Se registra habilidad de usuario móvil en la tabla AFLS_USER_SKILLS
	And Se registra usuario móvil asociado a grupo móvil en la tabla AFW_GROUP_USER


