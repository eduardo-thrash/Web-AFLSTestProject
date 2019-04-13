Feature: Calendars
	

Scenario: 1 Creación exitosa de Calendarios
	Given Tengo un usuario con rol administrador
	When Creación exitosa de Calendarios
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda de calendario existente
	Given Tengo un usuario con rol administrador
	When Busqueda de calendario existente
	Then Finaliza exitosa la prueba

Scenario: 3 modificación parcial de calendario
	Given Tengo un usuario con rol administrador
	When modificación parcial de calendario
	Then Finaliza exitosa la prueba

Scenario: 4 Borrar calendario existente
	Given Tengo un usuario con rol administrador
	When Borrar calendario existente
	Then Finaliza exitosa la prueba