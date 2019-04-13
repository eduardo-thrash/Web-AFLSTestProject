Feature: Providers


Scenario: Creacion exitosa completa de proveedores asociando servicio, zona y monitor
	Given Tengo un usuario con rol administrador
	When Creacion exitosa completa de proveedores asociando servicio, zona y monitor
	Then Finaliza exitosa la prueba

Scenario: Creacion exitosa basica de proveedores
	Given Tengo un usuario con rol administrador
	When Creacion exitosa basica de proveedores
	Then Finaliza exitosa la prueba

Scenario: Creacion exitosa de proveedor de prioridad media
	Given Tengo un usuario con rol administrador
	When Creacion exitosa de proveedor de prioridad media
	Then Finaliza exitosa la prueba

Scenario: Creacion exitosa de proveedor de prioridad alta
	Given Tengo un usuario con rol administrador
	When Creacion exitosa de proveedor de prioridad alta
	Then Finaliza exitosa la prueba

Scenario: Creacion exitosa de proveedor de prioridad baja
	Given Tengo un usuario con rol administrador
	When Creacion exitosa de proveedor de prioridad baja
	Then Finaliza exitosa la prueba

Scenario: Creacion exitosa de proveedor externo
	Given Tengo un usuario con rol administrador
	When Creacion exitosa de proveedor externo
	Then Finaliza exitosa la prueba

Scenario: Creacion exitosa de proveedor interno
	Given Tengo un usuario con rol administrador
	When Creacion exitosa de proveedor interno
	Then Finaliza exitosa la prueba

Scenario: Creacion exitosa de proveedor con asignación manual
	Given Tengo un usuario con rol administrador
	When Creacion exitosa de proveedor con asignación manual
	Then Finaliza exitosa la prueba

Scenario: Creacion exitosa de proveedor con asignación automatica
	Given Tengo un usuario con rol administrador
	When Creacion exitosa de proveedor con asignación automatica
	Then Finaliza exitosa la prueba

Scenario: Creacion fallida de proveedor sin nombre
	Given Tengo un usuario con rol administrador
	When Creacion fallida de proveedor sin nombre
	Then Finaliza exitosa la prueba

Scenario: Creacion fallida de proveedor sin descripción
	Given Tengo un usuario con rol administrador
	When Creacion fallida de proveedor sin descripción
	Then Finaliza exitosa la prueba

Scenario: Modificacion exitosa de proveedor cambiando nombre
	Given Tengo un usuario con rol administrador
	When Modificacion exitosa de proveedor cambiando nombre
	Then Finaliza exitosa la prueba

Scenario: Modificacion exitosa de proveedor cambiando prioridad
	Given Tengo un usuario con rol administrador
	When Modificacion exitosa de proveedor cambiando prioridad
	Then Finaliza exitosa la prueba

Scenario: Modificacion exitosa de proveedor cambiando asignación
	Given Tengo un usuario con rol administrador
	When Modificacion exitosa de proveedor cambiando asignación
	Then Finaliza exitosa la prueba

Scenario: Consulta exitosa de proveedor por nombre
	Given Tengo un usuario con rol administrador
	When Consulta exitosa de proveedor por nombre
	Then Finaliza exitosa la prueba

Scenario: Borrado exitoso de proveedor
	Given Tengo un usuario con rol administrador
	When Borrado exitoso de proveedor
	Then Finaliza exitosa la prueba