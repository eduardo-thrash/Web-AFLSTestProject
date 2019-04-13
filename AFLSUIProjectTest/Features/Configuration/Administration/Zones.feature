Feature: Zones


Scenario: Creación exitosa de Zonas
	Given Tengo un usuario con rol administrador
	When Creación exitosa de Zonas
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de zona existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de zona existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de Zonas
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de Zonas
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de Zonas
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de Zonas
	Then Finaliza exitosa la prueba
