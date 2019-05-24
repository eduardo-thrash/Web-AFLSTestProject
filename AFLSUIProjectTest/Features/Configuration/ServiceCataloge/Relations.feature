Feature: Relations

@Automation
Scenario: 1 Creación exitosa de relación
	Given Tengo un usuario con rol administrador
	And La relación no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Relaciones
	And Doy click en Nueva relación
	And Diligencio nombre de relación
	And Selecciono tipo de relación Vinculo
	And Diligencio campo origen de relación
	And Diligencio campo destino de relación
	And Doy click en Guardar relación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la relación en la tabla AFLS_RELATIONSHIP de tipo vinculo
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación fallida de relación con nombre repetido de tipo vinculo
	Given Tengo un usuario con rol administrador
	And La relación existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Relaciones
	And Doy click en Nueva relación
	And Diligencio nombre de relación existente
	And Selecciono tipo de relación Vinculo
	And Diligencio campo origen de relación
	And Diligencio campo destino de relación
	And Doy click en Guardar relación
	Then Se muestra mensaje indicando que el elemento ya existe
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Cancelación exitosa de creación de relación
	Given Tengo un usuario con rol administrador
	And La relación no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Relaciones
	And Doy click en Nueva relación
	And Diligencio nombre de relación existente
	And Selecciono tipo de relación Vinculo
	And Diligencio campo origen de relación
	And Diligencio campo destino de relación
	And Doy click en Cancelar relación
	And Doy click en Si de mensaje de confirmación
	Then No se registra la relación en la tabla AFLS_RELATIONSHIP de tipo vinculo
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Consulta exitosa de relación por nombre
	Given Tengo un usuario con rol administrador
	And La relación existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Relaciones
	And Busco y selecciono la relación
	Then Se muestra la tarjeta de la relación y el detalle del mismo
@Automation
Scenario: 3 Modificación exitosa de relaciones editado nombre
	Given Tengo un usuario con rol administrador
	And La relación existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Relaciones
	And Busco y selecciono la relación
	And Edito nombre de relación
	And Edito campo origen de relación
	And Edito campo destino de relación
	And Doy click en Guardar relación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Al buscar la relación con nuevo nombre se muestra exitosamente
	And Se modifica la información de la relación en la tabla AFLS_RELATIONSHIP
@Automation
Scenario: 3 Modificación fallida de relaciones dejando nombre o conectores vacíos
	Given Tengo un usuario con rol administrador
	And La relación existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Relaciones
	And Busco y selecciono la relación
	And Edito nombre de relación dejándolo vacío
	And Edito campo origen de relación
	And Edito campo destino de relación
	And Doy click en Guardar relación
	Then Se muestra mensaje indicando que existen campos inválidos
	And Al buscar la relación con anterior nombre se muestra exitosamente
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Inactivación exitosa de relaciones
    Given Tengo un usuario con rol administrador
	And La relación existe activa
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Relaciones
	And Busco y selecciono la relación
	And Doy click en switch de estado de relación
	And Doy click en Guardar relación
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra la relación en la tabla AFLS_RELATIONSHIP como inactiva
	And Cierro Sesión en la aplicación
@Automation
Scenario: 4 Eliminación exitosa de relaciones
	Given Tengo un usuario con rol administrador
	And La relación existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And selecciono la opción Relaciones
	And Busco y selecciono la relación
	And Doy click en eliminar relación
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se borra la relación de la tabla AFLS_RELATIONSHIP
	And Al buscar la relación en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación