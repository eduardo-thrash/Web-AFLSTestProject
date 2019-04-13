Feature: Web Users


Scenario: Creación exitosa de usuario web
	Given Tengo un usuario con rol administrador
	When Creación exitosa de usuario web
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de usuario web existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de usuario web existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de usuario web
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de usuario web
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de usuario web existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de usuario web existente
	Then Finaliza exitosa la prueba