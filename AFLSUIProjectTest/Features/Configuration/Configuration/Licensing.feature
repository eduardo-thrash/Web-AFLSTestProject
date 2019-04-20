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
	When Licenciar especialistas móviles
	Then Finaliza exitosa la prueba

Scenario: Eliminación exitosa de usuarios móviles
	Given Tengo un usuario con rol administrador
	And El usuario móvil existe
	And El usuario móvil tiene licencia activa
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Licenciamiento
	When Eliminar licencia de especialistas móviles
	Then Finaliza exitosa la prueba

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
	When Eliminar licencia de especialistas móviles
	Then Finaliza exitosa la prueba
