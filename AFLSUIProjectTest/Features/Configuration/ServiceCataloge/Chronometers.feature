Feature: Chronometers
	#Configuración de cronometros para uso sobre ANS y Ordenes de trabajo

Scenario: 1 Creación completa de cronometros
	Given Tengo un usuario con rol administrador
	And El cronometro no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Cronometros
	When Creación completa de cronometros
	Then Finaliza exitosa la prueba

Scenario: 2 consulta exitosa de cronometro por nombre
	Given Tengo un usuario con rol administrador
	And El cronometro existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Cronometros
	When consulta exitosa de cronometro por nombre
	Then Finaliza exitosa la prueba
	
Scenario: 3 Modificación parcial de cronometeros
	Given Tengo un usuario con rol administrador
	And El cronometro existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Cronometros
	When Modificación parcial de cronometeros
	Then Finaliza exitosa la prueba

Scenario: 4 Borrar cronometro existente
	Given Tengo un usuario con rol administrador
	And El cronometro existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Cronometros
	When Borrar cronometro existente
	Then Finaliza exitosa la prueba