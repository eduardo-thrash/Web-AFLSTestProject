Feature: Clients

@Automation
Scenario: 1 Creación completa exitosa de cliente
	Given Tengo un usuario con rol administrador
	And El cliente no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en Nuevo Cliente
	And Selecciono el Tab de Cliente
	And Diligencio nombre de cliente
	And Diligencio código único de cliente
	And Diligencio teléfono de cliente
	And Diligencio correo electrónico de cliente
	And Diligencio y selecciono una compañía para cliente
	And Diligencio dirección de cliente
	And Diligencio detalle de dirección de cliente
	And Doy click en switch de estado de cliente
	And Selecciono el Tab de Servicios
	And Diligencio y selecciono el servicio para cliente
	And Selecciono el Tab de Firma de cliente
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente
	And Selecciono el Tab de Canales
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario cliente en la tabla AFW_USERS
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS
	And Se registra la compañía asociada a cliente en la tabla AFLS_USER_CLIENTS
	And Se registra el servicio asociado a cliente en la tabla AFLS_CLIENT_SERVICES
	And se registran campos adicionales de cliente diligenciados en la tabla AFW_ADDITIONAL_FIELD_VALUE
	And se muestra cliente con canal de AssistMe habilitado
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Búsqueda exitosa de cliente existente
	Given Tengo un usuario con rol administrador
	And El cliente existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Busco y selecciono el cliente
	Then Se muestra la tarjeta del cliente y el detalle del mismo
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Modificación exitosa de cliente
	Given Tengo un usuario con rol administrador
	And El cliente existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Busco y selecciono el cliente
	And Selecciono el Tab de Cliente	
	And Edito nombre de cliente
	And Edito código único de cliente
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente	
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente	
	And Se registra el usuario cliente modificado en código único y nombre en la tabla AFW_USERS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Envío exitoso de correo de invitación AssistMe a cliente
	Given Tengo un usuario con rol administrador
	And El canal de AssistMe esta habilitado
	And El cliente existe con canal de AssistMe habilitado
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Busco y selecciono el cliente
	And Selecciono el Tab de Canales
	And Doy click en botón de envío de correo a cliente
	And Acepto el envío de correo
	Then Se muestra un mensaje indicando que se envío correo a email de cliente
	And Se registra el mensaje de correo en la tabla AFW_MAIL sin enviar a cliente aún
@Automation
Scenario: 3 Modificación exitosa de cliente agregando compañía
	Given Tengo un usuario con rol administrador
	And Existe al menos una compañía
	And El cliente existe sin compañía asociada
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Busco y selecciono el cliente
	And Selecciono el Tab de Cliente
	And Diligencio y selecciono una compañía para modificación de cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente	
	And Se registra el cliente modificado con compañía asociada en la tabla AFLS_USER_CLIENTS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 4 Borrado exitoso de cliente existente
	Given Tengo un usuario con rol administrador
	And El cliente existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Busco y selecciono el cliente
	And Doy click en eliminar cliente
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And se elimina el registro de usuario cliente de la tabla AFW_USERS
	And Al buscar el cliente en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación