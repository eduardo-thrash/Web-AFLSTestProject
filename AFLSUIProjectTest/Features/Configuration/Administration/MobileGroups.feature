Feature: Mobile Groups

Scenario: Creación exitosa de grupo movil
	Given Tengo un usuario con rol administrador
	When Creación exitosa de grupo movil
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de grupo movil existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de grupo movil existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de grupo movil
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de grupo movil
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de grupo movil existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de grupo movil existente
	Then Finaliza exitosa la prueba
