Feature: Products
	

Scenario: 1 Creación exitosa de producto tipo cantidad
	Given Tengo un usuario con rol administrador
	And El producto tipo cantidad con SKU no existe
	And Existe una medida	
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Productos
	And Doy click en Nuevo producto
	And Selecciono tipo producto cantidad
	And Diligencio SKU único
	And Diligencio nombre de producto
	And Diligencio descripción de producto
	And Diligencio cantidad mínima de producto
	And Selecciono una medida
	And Diligencio precio de venta
	#And Doy click en switch de estado de producto
	And Doy click en Guardar producto
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el producto de tipo cantidad en la tabla AFLS_STOCK_PRODUCTS

Scenario: 1 Creación exitosa de producto tipo único
	Given Tengo un usuario con rol administrador
	And El producto tipo único con SKU no existe
	And Existe una medida	
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Productos
	And Doy click en Nuevo producto
	And Selecciono tipo producto único
	And Diligencio SKU único
	And Diligencio nombre de producto
	And Diligencio descripción de producto
	And Diligencio cantidad mínima de producto
	And Selecciono una medida
	And Diligencio precio de venta
	#And Doy click en switch de estado de producto
	And Doy click en Guardar producto
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el producto de tipo único en la tabla AFLS_STOCK_PRODUCTS

Scenario: 2 Búsqueda exitosa de un producto existente
	Given Tengo un usuario con rol administrador
	And El producto existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Productos
	And Busco y selecciono el producto
	Then Se muestra la tarjeta del producto y el detalle del mismo

Scenario: 3 Modificación exitosa de un producto
	Given Tengo un usuario con rol administrador
	And El producto existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Productos
	And Busco y selecciono el producto
	And Modifico el nombre de producto
	And Doy click en Guardar producto
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el producto modificado en la tabla AFLS_STOCK_PRODUCTS

Scenario: 4 Borrado exitoso de producto existente
	Given Tengo un usuario con rol administrador
	And El producto existe
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Productos
	And Busco y selecciono el producto
	And Doy click en eliminar producto
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente
	And Se borra el registro de el producto en la tabla AFLS_STOCK_PRODUCTS
