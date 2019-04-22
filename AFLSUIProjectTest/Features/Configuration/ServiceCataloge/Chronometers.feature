Feature: Chronometers
	#Configuración de Cronómetros para uso sobre ANS y Ordenes de trabajo

@regression
Scenario:1 Creación completa de Cronómetros
	Given Tengo un usuario con rol administrador
	And El cronómetro no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Cronómetros
	And Doy click en Nuevo cronometro
	And Diligencio nombre de cronometro
	And Diligencio descripción de cronometro
	And Doy click en Guardar cronometro
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el cronometro en la tabla AFW_ITEM_TIMES
	And Cierro Sesión en la aplicación

@regression
Scenario: 2 consulta exitosa de cronómetro por nombre
	Given Tengo un usuario con rol administrador
	And El cronómetro existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Cronómetros
	And Busco y selecciono el cronómetro
	Then Se muestra la tarjeta del cronómetro y el detalle del mismo
	And Cierro Sesión en la aplicación

@regression
Scenario: 3 Modificación parcial de cronómetros
	Given Tengo un usuario con rol administrador
	And El cronómetro existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Cronómetros
	And Busco y selecciono el cronómetro
	And Modifico nombre de cronometro
	And Doy click en Guardar cronometro
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se modifica la información del cronómetro en la tabla AFW_ITEM_TIMES
	And Cierro Sesión en la aplicación

@regression
Scenario: 4 Borrar cronómetro existente
	Given Tengo un usuario con rol administrador
	And El cronómetro existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Cronómetros
	And Busco y selecciono el cronómetro
	And Doy click en eliminar cronómetro
	And Selecciono Aceptar en mensaje de confirmación
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se marca como eliminada la información del cronómetro en la tabla AFW_ITEM_TIMES
	And Al buscar el cronómetro en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación
