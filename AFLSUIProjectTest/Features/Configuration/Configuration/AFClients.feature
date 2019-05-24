Feature: AF Clients

@Automation
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
@Automation
Scenario: 1 Creación exitosa de campos adicionales clientes de tipo párrafo
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente de tipo párrafo
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales clientes
	And Doy click en Nuevo campo adicional de cliente
	And Diligencio etiqueta de campo adicional de cliente
	And Selecciono tipo de campo adicional de cliente párrafo
	And Doy click en opciones avanzadas de campo adicional de cliente
	And Diligencio nombre de campo adicional de cliente
	And Doy click en Aceptar campo adicional de cliente
	And Doy click en Guardar campo adicional de cliente
	Then Se muestra un mensaje indicando que se creo que campo adicional de cliente correctamente
	And Se registra campo adicional de cliente de tipo párrafo en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales clientes de tipo numérico
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente de tipo numérico
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales clientes
	And Doy click en Nuevo campo adicional de cliente
	And Diligencio etiqueta de campo adicional de cliente
	And Selecciono tipo de campo adicional de cliente numérico
	And Doy click en opciones avanzadas de campo adicional de cliente
	And Diligencio nombre de campo adicional de cliente
	And Doy click en Aceptar campo adicional de cliente
	And Doy click en Guardar campo adicional de cliente
	Then Se muestra un mensaje indicando que se creo que campo adicional de cliente correctamente
	And Se registra campo adicional de cliente de tipo numérico en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales clientes de tipo fecha
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente de tipo fecha
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales clientes
	And Doy click en Nuevo campo adicional de cliente
	And Diligencio etiqueta de campo adicional de cliente
	And Selecciono tipo de campo adicional de cliente fecha
	And Doy click en opciones avanzadas de campo adicional de cliente
	And Diligencio nombre de campo adicional de cliente
	And Doy click en Aceptar campo adicional de cliente
	And Doy click en Guardar campo adicional de cliente
	Then Se muestra un mensaje indicando que se creo que campo adicional de cliente correctamente
	And Se registra campo adicional de cliente de tipo fecha en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales clientes de tipo listado
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de cliente de tipo listado
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales clientes
	And Doy click en Nuevo campo adicional de cliente
	And Diligencio etiqueta de campo adicional de cliente
	And Selecciono tipo de campo adicional de cliente listado
	And Diligencio y confirmo las opciones de listado
	And Doy click en opciones avanzadas de campo adicional de cliente
	And Diligencio nombre de campo adicional de cliente
	And Doy click en Aceptar campo adicional de cliente
	And Doy click en Guardar campo adicional de cliente
	Then Se muestra un mensaje indicando que se creo que campo adicional de cliente correctamente
	And Se registra campo adicional de cliente de tipo listado en tabla AFW_ADDiTIONAL_FIELDS
	And Se registran las opciones de campo adicional de cliente de tipo listado en tabla AFW_ADDITIONAL_FIELD_LOOKUP
	And Cierro Sesión en la aplicación
@Automation
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
@Automation
Scenario: 2 Modificación exitosa de campos adicionales de clientes modificando orden
	Given Tengo un usuario con rol administrador
	And Existe mas de un campo adicional de cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales clientes
	And Selecciono el campo adicional y modifico su orden mediante drag and drop
	And Doy click en Guardar campo adicional de cliente
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se registra el campo adicional de cliente modificado en la tabla AFW_ADDiTIONAL_FIELDS con nuevo orden
	And Cierro Sesión en la aplicación
@Automation
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