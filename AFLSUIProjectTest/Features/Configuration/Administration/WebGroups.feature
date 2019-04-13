Feature: Web Groups


Scenario: Creación exitosa de grupo web
	Given Tengo un usuario con rol administrador
	When Creación exitosa de grupo web
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de Grupos web existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de Grupos web existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de grupos web
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de grupos web
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de grupo web existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de grupo web existente
	Then Finaliza exitosa la prueba

