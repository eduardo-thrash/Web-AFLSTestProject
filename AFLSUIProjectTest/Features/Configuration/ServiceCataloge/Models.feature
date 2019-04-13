Feature: Models


Scenario: 1 Creación exitosa de modelos
	Given Tengo un usuario con rol administrador
	When Creación exitosa de modelos
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda exitosa de un modelo existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de un modelo existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de un modelo
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de un modelo
	Then Finaliza exitosa la prueba

Scenario: 4 Borrado exitoso de modelo existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de modelo existente
	Then Finaliza exitosa la prueba
