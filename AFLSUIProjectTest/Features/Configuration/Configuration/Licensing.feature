Feature: Licensing


Scenario: Configuración exitosa de Licenciamiento
	Given Tengo un usuario con rol administrador
	When Configuración exitosa de Licenciamiento
	Then Finaliza exitosa la prueba

Scenario: Licenciar especialistas móviles
	Given Tengo un usuario con rol administrador
	When Licenciar especialistas móviles
	Then Finaliza exitosa la prueba

Scenario: Eliminar licencia de especialistas móviles
	Given Tengo un usuario con rol administrador
	When Eliminar licencia de especialistas móviles
	Then Finaliza exitosa la prueba
