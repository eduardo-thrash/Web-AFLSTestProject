Feature: Products
	

Scenario: 1 Creación exitosa de productos
	Given Tengo un usuario con rol administrador
	And El producto no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Productos
	When Creación exitosa de productos
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda exitosa de un producto existente
	Given Tengo un usuario con rol administrador
	And El producto existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Productos
	When Busqueda exitosa de un producto existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de un producto
	Given Tengo un usuario con rol administrador
	And El producto existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Productos
	When Modificación exitosa de un producto
	Then Finaliza exitosa la prueba



Scenario: 4 Borrado exitoso de producto existente
	Given Tengo un usuario con rol administrador
	And El producto existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Productos
	When Borrado exitoso de producto existente
	Then Finaliza exitosa la prueba
