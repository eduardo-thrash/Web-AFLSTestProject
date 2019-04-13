Feature: Quick Answers


Scenario: Creación exitosa de respuesta rápida
	Given Tengo un usuario con rol administrador
	When Creación exitosa de respuesta rápida
	Then Finaliza exitosa la prueba

Scenario: 1 Creación fallida de respuestas rápidas con nombre repetido
	Given Tengo un usuario con rol administrador
	When Creación fallida de respuestas rápidas con nombre repetido
	Then Finaliza exitosa la prueba

Scenario: 1 Cancelación exitosa de creación de respuestas rápidas
	Given Tengo un usuario con rol administrador
	When Cancelación exitosa de creación de respuestas rápidas
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de respuestas rápidas
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación fallida de respuestas rápidas dejando nombre o descripción vacios
	Given Tengo un usuario con rol administrador
	When Modificación fallida de respuestas rápidas dejando nombre o descripción vacios
	Then Finaliza exitosa la prueba

Scenario: 4 Inactivación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	When Inactivación exitosa de respuestas rápidas
	Then Finaliza exitosa la prueba

Scenario: 5 Eliminación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	When Eliminación exitosa de respuestas rápidas
	Then Finaliza exitosa la prueba
