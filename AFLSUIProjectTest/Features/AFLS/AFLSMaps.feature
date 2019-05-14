Feature: AFLSMaps
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Maps @Companies
Scenario: Validación exitosa de control de mapa en creación de compañía al dar click en cursor de validación
	Given Tengo un usuario con rol administrador
	And No existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Doy click en Nueva compañía
	And Diligencio nombre de compañía
	And Diligencio código único de compañía
	And Diligencio dirección de compañía dando click en cursor
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección

@Maps @Clients
Scenario: Validación exitosa de control de mapa en creación de compañía al presionar Enter
Given Tengo un usuario con rol administrador
	And No existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Doy click en Nueva compañía
	And Diligencio nombre de compañía
	And Diligencio código único de compañía
	And Diligencio dirección de compañía dando enter
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección

@Maps @Clients
Scenario: Validación exitosa de control de mapa en creación de compañía al presionar Tab}
	Given Tengo un usuario con rol administrador
	And No existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Doy click en Nueva compañía
	And Diligencio nombre de compañía
	And Diligencio código único de compañía
	And Diligencio dirección de compañía dando tab
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección

@Maps @Clients
Scenario: Validación exitosa de control de mapa en creación de clientes al dar click en cursor de validación
	Given Tengo un usuario con rol administrador
	And El cliente no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en Nuevo Cliente
	And Diligencio nombre de compañía
	And Diligencio código único de cliente
	And Diligencio dirección de cliente dando click en cursor
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario cliente en la tabla AFW_USERS
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección

@Maps @Clients
Scenario: Validación exitosa de control de mapa en creación de clientes al presionar Enter
	Given Tengo un usuario con rol administrador
	And El cliente no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en Nuevo Cliente
	And Diligencio nombre de compañía
	And Diligencio código único de cliente
	And Diligencio dirección de cliente dando enter
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario cliente en la tabla AFW_USERS
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección

@Maps @Clients
Scenario: Validación exitosa de control de mapa en creación de clientes al presionar Tab
	Given Tengo un usuario con rol administrador
	And El cliente no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en Nuevo Cliente
	And Diligencio nombre de compañía
	And Diligencio código único de cliente
	And Diligencio dirección de cliente dando tab
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario cliente en la tabla AFW_USERS
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección

@Maps @MobileUsers
Scenario: Validación exitosa de control de mapa en creación de usuarios móviles al dar click en cursor de validación
	Given No existe el usuario móvil
	And Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Doy click en Nuevo usuario móvil
	And Diligencio nombre de usuario móvil
	And Diligencio usuario de usuario móvil
	And diligencio correo electrónico valido de usuario móvil
	And Diligencio teléfono de usuario móvil
	And diligencio contraseña de usuario móvil
	And selecciono cargo de usuario móvil
	And diligencio dirección valida de usuario móvil dando click en cursor
	And selecciono sede de inventario
	And selecciono tipo de transporte de usuario móvil
	And selecciono proveedor de usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección

@Maps @MobileUsers
Scenario: Validación exitosa de control de mapa en creación de usuarios móviles al presionar Enter
	Given No existe el usuario móvil
	And Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Doy click en Nuevo usuario móvil
	And Diligencio nombre de usuario móvil
	And Diligencio usuario de usuario móvil
	And diligencio correo electrónico valido de usuario móvil
	And Diligencio teléfono de usuario móvil
	And diligencio contraseña de usuario móvil
	And selecciono cargo de usuario móvil
	And diligencio dirección valida de usuario móvil dando enter
	And selecciono sede de inventario
	And selecciono tipo de transporte de usuario móvil
	And selecciono proveedor de usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección

@Maps @MobileUsers
Scenario: Validación exitosa de control de mapa en creación de usuarios móviles al presionar Tab
	Given No existe el usuario móvil
	And Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Doy click en Nuevo usuario móvil
	And Diligencio nombre de usuario móvil
	And Diligencio usuario de usuario móvil
	And diligencio correo electrónico valido de usuario móvil
	And Diligencio teléfono de usuario móvil
	And diligencio contraseña de usuario móvil
	And selecciono cargo de usuario móvil
	And diligencio dirección valida de usuario móvil dando tab
	And selecciono sede de inventario
	And selecciono tipo de transporte de usuario móvil
	And selecciono proveedor de usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección

