Feature: AF Orders


@migrationAFLS
Scenario: 1 Creación exitosa de campo adicional de orden de tipo simple
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de orden de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales de ordenes
	And Doy click en Nuevo campo adicional de orden
	And Diligencio etiqueta de campo adicional de orden
	And Selecciono tipo de campo adicional de orden simple
	And Diligencio texto de ayuda de campo adicional de orden
	And Doy click en opciones avanzadas de campo adicional de oren
	And Diligencio nombre de campo adicional de orden
	And Doy click en Aceptar campo adicional de orden
	And Doy click en Guardar campo adicional de orden
	Then Se muestra un mensaje indicando que se creo que campo adicional de orden correctamente
	And Se registra campo adicional de orden de tipo simple en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación

@migrationAFLS
Scenario: 2 Modificación exitosa de campos adicionales de ordenes de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de orden de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales de ordenes
	And Doy click en editar el campo adicional de orden de tipo simple
	And Edito nombre de etiqueta de campo adicional de orden de tipo simple
	And Doy click en Aceptar campo adicional de orden
	And Doy click en Guardar campo adicional de orden
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se registra el campo adicional de orden modificado en la tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación

@migrationAFLS
Scenario: 3 Eliminación exitosa de campos adicionales ordenes de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de orden de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales de ordenes
	And Doy click en eliminar el campo adicional de orden de tipo simple
	And Doy click en Si de mensaje de confirmación de borrado de campo adicional
	And Doy click en Guardar campo adicional de orden
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se borra el registro de el campo adicional de orden en la tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación