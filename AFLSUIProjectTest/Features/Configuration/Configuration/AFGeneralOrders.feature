Feature: AF Orders



Scenario: Creación exitosa de campo adicional de orden de tipo simple
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
	When Crear campo adicional de orden de tipo simple
	Then Se muestra un mensaje indicando que se creo que campo adicional correctamente
	And Se registra campo adicional de orden de tipo simple en tabla AFW_ADDiTIONAL_FIELDS


Scenario: Modificación exitosa de campo adicional de orden de tipo simple
Given Tengo un usuario con rol administrador
	And Existe el campo adicional de orden de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales de ordenes
	And Doy click en editar el campo adicional de orden de tipo simple
	And Modifico etiqueta de campo adicional de orden de tipo simple
	And Doy click en opciones avanzadas de campo adicional de oren
	And Modifico nombre de campo adicional de orden de tipo simple
	And Doy click en Guardar campo adicional de orden
	Then Se muestra un mensaje indicando que se creo que campo adicional correctamente
	And Se modifican datos de campo adicional de orden de tipo simple en tabla AFW_ADDiTIONAL_FIELDS

Scenario: Eliminación exitosa de campo adicional de orden de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de orden de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales de ordenes
	And Doy click en eliminar el campo adicional de orden de tipo simple
	And Doy click en Aceptar de mensaje de confirmación de campo adicional de orden
	Then Se muestra un mensaje indicando que se creo que campo adicional correctamente
	And Se elimina el registro de campo adicional de orden de tipo simple en tabla AFW_ADDiTIONAL_FIELDS