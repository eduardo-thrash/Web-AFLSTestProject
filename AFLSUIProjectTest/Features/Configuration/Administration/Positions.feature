Feature: Positions


Scenario: Creación exitosa de Cargos

	Given Tengo un usuario con rol administrador
	And El cargo no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Cargos
	When Creación exitosa de Cargos
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de cargo existente
	Given Tengo un usuario con rol administrador
	And El cargo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Cargos
	When Busqueda exitosa de cargo existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de cargos
	Given Tengo un usuario con rol administrador
	And El cargo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Cargos
	When Modificación exitosa de cargos
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de cargo existente
	Given Tengo un usuario con rol administrador
	And El cargo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Cargos
	When Borrado exitoso de cargo existente
	Then Finaliza exitosa la prueba