Feature: Licensing


Scenario: Licenciamiento exitoso de especialistas móviles
	Given Tengo un usuario con rol administrador
	And El usuario móvil existe
	And El usuario móvil no tiene licencia activa
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Licenciamiento
	And Selecciono el Tab Especialistas para licenciamiento
	And Diligencio y selecciono especialista para licenciar
	Then Se muestra vista con nombre de especialista comprobando su licenciamiento
	And se registra el especialista en la tabla AFW_LICENSES_NAMED


Scenario: Eliminación exitosa de usuarios móviles
	Given Tengo un usuario con rol administrador
	And El usuario móvil existe
	And El usuario móvil tiene licencia activa
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Licenciamiento
	And Selecciono el Tab Especialistas para licenciamiento
	And Doy click en eliminar licencia de especialista
	Then se quita la vista del especialista de la pantalla
	And No se registra el especialista en la tabla AFW_LICENSES_NAMED


Scenario: Eliminación fallida de usuarios móviles por trabajo en campo en curso
	Given Tengo un usuario con rol administrador
	And El usuario móvil existe
	And El usuario móvil tiene licencia activa
	And El usuario móvil tiene ordenes en proceso
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Licenciamiento
	And Selecciono el Tab Especialistas para licenciamiento
	Then Se muestra mensaje indicando que el especialista esta trabajando y no puede quitar la licencia
	And se registra el especialista en la tabla AFW_LICENSES_NAMED