@Maps @Specialist
Scenario: Validación exitosa de control de mapa en creación de especialistas de monitor al dar click en cursor de validación
	Given No existe el usuario móvil
	And Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Doy click en Nuevo usuario móvil
	And Diligencio nombre de usuario móvil
	And Diligencio usuario de usuario móvil
	And diligencio correo electrónico valido de usuario móvil
	And Diligencio teléfono de usuario móvil
	And diligencio contraseña de usuario móvil
	And selecciono cargo de usuario móvil
	And diligencio dirección valida de usuario móvil dando click en cursor
	And selecciono sede de inventario
	And selecciono tipo de transporte de usuario móvil
	And selecciono proveedor de usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección

@Maps @Specialist
Scenario: Validación exitosa de control de mapa en creación de especialistas de monitor al presionar Enter
	Given No existe el usuario móvil
	And Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Doy click en Nuevo usuario móvil
	And Diligencio nombre de usuario móvil
	And Diligencio usuario de usuario móvil
	And diligencio correo electrónico valido de usuario móvil
	And Diligencio teléfono de usuario móvil
	And diligencio contraseña de usuario móvil
	And selecciono cargo de usuario móvil
	And diligencio dirección valida de usuario móvil dando enter
	And selecciono sede de inventario
	And selecciono tipo de transporte de usuario móvil
	And selecciono proveedor de usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección

@Maps @Specialist
Scenario: Validación exitosa de control de mapa en creación de especialistas de monitor al presionar Tab
	Given No existe el usuario móvil
	And Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Doy click en Nuevo usuario móvil
	And Diligencio nombre de usuario móvil
	And Diligencio usuario de usuario móvil
	And diligencio correo electrónico valido de usuario móvil
	And Diligencio teléfono de usuario móvil
	And diligencio contraseña de usuario móvil
	And selecciono cargo de usuario móvil
	And diligencio dirección valida de usuario móvil dando tab
	And selecciono sede de inventario
	And selecciono tipo de transporte de usuario móvil
	And selecciono proveedor de usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección

@Maps @Zones
Scenario: Validación exitosa de control de mapa en creación de zonas
	Given Tengo un usuario con rol administrador
    And No existe la zona
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Zonas
	And Doy click en Nueva zona
	And Diligencio nombre de zona
	And Diligencio descripción de zona
	And Selecciono prioridad Máxima
	And Doy click en switch de estado de zona
	And Selecciono el tab Zona
	And Doy click en crear zona
	And Dibujo polígono de zona
	And Doy click en cerrar zona
	And Selecciono el tab Proveedores
	And Diligencio y selecciono proveedor para zona
	And Selecciono el tab Información de zona
	And Doy click en Guardar zona
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la zona en la tabla AFLS_ZONES
	And Se registra el polígono de la zona en la tabla AFLS_ZONE_POLYGON
	And Se registra la relación de proveedor con zona en la tabla AFLS_PROVIDER_ZONE

@Maps @Locations
Scenario: Validación exitosa de control de mapa en creación de ubicaciones al dar click en cursor de validación
	Given Tengo un usuario con rol administrador
	And No existe la ubicación de tipo sede 
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Doy click en Nueva ubicación sede
	And Selecciono tipo de ubicación de sede
	And Diligencio nombre de ubicación
	And Diligencio descripción de ubicación
	And Diligencio dirección de ubicación dando click en cursor
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO con longitud, latitud y dirección

@Maps @Locations
Scenario: Validación exitosa de control de mapa en creación de ubicaciones al presionar Enter
	Given Tengo un usuario con rol administrador
	And No existe la ubicación de tipo sede 
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Doy click en Nueva ubicación sede
	And Selecciono tipo de ubicación de sede
	And Diligencio nombre de ubicación
	And Diligencio descripción de ubicación
	And Diligencio dirección de ubicación dando enter
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO con longitud, latitud y dirección

