Feature: LocationAccuracy
	


 Scenario: Configuración exitosa de precisión de ubicación alta
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Precisión de ubicación
	And Configuración exitosa de precisión de ubicación alta
	
	Then Finaliza exitosa la prueba

 Scenario: Configuración exitosa de precisión de ubicación media
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Precisión de ubicación
	When Configuración exitosa de precisión de ubicación media
	Then Finaliza exitosa la prueba

 Scenario: Configuración exitosa de precisión de ubicación baja
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Precisión de ubicación
	When Configuración exitosa de precisión de ubicación baja
	Then Finaliza exitosa la prueba



