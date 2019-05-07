Feature: AF Clients

@migrationAFLS
Scenario: 1 Creación exitosa de campos adicionales clientes de tipo simple
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales clientes
	And Doy click en Nuevo campo adicional de cliente
	And Diligencio etiqueta de campo adicional de cliente
	And Selecciono tipo de campo adicional de cliente simple
	And Diligencio texto de ayuda de campo adicional de cliente
	And Doy click en opciones avanzadas de campo adicional de cliente
	And Diligencio nombre de campo adicional de cliente
	And Doy click en Aceptar campo adicional de cliente
	And Doy click en Guardar campo adicional de cliente
	Then Se muestra un mensaje indicando que se creo que campo adicional de cliente correctamente
	And Se registra campo adicional de cliente de tipo simple en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación

@migrationAFLS
Scenario: 2 Modificación exitosa de campos adicionales de clientes de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de cliente de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales clientes
	And Doy click en editar el campo adicional de cliente de tipo simple
	And Edito nombre de etiqueta de campo adicional de cliente de tipo simple
	And Doy click en Aceptar campo adicional de cliente
	And Doy click en Guardar campo adicional de cliente
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se registra el campo adicional de cliente modificado en la tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación

@migrationAFLS
Scenario: 3 Eliminación exitosa de campos adicionales clientes de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de cliente de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales clientes
	And Doy click en eliminar el campo adicional de cliente de tipo simple
	And Doy click en Si de mensaje de confirmación de borrado de campo adicional
	And Doy click en Guardar campo adicional de cliente
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se borra el registro de el campo adicional de cliente en la tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación