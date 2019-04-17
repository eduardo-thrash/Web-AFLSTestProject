Feature: Models


Scenario: 1 Creación exitosa de modelos
	Given Tengo un usuario con rol administrador
	And El modelo no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Modelos
	When Creación exitosa de modelos
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda exitosa de un modelo existente
	Given Tengo un usuario con rol administrador
	And El modelo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Modelos
	When Busqueda exitosa de un modelo existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de un modelo
	Given Tengo un usuario con rol administrador
	And El modelo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Modelos
	When Modificación exitosa de un modelo
	Then Finaliza exitosa la prueba

Scenario: 4 Borrado exitoso de modelo existente
	Given Tengo un usuario con rol administrador
	And El modelo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Modelos
	When Borrado exitoso de modelo existente
	Then Finaliza exitosa la prueba
