Feature: GeneralAlerts

Scenario: Carga exitosa de modulo Alertas generales
	Given Tengo un usuario con rol monitor
	And El usuario monitor y administrador tiene proveedores asociados
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Selecciono la opción de item de Alertas General
	Then Se carga la pantalla principal de alertas generales
