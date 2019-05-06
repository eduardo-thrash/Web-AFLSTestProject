Feature: LocationAccuracy
	


 Scenario: Configuración exitosa de precisión de ubicación alta
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Precisión de ubicación
	And Configuración exitosa de precisión de ubicación alta
	And Selecciono la opción de precisión alta
	And Doy click en Guardar configuración de precisión
	Then Se muestra mensaje indicando que se guardo el registro exitosamente

 Scenario: Configuración exitosa de precisión de ubicación media
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Precisión de ubicación
	And Selecciono la opción de precisión media
	And Doy click en Guardar configuración de precisión
	Then Se muestra mensaje indicando que se guardo el registro exitosamente

 Scenario: Configuración exitosa de precisión de ubicación baja
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Precisión de ubicación
	And Selecciono la opción de precisión baja
	And Doy click en Guardar configuración de precisión
	Then Se muestra mensaje indicando que se guardo el registro exitosamente



