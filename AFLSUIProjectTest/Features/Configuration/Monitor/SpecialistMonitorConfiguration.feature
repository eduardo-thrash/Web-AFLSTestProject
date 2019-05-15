Feature: SpecialistMonitorConfiguration
#	In order to avoid silly mistakes
#	As a math idiot
#	I want to be told the sum of two numbers
#
#@mytag
Scenario: Creación completa exitosa de especialista de monitor
	Given Tengo un usuario con rol monitor y con proveedores asociados
	And no existe el especialista
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Accedo al menú Configuración de monitor
	And Doy click en Nuevo especialista de proveedor
	And Diligencio nombre de especialista de proveedor
	And Diligencio usuario de especialista de proveedor
	And diligencio correo electrónico valido de especialista de proveedor
	And Diligencio teléfono de especialista de proveedor
	And diligencio contraseña de especialista de proveedor
	And selecciono cargo de especialista de proveedor
	And diligencio dirección valida de especialista de proveedor
	And selecciono sede de inventario para especialista de proveedor
	And selecciono tipo de transporte de especialista de proveedor
	And valido selección inhabilitada de proveedor para especialista
	And Doy click en switch de estado de especialista de proveedor
	And Selecciono el Tab de grupos móvil de especialista de proveedor
	And Diligencio y selecciono un grupo móvil para especialista de proveedor
	And Selecciono el Tab de disponibilidad de especialista de proveedor
	And Selecciono disponibilidad de siete días a especialista de proveedor
	And Selecciono el Tab de habilidades de especialista de proveedor
	And Valido que no existen campos para asociar habilidades
	And Selecciono el tab Información de especialista de proveedor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el especialista en la tabla AFW_USERS
	And Se registra el especialista con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS
	And Se registra disponibilidad de todos los días en la tabla AFLS_USER_AVAILABILITIES
	And Se registra habilidad de especialista en la tabla AFLS_USER_SKILLS
	And Se registra especialista asociado a grupo móvil en la tabla AFW_GROUP_USER
	And Se muestra la habilidad asociada en el tab Habilidades del especialista
	And Se muestra el grupo móvil asociado en el tab Habilidades del especialista
	And Se muestra la disponibilidad asociada en el tab disponibilidad del especialista
	And Cierro Sesión en la aplicación
