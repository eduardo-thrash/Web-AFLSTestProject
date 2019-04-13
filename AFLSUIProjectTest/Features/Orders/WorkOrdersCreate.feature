Feature: WorkOrdersCreate


Scenario: Creación Básica de orden de trabajo
	Given Tengo un usuario con rol despachador
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio campo de solicitante de cita de orden
	And Diligencio Teléfono de Solicitante de orden
	And Diligencio Correo de Solicitante de orden
	And Diligencio Dirección de cita de orden
	And Diligencio Detalle de la dirección de cita de orden
	And Diligencio y selecciono servicio de orden
	And Selecciono Tipo de Orden Emergencia de orden
	And Selecciono Tipo de Orden Prioritaria de orden
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio Descripción de orden
	And Doy click en Tab Dirección de orden
	And Doy click en Tab Asignación de orden
	And Selecciono tab Asignación Automática
	And Selecciono tab Asignación por Restricción
	And Selecciono check Proveedor en restricción
	And Selecciono check Especialista en restricción
	And Selecciono check Fecha Inicial en restricción
	And Selecciono check Jornada en restricción
	And Selecciono tab Asignación Manual
	And Doy click en Buscar especialista para asignación manual
	And selecciono Proveedor en asignación manual
	And Diligencio y selecciono especialista para asignación manual
	And Selecciono Fecha para asignación manual
	And Doy click en Tab Tareas de orden
	And Doy click en Nueva Tarea para orden
	And Diligencio nombre de tarea para orden
	And Diligencio y selecciono especialista para tarea en orden
	And Selecciono Fecha para tarea en orden
	And Doy click en Aplicar Cambios en tarea de orden
	And Doy click en Cancelar Cambios en tarea de orden
	And Doy click en Tab Inventario de orden
	And Diligencio y selecciono producto para orden de tipo cantidad
	And Diligencio y selecciono producto para orden de tipo único	
	And Doy click en Tab Costo de orden
	And Doy click en Tab Comentarios de orden
	And Doy click en Tab Cronómetros de orden
	And Doy click en Tab Alertas de orden
	And Doy click en Tab Campos adicionales de orden
	And Doy click en Tab Firma de orden
	And Doy click en Tab Cliente de orden
	And Doy click en Tab Relaciones de orden
	And Doy click en nueva relación en orden
	And Selecciono relación de tipo sucesión
	And Selecciono relación de tipo vinculo
	And Diligencio y selecciono orden a relacionar
	And Diligencio nuevo comentario de orden y doy click en agregar
	And Doy click en Crear orden
	And Doy click en Guardar orden
	And Doy click en Salir de orden