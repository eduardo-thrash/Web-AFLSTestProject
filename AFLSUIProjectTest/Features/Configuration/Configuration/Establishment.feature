Feature: Establishment

@Automation
Scenario: 1 Configuración exitosa de Información básica
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	And Diligencio nombre de compañía en información básica
	And Diligencio NIT de compañía en información básica
	And Diligencio dirección de compañía en información básica dando click en cursor
	And Doy click en Guardar información básica
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la configuración básica en la tabla AFLS_ESTABLISHMENT con longitud, latitud y dirección
	And Se registra por base de datos la zona geográfica de dos países
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Cancelación exitosa configuración de Información básica
	Given Tengo un usuario con rol administrador
	And Tengo información básica configurada
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	And Diligencio nombre de compañía en información básica
	And Diligencio NIT de compañía en información básica
	And Diligencio dirección de compañía en información básica dando click en cursor
	And Doy click en Cancelar información básica
	And Doy click en confirmar cancelación de información básica
	Then se mantiene la información básica sin modificar
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Modificación exitosa de Información básica
	Given Tengo un usuario con rol administrador
	And Tengo información básica configurada
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	And Modifico nombre de compañía en información básica
	And Modifico NIT de compañía en información básica
	And Modifico dirección de compañía en información básica dando click en cursor
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la configuración básica en la tabla AFLS_ESTABLISHMENT con nombre, NIT y dirección modificado
	And Se registra por base de datos la zona geográfica de dos países
	And Cierro Sesión en la aplicación
@Automation
Scenario: 4 Modificación fallida de información básica dejando nombre vacío
	Given Tengo un usuario con rol administrador
	And Tengo información básica configurada
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	And Modifico nombre de compañía en información básica dejándolo vacío
	And Doy click en Guardar información básica
	Then Se muestra mensaje indicando que existen campos inválidos
	And Cierro Sesión en la aplicación