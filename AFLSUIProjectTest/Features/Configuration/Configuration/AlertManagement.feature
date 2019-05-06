Feature: Gestión de Alertas

Scenario: Configuración exitosa de gestión de alertas habilitando todas las alertas y adicionando tiempos
	Given Tengo un usuario con rol administrador
	And No se encuentra las alertas habilitadas
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Gestión de alertas
	And Habilito alerta de gestión de tarea en campo con tiempo configurado
	And Habilito alerta de no se detecta desplazamiento con tiempo configurado
	And Habilito alerta de tarea de iniciada con tiempo configurado
	And Doy click en Guardar configuración de alertas