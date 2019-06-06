﻿Feature: AFLSMaps
	Control de mapas sobre AFLS bajo proveedores:
	- Open street maps + Nominatim
	- Open street maps + Arcgis
	- Google maps + google maps
	Pre requisitos: Configuración de columna [esta_country] de tabla [AFLS_ESTABLISHMENT]
	- identificador del conjunto: 112505
	- FEATURE 112507
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de compañía al dar click en cursor de validación
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
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de compañía al dar click en cursor de validación
	Given Tengo un usuario con rol administrador
	And Existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Busco y selecciono la compañía
	And modifico dirección de compañía dando click en cursor
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de compañía al presionar Enter
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
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de compañía al presionar Enter
	Given Tengo un usuario con rol administrador
	And Existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Busco y selecciono la compañía
	And modifico dirección de compañía dando enter
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de compañía al presionar Tab
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
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de compañía al presionar Tab
	Given Tengo un usuario con rol administrador
	And Existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Busco y selecciono la compañía
	And modifico dirección de compañía dando tab
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación 
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de compañía al dar click en mapa
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
	And Diligencio dirección de compañía dando click en mapa
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de compañía al dar click en mapa
	Given Tengo un usuario con rol administrador
	And Existe la compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañias
	And Busco y selecciono la compañía
	And modifico dirección de compañía dando click en mapa
	And Selecciono el Tab Campos adicionales
	And Diligencio campos adicionales de compañía
	And Doy click en Guardar compañía
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_COMPANIES con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de clientes al dar click en cursor de validación
	Given Tengo un usuario con rol administrador
	And El cliente no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en Nuevo Cliente
	And Diligencio nombre de cliente
	And Diligencio código único de cliente
	And Diligencio dirección de cliente dando click en cursor
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario cliente en la tabla AFW_USERS
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de cliente al dar click en cursor de validación
	Given Tengo un usuario con rol administrador
	And El cliente existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Busco y selecciono el cliente
	And modifico dirección de cliente dando click en cursor
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de clientes al presionar Enter
	Given Tengo un usuario con rol administrador
	And El cliente no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en Nuevo Cliente
	And Diligencio nombre de cliente
	And Diligencio código único de cliente
	And Diligencio dirección de cliente dando enter
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario cliente en la tabla AFW_USERS
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de cliente al presionar Enter
	Given Tengo un usuario con rol administrador
	And El cliente existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Busco y selecciono el cliente
	And modifico dirección de cliente dando enter
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de clientes al presionar Tab
	Given Tengo un usuario con rol administrador
	And El cliente no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en Nuevo Cliente
	And Diligencio nombre de cliente
	And Diligencio código único de cliente
	And Diligencio dirección de cliente dando tab
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario cliente en la tabla AFW_USERS
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de cliente al presionar Tab
	Given Tengo un usuario con rol administrador
	And El cliente existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Busco y selecciono el cliente
	And modifico dirección de cliente dando Tab
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de clientes al dar click en mapa
	Given Tengo un usuario con rol administrador
	And El cliente no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Doy click en Nuevo Cliente
	And Diligencio nombre de cliente
	And Diligencio código único de cliente
	And Diligencio dirección de cliente dando click en mapa
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario cliente en la tabla AFW_USERS
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de cliente al dar click en mapa
	Given Tengo un usuario con rol administrador
	And El cliente existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Clientes
	And Busco y selecciono el cliente
	And modifico dirección de cliente dando click en mapa
	And Selecciono el Tab de Campos adicionales
	And Diligencio campos adicionales de cliente
	And Doy click en Guardar cliente
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de usuarios móviles al dar click en cursor de validación
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
	And selecciono tipo de transporte de usuario móvil
	And selecciono proveedor de usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de usuarios móviles al dar click en cursor de validación
	Given Tengo un usuario con rol administrador
	And El usuario móvil existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Busco y selecciono el usuario móvil
	And modifico dirección de usuario móvil dando click en mapa
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de usuarios móviles al dar Enter
	Given Tengo un usuario con rol administrador
	And El usuario móvil existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Busco y selecciono el usuario móvil
	And modifico dirección de usuario móvil dando enter
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de usuarios móviles al dar Tab
	Given Tengo un usuario con rol administrador
	And El usuario móvil existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Busco y selecciono el usuario móvil
	And modifico dirección de usuario móvil dando tab
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de usuarios móviles al dar click en mapa
	Given Tengo un usuario con rol administrador
	And El usuario móvil existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Usuarios Móviles
	And Busco y selecciono el usuario móvil
	And modifico dirección de usuario móvil dando click en mapa
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la compañía en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de usuarios móviles al presionar Enter
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
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de usuarios móviles al presionar Tab
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
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de usuarios móviles al dar click en mapa
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
	And diligencio dirección valida de usuario móvil dando click en mapa
	And selecciono sede de inventario
	And selecciono tipo de transporte de usuario móvil
	And selecciono proveedor de usuario móvil
	And Doy click en Guardar usuario móvil
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el usuario en la tabla AFW_USERS
	And Se registra el usuario móvil con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de especialistas de monitor al dar click en cursor de validación
	Given Tengo un usuario con rol monitor y con proveedores asociados
	And no existe el especialista
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Selecciono la opción especialistas
	And Doy click en Nuevo especialista de proveedor
	And Diligencio nombre de especialista de proveedor
	And Diligencio usuario de especialista de proveedor
	And diligencio correo electrónico valido de especialista de proveedor
	And Diligencio teléfono de especialista de proveedor
	And diligencio contraseña de especialista de proveedor
	And selecciono cargo de especialista de proveedor
	And diligencio dirección valida de especialista de proveedor dando click en cursor
	And selecciono sede de inventario para especialista de proveedor
	And selecciono tipo de transporte de especialista de proveedor
	And Doy click en Guardar especialista
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el especialista de proveedor en la tabla AFW_USERS
	And Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de especialista de monitor al dar click en cursor de validación
	Given Tengo un usuario con rol monitor y con proveedores asociados
	And Existe el especialista con proveedor y monitor relacionado
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Selecciono la opción especialistas
	And Busco y selecciono el especialista de proveedor
	And modifico dirección valida de especialista de proveedor dando click en cursor
	And Doy click en Guardar especialista
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección modificado
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de especialista de monitor al dar Enter
	Given Tengo un usuario con rol monitor y con proveedores asociados
	And Existe el especialista con proveedor y monitor relacionado
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Selecciono la opción especialistas
	And Busco y selecciono el especialista de proveedor
	And modifico dirección valida de especialista de proveedor dando enter
	And Doy click en Guardar especialista
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección modificado
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de especialista de monitor al dar Tab
	Given Tengo un usuario con rol monitor y con proveedores asociados
	And Existe el especialista con proveedor y monitor relacionado
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Selecciono la opción especialistas
	And Busco y selecciono el especialista de proveedor
	And modifico dirección valida de especialista de proveedor dando Tab
	And Doy click en Guardar especialista
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección modificado
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de especialista de monitor al dar click en mapa
	Given Tengo un usuario con rol monitor y con proveedores asociados
	And Existe el especialista con proveedor y monitor relacionado
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Selecciono la opción especialistas
	And Busco y selecciono el especialista de proveedor
	And modifico dirección valida de especialista de proveedor dando click en mapa
	And Doy click en Guardar especialista
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección modificado
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de especialistas de monitor al presionar Enter
	Given Tengo un usuario con rol monitor y con proveedores asociados
	And no existe el especialista
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Accedo a ítem Configuración de monitor
	And Selecciono la opción especialistas
	And Doy click en Nuevo especialista de proveedor
	And Diligencio nombre de especialista de proveedor
	And Diligencio usuario de especialista de proveedor
	And diligencio correo electrónico valido de especialista de proveedor
	And Diligencio teléfono de especialista de proveedor
	And diligencio contraseña de especialista de proveedor
	And selecciono cargo de especialista de proveedor
	And diligencio dirección valida de especialista de proveedor dando enter
	And selecciono sede de inventario para especialista de proveedor
	And selecciono tipo de transporte de especialista de proveedor
	And Doy click en Guardar especialista
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el especialista de proveedor en la tabla AFW_USERS
	And Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de especialistas de monitor al presionar Tab
	Given Tengo un usuario con rol monitor y con proveedores asociados
	And no existe el especialista
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Selecciono la opción especialistas
	And Doy click en Nuevo especialista de proveedor
	And Diligencio nombre de especialista de proveedor
	And Diligencio usuario de especialista de proveedor
	And diligencio correo electrónico valido de especialista de proveedor
	And Diligencio teléfono de especialista de proveedor
	And diligencio contraseña de especialista de proveedor
	And selecciono cargo de especialista de proveedor
	And diligencio dirección valida de especialista de proveedor dando tab
	And selecciono sede de inventario para especialista de proveedor
	And selecciono tipo de transporte de especialista de proveedor
	And Doy click en Guardar especialista
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el especialista de proveedor en la tabla AFW_USERS
	And Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de especialistas de monitor al dar click en mapa
	Given Tengo un usuario con rol monitor y con proveedores asociados
	And no existe el especialista
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración de monitor
	And Selecciono la opción especialistas
	And Doy click en Nuevo especialista de proveedor
	And Diligencio nombre de especialista de proveedor
	And Diligencio usuario de especialista de proveedor
	And diligencio correo electrónico valido de especialista de proveedor
	And Diligencio teléfono de especialista de proveedor
	And diligencio contraseña de especialista de proveedor
	And selecciono cargo de especialista de proveedor
	And diligencio dirección valida de especialista de proveedor click en mapa
	And selecciono sede de inventario para especialista de proveedor
	And selecciono tipo de transporte de especialista de proveedor
	And Doy click en Guardar especialista
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el especialista de proveedor en la tabla AFW_USERS
	And Se registra el especialista de proveedor  con proveedor asociado en la tabla AFLS_USERS_SPECIALISTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de zonas
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
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de zonas
	Given Tengo un usuario con rol administrador
    And Existe la zona
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And selecciono la opción Zonas
	And Busco y selecciono la zona
	And Selecciono el tab Zona
	And modifico el polígono de la zona
	And Doy click en Guardar zona
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la zona en la tabla AFLS_ZONES
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de ubicaciones al dar click en cursor de validación
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
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de ubicaciones al dar click en cursor de validación
	Given Tengo un usuario con rol administrador
	And Existe la ubicación
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Ubico y selecciono la ubicación deseada
	And Modifico dirección de ubicación dando click en cursor
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de ubicaciones al dar Enter
	Given Tengo un usuario con rol administrador
	And Existe la ubicación
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Ubico y selecciono la ubicación deseada
	And Modifico dirección de ubicación dando Enter
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de ubicaciones al dar Tab
	Given Tengo un usuario con rol administrador
	And Existe la ubicación
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Ubico y selecciono la ubicación deseada
	And Modifico dirección de ubicación dando Tab
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en actualización de ubicaciones al dar click en mapa
	Given Tengo un usuario con rol administrador
	And Existe la ubicación
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Ubicaciones
	And Ubico y selecciono la ubicación deseada
	And Modifico dirección de ubicación dando click en mapa
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO con longitud, latitud y dirección modificada
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de ubicaciones al presionar Enter
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
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de ubicaciones al presionar Tab
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
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de ubicaciones al dar click en mapa
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
	And Diligencio dirección de ubicación dando click en mapa
	And Doy click en Guardar ubicación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la ubicación en la tabla AFLS_STOCK_LOCATIONS_INFO con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en configuración de información básica al dar click en cursor de validación
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
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en configuración de información básica al presionar Enter
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
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en configuración de información básica al presionar Tab
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
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en configuración de información básica al dar click en mapa
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono opción de Información básica
	And Diligencio nombre de compañía en información básica
	And Diligencio NIT de compañía en información básica
	And Diligencio dirección de compañía en información básica dando click en mapa
	And Doy click en Guardar información básica
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la configuración básica en la tabla AFLS_ESTABLISHMENT con longitud, latitud y dirección
	And Se registra por base de datos la zona geográfica de dos países
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Visualización exitosa de control de mapa en monitoreo de especialistas
	Given Tengo un usuario con rol monitor
	And Tengo proveedores asociados al proveedor
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Selecciono la opción de ítem Monitoreo de especialistas
	Then Se carga la pantalla principal de monitoreo de especialistas
	And Se muestra correctamente el control de mapas
	And Al seleccionar un especialista se muestra su información en el mapa correctamente
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Visualización exitosa de control de mapa en monitoreo de clientes
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
Scenario: CP_AFLS: Mapas > Visualización exitosa de control de mapa en monitoreo de planeación
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
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de cita para creación de orden de trabajo al dar click en cursor de validación
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
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de cita para creación de orden de trabajo al presionar Enter
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
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de cita para creación de orden de trabajo al presionar Tab
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
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de cita para creación de orden de trabajo al dar click en mapa
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando click en mapa
	And Diligencio y selecciono servicio de orden
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de destino para creación de orden de trabajo al dar click en cursor de validación
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente de tipo desplazamiento
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando click en cursor
	And Diligencio y selecciono servicio de orden de tipo desplazamiento
	And Diligencio Dirección de destino de orden dando click en cursor
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud de destino, latitud de destino y dirección de destino
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de destino para creación de orden de trabajo al presionar Enter
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando enter
	And Diligencio y selecciono servicio de orden de tipo desplazamiento
	And Diligencio Dirección de destino de orden dando enter
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud de destino, latitud de destino y dirección de destino
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de destino para creación de orden de trabajo al presionar Tab
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando tab
	And Diligencio y selecciono servicio de orden de tipo desplazamiento
	And Diligencio Dirección de destino de orden dando Tab
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud de destino, latitud de destino y dirección de destino
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de destino para creación de orden de trabajo al dar click en mapa
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden dando click en mapa
	And Diligencio y selecciono servicio de orden de tipo desplazamiento
	And Diligencio Dirección de destino de orden dando click en mapa
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud de destino, latitud de destino y dirección de destino
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de cita para actualización de orden de trabajo al dar click en cursor de validación
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo en estado abierta
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de cita de orden de trabajo dando click en cursor
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en dirección de cita para actualización de orden de trabajo al presionar Enter
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo en estado abierta
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de cita de orden de trabajo dando enter
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de mapa en dirección de cita para actualización de orden de trabajo al presionar Tab
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de mapa en dirección de cita para actualización de orden de trabajo al dar click en mapa
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo en estado abierta
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de cita de orden de trabajo dando click en mapa
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de mapa en dirección de destino para actualización de orden de trabajo al dar click en cursor de validación
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de mapa en dirección de destino para actualización de orden de trabajo al presionar Enter
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de mapa en dirección de destino para actualización de orden de trabajo al presionar Tab
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de mapa en dirección de destino para actualización de orden de trabajo al dar click en mapa
	Given Tengo un usuario con rol despachador
	And Existe una orden de trabajo abierta o en proceso
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Diligencio y selecciono la orden de trabajo
	And Doy click en Abrir orden de trabajo
	And Edito dirección de destino de orden de trabajo dando click en mapa
	But Si se muestra mensaje de reasignación doy click en Aceptar
	And Doy click en Guardar orden
	Then se muestra mensaje indicando que se guardo orden de trabajo exitosamente
	And se actualiza dirección, longitud y latitud de orden en la tabla AFLS_WORKORDERS
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Visualización exitosa de control de mapa en ordenes disponibles
	Given Tengo un usuario con rol monitor y proveedores asociados
	And Existe una orden sin proveedor
	When Accedo a la aplicación
	And Realizo Login con usuario rol monitor
	And Accedo a ítem de menú de Ordenes disponibles
	And Diligencio y selecciono la orden de trabajo
	Then se muestra control de mapa en resumen de orden de trabajo
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de direcciones en importación de clientes sin dirección y con coordenadas
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de direcciones en importación de clientes con dirección y sin coordenadas
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de direcciones en importación de ordenes sin dirección y con coordenadas
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de direcciones en importación de ordenes con dirección y sin coordenadas
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Visualización exitosa de control de mapa al terminar importación de ordenes
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Visualización exitosa de control de mapa al terminar importación de clientes
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Solución exitosa de motor de asignación con ordenes de trabajo en petición automática
	Given Tengo ordenes de trabajo sin asignar especialista
	When Accedo a base de datos de aplicación
	And Se espera ejecución de motor de asignación y finalización de la ejecución
	And Se revisan ordenes de trabajo
	Then Se reflejan las ordenes de trabajo con asignación correcta de especialista y fechas tentativas de inicio, finalización y transporte
