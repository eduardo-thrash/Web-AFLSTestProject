Feature: PrincipalDashboard
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Carga exitosa de modulo Panel de control
	Given Tengo un usuario con rol monitor
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Accedo a ítem Panel de control
	Then Se carga la pantalla principal de alertas generales
