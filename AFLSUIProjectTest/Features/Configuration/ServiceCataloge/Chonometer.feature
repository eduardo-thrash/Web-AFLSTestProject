Feature: Chronometers
	#Configuración de cronometros para uso sobre ANS y Ordenes de trabajo

Scenario: 1 Creación completa de cronometros
	Given Tengo un usuario con rol administrador
	When Creación completa de cronometros
	Then Finaliza exitosa la prueba

Scenario: 2 consulta exitosa de cronometro por nombre
	Given Tengo un usuario con rol administrador
	When consulta exitosa de cronometro por nombre
	Then Finaliza exitosa la prueba
	
Scenario: 3 Modificación parcial de cronometeros
	Given Tengo un usuario con rol administrador
	When Modificación parcial de cronometeros
	Then Finaliza exitosa la prueba

Scenario: 4 Borrar cronometro existente
	Given Tengo un usuario con rol administrador
	When Borrar cronometro existente
	Then Finaliza exitosa la prueba