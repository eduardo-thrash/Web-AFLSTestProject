Feature: Quick Answers


Scenario: Creación exitosa de respuesta rápida
	Given Tengo un usuario con rol administrador
	And La respuesta rápida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	When Creación exitosa de respuesta rápida
	Then Finaliza exitosa la prueba

Scenario: 1 Creación fallida de respuestas rápidas con nombre repetido
	Given Tengo un usuario con rol administrador
	And La respuesta rápida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	When Creación fallida de respuestas rápidas con nombre repetido
	Then Finaliza exitosa la prueba

Scenario: 1 Cancelación exitosa de creación de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rápida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	When Cancelación exitosa de creación de respuestas rápidas
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rápida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	When Modificación exitosa de respuestas rápidas
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación fallida de respuestas rápidas dejando nombre o descripción vacíos
	Given Tengo un usuario con rol administrador
	And La respuesta rápida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	When Modificación fallida de respuestas rápidas dejando nombre o descripción vacíos
	Then Finaliza exitosa la prueba

Scenario: 4 Inactivación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rápida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	When Inactivación exitosa de respuestas rápidas
	Then Finaliza exitosa la prueba

Scenario: 5 Eliminación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rápida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	When Eliminación exitosa de respuestas rápidas
	Then Finaliza exitosa la prueba
