Feature: OLAs

@regression
Scenario: 1 Creación exitosa de OLA
	Given Tengo un usuario con rol administrador
	And El OLA no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción OLA's
	And Doy click en Nuevo OLA
	And Diligencio nombre de OLA
	And Diligencio descripción de OLA
	And Selecciono fecha de inicio de OLA
	And Selecciono fecha de finalización de OLA
	And Doy click en switch de finalización de alarma de OLA
	And Diligencio días de alarma de finalización de OLA
	And Selecciono fecha de revisión de OLA
	And Doy click en switch de revisión de alarma de OLA
	And Diligencio días de alarma de revisión de OLA
	And Diligencio costo relacionado al OLA
	And Diligencio costo por incumplimiento del OLA
	And Selecciono el Tab de Acuerdos de tiempos de OLA
	And Diligencio y selecciono el cronometro para OLA
	And Diligencio horas minutos y porcentaje de cumplimiento de cronometro asociado a OLA
	And Selecciono el Tab de Adjuntos de OLA
	And Doy click en Guardar OLA
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el OLA en la tabla AFLS_SLA
	And Cierro Sesión en la aplicación

@regression
Scenario: 2 Búsqueda exitosa de OLA existente
	Given Tengo un usuario con rol administrador
	And El OLA existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción OLA's
	And Busco y selecciono el OLA
	Then Se muestra la tarjeta del OLA y el detalle del mismo
	And Cierro Sesión en la aplicación

@regression
Scenario: 3 Modificación exitosa de OLA
	Given Tengo un usuario con rol administrador
	And El OLA existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción OLA's
	And Busco y selecciono el OLA
	And Edito nombre de OLA
	And Doy click en Guardar OLA
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el OLA modificado en la tabla AFLS_SLA
	And Cierro Sesión en la aplicación

@regression
Scenario: 4 Borrado exitoso de OLA existente
	Given Tengo un usuario con rol administrador
	And El OLA existe sin relaciones
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción OLA's
	And Busco y selecciono el OLA
	And Doy click en eliminar OLA
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se marca como eliminada la información del OLA en la tabla AFLS_SLA
	And Al buscar el OLA en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación

