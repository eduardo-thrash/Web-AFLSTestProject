Feature: Clients

Scenario: Creación exitosa de cliente
	Given Tengo un usuario con rol administrador
	When Creación exitosa de cliente
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de cliente existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de cliente existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de cliente
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de cliente
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de cliente existente
	Given Tengo un usuario con rol administrador
	When orrado exitoso de cliente existente
	Then Finaliza exitosa la prueba
