Feature: SpecialistMonitor
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#@mytag
Scenario: Acceso exitoso a pantalla de monitoreo de especialistas
	Given Tengo un usuario con rol monitor
	And Tengo proveedores asociados al proveedor
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Selecciono la opción de ítem MOnitoreo de especialistas
	Then Se carga la pantalla principal de monitoreo de especialistas
	And No se cargan errores en el modulo
	And Cierro Sesión en la aplicación