Scenario: CP_AFLS: Mapas > Solución exitosa de motor de asignación con ordenes de trabajo en petición manual
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
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación exitosa de control de mapa en creación de solicitud de trabajo al dar click en cursor de validación
	Given Tengo usuario cliente con canal AssistMe activo
	When Accedo a la aplicación de AssistMe
	And Realizo Login con usuario cliente
	And Diligencio dirección dando click en cursor
	And Selecciono servicio
	And diligencio descripción para servicio
	And Doy click en crear solicitud
	Then se muestra mensaje pantalla con datos de solicitud creada exitosamente
Scenario: CP_AFLS: Mapas > Visualización exitosa de control de mapa en seguimiento de especialista en solicitud creada
	Given Tengo usuario cliente con canal AssistMe activo
	And Tengo solicitudes creadas para el cliente
	When Accedo a la aplicación AssistMe
	And Realizo Login con usuario cliente
	And Selecciono solicitud existente
	And Doy click en ubicación de especialista
	Then se muestra control de mapa con ubicación de solicitud y ubicación actual de especialista
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación correcta de control de mapas externo al revisar orden de trabajo con solo dirección de cita
	Given Tengo usuario con rol especialista
	And Tengo ordenes asignadas a especialista con solo dirección de cita
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono mapa de orden de trabajo
	Then se dirige mapa a aplicación externa y se muestra ruta hacia la dirección de la orden
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación correcta de control de mapas externo al revisar orden de trabajo con dirección de cita y destino
	Given Tengo usuario con rol especialista
	And Tengo ordenes asignadas a especialista con dirección de cita y destino
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono mapa de orden de trabajo
	Then se dirige mapa a aplicación externa y se muestra ruta de orden de cita y destino
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación correcta de control de mapas al crear cliente pulsando botón de validación de dirección de cita
	Given Tengo usuario con rol especialista
	And El cliente no existe
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Pulso crear cliente ne móvil
	And Diligencio datos básicos de cliente en móvil
	And Diligencio y valido dirección de cliente en móvil
	And Pulso Crear cliente en móvil
	Then Se muestra mensaje indicado que se creó el cliente exitosamente
	And Se registra el cliente en la tabla AFLS_USER_CLIENTS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