@Maps @Locations
Scenario: Validación exitosa de control de mapa en creación de ubicaciones al presionar Tab
	Given Tengo un usuario con rol administrador
	And No existe la ubicación de tipo sede 
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Doy click en Nueva ubicación sede
	And Selecciono tipo de ubicación de sede
	And Diligencio nombre de ubicación
	And Diligencio descripción de ubicación
	And Diligencio dirección de ubicación dando tab
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO con longitud, latitud y dirección

@Maps @Establishment
Scenario: Validación exitosa de control de mapa en configuración de información básica al dar click en cursor de validación
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

@Maps @Establishment
Scenario: Validación exitosa de control de mapa en configuración de información básica al presionar Enter
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	And Diligencio nombre de compañía en información básica
	And Diligencio NIT de compañía en información básica
	And Diligencio dirección de compañía en información básica dando enter
	And Doy click en Guardar información básica
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la configuración básica en la tabla AFLS_ESTABLISHMENT con longitud, latitud y dirección
	And Se registra por base de datos la zona geográfica de dos países

@Maps @Establishment
Scenario: Validación exitosa de control de mapa en configuración de información básica al presionar Tab
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	And Diligencio nombre de compañía en información básica
	And Diligencio NIT de compañía en información básica
	And Diligencio dirección de compañía en información básica dando tab
	And Doy click en Guardar información básica
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la configuración básica en la tabla AFLS_ESTABLISHMENT con longitud, latitud y dirección
	And Se registra por base de datos la zona geográfica de dos países

@Maps @Monitoring
Scenario: Visualización exitosa de control de mapa en monitoreo de especialistas
	Given Tengo un usuario con rol monitor
	And Tengo proveedores asociados al proveedor
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Selecciono la opción de ítem Monitoreo de especialistas
	Then Se carga la pantalla principal de monitoreo de especialistas
	And Se muestra correctamente el control de mapas
	And Al seleccionar un especialista se muestra su información en el mapa correctamente
	And Cierro Sesión en la aplicación

@Maps @Monitoring
Scenario: Visualización exitosa de control de mapa en monitoreo de clientes
	Given Tengo un usuario con rol monitor
	And El usuario monitor tiene proveedores asociados
	And Existen clientes con ordenes del día en curso
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Selecciono la opción de ítem de Monitoreo de clientes
	Then Se carga la pantalla principal de monitoreo de clientes
	And No se cargan errores en el modulo
	And Se muestra correctamente el control de mapas
	And Al seleccionar un cliente se muestra su información en el mapa correctamente
	And Cierro Sesión en la aplicación

@Maps @Monitoring
Scenario: Visualización exitosa de control de mapa en monitoreo de planeación
	Given Tengo un usuario con rol monitor
	And El usuario monitor tiene proveedores asociados
	And Existen especialistas con ordenes del día en curso
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Selecciono la opción de ítem de Monitoreo de planeación
	Then Se carga la pantalla principal de monitoreo de planeación
	And No se cargan errores en el modulo
	And Se muestra correctamente el control de mapas
	And Al seleccionar un especialista se muestra su información en el mapa correctamente
	And Cierro Sesión en la aplicación

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de cita para creación de orden de trabajo al dar click en cursor de validación
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando click en cursor
	And Diligencio y selecciono servicio de orden
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra la orden con ticket_id, longitud, latitud y dirección

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de cita para creación de orden de trabajo al presionar Enter
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando enter
	And Diligencio y selecciono servicio de orden
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra la orden con ticket_id, longitud, latitud y dirección

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de cita para creación de orden de trabajo al presionar Tab
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando tab
	And Diligencio y selecciono servicio de orden
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra la orden con ticket_id, longitud, latitud y dirección

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de destino para creación de orden de trabajo al dar click en cursor de validación
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando click en cursor
	And Diligencio y selecciono servicio de orden
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra la orden en la tabla AFLS_WORKORDERS con ticket_id, longitud, latitud y dirección

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de destino para creación de orden de trabajo al presionar Enter
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando enter
	And Diligencio y selecciono servicio de orden
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra la orden en la tabla AFLS_WORKORDERS con ticket_id, longitud, latitud y dirección

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de destino para creación de orden de trabajo al presionar Tab
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando tab
	And Diligencio y selecciono servicio de orden
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra la orden en la tabla AFLS_WORKORDERS con ticket_id, longitud, latitud y dirección

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de cita para actualización de orden de trabajo al dar click en cursor de validación
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo en estado abierta
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de cita de orden de trabajo dando click en cursor
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS
	
