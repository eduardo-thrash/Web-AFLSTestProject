Feature: ASDK
#

Scenario: Configuración exitosa de Mesa de servicio ASDK con fuente Clientes
	Given Tengo un usuario con rol administrador
	When Configuración exitosa de Mesa de servicio ASDK con fuente Clientes
	Then Finaliza exitosa la prueba

Scenario: Configuración exitosa de Mesa de servicio ASDK con fuente Compañías
	Given Tengo un usuario con rol administrador
	When Configuración exitosa de Mesa de servicio ASDK con fuente Compañías
	Then Finaliza exitosa la prueba
