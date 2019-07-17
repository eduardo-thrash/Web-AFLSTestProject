Feature: InventorySearch
	Búsqueda de productos de inventario localizado en bodegas de aplicación Web.
	Búsqueda por SKU, Nombre de producto o serial de producto de tipo único

Scenario: CP_AFLS: Android > Inventario > Búsqueda > Listado exitoso de ubicaciones de tipo sede activas
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de tipo sede creadas activas en AFLS Web
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	Then Se listan ubicaciones activas de tipo sede con información de nombre, dirección y detalle de dirección
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Listado fallido de ubicaciones de tipo sede inactivas
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de tipo sede creadas inactivas en AFLS Web
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	Then No Se listan ubicaciones inactivas de tipo sede
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Listado exitoso de ubicaciones de tipo transporte activas
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de tipo transporte creadas activas en AFLS Web
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	Then Se listan ubicaciones activas de tipo transporte con información de nombre, dirección y detalle de dirección
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Listado fallido de ubicaciones de tipo transporte inactivas
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de tipo transporte creadas inactivas en AFLS Web
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	Then No Se listan ubicaciones inactivas de tipo transporte
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Visualización exitosa en mapa de ubicaciones de tipo sede activas
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de tipo sede creadas activas en AFLS Web
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la pestaña Mapa
	Then Se visualizan las ubicaciones de tipo sede activas en mapa centrado de acuerdo a la dirección de ubicaciones
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Visualización fallida en mapa de ubicaciones de tipo transporte
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de tipo transporte creadas en AFLS Web
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la pestaña Mapa
	Then No se visualizan las ubicaciones de tipo transporte en mapa
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda exitosa de producto tipo cantidad buscado por nombre
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And Tengo productos de tipo cantidad en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo cantidad
	And Diligencio nombre o parte del nombre de un producto tipo cantidad
	Then Se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra en cada producto del listado nombre, SKU y ultima fecha de ingreso del producto en la ubicación
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda exitosa de producto tipo cantidad buscado por SKU
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And Tengo productos de tipo cantidad en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo cantidad
	And Diligencio SKU o parte del SKU de un producto tipo cantidad
	Then Se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra en cada producto del listado nombre, SKU y ultima fecha de ingreso del producto en la ubicación
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda exitosa de producto tipo único buscado por nombre
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And Tengo productos de tipo único en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo único
	And Diligencio nombre o parte del nombre de un producto tipo único
	Then Se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra en cada producto del listado nombre, SKU y ultima fecha de ingreso del producto en la ubicación
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda exitosa de producto tipo único buscado por SKU
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And Tengo productos de tipo único en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo único
	And Diligencio SKU o parte del SKU de un producto tipo único
	Then Se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra en cada producto del listado nombre, SKU y ultima fecha de ingreso del producto en la ubicación
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda exitosa de producto tipo único buscado por serial
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And Tengo productos de tipo único en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo único
	And Diligencio serial o parte del serial de un producto tipo único
	Then Se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra en cada producto del listado nombre, SKU y ultima fecha de ingreso del producto en la ubicación
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda fallida de producto tipo cantidad buscado por nombre sin existencia en la ubicación
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And No tengo productos de tipo cantidad en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo cantidad
	And Diligencio nombre o parte del nombre de un producto tipo cantidad
	Then No se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra una marca de agua indicando que no hay resultados
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda fallida de producto tipo cantidad buscado por SKU sin existencia en la ubicación
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And No tengo productos de tipo cantidad en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo cantidad
	And Diligencio SKU o parte del SKU de un producto tipo cantidad
	Then No se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra una marca de agua indicando que no hay resultados
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda fallida de producto tipo único buscado por nombre sin existencia en la ubicación
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And No tengo productos de tipo único en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo único
	And Diligencio nombre o parte del nombre de un producto tipo único
	Then No se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra una marca de agua indicando que no hay resultados
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda fallida de producto tipo único buscado por SKU sin existencia en la ubicación
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And No tengo productos de tipo único en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo único
	And Diligencio SKU o parte del SKU de un producto tipo único
	Then No se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra una marca de agua indicando que no hay resultados
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda fallida de producto tipo único buscado por serial sin existencia en la ubicación
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And Tengo productos de tipo único en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo único
	And Diligencio serial inexistente de un producto tipo único
	Then No se listan los resultados que coinciden con los criterios de búsqueda
	And Se muestra una marca de agua indicando que no hay resultados
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Visualización exitosa de producto tipo cantidad seleccionado
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And Tengo productos de tipo cantidad en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo cantidad
	And Diligencio nombre de un producto tipo cantidad
	And Selecciono un producto de tipo cantidad
	Then Se muestra el producto con nombre, SKU, descripción, fecha ultimo ingreso y cantidad disponible
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Visualización exitosa de producto tipo único seleccionado
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And Tengo productos de tipo único en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos tipo único
	And Diligencio nombre de un producto tipo único
	And Selecciono un producto de tipo único
	Then Se muestra el producto con nombre, SKU, serial, descripción, fecha ingreso y cantidad disponible
Scenario: CP_AFLS: Android > Inventario > Búsqueda > Búsqueda fallida de productos sin conexión en aplicación
	Given Tengo usuario con rol especialista
	And Tengo ubicaciones de creadas en AFLS Web
	And Tengo productos en las ubicaciones
	When Accedo a la aplicación móvil
	And Realizo Login con usuario rol especialista
	And Selecciono menú Bar side
	And Selecciono Opción Inventario
	And Selecciono opción de búsqueda de ubicaciones
	And Selecciono la ubicación con productos
	And Cierro conexión en el dispositivo móvil
	And Diligencio nombre de producto para búsqueda en móvil
	Then se muestra un mensaje indicando que no hay conexión