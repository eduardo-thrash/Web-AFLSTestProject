Feature: AF Services

@Automation
Scenario: 1 Creación exitosa de campos adicionales de servicios de tipo simple
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de servicio de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	And Doy click en Nuevo campo adicional de servicio
	And Diligencio etiqueta de campo adicional de servicio
	And Selecciono tipo de campo adicional de servicio simple
	And Diligencio texto de ayuda de campo adicional de servicio
	And Doy click en opciones avanzadas de campo adicional de servicio
	And Diligencio nombre de campo adicional de servicio
	And Doy click en Aceptar campo adicional de servicio
	And Doy click en Guardar campo adicional de servicio
	Then Se muestra un mensaje indicando que se creo que campo adicional de servicio correctamente
	And Se registra campo adicional de servicio de tipo simple en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales de servicios de tipo párrafo
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de servicio de tipo párrafo
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	And Doy click en Nuevo campo adicional de servicio
	And Diligencio etiqueta de campo adicional de servicio
	And Selecciono tipo de campo adicional de servicio párrafo
	And Diligencio texto de ayuda de campo adicional de servicio
	And Doy click en opciones avanzadas de campo adicional de servicio
	And Diligencio nombre de campo adicional de servicio
	And Doy click en Aceptar campo adicional de servicio
	And Doy click en Guardar campo adicional de servicio
	Then Se muestra un mensaje indicando que se creo que campo adicional de servicio correctamente
	And Se registra campo adicional de servicio de tipo párrafo en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales de servicios de tipo numérico
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de servicio de tipo numérico
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	And Doy click en Nuevo campo adicional de servicio
	And Diligencio etiqueta de campo adicional de servicio
	And Selecciono tipo de campo adicional de servicio numérico
	And Diligencio texto de ayuda de campo adicional de servicio
	And Doy click en opciones avanzadas de campo adicional de servicio
	And Diligencio nombre de campo adicional de servicio
	And Doy click en Aceptar campo adicional de servicio
	And Doy click en Guardar campo adicional de servicio
	Then Se muestra un mensaje indicando que se creo que campo adicional de servicio correctamente
	And Se registra campo adicional de servicio de tipo numérico en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales de servicios de tipo fecha
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de servicio de tipo fecha
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	And Doy click en Nuevo campo adicional de servicio
	And Diligencio etiqueta de campo adicional de servicio
	And Selecciono tipo de campo adicional de servicio fecha
	And Diligencio texto de ayuda de campo adicional de servicio
	And Doy click en opciones avanzadas de campo adicional de servicio
	And Diligencio nombre de campo adicional de servicio
	And Doy click en Aceptar campo adicional de servicio
	And Doy click en Guardar campo adicional de servicio
	Then Se muestra un mensaje indicando que se creo que campo adicional de servicio correctamente
	And Se registra campo adicional de servicio de tipo fecha en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales de servicios de tipo listado
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de servicio de tipo listado
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	And Doy click en Nuevo campo adicional de servicio
	And Diligencio etiqueta de campo adicional de servicio
	And Selecciono tipo de campo adicional de servicio listado
	And Diligencio texto de ayuda de campo adicional de servicio
	And Diligencio y confirmo las opciones de listado de servicio
	And Doy click en opciones avanzadas de campo adicional de servicio
	And Diligencio nombre de campo adicional de servicio
	And Doy click en Aceptar campo adicional de servicio
	And Doy click en Guardar campo adicional de servicio
	Then Se muestra un mensaje indicando que se creo que campo adicional de servicio correctamente
	And Se registra campo adicional de servicio de tipo listado en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Modificación exitosa de campos adicionales de servicios de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de servicio de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	And Doy click en editar el campo adicional de servicio de tipo simple
	And Edito nombre de etiqueta de campo adicional de servicio de tipo simple
	And Doy click en Aceptar campo adicional de servicio
	And Doy click en Guardar campo adicional de servicio
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se registra el campo adicional de servicio modificado en la tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Modificación exitosa de campos adicionales de servicios modificando orden
	Given Tengo un usuario con rol administrador
	And Existe mas de un campo adicional de cliente
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	And Selecciono el campo adicional de servicio y modifico su orden mediante drag and drop
	And Doy click en Guardar campo adicional de servicio
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se registra el campo adicional de servicio modificado en la tabla AFW_ADDiTIONAL_FIELDS con nuevo orden
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Eliminación exitosa de campos adicionales servicios de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de servicio de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales servicios
	And Doy click en eliminar el campo adicional de servicio de tipo simple
	And Doy click en Si de mensaje de confirmación de borrado de campo adicional
	And Doy click en Guardar campo adicional de servicio
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se borra el registro de el campo adicional de servicio en la tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación