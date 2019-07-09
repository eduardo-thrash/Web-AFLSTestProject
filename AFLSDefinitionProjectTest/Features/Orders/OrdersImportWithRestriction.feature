Feature: OrdersImportWithRestriction
	
Scenario: CP_AFLS: Ordenes > Importación > Importación exitosa de ordenes sin restricción de especialista
	Given Tengo usuario con rol despachador
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Selecciono importación de ordenes
	And Cargo archivo configurado con datos diligenciados sin diligenciar restricción de especialista
	And Realizo click en botón importar
	Then Se importan las ordenes de trabajo exitosamente
	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
	And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo y sin restricción
	And Al revisar la tabla AFLS_WORKORDERS, el campo work_restriction_info no refleja información

Scenario: CP_AFLS: Ordenes > Importación > Importación exitosa de ordenes con restricción de especialista
	Given Tengo usuario con rol despachador
	And tengo especialistas activos, con licencia y con habilidades para el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Selecciono importación de ordenes
	And Cargo archivo configurado con datos diligenciados diligenciando nombre de especialista en restricción
	And Realizo click en botón importar
	Then Se importan las ordenes de trabajo exitosamente
	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
	And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo, proveedor y con restricción
	And Al revisar la tabla AFLS_WORKORDERS, el campo work_restriction_info refleja arreglo de restricción con nombre de especialista y Id

Scenario: CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción de especialista inexistente
	Given Tengo usuario con rol despachador
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Selecciono importación de ordenes
	And Cargo archivo configurado con datos diligenciados diligenciando nombre de especialista inexistente en restricción
	And Realizo click en botón importar
	Then No se importan las ordenes de trabajo exitosamente
	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de especialista inexistente

Scenario: CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción de especialista inactivo
	Given Tengo usuario con rol despachador
	And tengo especialistas inactivos, con licencia y con habilidades para el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Selecciono importación de ordenes
	And Cargo archivo configurado con datos diligenciados diligenciando nombre de especialista inactivo en restricción
	And Realizo click en botón importar
	Then No importan las ordenes de trabajo exitosamente
	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de especialista inactivo

Scenario: CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción de especialista sin licencia
	Given Tengo usuario con rol despachador
	And tengo especialistas activos, sin licencia y con habilidades para el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Selecciono importación de ordenes
	And Cargo archivo configurado con datos diligenciados diligenciando nombre de especialista sin licencia en restricción
	And Realizo click en botón importar
	Then No importan las ordenes de trabajo exitosamente
	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de especialista sin licencia

Scenario: CP_AFLS: Ordenes > Importación > Importación fallida de ordenes con restricción de especialista sin habilidades para el servicio
	Given Tengo usuario con rol despachador
	And tengo especialistas activos, con licencia y sin habilidades para el servicio
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Selecciono importación de ordenes
	And Cargo archivo configurado con datos diligenciados diligenciando nombre de especialista sin habilidades en restricción
	And Realizo click en botón importar
	Then No importan las ordenes de trabajo exitosamente
	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de especialista invalido para el servicio

Scenario: CP_AFLS: Ordenes > Importación > Importación exitosa de ordenes con restricción de especialista y campos adicionales
	Given Tengo usuario con rol despachador
	And tengo especialistas activos, con licencia y con habilidades para el servicio
	And Tengo campos adicionales de ordenes y modelos configurados
	When Accedo a la aplicación
	And Realizo Login con usuario rol despachador
	And Accedo a ítem Ordenes
	And Selecciono importación de ordenes
	And Cargo archivo configurado con datos diligenciados diligenciando nombre de especialista en restricción y campos adicionales
	And Realizo click en botón importar
	Then Se importan las ordenes de trabajo exitosamente con restricción de especialista y campos adicionales diligenciados
	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
	And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo, proveedor y con restricción
	And Al revisar la tabla AFLS_WORKORDERS, el campo work_restriction_info refleja arreglo de restricción con nombre de especialista y Id