Scenario: CP_AFLS: Mapas > Validación correcta de control de mapas al crear orden pulsando botón de validación de dirección de cita
	Given Tengo usuario con rol especialista
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Pulso crear orden en móvil
	And Diligencio datos básicos de orden en móvil
	And Diligencio y valido dirección de orden en móvil
	And Pulso Crear orden en móvil
	Then Se muestra mensaje indicado que se creó la orden exitosamente
	And Se registra la orden en la tabla AFLS_WORKORDERS con longitud, latitud y dirección
	And Cierro Sesión en la aplicación
@Automation
Scenario: CP_AFLS: Mapas > Visualización exitosa de control de mapa en pre registro de cliente nuevo en AssistMe
	Given El cliente para registro en AssitMe no existe
	And El servidor de correo esta configurado como activo
	And El canal de AssistMe esta habilitado
	And Tengo configurado registro de cliente en Configuración de AssistMe
	When Accedo a la aplicación de AssistMe
	And Pulso el link de registro de AssistMe
	And Diligencio campo nombre para registro en AssistMe
	And Diligencio campo dirección para registro en AssistMe
	And Diligencio campo correo electrónico para registro en AssistMe
	And Diligencio campo usuario para registro en AssistMe
	And Diligencio campo contraseña para registro en AssistMe
	And Diligencio campo confirmar contraseña para registro en AssistMe
	And Pulso el botón registrarse
	Then Se muestra un mensaje indicando que el registro se realizo exitosamente.
