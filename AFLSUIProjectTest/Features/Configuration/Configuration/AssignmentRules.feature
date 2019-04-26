Feature: Assigment Rules


Scenario: Configuración exitosa de reglas de asignación
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Reglas de asignación
	And pulso el tab "Variables del negocio"
    And aumento estrellas (1) a la variable Costo
    And aumento estrellas (1) a la variable Distancia
    And aumento estrellas (1) a la variable Habilidades
    And aumento estrellas (1) a la variable ANS
    And aumento estrellas (1) a la variable Distribución de carga
    And modifico datos en el campo cantidad de procesos
    And modifico datos en el campo Uso máximo de CPU
    And pulso en el tab Rango de tiempo
    And Selecciono la opción Rango de tiempo
    And pulso en el tab Proveedores
    And selecciono la opción Asignar al proveedor con menos carga de trabajo por servicio
    And modifico los datos del campo Tiempo máximo para asignación de proveedor         
    And adiciono puntare (1) a la variable Calificación
    And adiciono puntare (1) a la variable Cumplimiento
    And adiciono puntare (1) a la variable Respuesta
	And Doy click en Guardar configuración de variables de negocio
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Cierro Sesión en la aplicación
        
