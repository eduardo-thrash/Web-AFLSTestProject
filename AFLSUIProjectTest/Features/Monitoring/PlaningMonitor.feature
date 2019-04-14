Feature: PlaningMonitor


Scenario: Carga exitosa de pantalla de Monitoreo de planeación
	Given Tengo un usuario con rol monitor
	And El usuario monitor tiene proveedores asociados
	And Existen especialistas con ordenes del día en curso
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Selecciono la opción de item de Monitoreo de planeación
	Then Se carga la pantalla principal de monitoreo de planeación