@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de cita para actualización de orden de trabajo al presionar Enter
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo en estado abierta
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de cita de orden de trabajo dando enter
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de cita para actualización de orden de trabajo al presionar Tab
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo en estado abierta
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de cita de orden de trabajo dando tab
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de destino para actualización de orden de trabajo al dar click en cursor de validación
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo abierta o en proceso
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de destino de orden de trabajo dando click en cursor
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de destino para actualización de orden de trabajo al presionar Enter
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo abierta o en proceso
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de destino de orden de trabajo dando enter
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS

@Maps @Orders
Scenario: Validación exitosa de control de mapa en dirección de destino para actualización de orden de trabajo al presionar Tab
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo abierta o en proceso
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de destino de orden de trabajo dando tab
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS

@Maps @Orders
Scenario: Visualización exitosa de control de mapa en ordenes disponibles
	Given Tengo un usuario con rol monitor y proveedores asociados
	And Existe una orden sin proveedor
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Accedo a ítem de menú de Ordenes disponibles
	And Diligencio y selecciono la orden de trabajo
	Then se muestra control de mapa en resumen de orden de trabajo

@Maps @Import
Scenario: Validación exitosa de direcciones en importación de clientes sin dirección y con coordenadas
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en importar clientes desde archivo
	And Adjunto archivo csv valido con clientes sin dirección y con coordenadas
	And Doy click en Importar clientes
	Then Se importan correctamente los clientes y se muestran ubicaciones en el mapa
	And se registran clientes importados en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección

@Maps @Import
Scenario: Validación exitosa de direcciones en importación de clientes con dirección y sin coordenadas
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en importar clientes desde archivo
	And Adjunto archivo csv valido con clientes con dirección y sin coordenadas
	And Doy click en Importar clientes
	Then Se importan correctamente los clientes y se muestran ubicaciones en el mapa
	And se registran clientes importados en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección

@Maps @Import
Scenario: Validación exitosa de direcciones en importación de ordenes sin dirección y con coordenadas
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo abierta o en proceso
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Doy click en importar orden
	And Adjunto archivo csv valido con ordenes sin dirección y con coordenadas
	And Doy click en importar ordenes de trabajo
	Then Se importan correctamente las ordenes de trabajo y se muestran ubicaciones en el mapa
	And se registran ordenes importadas en la tabla AFLS_WORKORDERS con longitud, latitud y dirección

@Maps @Import
Scenario: Validación exitosa de direcciones en importación de ordenes con dirección y sin coordenadas
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo abierta o en proceso
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Doy click en importar orden
	And Adjunto archivo csv valido con ordenes con dirección y sin coordenadas
	And Doy click en importar ordenes de trabajo
	Then Se importan correctamente las ordenes de trabajo y se muestran ubicaciones en el mapa
	And se registran ordenes importadas en la tabla AFLS_WORKORDERS con longitud, latitud y dirección

@Maps @Import
Scenario: Visualización exitosa de control de mapa al terminar importación de ordenes
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo abierta o en proceso
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Doy click en importar orden
	And Adjunto archivo csv valido con ordenes con dirección o coordenadas
	And Doy click en importar ordenes de trabajo
	Then Se importan correctamente las ordenes de trabajo y se muestran ubicaciones en el mapa
	And se muestra control de mapa con información de ordenes importadas y no importadas y puntos de ubicación de ordenes
	And se registran ordenes importadas en la tabla AFLS_WORKORDERS con longitud, latitud y dirección

