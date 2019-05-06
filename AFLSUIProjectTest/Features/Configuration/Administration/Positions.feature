Feature: Positions


Scenario: Creación exitosa de Cargos

	Given Tengo un usuario con rol administrador
	And El cargo no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Cargos
	And Doy click en Nuevo cargo
	And Diligencio nombre de cargo
	And Diligencio costo por hora
	And Doy click en switch de cargo
	And Doy click en Guardar cargo
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el cargo en la tabla AFLS_WORK_POSITIONS


Scenario: Búsqueda exitosa de cargo existente
	Given Tengo un usuario con rol administrador
	And El cargo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Cargos
	And Busco y selecciono el cargo	
	Then Se muestra la tarjeta del cargo y el detalle del mismo

Scenario: Modificación exitosa de cargos
	Given Tengo un usuario con rol administrador
	And El cargo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Cargos
	And Busco y selecciono el cargo	
	And Edito nombre de cargo
	And Doy click en Guardar cargo
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el cargo modificado en la tabla AFLS_WORK_POSITIONS

Scenario: Borrado exitoso de cargo existente
	Given Tengo un usuario con rol administrador
	And El cargo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Cargos
	And Busco y selecciono el cargo	
	And Doy click en eliminar cargo
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And No se registra el cargo en la tabla AFLS_WORK_POSITIONS
	And Al buscar el cargo en la aplicación no se lista