Feature: Establishment


Scenario: 1 Configuración exitosa de Información básica
	Given Tengo un usuario con rol administrador
	And No tengo información básica configurada
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	When Configuración exitosa de Información básica
	And Se registra la configuración en la tabla AFLS_ESTABLISHMENT
	And Se registra por base de datos la zona geográfica de dos países
	Then Finaliza exitosa la prueba

Scenario: 2 Cancelación exitosa configuración de Información básica
	Given Tengo un usuario con rol administrador
	And Tengo información básica configurada
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	When Cancelación exitosa configuración de Información básica
	And Se registra por base de datos la zona geográfica de dos países
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de Información básica
	Given Tengo un usuario con rol administrador
	And Tengo información básica configurada
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	When Modificación exitosa de Información básica
	And Se registra por base de datos la zona geográfica de dos países
	Then Finaliza exitosa la prueba

Scenario: 4 Modificación fallida de información básica dejando nombre vacío
	Given Tengo un usuario con rol administrador
	And Tengo información básica configurada
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	When Modificación fallida de información básica dejando nombre vacío
	And Se registra por base de datos la zona geográfica de dos países
	Then Finaliza exitosa la prueba
