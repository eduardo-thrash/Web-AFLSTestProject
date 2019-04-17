Feature: OLAs


Scenario: Creación exitosa de OLA
	Given Tengo un usuario con rol administrador
	And El OLA no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción OLA's
	When Creación exitosa de OLA
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de OLA existente
	Given Tengo un usuario con rol administrador
	And El OLA existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción OLA's
	When Busqueda exitosa de OLA existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de OLA
	Given Tengo un usuario con rol administrador
	And El OLA existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción OLA's
	When Modificación exitosa de OLA
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de OLA existente
	Given Tengo un usuario con rol administrador
	And El OLA existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción OLA's
	When Borrado exitoso de OLA existente
	Then Finaliza exitosa la prueba

