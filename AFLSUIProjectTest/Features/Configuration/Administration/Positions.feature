Feature: Positions


Scenario: Creación exitosa de Cargos
	Given Tengo un usuario con rol administrador
	When Creación exitosa de Cargos
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de cargo existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de cargo existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de cargos
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de cargos
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de cargo existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de cargo existente
	Then Finaliza exitosa la prueba