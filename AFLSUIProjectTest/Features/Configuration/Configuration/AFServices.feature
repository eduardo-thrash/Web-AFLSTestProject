Feature: Additional Field Services


Scenario: Creación exitosa de campo adicional de servicio de tipo simple
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de servicio de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales de servicios
	And Doy click en Nuevo campo adicional de servicio
	And Diligencio etiqueta de campo adicional de servicio
	And Selecciono tipo de campo adicional de servicio simple
	And Diligencio texto de ayuda de campo adicional de servicio
	And Doy click en opciones avanzadas de campo adicional de oren
	And Diligencio nombre de campo adicional de servicio
	And Doy click en Aceptar campo adicional de servicio
	And Doy click en Guardar campo adicional de servicio
	When Crear campo adicional de servicio de tipo simple
	Then Se muestra un mensaje indicando que se creo que campo adicional correctamente
	And Se registra campo adicional de servicio de tipo simple en tabla AFW_ADDiTIONAL_FIELDS


Scenario: Modificación exitosa de campo adicional de servicio de tipo simple
Given Tengo un usuario con rol administrador
	And Existe el campo adicional de servicio de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales de servicios
	And Doy click en editar el campo adicional de servicio de tipo simple
	And Modifico etiqueta de campo adicional de servicio de tipo simple
	And Doy click en opciones avanzadas de campo adicional de oren
	And Modifico nombre de campo adicional de servicio de tipo simple
	And Doy click en Guardar campo adicional de servicio
	Then Se muestra un mensaje indicando que se creo que campo adicional correctamente
	And Se modifican datos de campo adicional de servicio de tipo simple en tabla AFW_ADDiTIONAL_FIELDS

Scenario: Eliminación exitosa de campo adicional de servicio de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de servicio de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales de servicios
	And Doy click en eliminar el campo adicional de servicio de tipo simple
	And Doy click en Aceptar de mensaje de confirmación de campo adicional de servicio
	Then Se muestra un mensaje indicando que se creo que campo adicional correctamente
	And Se elimina el registro de campo adicional de servicio de tipo simple en tabla AFW_ADDiTIONAL_FIELDS
