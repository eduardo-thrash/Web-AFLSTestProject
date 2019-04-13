Feature: Skills
	#Configuración de habilidades para asociación en servicios, usuarios moviles, grupos moviles
	#And validación de ellos al asignar ordenes de trabajo

Scenario: 1 Creación exitosa de habilidad
	Given Tengo un usuario con rol administrador
	When Creación exitosa de habilidad
	Then Finaliza exitosa la prueba

Scenario: 1 Creación fallida de habilidad con nombre repetido
	Given Tengo un usuario con rol administrador
	When Creación fallida de habilidad con nombre repetido
	Then Finaliza exitosa la prueba

Scenario: 1 Cancelación exitosa de creación de habilidad
	Given Tengo un usuario con rol administrador
	When Cancelación exitosa de creación de habilidad
	Then Finaliza exitosa la prueba

Scenario: 2 Consulta exitosa de habilidad por nombre
	Given Tengo un usuario con rol administrador
	When Consulta exitosa de habilidad por nombre
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de habilidades
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de habilidades
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación fallida de habilidades dejando nombre o descripción vacios
	Given Tengo un usuario con rol administrador
	When Modificación fallida de habilidades dejando nombre o descripción vacios
	Then Finaliza exitosa la prueba

Scenario: 3 Inactivación exitosa de habilidades
	Given Tengo un usuario con rol administrador
	When Inactivación exitosa de habilidades
	Then Finaliza exitosa la prueba

Scenario: 4 Eliminación exitosa de habilidades
	Given Tengo un usuario con rol administrador
	When Eliminación exitosa de habilidades
	Then Finaliza exitosa la prueba