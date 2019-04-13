Feature: Meassures


Scenario: 1 Creación exitosa de Medidas
	Given Tengo un usuario con rol administrador
	When Creación exitosa de Medidas
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda exitosa de Medida existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de Medida existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de Medidas
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de Medidas
	Then Finaliza exitosa la prueba

Scenario: 4 Borrado exitoso de Medida existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de Medida existente
	Then Finaliza exitosa la prueba

