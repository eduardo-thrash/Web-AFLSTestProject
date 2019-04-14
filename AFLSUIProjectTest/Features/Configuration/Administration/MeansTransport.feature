Feature: MeansTransport

Scenario: Creación exitosa de Transportes

	Given Tengo un usuario con rol administrador
	And El transporte no existe
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Transportes


	When Creación exitosa de Transportes
	Then Finaliza exitosa la prueba

Scenario: Busqueda exitosa de un transporte existente
	Given Tengo un usuario con rol administrador
	And El transporte existe
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Transportes
	When Busqueda exitosa de un transporte existente
	Then Finaliza exitosa la prueba

Scenario: Modificación exitosa de un transporte
	Given Tengo un usuario con rol administrador
	And El transporte existe
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Transportes
	When odificación exitosa de un transporte
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de transporte existente
	Given Tengo un usuario con rol administrador
	And El transporte existe
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Transportes
	When Borrado exitoso de transporte existente
	Then Finaliza exitosa la prueba
