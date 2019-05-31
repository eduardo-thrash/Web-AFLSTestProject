Feature: WorkOrdersBasic
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#Scenario: Creación Básica de orden de trabajo
	#Given Tengo un usuario con rol despachador
	#And Existe un cliente sin email, teléfono y compañía asociada
	#When Accedo a la aplicación
	#And Realizo Login con usuario rol despachador
	#And Accedo a ítem Nueva orden
	#And Diligencio y selecciono un cliente de orden
	##And Diligencio campo de solicitante de cita de orden
	##And Diligencio Teléfono de Solicitante de orden
	##And Diligencio Correo de Solicitante de orden
	#And Diligencio Dirección de cita de orden
	#And Diligencio Detalle de la dirección de cita de orden
	#And Diligencio y selecciono servicio de orden
	#And Selecciono Tipo de Orden Emergencia de orden
	#And Selecciono Tipo de Orden Prioritaria de orden
	#And Selecciono Tipo de Orden Normal de orden
	#And Diligencio Asunto de orden
	#And Diligencio descripción de OLA de orden
	#And Doy click en Tab Dirección de orden
	#And Doy click en Tab Asignación de orden
	#And Selecciono tab Asignación Automática
	#And Selecciono tab Asignación por Restricción
	#And Selecciono check Proveedor en restricción
	#And Selecciono check Especialista en restricción
	#And Selecciono check Fecha Inicial en restricción
	#And Selecciono check Jornada en restricción
	#And Selecciono tab Asignación Manual
	#And Doy click en Buscar especialista para asignación manual
	#And selecciono Proveedor en asignación manual
	#And Diligencio y selecciono especialista para asignación manual
	#And Selecciono Fecha para asignación manual
	#And Doy click en Tab Tareas de orden
	#And Doy click en Nueva Tarea para orden
	#And Diligencio nombre de tarea para orden
	#And Diligencio y selecciono especialista para tarea en orden
	#And Selecciono Fecha para tarea en orden
	#And Doy click en Aplicar Cambios en tarea de orden
	#And Doy click en Cancelar Cambios en tarea de orden
	#And Doy click en Tab Inventario de orden
	#And Diligencio y selecciono producto para orden de tipo cantidad
	#And Diligencio y selecciono producto para orden de tipo único	
	#And Doy click en Tab Costo de orden
	#And Doy click en Tab Comentarios de orden
	#And Doy click en Tab Cronómetros de orden
	#And Doy click en Tab Alertas de orden
	#And Doy click en Tab Campos adicionales de orden
	#And Doy click en Tab Firma de orden
	#And Doy click en Tab Cliente de orden
	#And Doy click en Tab Relaciones de orden
	#And Doy click en nueva relación en orden
	#And Selecciono relación de tipo sucesión
	#And Selecciono relación de tipo vinculo
	#And Diligencio y selecciono orden a relacionar
	#And Diligencio nuevo comentario de orden y doy click en agregar
	#And Doy click en Crear orden
	#And Doy click en Guardar orden
	#And Doy click en Salir de orden

@Automation
Scenario: Creación exitosa de orden de trabajo con todos los datos de cliente y solicitante de cita
	Given Tengo un usuario con rol despachador
	And Existe un cliente
	And Existen servicios asociados al cliente
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
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección

@Automation
Scenario: Creación exitosa de orden de trabajo con datos básicos de cliente
	Given Tengo un usuario con rol despachador
	And Existe un cliente sin email, teléfono y compañía asociada
	And Existen servicios asociados al cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Nueva orden
	And Diligencio y selecciono un cliente de orden
	And Diligencio Dirección de cita de orden
	And Diligencio y selecciono servicio de orden
	And Selecciono Tipo de Orden Normal de orden
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección


Scenario: Creación exitosa de orden de trabajo de emergencia con asignación automática
	Given Tengo un usuario con rol despachador
	And Existe un cliente
	And Existen servicios asociados al cliente
	And Existe relación del proveedor de especialista con zona
	And Existe especialista con disponibilidad, habilidad del servicio activa, licencia activa y estado activo
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
	And Diligencio Asunto de orden
	And Diligencio descripción de orden
	And Doy click en Tab Asignación de orden
	And Selecciono tab Asignación Manual
	And Doy click en Buscar especialista para asignación manual
	And Selecciono el Tab de campos adicionales de orden de trabajo
	And Diligencio campos adicionales de orden de trabajo
	And Doy click en Crear orden
	Then se muestra mensaje indicando que se creo la orden de trabajo correctamente
	And Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección
	And Se registra en la tabla AFLS_WORKORDERS la orden con prioridad de emergencia y especialista asignado

#Scenario: Creación exitosa de orden de trabajo de prioridad con asignación automática
#
#Scenario: Creación exitosa de orden de trabajo a cliente que tiene compañía asociada
#
#Scenario: Creación exitosa de orden de trabajo a cliente que no tiene compañía asociada
#
#Scenario: Creación exitosa de orden de trabajo con servicio tipo estándar
#
#Scenario: Creación exitosa de orden de trabajo con servicio tipo desplazamiento
#
#Scenario: Creación exitosa de orden de trabajo con servicio tipo asignación directa
#
#Scenario: Creación exitosa de orden de trabajo con servicio tipo distribución publica
#
#Scenario: Creación exitosa de orden de trabajo con asignación manual a especialista
#
#Scenario: Creación exitosa de orden de trabajo de tipo emergencia con asignación manual a especialista
#
#Scenario: Creación exitosa de orden de trabajo de tipo prioridad con asignación manual a especialista
#
#Scenario: Creación exitosa de orden de trabajo con asignación por restricción de proveedor
#
#Scenario: Creación exitosa de orden de trabajo con asignación por restricción de especialista
#
#Scenario: Creación exitosa de orden de trabajo con asignación por restricción de fecha
