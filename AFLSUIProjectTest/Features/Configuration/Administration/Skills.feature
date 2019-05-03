Feature: Skills
	#Configuración de habilidades para asociación en servicios, usuarios moviles, grupos moviles
	#And validación de ellos al asignar ordenes de trabajo

@regression
Scenario: 1 Creación exitosa de habilidad
	Given Tengo un usuario con rol administrador
	And No existe la habilidad
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Habilidades
	And Doy click en Nueva habilidad
	And Diligencio nombre de habilidad
	And Diligencio descripción de habilidad
	And Doy click en Guardar habilidad
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la habilidad en la tabla AFLS_SKILLS
	And Cierro Sesión en la aplicación

@regression
Scenario: 1 Creación fallida de habilidad con nombre repetido
	Given Tengo un usuario con rol administrador
	And Existe la habilidad
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Habilidades
	And Doy click en Nueva habilidad
	And Diligencio nombre de habilidad existente
	Then Se muestra una ventana emergente indicando que la habilidad ya existe
	And Cierro Sesión en la aplicación

@regression
Scenario: 1 Cancelación exitosa de creación de habilidad
	Given Tengo un usuario con rol administrador
	And No existe la habilidad
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Habilidades
	And Doy click en Nueva habilidad
	And Diligencio nombre de habilidad
	And Diligencio descripción de habilidad
	And Doy click en Cancelar habilidad
	And Selecciono Aceptar en mensaje de confirmación de cancelación de creación
	Then Se retorna a la pantalla de habilidades
	And No Se registra la habilidad en la tabla AFLS_SKILLS
	And Cierro Sesión en la aplicación

@regression
Scenario: 2 Consulta exitosa de habilidad por nombre
	Given Tengo un usuario con rol administrador
	And Existe la habilidad
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Habilidades
	And Busco y selecciono la habilidad
	Then Se muestra la tarjeta de la habilidad y el detalle del mismo
	And Cierro Sesión en la aplicación

@regression
Scenario: 3 Modificación exitosa de habilidades
	Given Tengo un usuario con rol administrador
	And Existe la habilidad
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Habilidades
	And Busco y selecciono la habilidad
	And Edito nombre de habilidad
	And Doy click en Guardar habilidad
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la habilidad modificada en la tabla AFLS_SKILLS
	And Cierro Sesión en la aplicación

@regression
Scenario: 3 Modificación fallida de habilidades dejando nombre o descripción vacíos
	Given Tengo un usuario con rol administrador
	And Existe la habilidad
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Habilidades
	And Busco y selecciono la habilidad
	And Edito nombre de habilidad dejándolo vacío
	And Edito descripción de habilidad dejándolo vacío
	And Doy click en Guardar habilidad
	Then Se muestra mensaje indicando que existen campos inválidos
	And Se registra la habilidad sin modificar en la tabla AFLS_SKILLS
	And Cierro Sesión en la aplicación

@regression
Scenario: 3 Inactivación exitosa de habilidades
	Given Tengo un usuario con rol administrador
	And Existe la habilidad activa
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Habilidades
	And Busco y selecciono la habilidad
	And Doy click en switch de estado de habilidad
	And Doy click en Guardar habilidad
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la habilidad modificada a inactiva en la tabla AFLS_SKILLS
	And Al buscar la habilidad se lista como inactiva

@regression
Scenario: 4 Eliminación exitosa de habilidades
	Given Tengo un usuario con rol administrador
	And Existe la habilidad
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Habilidades
	And Busco y selecciono la habilidad
	And Doy click en eliminar habilidad
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se borra la habilidad de la tabla AFLS_SKILLS
	And Al buscar la habilidad no se lista
	And Cierro Sesión en la aplicación