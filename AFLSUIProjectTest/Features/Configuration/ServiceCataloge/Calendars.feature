Feature: Calendars
	

Scenario: 1 Creación exitosa de Calendarios
	Given Tengo un usuario con rol administrador
	And El calendario no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Calendarios
	When Creación exitosa de Calendarios
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda de calendario existente
	Given Tengo un usuario con rol administrador
	And El calendario existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Calendarios
	When Busqueda de calendario existente
	Then Finaliza exitosa la prueba

Scenario: 3 modificación parcial de calendario
	Given Tengo un usuario con rol administrador
	And El calendario existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Calendarios
	When modificación parcial de calendario
	Then Finaliza exitosa la prueba

Scenario: 4 Borrar calendario existente
	Given Tengo un usuario con rol administrador
	And El calendario existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Calendarios
	When Borrar calendario existente
	Then Finaliza exitosa la prueba