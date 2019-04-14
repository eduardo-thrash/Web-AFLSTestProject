Feature: ReassignMonitor
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Carga exitosa de pantalla de Monitoreo y reasignación
	Given Tengo un usuario con rol monitor y administrador
	And El usuario monitor y administrador tiene proveedores asociados
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Selecciono la opción de item de Monitoreo  y reasignación
	Then Se carga la pantalla principal de monitoreo  y reasignación
