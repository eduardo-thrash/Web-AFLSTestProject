Feature: UCs


Scenario: 1 Creación exitosa de UC
	Given Tengo un usuario con rol administrador
	When Creación exitosa de UC
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda exitosa de UC existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de UC existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de UC
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de UC
	Then Finaliza exitosa la prueba

Scenario: 4 Borrado exitoso de UC existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de UC existente
	Then Finaliza exitosa la prueba

