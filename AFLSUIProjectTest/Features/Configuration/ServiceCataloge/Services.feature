Feature: Services
#

Scenario: Creación exitosa de Servicio completo
	Given Tengo un usuario con rol Administrador
	And No tengo servicio creado
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Catalogo de Servicios
	And selecciono la opción Servicios
	And Doy Click en nuevo Servicio
	And Diligencio nuevo servicio
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
	And Selecciono Tipo de asignación servicio de distribución publica
	And Selecciono Tipo de asignación servicio de asignación directa
	And Doy click en switch de estado
	And Selecciono check de brindar el servicio a todos los clientes
	And Selecciono check de Habilitar ordenes de emergencia para este servicio
	And Diligencio Horas de servicio
	And Diligencio Minutos de servicio
	And Selecciono el Tab de Servicio de servicio
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
	And Doy click en Guardar servicio
	And Doy click en Cancelar servicio
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And se registra en la tabla AFLS_SERVICES el nuevo servicio
