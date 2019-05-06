Feature: MailServer



Scenario: Configuración exitosa de servidor de correo
	Given Tengo un usuario con rol administrador
	And No existe configuración de servidor de correo
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Servidor de correo
	And Doy click en switch de estado de servidor de correo
	And Doy click en Guardar Servidor de correo
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra activo el servidor de correo en la tabla AFW_SETTINGS

Scenario: Inactivación exitosa de servidor de correo
	Given Tengo un usuario con rol administrador
	And Existe configuración de servidor de correo activa
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Servidor de correo
	And Doy click en switch de estado de servidor de correo
	And Doy click en Guardar Servidor de correo
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra inactivo el servidor de correo en la tabla AFW_SETTINGS


