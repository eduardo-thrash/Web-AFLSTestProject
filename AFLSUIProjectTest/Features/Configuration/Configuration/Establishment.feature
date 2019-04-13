Feature: Establishment


Scenario: 1 Configuración exitosa de Información básica
	Given Tengo un usuario con rol administrador
	When Configuración exitosa de Información básica
	Then Finaliza exitosa la prueba

Scenario: 2 Cancelación exitosa configuración de Información básica
	Given Tengo un usuario con rol administrador
	When Cancelación exitosa configuración de Información básica
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de Información básica
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de Información básica
	Then Finaliza exitosa la prueba

Scenario: 4 Modificación fallida de información básica dejando nombre vacio
	Given Tengo un usuario con rol administrador
	When Modificación fallida de información básica dejando nombre vacio
	Then Finaliza exitosa la prueba
