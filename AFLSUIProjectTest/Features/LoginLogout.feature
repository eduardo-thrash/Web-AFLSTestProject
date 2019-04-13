Feature: LoginLogout

@mytag
Scenario: Login exitoso con rol Administrador
	Given Tengo usuario administrador
	When Accedo a la aplicación
	And Ingreso nombre de usuario administrador valido
	And Ingreso contraseña de usuario administrador valido
	And Doy click en Login
	Then Accedo a la pantalla principal de configuración
	And se registra en base de datos el usuario con sesión activa en la tabla AFW_USER_SESSION_TOKEN

Scenario: Logout exitoso con rol Administrador
	Given Tengo usuario administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Pulso link de cierre de sesión
	Then Se cierra la sesión exitosamente del usuario administrador
	And se elimina el registro de sesión de usuario de la tabla AFW_USER_SESSION_TOKEN

