Feature: OLAs


Scenario: Creación exitosa de OLA
	Given Tengo un usuario con rol administrador
	When Creación exitosa de OLA
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de OLA existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de OLA existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de OLA
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de OLA
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de OLA existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de OLA existente
	Then Finaliza exitosa la prueba

