Feature: ClientsMonitor
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Carga exitosa de pantalla de Monitoreo de clientes
	Given Tengo un usuario con rol monitor
	And El usuario monitor tiene proveedores asociados
	And Existen clientes con ordenes del día en curso
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Selecciono la opción de item de Monitoreo de clientes
	Then Se carga la pantalla principal de monitoreo de clientes
