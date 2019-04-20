Feature: Meassures


Scenario: 1 Creación exitosa de Medidas
	Given Tengo un usuario con rol administrador
	And La medida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Medidas
	And Creación exitosa de Medidas
	Then Finaliza exitosa la prueba

Scenario: 2 Búsqueda exitosa de Medida existente
	Given Tengo un usuario con rol administrador
	And La medida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Medidas
	And Búsqueda exitosa de Medida existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de Medidas
	Given Tengo un usuario con rol administrador
	And La medida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Medidas
	And Modificación exitosa de Medidas
	Then Finaliza exitosa la prueba

Scenario: 4 Borrado exitoso de Medida existente
	Given Tengo un usuario con rol administrador
	And La medida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Medidas
	And Borrado exitoso de Medida existente
	Then Finaliza exitosa la prueba

