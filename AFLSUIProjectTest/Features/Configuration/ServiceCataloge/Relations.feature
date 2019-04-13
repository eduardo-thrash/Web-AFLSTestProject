Feature: Relations

#
#<summary>
Scenario: 1 Creación exitosa de relación
	Given Tengo un usuario con rol administrador
	When Creación exitosa de relación
	Then Finaliza exitosa la prueba
#
# <summary>
Scenario: 1 Creación fallida de relación con nombre repetido
	Given Tengo un usuario con rol administrador
	When Creación fallida de relación con nombre repetido
	Then Finaliza exitosa la prueba
#
#
#
# <summary>
Scenario: 1 Cancelación exitosa de creación de relación
	Given Tengo un usuario con rol administrador
	When Cancelación exitosa de creación de relación
	Then Finaliza exitosa la prueba
#
#
# <summary>
Scenario: 2 Consulta exitosa de relación por nombre
	Given Tengo un usuario con rol administrador
	When Consulta exitosa de relación por nombre
	Then Finaliza exitosa la prueba
#
#
#
#
# <summary>
Scenario: 3 Modificación exitosa de relaciones
	Given Tengo un usuario con rol administrador
	When Modificación exitosa de relaciones
	Then Finaliza exitosa la prueba
#
#
#
# <summary>
Scenario: 3 Modificación fallida de relaciones dejando nombre o conectores vacios
Given Tengo un usuario con rol administrador
	When Modificación fallida de relaciones dejando nombre o conectores vacios
	Then Finaliza exitosa la prueba
#
#
#
# <summary>
Scenario: 3 Inactivación exitosa de relaciones
    Given Tengo un usuario con rol administrador
	When Inactivación exitosa de relaciones
	Then Finaliza exitosa la prueba
#
#
#
# <summary>
Scenario: 4 Eliminación exitosa de relaciones
Given Tengo un usuario con rol administrador
	When Eliminación exitosa de relaciones
	Then Finaliza exitosa la prueba
#
