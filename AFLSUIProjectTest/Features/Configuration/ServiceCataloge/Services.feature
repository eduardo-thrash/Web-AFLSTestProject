Feature: Services

@regression
Scenario: 1 Creación exitosa de Servicio completo
	Given Tengo un usuario con rol administrador
	And No existe el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Servicios
	And Doy Click en nuevo Servicio
	And Diligencio nombre de servicio
	And Selecciono Modelo de servicio
	And Diligencio descripción del servicio
	And Diligencio Asunto del servicio
	And Selecciono Calendario del servicio
	And Selecciono ANS del servicio
	And Selecciono UC del servicio
	And Selecciono OLA del servicio
	And Diligencio Costo base del servicio
	And Selecciono Tipo de servicio Estándar
	And Selecciono Tipo de servicio Desplazamiento	
	And Doy click en switch de estado de servicio
	And Selecciono check de brindar el servicio a todos los clientes
	And Selecciono check de Habilitar ordenes de emergencia para este servicio
	And Selecciono Tipo de asignación servicio de distribución publica
	And Selecciono Tipo de asignación servicio de asignación directa
	And Diligencio Horas de servicio
	And Diligencio Minutos de servicio
	And Selecciono el Tab de Inventario de servicio
	And Diligencio y selecciono producto tipo cantidad para servicio
	And Diligencio y selecciono producto tipo único para servicio
	And Selecciono el Tab de Habilidades de servicio
	And Diligencio y selecciono Habilidad para servicio
	And Selecciono el Tab de Proveedores de servicio
	And Diligencio y selecciono proveedor para servicio
	And Selecciono el Tab de Tareas de servicio
	And Diligencio nombre de nueva tarea para servicio
	And Doy click en Agregar tarea para servicio
	And Selecciono el Tab de Campos adicionales de servicio
	And Diligencio campos adicionales de servicio
	And Selecciono el Tab de Servicio de servicio
	And Doy click en Guardar servicio
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el servicio en la tabla AFLS_SERVICES
	And Se registra el producto de tipo cantidad asociado al servicio en la tabla AFLS_STOCK_SERVICE_PRODUCTS
	And Se registra el producto de tipo único asociado al servicio en la tabla AFLS_STOCK_SERVICE_PRODUCTS
	And Se registra la habilidad asociada al servicio en la tabla AFLS_SERVICES_SKILLS
	And Se registra el proveedor asociado al servicio en la tabla AFLS_PROVIDER_SERVICES
	And Se registra la tarea asociada al servicio en la tabla AFLS_SERVICE_TASKS
	And se registran campos adicionales de servicio diligenciados en la tabla AFW_ADDITIONAL_FIELD_VALUE
	And Cierro Sesión en la aplicación

@regression
 Scenario: 1 Creación exitosa de servicio tipo estándar
 	Given Tengo un usuario con rol administrador
	And No existe el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Servicios
	And Doy Click en nuevo Servicio
	And Diligencio nombre de servicio
	And Selecciono Modelo de servicio
	And Diligencio descripción del servicio
	And Diligencio Asunto del servicio
	And Selecciono Calendario del servicio
	And Selecciono ANS del servicio
	And Selecciono UC del servicio
	And Selecciono OLA del servicio
	And Diligencio Costo base del servicio
	And Selecciono Tipo de servicio Estándar
	And Selecciono check de brindar el servicio a todos los clientes
	And Selecciono check de Habilitar ordenes de emergencia para este servicio
	And Selecciono Tipo de asignación servicio de distribución publica
	And Diligencio Horas de servicio
	And Diligencio Minutos de servicio
	And Selecciono el Tab de Habilidades de servicio
	And Diligencio y selecciono Habilidad para servicio
	And Selecciono el Tab de Servicio de servicio
	And Doy click en Guardar servicio
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el servicio en la tabla AFLS_SERVICES de tipo estándar
	And Cierro Sesión en la aplicación

