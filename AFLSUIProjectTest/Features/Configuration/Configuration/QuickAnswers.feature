Feature: Quick Answers


Scenario: Creación exitosa de respuesta rápida
	Given Tengo un usuario con rol administrador
	And La respuesta rápida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	And Doy click en Nueva respuesta rápida
	And Diligencio nombre de respuesta rápida
	And Diligencio y selecciono servicio para respuesta rápida
	And Selecciono tipo de respuesta rápida de Descripción
	And Selecciono tipo de respuesta rápida de Nota
	And Diligencio descripción de respuesta rápida
	And Doy click en switch de estado de respuesta rápida
	And Doy click en Guardar respuesta rápida
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra respuesta rápida en la tabla AFLS_QUICK_ANSWERS

Scenario: 1 Creación fallida de respuestas rápidas con nombre repetido
	Given Tengo un usuario con rol administrador
	And La respuesta rápida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	And Doy click en Nueva respuesta rápida
	And Diligencio nombre de respuesta rápida existente
	And Diligencio y selecciono servicio para respuesta rápida
	And Selecciono tipo de respuesta rápida de Descripción
	And Diligencio descripción de respuesta rápida
	And Doy click en Guardar respuesta rápida
	Then Se muestra mensaje indicando que el elemento ya existe
	And Se registra una sola respuesta rápida con el nombre en la tabla AFLS_QUICK_ANSWERS

Scenario: 1 Cancelación exitosa de creación de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rápida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	And Doy click en Nueva respuesta rápida
	And Diligencio nombre de respuesta rápida
	And Diligencio y selecciono servicio para respuesta rápida
	And Selecciono tipo de respuesta rápida de Nota
	And Diligencio descripción de respuesta rápida
	And Doy click en Cancelar respuesta rápida
	Then No se registra respuesta rápida en la tabla AFLS_QUICK_ANSWERS

Scenario: 3 Modificación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rápida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	And Busco y selecciono la respuesta rápida
	And Edito nombre de respuesta rápida
	And Doy click en Guardar respuesta rápida
	Then Se muestra mensaje indicando que el elemento ya existe
	And Se registra nombre de respuesta rápida modificada en la tabla AFLS_QUICK_ANSWERS

Scenario: 3 Modificación fallida de respuestas rápidas dejando nombre o descripción vacíos
	Given Tengo un usuario con rol administrador
	And La respuesta rápida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	And Busco y selecciono la respuesta rápida
	And Edito nombre de respuesta rápida dejándolo vacío
	And Edito descripción de respuesta rápida dejándolo vacío
	And Doy click en Guardar respuesta rápida
	Then Se muestra mensaje indicando que existen campos inválidos
	And Se registra nombre de respuesta rápida sin modificar en la tabla AFLS_QUICK_ANSWERS

Scenario: 4 Inactivación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rápida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	And Busco y selecciono la respuesta rápida
	And Doy click en switch de estado de respuesta rápida
	And Doy click en Guardar respuesta rápida
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra respuesta rápida inactiva en la tabla AFLS_QUICK_ANSWERS

Scenario: 5 Eliminación exitosa de respuestas rápidas
	Given Tengo un usuario con rol administrador
	And La respuesta rápida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Respuestas rápidas
	And Busco y selecciono la respuesta rápida
	And Doy click en eliminar respuesta rápida
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And No se registra respuesta rápida en la tabla AFLS_QUICK_ANSWERS
	And Al buscar respuesta rápida en la aplicación, no se lista en la búsqueda