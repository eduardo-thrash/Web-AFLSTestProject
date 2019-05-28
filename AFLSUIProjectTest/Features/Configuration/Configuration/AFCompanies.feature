Feature: AF Companies

@Automation
Scenario: 1 Creación exitosa de campos adicionales compañías de tipo simple
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de compañía de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	And Doy click en Nuevo campo adicional de compañía
	And Diligencio etiqueta de campo adicional de compañía
	And Selecciono tipo de campo adicional de compañía simple
	And Diligencio texto de ayuda de campo adicional de compañía
	And Doy click en opciones avanzadas de campo adicional de compañía
	And Diligencio nombre de campo adicional de compañía
	And Doy click en Aceptar campo adicional de compañía
	And Doy click en Guardar campo adicional de compañía
	Then Se muestra un mensaje indicando que se creo que campo adicional de compañía correctamente
	And Se registra campo adicional de compañía de tipo simple en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales compañías de tipo párrafo
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de compañía de tipo párrafo
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	And Doy click en Nuevo campo adicional de compañía
	And Diligencio etiqueta de campo adicional de compañía
	And Selecciono tipo de campo adicional de compañía párrafo
	And Diligencio texto de ayuda de campo adicional de compañía
	And Doy click en opciones avanzadas de campo adicional de compañía
	And Diligencio nombre de campo adicional de compañía
	And Doy click en Aceptar campo adicional de compañía
	And Doy click en Guardar campo adicional de compañía
	Then Se muestra un mensaje indicando que se creo que campo adicional de compañía correctamente
	And Se registra campo adicional de compañía de tipo párrafo en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales compañías de tipo numérico
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de compañía de tipo numérico
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	And Doy click en Nuevo campo adicional de compañía
	And Diligencio etiqueta de campo adicional de compañía
	And Selecciono tipo de campo adicional de compañía numérico
	And Diligencio texto de ayuda de campo adicional de compañía
	And Doy click en opciones avanzadas de campo adicional de compañía
	And Diligencio nombre de campo adicional de compañía
	And Doy click en Aceptar campo adicional de compañía
	And Doy click en Guardar campo adicional de compañía
	Then Se muestra un mensaje indicando que se creo que campo adicional de compañía correctamente
	And Se registra campo adicional de compañía de tipo numérico en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales compañías de tipo fecha
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de compañía de tipo fecha
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	And Doy click en Nuevo campo adicional de compañía
	And Diligencio etiqueta de campo adicional de compañía
	And Selecciono tipo de campo adicional de compañía fecha
	And Diligencio texto de ayuda de campo adicional de compañía
	And Doy click en opciones avanzadas de campo adicional de compañía
	And Diligencio nombre de campo adicional de compañía
	And Doy click en Aceptar campo adicional de compañía
	And Doy click en Guardar campo adicional de compañía
	Then Se muestra un mensaje indicando que se creo que campo adicional de compañía correctamente
	And Se registra campo adicional de compañía de tipo fecha en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 1 Creación exitosa de campos adicionales compañías de tipo listado
	Given Tengo un usuario con rol administrador
	And No existe el campo adicional de compañía de tipo listado
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	And Doy click en Nuevo campo adicional de compañía
	And Diligencio etiqueta de campo adicional de compañía
	And Selecciono tipo de campo adicional de compañía listado
	And Diligencio texto de ayuda de campo adicional de compañía
	And Diligencio y confirmo las opciones de listado de compañía
	And Doy click en opciones avanzadas de campo adicional de compañía
	And Diligencio nombre de campo adicional de compañía
	And Doy click en Aceptar campo adicional de compañía
	And Doy click en Guardar campo adicional de compañía
	Then Se muestra un mensaje indicando que se creo que campo adicional de compañía correctamente
	And Se registra campo adicional de compañía de tipo listado en tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Modificación exitosa de campos adicionales de compañías de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de compañía de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	And Doy click en editar el campo adicional de compañía de tipo simple
	And Edito nombre de etiqueta de campo adicional de compañía de tipo simple
	And Doy click en Aceptar campo adicional de compañía
	And Doy click en Guardar campo adicional de compañía
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se registra el campo adicional de compañía modificado en la tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Modificación exitosa de campos adicionales de compañias modificando orden
	Given Tengo un usuario con rol administrador
	And Existe mas de un campo adicional de compañía
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	And Selecciono el campo adicional de compañía y modifico su orden mediante drag and drop
	And Doy click en Guardar campo adicional de compañía
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se registra el campo adicional de compañía modificado en la tabla AFW_ADDiTIONAL_FIELDS con nuevo orden
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Eliminación exitosa de campos adicionales compañías de tipo simple
	Given Tengo un usuario con rol administrador
	And Existe el campo adicional de compañía de tipo simple
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Campos adicionales compañías
	And Doy click en eliminar el campo adicional de compañía de tipo simple
	And Doy click en Si de mensaje de confirmación de borrado de campo adicional
	And Doy click en Guardar campo adicional de compañía
	Then Se muestra un mensaje indicando que se guardo que campo adicional correctamente
	And Se borra el registro de el campo adicional de compañía en la tabla AFW_ADDiTIONAL_FIELDS
	And Cierro Sesión en la aplicación