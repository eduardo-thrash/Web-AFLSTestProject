Feature: Locations
	

Scenario: Creación exitosa de ubicaciones
	Given Tengo un usuario con rol administrador
	When Creación exitosa de ubicaciones
	Then Finaliza exitosa la prueba


Scenario: Busqueda exitosa de Ubicación existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de Ubicación existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de Ubicación
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de Ubicación
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de Ubicación existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de Ubicación existente
	Then Finaliza exitosa la prueba
