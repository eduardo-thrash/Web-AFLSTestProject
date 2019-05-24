Feature: AssistMeRegister
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: Carga exitosa de link de registro de cliente en AssistMe

Scenario: Pre registro exitoso de cliente en AssistMe
	Given El cliente para registro en AssitMe no existe
	And El servidor de correo esta configurado como activo
	And El canal de AssistMe esta habilitado
	And Tengo usuario cliente con canal AssistMe activo
	And Tengo usuario cliente con canal AssistMe activo para realizar Login en AssistMe
	And Tengo configurado registro de cliente en Configuración de AssistMe
	When Accedo a la aplicación de AssistMe
	And Pulso el link de registro de AssistMe
	And Diligencio campo nombre para registro en AssistMe
	And Diligencio campo dirección para registro en AssistMe
	And Diligencio campo detalle de dirección para registro en AssistMe
	And Diligencio campo número de teléfono móvil para registro en AssistMe
	And Diligencio campo correo electrónico para registro en AssistMe
	And Diligencio campo usuario para registro en AssistMe
	And Diligencio campo contraseña para registro en AssistMe
	And Diligencio campo confirmar contraseña para registro en AssistMe
	And Pulso el botón registrarse
	Then Se muestra un mensaje indicando que el registro se realizo exitosamente.

Scenario: Pre registro exitoso de cliente básico en AssistMe
	Given Tengo configurado el acceso a AssistMe
	And quiero realizar registro de cliente en AssistMe
	And configuro registro de cliente en Configuración de AssistMe
	When Accedo a la aplicación de AssistMe
	And pulso el link de registro de AssistMe
	And completo los campos nombre, usuario, contraseña y confirmar contraseña
	And pulso el botón registrar
	Then Se muestra un mensaje indicando que el registro se realizo exitosamente.



	
