Feature: SLAs
	

Scenario: 1 Creación exitosa de ANS
	Given Tengo un usuario con rol administrador
	When Creación exitosa de ANS
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda exitosa de un ANS existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de un ANS existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de un ANS
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de un ANS
	Then Finaliza exitosa la prueba

Scenario: 4 Borrado exitoso de ANS existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de ANS existente
	Then Finaliza exitosa la prueba