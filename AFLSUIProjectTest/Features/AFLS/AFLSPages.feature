Feature: AFLSPages

Scenario: Revisión Exitosa de Keys en pantallas de Catalogo de servicios
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Selecciono la opción ANS's
	And Valido que no existan MissingKey en pantalla principal ANS's
	And Selecciono la opción OLA's							   
	And Valido que no existan MissingKey en pantalla principal OLA's
	And Selecciono la opción UC's							   
	And Valido que no existan MissingKey en pantalla principal UC's
	And Selecciono la opción Calendarios					   
	And Valido que no existan MissingKey en pantalla principal Calendarios
	And Selecciono la opción Cronómetros					   
	And Valido que no existan MissingKey en pantalla principal Cronómetros
	And Selecciono la opción Modelos						   
	And Valido que no existan MissingKey en pantalla principal Modelos
	And selecciono la opción Servicios						   
	And Valido que no existan MissingKey en pantalla principal Servicios
	And selecciono la opción Relaciones						   
	And Valido que no existan MissingKey en pantalla principal Relaciones
	Then Valido si hay Missing Key localizados
	And Cierro Sesión en la aplicación

Scenario: Revisión Exitosa de Keys en pantallas de Administración
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Administración
	And Selecciono la opción Compañías
	And Valido que no existan MissingKey en pantalla principal  Compañias
	And Selecciono la opción Clientes
	And Valido que no existan MissingKey en pantalla principal  Clientes
	And Selecciono la opción Transportes
	And Valido que no existan MissingKey en pantalla principal  Transportes
	And Selecciono la opción Cargos
	And Valido que no existan MissingKey en pantalla principal  Cargos
	And Selecciono la opción Proveedores
	And Valido que no existan MissingKey en pantalla principal  Proveedores
	And Selecciono la opción Habilidades
	And Valido que no existan MissingKey en pantalla principal  Habilidades
	And selecciono la opción Usuarios Web
	And Valido que no existan MissingKey en pantalla principal  Usuarios Web
	And selecciono la opción Grupos Web
	And Valido que no existan MissingKey en pantalla principal  Grupos Web
	And selecciono la opción Usuarios Móvil
	And Valido que no existan MissingKey en pantalla principal  Usuarios Web
	And selecciono la opción Grupos Móvil
	And Valido que no existan MissingKey en pantalla principal  Grupos Web
	And selecciono la opción Zonas
	And Valido que no existan MissingKey en pantalla principal  Zonas
	Then Valido si hay Missing Key localizados
	And Cierro Sesión en la aplicación

Scenario: Revisión Exitosa de Keys en pantallas de Inventario
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Inventario
	And Selecciono la opción Medidas
	And Valido que no existan MissingKey en pantalla principal  Medidas
	And Selecciono la opción Productos
	And Valido que no existan MissingKey en pantalla principal  Productos
	And Selecciono la opción Ubicaciones
	And Valido que no existan MissingKey en pantalla principal  Ubicaciones
	Then Valido si hay Missing Key localizados
	And Cierro Sesión en la aplicación

Scenario: Revisión Exitosa de Keys en pantallas de Integración
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Integración
	And Selecciono la opción LDAP
	And Valido que no existan MissingKey en pantalla principal LDAP
	And Selecciono la opción ASDK
	And Valido que no existan MissingKey en pantalla principal ASDK
	And Selecciono la opción Otras aplicaciones
	And Valido que no existan MissingKey en pantalla principal Otras aplicaciones
	Then Valido si hay Missing Key localizados
	And Cierro Sesión en la aplicación

Scenario: Revisión Exitosa de Keys en pantallas de Configuración
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Realizo Login con usuario rol administrador
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción Información básica
	And Valido que no existan MissingKey en pantalla principal Información básica
	And Selecciono la opción Campos adicionales compañías
	And Valido que no existan MissingKey en pantalla principal Campos adicionales compañías
	And Selecciono la opción Campos adicionales clientes
	And Valido que no existan MissingKey en pantalla principal Campos adicionales clientes
	And Selecciono la opción Campos adicionales servicios
	And Valido que no existan MissingKey en pantalla principal Campos adicionales servicios
	And Selecciono la opción Campos adicionales de ordenes
	And Valido que no existan MissingKey en pantalla principal Campos adicionales ordenes
	And Selecciono la opción Días no laborales
	And Valido que no existan MissingKey en pantalla principal Días no laborales
	And Selecciono la opción Servidor de correo
	And Valido que no existan MissingKey en pantalla principal Servidor de correo
	And Selecciono la opción Encuestas general
	And Valido que no existan MissingKey en pantalla principal Encuestas general
	And Selecciono la opción Plantillas de Encuestas
	And Valido que no existan MissingKey en pantalla principal Plantillas de Encuestas
	And Selecciono la opción Respuestas rápidas
	And Valido que no existan MissingKey en pantalla principal Respuestas rápidas
	And Selecciono la opción Plantillas de correo Generales
	And Valido que no existan MissingKey en pantalla principal Plantillas de correo generales
	And Selecciono la opción Plantillas de correo Encuestas
	And Valido que no existan MissingKey en pantalla principal Plantillas de correo Encuestas
	And Selecciono la opción Plantillas de correo ANS's
	And Valido que no existan MissingKey en pantalla principal Plantillas de correo ANS's
	And Selecciono la opción Plantillas de correo UC's
	And Valido que no existan MissingKey en pantalla principal Plantillas de correo UC's
	And Selecciono la opción Plantillas de correo OLA's
	And Valido que no existan MissingKey en pantalla principal Plantillas de correo OLA's
	And Selecciono la opción Plantillas de correo AssistMe's
	And Valido que no existan MissingKey en pantalla principal Plantillas de correo AssistMe's
	And Selecciono la opción Reglas de asignación
	And Valido que no existan MissingKey en pantalla principal Reglas de asignación
	And Selecciono la opción Precisión de ubicación
	And Valido que no existan MissingKey en pantalla principal Precisión de ubicación
	And Selecciono la opción Licenciamiento
	And Valido que no existan MissingKey en pantalla principal Licenciamiento
	And Selecciono la opción Canal AssistMe
	And Valido que no existan MissingKey en pantalla principal Canal AssistMe
	And Selecciono la opción Gestión de alertas
	And Valido que no existan MissingKey en pantalla principal Gestión de alertas
	Then Valido si hay Missing Key localizados
	And Cierro Sesión en la aplicación