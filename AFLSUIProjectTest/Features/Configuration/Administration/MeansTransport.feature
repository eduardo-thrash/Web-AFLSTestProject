Feature: MeansTransport

Scenario: Creación exitosa de Transportes
	Given Tengo un usuario con rol administrador
	When Creación exitosa de Transportes
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de un transporte existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de un transporte existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de un transporte
	Given Tengo un usuario con rol administrador
	When odificación exitosa de un transporte
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de transporte existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de transporte existente
	Then Finaliza exitosa la prueba
