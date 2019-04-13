Feature: NonWorkingDays
	#Como Administrador
	#Quiero añadir dias no laborales
	#Para que no se asignenen ordenes de trabajo en ese día

@Migration
Scenario: Adición exitosa de día no laboral
	Given Tengo un usuario con rol administrador
	When Adición exitosa de día no laboral
	Then Finaliza exitosa la prueba



