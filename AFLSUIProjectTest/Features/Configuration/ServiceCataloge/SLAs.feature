Feature: ANSs

@regression
Scenario: 1 Creación exitosa de ANS
	Given Tengo un usuario con rol administrador
	And El ANS no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción ANS's
	And Doy click en Nuevo ANS
	And Diligencio nombre de ANS
	And Diligencio descripción de ANS
	And Selecciono fecha de inicio de ANS
	And Selecciono fecha de finalización de ANS
	And Doy click en switch de finalización de alarma de ANS
	And Diligencio días de alarma de finalización de ANS
	And Selecciono fecha de revisión de ANS
	And Doy click en switch de revisión de alarma de ANS
	And Diligencio días de alarma de revisión de ANS
	And Diligencio costo relacionado al ANS
	And Diligencio costo por incumplimiento del ANS
	And Selecciono el Tab de Acuerdos de tiempos de ANS
	And Diligencio y selecciono el cronometro para ANS
	And Diligencio horas minutos y porcentaje de cumplimiento de cronometro asociado a ANS
	And Selecciono el Tab de Adjuntos de ANS
	And Doy click en Guardar ANS
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el ANS en la tabla AFLS_SLA
	And Cierro Sesión en la aplicación

@regression
Scenario: 2 Búsqueda exitosa de ANS existente
	Given Tengo un usuario con rol administrador
	And El ANS existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción ANS's
	And Busco y selecciono el ANS
	Then Se muestra la tarjeta del ANS y el detalle del mismo
	And Cierro Sesión en la aplicación

@regression
Scenario: 3 Modificación exitosa de ANS
	Given Tengo un usuario con rol administrador
	And El ANS existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción ANS's
	And Busco y selecciono el ANS
	And Edito nombre de ANS
	And Doy click en Guardar ANS
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el ANS modificado en la tabla AFLS_SLA
	And Cierro Sesión en la aplicación

@regression
Scenario: 4 Borrado exitoso de ANS existente
	Given Tengo un usuario con rol administrador
	And El ANS existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción ANS's
	And Busco y selecciono el ANS
	And Doy click en eliminar ANS
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se marca como eliminada la información del ANS en la tabla AFLS_SLA
	And Al buscar el ANS en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación