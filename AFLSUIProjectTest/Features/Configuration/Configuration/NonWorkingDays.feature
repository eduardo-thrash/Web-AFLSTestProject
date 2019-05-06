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
	And Selecciono día no laboral en control de fecha
	And Doy click en Agregar día no laboral
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se agrega vista con día no laboral añadido