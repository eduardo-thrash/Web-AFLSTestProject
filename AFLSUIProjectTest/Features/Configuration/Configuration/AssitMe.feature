Feature: AssistMe Basic Configuration


Scenario: Configuración exitosa de AssistMe habilitando canal
	Given Tengo un usuario con rol administrador
	And No tengo configurado canal de AssistMe habilitado
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Canal AssistMe
	And Doy click en switch de estado de Canal AssistMe
	And Diligencio URL de canal de AssistMe
	And Diligencio URL de Acerca de
	And Diligencio texto de bienvenida de Canal AssistMe
	And Diligencio texto de termino de especialista en campo de Canal AssistMe
	And Diligencio texto de termino de trabajo en campo de Canal AssistMe
	And Doy click en switch de registro de cliente de Canal AssistMe
	And Doy click en Guardar configuración de Canal AssistMe
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	Then Se registra canal AssistMe configurado como activo y registro cliente habilitado