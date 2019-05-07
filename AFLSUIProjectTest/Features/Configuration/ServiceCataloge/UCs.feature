Feature: UCs

@regression
Scenario: 1 Creación exitosa de UC
	Given Tengo un usuario con rol administrador
	And El UC no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción UC's
	And Doy click en Nuevo UC
	And Diligencio nombre de UC
	And Diligencio descripción de UC
	And Selecciono fecha de inicio de UC
	And Selecciono fecha de finalización de UC
	And Doy click en switch de finalización de alarma de UC
	And Diligencio días de alarma de finalización de UC
	And Selecciono fecha de revisión de UC
	And Doy click en switch de revisión de alarma de UC
	And Diligencio días de alarma de revisión de UC
	And Diligencio costo relacionado al UC
	And Diligencio costo por incumplimiento del UC
	And Selecciono el Tab de Acuerdos de tiempos de UC
	And Diligencio y selecciono el cronometro para UC
	And Diligencio horas minutos y porcentaje de cumplimiento de cronometro asociado a UC
	And Selecciono el Tab de Adjuntos de UC
	And Doy click en Guardar UC
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el UC en la tabla AFLS_SLA
	And Cierro Sesión en la aplicación

@regression
Scenario: 2 Búsqueda exitosa de UC existente
	Given Tengo un usuario con rol administrador
	And El UC existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción UC's
	And Busco y selecciono el UC
	Then Se muestra la tarjeta del UC y el detalle del mismo
	And Cierro Sesión en la aplicación

@regression
Scenario: 3 Modificación exitosa de UC
	Given Tengo un usuario con rol administrador
	And El UC existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción UC's
	And Busco y selecciono el UC
	And Edito nombre de UC
	And Doy click en Guardar UC
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el UC modificado en la tabla AFLS_SLA
	And Cierro Sesión en la aplicación

@regression
Scenario: 4 Borrado exitoso de UC existente
	Given Tengo un usuario con rol administrador
	And El UC existe sin relaciones
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción UC's
	And Busco y selecciono el UC
	And Doy click en eliminar UC
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se marca como eliminada la información del UC en la tabla AFLS_SLA
	And Al buscar el UC en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación

