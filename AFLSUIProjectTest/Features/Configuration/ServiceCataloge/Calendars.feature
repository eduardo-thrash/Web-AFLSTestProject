Feature: Calendars
	
@regression
Scenario: 1 Creación exitosa de Calendarios
	Given Tengo un usuario con rol administrador
	And El calendario no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Calendarios
	And Doy click en Nuevo calendario
	And Diligencio nombre de calendario
	And Diligencio descripción de OLA de calendario
	And Selecciono el Tab de Horas laborales de calendario
	And Selecciono disponibilidad de siete días en calendario
	And Selecciono el Tab de Días no laborales
	And Selecciono día no laboral
	And Doy click en Guardar calendario
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	Then Se registra el calendario en la tabla AFLS_CALENDAR
	And Cierro Sesión en la aplicación

@regression
Scenario: 2 Búsqueda de calendario existente
	Given Tengo un usuario con rol administrador
	And El calendario existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Calendarios
	And Busco y selecciono el calendario
	Then Se muestra la tarjeta del calendario y el detalle del mismo
	And Cierro Sesión en la aplicación

@regression
Scenario: 3 modificación parcial de calendario
	Given Tengo un usuario con rol administrador
	And El calendario existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Calendarios
	And Busco y selecciono el calendario
	And Edito nombre de calendario
	And Doy click en Guardar calendario
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el calendario modificado en la tabla AFLS_CALENDAR
	And Cierro Sesión en la aplicación

@regression
Scenario: 4 Borrar calendario existente
	Given Tengo un usuario con rol administrador
	And El calendario existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción Calendarios
	And Busco y selecciono el calendario
	And Doy click en eliminar calendario
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And No se registra el calendario en la tabla AFLS_CALENDAR
	And Al buscar el calendario en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación