Feature: MailServer



Scenario: Configuración exitosa de servidor de correo
	Given Tengo un usuario con rol administrador
	And No existe configuración de servidor de correo
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Servidor de correo
	When Configuración exitosa de servidor de correo
	Then Finaliza exitosa la prueba


