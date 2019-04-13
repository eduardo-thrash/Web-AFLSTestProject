Feature: AF Orders



Scenario: Crear campo adicional de orden de tipo simple
	Given Tengo un usuario con rol administrador
	When Crear campo adicional de orden de tipo simple
	Then Finaliza exitosa la prueba

Scenario: Editar campo adicional de orden de tipo simple
	Given Tengo un usuario con rol administrador
	When Editar campo adicional de orden de tipo simple
	Then Finaliza exitosa la prueba

