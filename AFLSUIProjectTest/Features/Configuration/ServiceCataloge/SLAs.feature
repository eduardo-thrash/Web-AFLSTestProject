Feature: SLAs
	

Scenario: 1 Creación exitosa de ANS
	Given Tengo un usuario con rol administrador
	And El ANS no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción ANS's
	When Creación exitosa de ANS
	Then Finaliza exitosa la prueba

Scenario: 2 Busqueda exitosa de un ANS existente
	Given Tengo un usuario con rol administrador
	And El ANS existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción ANS's
	When Busqueda exitosa de un ANS existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de un ANS
	Given Tengo un usuario con rol administrador
	And El ANS existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción ANS's
	When Modificación exitosa de un ANS
	Then Finaliza exitosa la prueba

Scenario: 4 Borrado exitoso de ANS existente
	Given Tengo un usuario con rol administrador
	And El ANS existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción ANS's
	When Borrado exitoso de ANS existente
	Then Finaliza exitosa la prueba