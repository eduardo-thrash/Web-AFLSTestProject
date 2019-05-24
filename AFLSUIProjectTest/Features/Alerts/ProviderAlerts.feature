Feature: ProviderAlerts



Scenario: Carga exitosa de modulo Alertas de proveedores con selector de todos los proveedores
	Given Tengo un usuario con rol monitor y despachador
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor y despachador
	And Selecciono la opción de ítem de Alertas Proveedores
	Then Se carga la pantalla principal de alertas de proveedores
