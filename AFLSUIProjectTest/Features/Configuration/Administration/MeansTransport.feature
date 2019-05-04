Feature: MeansTransport

Scenario: Creación exitosa de Transportes
	Given Tengo un usuario con rol administrador
	And El transporte no existe
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Transportes
	And Doy click en Nuevo transporte
	And Diligencio nombre de transporte
	And Diligencio descripción de transporte
	And Diligencio costo inicial de transporte
	And Diligencio costo por kilómetro de transporte
	And Selecciono medio de transporte
	And Selecciono tipo de transporte publico si se habilita
	And Doy click en switch de estado de transporte
	And Doy click en Guardar transporte
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra el transporte en la tabla AFLS_VEHICLE_TYPE

Scenario: Búsqueda exitosa de un transporte existente
	Given Tengo un usuario con rol administrador
	And El transporte existe
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Transportes
	And Busco y selecciono el transporte
	Then Se muestra la tarjeta del transporte y el detalle del mismo

Scenario: Modificación exitosa de un transporte
	Given Tengo un usuario con rol administrador
	And El transporte existe
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Transportes
	And Busco y selecciono el transporte
	And Edito nombre de transporte
	And Doy click en Guardar transporte
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra modificado el transporte en la tabla AFLS_VEHICLE_TYPE

Scenario: Borrado exitoso de transporte existente
	Given Tengo un usuario con rol administrador
	And El transporte existe
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Transportes
	And Busco y selecciono el transporte
	And Doy click en eliminar transporte
	And Selecciono Aceptar en mensaje de confirmación de borrado
	Then Se muestra mensaje indicando que se borro el registro exitosamente	
	And No se registra el transporte en la tabla AFLS_VEHICLE_TYPE
	And Al buscar el transporte en la aplicación, no se lista en la búsqueda