@Maps @Import
Scenario: Visualización exitosa de control de mapa al terminar importación de clientes
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en importar clientes desde archivo
	And Adjunto archivo csv valido con clientes con dirección o coordenadas
	And Doy click en Importar clientes
	Then Se importan correctamente los clientes y se muestran ubicaciones en el mapa
	And se muestra control de mapa con información de clientes importadas y no importadas y puntos de ubicación de clientes
	And se registran clientes importados en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección

@Maps @Motor @Orders
Scenario: Solución exitosa de motor de asignación con ordenes de trabajo en petición automática
	Given Tengo ordenes de trabajo sin asignar especialista
	When Accedo a base de datos de aplicación
	And Se espera ejecución de motor de asignación y finalización de la ejecución
	And Se revisan ordenes de trabajo
	Then Se reflejan las ordenes de trabajo con asignación correcta de especialista y fechas tentativas de inicio, finalización y transporte

@Maps @Motor @Orders
Scenario: Solución exitosa de motor de asignación con ordenes de trabajo en petición manual
	Given Tengo un usuario con rol despachador
	And Tengo ordenes de trabajo sin asignar especialista
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Doy click en el Tab Asignación de especialista en orden de trabajo
	And Doy click en Filtrar
	And Se espera ejecución de motor de asignación y finalización de la ejecución
	And Selecciono un especialista del listado resultante
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	Then Se reflejan las ordenes de trabajo con asignación correcta de especialista y fechas tentativas de inicio, finalización y transporte

@AssitMe @Orders
Scenario: Validación exitosa de control de mapa en creación de solicitud de trabajo al dar click en cursor de validación
	Given Tengo usuario cliente con canal AssistMe activo
	When Accedo a la aplicación AssistMe
	And Realizo Login con usuario cliente
	And Diligencio dirección dando click en cursor
	And Selecciono servicio
	And diligencio descripción para servicio
	And Doy click en crear solicitud
	Then se muestra mensaje pantalla con datos de solicitud creada exitosamente

@AssitMe @Orders
Scenario: Visualización exitosa de control de mapa en seguimiento de especialista en solicitud creada
	Given Tengo usuario cliente con canal AssistMe activo
	And Tengo solicitudes creadas para el cliente
	When Accedo a la aplicación AssistMe
	And Realizo Login con usuario cliente
	And Selecciono solicitud existente
	And Doy click en ubicación de especialista
	Then se muestra control de mapa con ubicación de solicitud y ubicación actual de especialista

@Mobile @Orders
Scenario: Validación correcta de control de mapas externo al revisar orden de trabajo con solo dirección de cita
	Given Tengo usuario con rol especialista
	And Tengo ordenes asignadas a especialista con solo dirección de cita
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono mapa de orden de trabajo
	Then se dirige mapa a aplicación externa y se muestra ruta hacia la dirección de la orden

@Mobile @Orders
Scenario: Validación correcta de control de mapas externo al revisar orden de trabajo con dirección de cita y destino
	Given Tengo usuario con rol especialista
	And Tengo ordenes asignadas a especialista con dirección de cita y destino
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono mapa de orden de trabajo
	Then se dirige mapa a aplicación externa y se muestra ruta de orden de cita y destino

@Mobile @Clients
Scenario: Validación correcta de control de mapas al crear cliente pulsando botón de validación de dirección de cita
	Given Tengo usuario con rol especialista
	And El cliente no existe
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Pulso crear cliente ne móvil
	And Diligencio datos básicos de cliente en móvil
	And Diligencio y valido dirección de cliente en móvil
	And Pulso Crear cliente en móvil
	And Se muestra mensaje indicado que se creó el cliente exitosamente
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección

@Mobile @Orders
Scenario: Validación correcta de control de mapas al crear orden pulsando botón de validación de dirección de cita
	Given Tengo usuario con rol especialista
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Pulso crear orden en móvil
	And Diligencio datos básicos de orden en móvil
	And Diligencio y valido dirección de orden en móvil
	And Pulso Crear orden en móvil
	And Se muestra mensaje indicado que se creó la orden exitosamente
	And Se registra la orden en la tabla AFLS_WORKORDERS con longitud, latitud y dirección