@regression
 Scenario: 1 Creación exitosa de servicio tipo desplazamiento
 Given Tengo un usuario con rol administrador
	And No existe el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Servicios
	And Doy Click en nuevo Servicio
	And Diligencio nombre de servicio
	And Selecciono Modelo de servicio
	And Diligencio descripción del servicio
	And Diligencio Asunto del servicio
	And Selecciono Calendario del servicio
	And Selecciono ANS del servicio
	And Selecciono UC del servicio
	And Selecciono OLA del servicio
	And Diligencio Costo base del servicio
	And Selecciono Tipo de servicio Desplazamiento
	And Selecciono check de brindar el servicio a todos los clientes
	And Selecciono check de Habilitar ordenes de emergencia para este servicio
	And Selecciono Tipo de asignación servicio de distribución publica
	And Diligencio Horas de servicio
	And Diligencio Minutos de servicio
	And Selecciono el Tab de Habilidades de servicio
	And Diligencio y selecciono Habilidad para servicio
	And Selecciono el Tab de Servicio de servicio
	And Doy click en Guardar servicio
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el servicio en la tabla AFLS_SERVICES de tipo desplazamiento
	And Cierro Sesión en la aplicación

@regression
 Scenario: 1 Creación exitosa de servicios tipo asignación directa
 Given Tengo un usuario con rol administrador
	And No existe el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Servicios
	And Doy Click en nuevo Servicio
	And Diligencio nombre de servicio
	And Selecciono Modelo de servicio
	And Diligencio descripción del servicio
	And Diligencio Asunto del servicio
	And Selecciono Calendario del servicio
	And Selecciono ANS del servicio
	And Selecciono UC del servicio
	And Selecciono OLA del servicio
	And Diligencio Costo base del servicio
	And Selecciono Tipo de servicio Desplazamiento
	And Selecciono check de brindar el servicio a todos los clientes
	And Selecciono check de Habilitar ordenes de emergencia para este servicio
	And Selecciono Tipo de asignación servicio de asignación directa
	And Diligencio Horas de servicio
	And Diligencio Minutos de servicio
	And Selecciono el Tab de Habilidades de servicio
	And Diligencio y selecciono Habilidad para servicio
	And Selecciono el Tab de Servicio de servicio
	And Doy click en Guardar servicio
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el servicio en la tabla AFLS_SERVICES de asignación directa
	And Cierro Sesión en la aplicación

@regression
 Scenario: 1 Creación exitosa de servicios tipo distribución publica
 Given Tengo un usuario con rol administrador
	And No existe el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Servicios
	And Doy Click en nuevo Servicio
	And Diligencio nombre de servicio
	And Selecciono Modelo de servicio
	And Diligencio descripción del servicio
	And Diligencio Asunto del servicio
	And Selecciono Calendario del servicio
	And Selecciono ANS del servicio
	And Selecciono UC del servicio
	And Selecciono OLA del servicio
	And Diligencio Costo base del servicio
	And Selecciono Tipo de servicio Desplazamiento
	And Selecciono check de brindar el servicio a todos los clientes
	And Selecciono check de Habilitar ordenes de emergencia para este servicio
	And Selecciono Tipo de asignación servicio de distribución publica
	And Diligencio Horas de servicio
	And Diligencio Minutos de servicio
	And Selecciono el Tab de Habilidades de servicio
	And Diligencio y selecciono Habilidad para servicio
	And Selecciono el Tab de Servicio de servicio
	And Doy click en Guardar servicio
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el servicio en la tabla AFLS_SERVICES de distribución publica
	And Cierro Sesión en la aplicación

@regression
 Scenario: 2 Búsqueda exitosa de servicios por nombre
  Given Tengo un usuario con rol administrador
	And Existe el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Servicios
	And Busco y selecciono el servicio
	Then Se muestra la tarjeta del servicio y el detalle del mismo
	And Cierro Sesión en la aplicación

@regression
 Scenario: 3 Modificación exitosa de servicios cambiando tipo de servicio y tipo de distribución
	Given Tengo un usuario con rol administrador
	And Existe el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Servicios
	And Busco y selecciono el servicio
	And Selecciono el Tab de Servicio de servicio
	And Edito nombre de servicio
	And Edito tipo de servicio
	And Edito tipo de asignación de servicio
	And Doy click en Guardar servicio
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el servicio modificado en nombre, tipo de servicio y tipo de asignación de servicio en la tabla AFLS_SERVICES
	And Cierro Sesión en la aplicación

@regression
 Scenario: 4 Borrado exitoso de servicios
	Given Tengo un usuario con rol administrador
	And Existe el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Servicios
	And Busco y selecciono el servicio
	And Doy click en eliminar Servicio
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se borra el registro del servicio en la tabla AFLS_SERVICES
	And Al buscar el servicio en la aplicación no se lista
	And Cierro Sesión en la aplicación