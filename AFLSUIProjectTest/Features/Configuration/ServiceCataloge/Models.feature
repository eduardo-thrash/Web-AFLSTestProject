Feature: Models

@regression
Scenario: 1 Creación exitosa de modelos
	Given Tengo un usuario con rol administrador
	And El modelo no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Modelos
	And Doy click en Nuevo modelo
	And Diligencio nombre de modelo
	And Diligencio descripción de modelo
	And Selecciono encuesta para modelo
	And Doy click en Guardar modelo
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el modelo en la tabla AFW_ITEM_MODEL
	And Cierro Sesión en la aplicación

@regression
Scenario: 2 Búsqueda exitosa de un modelo existente
	Given Tengo un usuario con rol administrador
	And El modelo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Modelos
	And Busco y selecciono el modelo	
	Then Se muestra la tarjeta de modelo y se carga formulario de información básica
	And Cierro Sesión en la aplicación

@regression
Scenario: 3 Modificación exitosa de un modelo
	Given Tengo un usuario con rol administrador
	And El modelo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Modelos
	And Busco y selecciono el modelo
	And Edito nombre de modelo
	And Doy click en Guardar modelo
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se modifica la información del modelo en la tabla AFW_ITEM_MODEL
	And Cierro Sesión en la aplicación

@regression
Scenario: 4 Borrado exitoso de modelo existente
	Given Tengo un usuario con rol administrador
	And El modelo existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Modelos
	And Busco y selecciono el modelo
	And Doy click en eliminar modelo
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se marca como eliminada la información del modelo en la tabla AFW_ITEM_MODEL
	And Al buscar el modelo en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación
