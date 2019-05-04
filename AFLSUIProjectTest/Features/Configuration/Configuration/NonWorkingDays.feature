Feature: NonWorkingDays
	#Como Administrador
	#Quiero añadir dias no laborales
	#Para que no se asignenen ordenes de trabajo en ese día

Scenario: Adición exitosa de día no laboral
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Días no laborales
	When Adición exitosa de día no laboral
	Then Finaliza exitosa la prueba



