Feature: Clients

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
	And Diligencio campos adicionales de cliente 
	And Selecciono el Tab de Canales
	And Habilito canal de AssistMe para cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario cliente en la tabla AFW_USERS
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS
	And Se registra la compañía asociada a cliente en la tabla AFLS_USER_CLIENTS
	And Se registra el servicio asociado a cliente en la tabla AFLS_CLIENT_SERVICES
	And se registran campos adicionales de cliente diligenciados
	And se muestra cliente con canal de AssistMe habilitado

	Then Finaliza exitosa la prueba

Scenario: 2 Búsqueda exitosa de cliente existente
	Given Tengo un usuario con rol administrador
	When Búsqueda exitosa de cliente existente
	Then Finaliza exitosa la prueba

Scenario: 3 Modificación exitosa de cliente
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de cliente
	Then Finaliza exitosa la prueba

Scenario: 4 Borrado exitoso de cliente existente
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de cliente existente
	Then Finaliza exitosa la prueba
