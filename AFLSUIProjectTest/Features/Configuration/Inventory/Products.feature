Feature: Products
	

Scenario: 1 Creación exitosa de productos
	Given Tengo un usuario con rol administrador
	When Creación exitosa de productos
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda exitosa de un producto existente
	Given Tengo un usuario con rol administrador
	When Busqueda exitosa de un producto existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de un producto
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de un producto
	Then Finaliza exitosa la prueba



Scenario: 4 Borrado exitoso de producto existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de producto existente
	Then Finaliza exitosa la prueba
