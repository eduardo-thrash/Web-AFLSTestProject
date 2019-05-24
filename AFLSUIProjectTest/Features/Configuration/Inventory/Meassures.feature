Feature: Meassures


@Automation
Scenario: 1 Creación exitosa de Medidas
	Given Tengo un usuario con rol administrador
	And La medida no existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Medidas
	And Doy click en Nueva medida
	And Diligencio nombre de medida
	And Diligencio descripción de medida
	And Doy click en Guardar medida
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra medida en la tabla AFLS_STOCK_MEASURES
	And Cierro Sesión en la aplicación
@Automation
Scenario: 2 Búsqueda exitosa de Medida existente
	Given Tengo un usuario con rol administrador
	And La medida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Medidas
	And Busco y selecciono la medida
	Then Se muestra la tarjeta de la medida y el detalle del mismo
	And Cierro Sesión en la aplicación
@Automation
Scenario: 3 Modificación exitosa de Medidas
	Given Tengo un usuario con rol administrador
	And La medida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Medidas
	And Busco y selecciono la medida
	And Edito nombre de medida
	And Doy click en Guardar medida
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el nombre de medida modificado en la tabla AFLS_STOCK_MEASURES
	And Cierro Sesión en la aplicación
@Automation
Scenario: 4 Borrado exitoso de Medida existente
	Given Tengo un usuario con rol administrador
	And La medida existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Medidas
	And Busco y selecciono la medida
	And Doy click en eliminar medida
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And No se registra la medida en la tabla AFLS_STOCK_MEASURES
	And Al buscar la medida en la aplicación, no se lista en la búsqueda
	And Cierro Sesión en la aplicación

