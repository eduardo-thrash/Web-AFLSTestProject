Feature: Licensing


Scenario: Configuración exitosa de Licenciamiento
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Licenciamiento
	When Configuración exitosa de Licenciamiento
	Then Finaliza exitosa la prueba

Scenario: Licenciar especialistas móviles
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Licenciamiento
	When Licenciar especialistas móviles
	Then Finaliza exitosa la prueba

Scenario: Eliminar licencia de especialistas móviles
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Licenciamiento
	When Eliminar licencia de especialistas móviles
	Then Finaliza exitosa la prueba
