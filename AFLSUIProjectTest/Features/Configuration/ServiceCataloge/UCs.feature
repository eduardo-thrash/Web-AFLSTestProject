Feature: UCs


Scenario: 1 Creación exitosa de UC
	Given Tengo un usuario con rol administrador
	And El UC no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción UC's
	When Creación exitosa de UC
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda exitosa de UC existente
	Given Tengo un usuario con rol administrador
	And EL UC existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción UC's
	When Busqueda exitosa de UC existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de UC
	Given Tengo un usuario con rol administrador
	And El UC existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción UC's
	When Modificación exitosa de UC
	Then Finaliza exitosa la prueba

Scenario: 4 Borrado exitoso de UC existente
	Given Tengo un usuario con rol administrador
	And El UC existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción UC's
	When Borrado exitoso de UC existente
	Then Finaliza exitosa la prueba

