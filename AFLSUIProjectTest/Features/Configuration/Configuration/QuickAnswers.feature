Feature: Quick Answers


Scenario: Creación exitosa de respuesta rápida
	Given Tengo un usuario con rol administrador
	And La respuesta rapida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rapidas
	When Creación exitosa de respuesta rápida
	Then Finaliza exitosa la prueba

Scenario: 1 Creación fallida de respuestas rápidas con nombre repetido
	Given Tengo un usuario con rol administrador
	And La respuesta rapida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rapidas
	When Creación fallida de respuestas rápidas con nombre repetido
	Then Finaliza exitosa la prueba

Scenario: 1 Cancelación exitosa de creación de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rapida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rapidas
	When Cancelación exitosa de creación de respuestas rápidas
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rapida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rapidas
	When Modificación exitosa de respuestas rápidas
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación fallida de respuestas rápidas dejando nombre o descripción vacios
	Given Tengo un usuario con rol administrador
	And La respuesta rapida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rapidas
	When Modificación fallida de respuestas rápidas dejando nombre o descripción vacios
	Then Finaliza exitosa la prueba

Scenario: 4 Inactivación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rapida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rapidas
	When Inactivación exitosa de respuestas rápidas
	Then Finaliza exitosa la prueba

Scenario: 5 Eliminación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rapida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rapidas
	When Eliminación exitosa de respuestas rápidas
	Then Finaliza exitosa la prueba
