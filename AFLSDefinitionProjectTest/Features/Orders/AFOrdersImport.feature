Feature: AFOrdersImport
#
##Estructura
#Scenario: Importación exitosa de campos adicionales de orden y modelo con etiqueta del campo en encabezado
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelo configurando encabezado con etiqueta del campo
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra un mensaje indicando que existen columnas invalidas.
#
#Scenario: Importación exitosa de campos adicionales de orden y modelo con nombre del campo en encabezado
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre del campo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
##Básico
#Scenario: Importación de orden exitosa con campos adicionales de ordenes y modelos sin diligenciar
#	Given Tengo usuario con rol despachador
#	And Tengo permisos de escritura en campos para rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado sin diligenciar campos en registros del archivo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra los campos adicionales sin información
#
#Scenario: Importación de orden exitosa con campos adicionales de ordenes y modelos diligenciados
#	Given Tengo usuario con rol despachador
#	And Tengo permisos de escritura en campos para rol despachador
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado y diligenciando campos en registros del archivo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra los campos diligenciados con el dato de archivo
#
#Scenario: Importación de orden fallida con campos adicionales de ordenes y modelos inactivos sin diligenciar
#	Given Tengo usuario con rol despachador
#	And Tengo permisos de escritura en campos para rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados como inactivos
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And  Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campos inactivos sin diligenciar en registros del archivo
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo inactivo
#
#Scenario: Importación de orden fallida con campos adicionales de ordenes y modelos inactivos diligenciados
#	Given Tengo usuario con rol despachador
#	And Tengo permisos de escritura en campos para rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados como inactivos
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campos inactivos y diligenciando los campos en registros del archivo
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo inactivo
#
#Scenario: Importación fallida de campos adicionales de orden con todos los campos en encabezado y diligenciando solo opcionales
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados como obligatorios y escritura
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con todos los campos y diligenciando solo los campos de escritura
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#Scenario: Importación fallida de campos adicionales de orden y modelo separando con ,
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con separación de coma (,)
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And se muestra un mensaje indicando que la estructura es invalida
#
#Scenario: Importación exitosa de orden con campos adicionales de orden y modelo con nombre de campo configurado mas de una vez sin diligenciar
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados sin obligatoriedad
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre del mismo campo dos veces sin diligenciar ambos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo adicional sin información
#
#Scenario: Importación exitosa de orden con campos adicionales de orden y modelo con nombre de campo configurado mas de una vez diligenciando solo el primero
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados sin obligatoriedad
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre del mismo campo dos veces diligenciando solo el primer campo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo adicional sin información
#
#Scenario: Importación exitosa de orden con campos adicionales de orden y modelo con nombre de campo configurado dos veces diligenciando solo el segundo
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados sin obligatoriedad
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre del mismo campo dos veces diligenciando solo el segundo campo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#Scenario: Importación exitosa de orden con campos adicionales de orden y modelo con nombre de campo configurado dos veces diligenciando los dos
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados sin obligatoriedad
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre del mismo campo dos veces diligenciando ambos campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el segundo dato del archivo
#
#Scenario: Importación fallida de orden con campos adicionales de orden y modelo con nombre de campo configurado dos veces diligenciando de forma valida el primero y el segundo invalido
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados sin obligatoriedad
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo dos veces diligenciando ambos campos pero el segundo con dato invalido
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje con nombre de campo diligenciado de forma invalida
#
#
#
#Scenario: Importación fallida de orden con campos adicionales de orden y modelo con nombre de campo obligatorio configurado dos veces diligenciando solo el primero
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados con obligatoriedad
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo dos veces diligenciando solo el primero
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo obligatorio
#
#
#Scenario: Importación fallida de orden con campos adicionales de orden y modelo con nombre de campo obligatorio configurado dos veces diligenciando solo el segundo
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados con obligatoriedad
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre del mismo campo dos veces diligenciando solo el segundo
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#Scenario: Importación fallida de orden con campos adicionales de orden y modelo con nombre de campo de solo lectura configurado dos veces diligenciando solo el segundo
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de solo lectura
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre del mismo campo dos veces diligenciando solo el segundo
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es de solo lectura
#
#Scenario: Importación exitosa de orden con campos adicionales de orden y modelo con nombre de campo de solo lectura configurado dos veces diligenciando solo el primero
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de solo lectura
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo dos veces diligenciando solo el primero
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo adicional sin información
#
#
#
#
#
##Tipos de campo
#Scenario: Importación exitosa de campos adicionales de ordenes y modelos con campo de tipo texto simple diligenciado
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo texto simple
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo texto simple
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo de texto simple diligenciado con el dato del archivo
#	
#
#Scenario: Importación exitosa de campos adicionales de ordenes y modelos con campo de tipo texto simple diligenciado con caracteres especiales
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo texto simple
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo texto simple y diligenciando con caracteres especiales
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo de texto simple diligenciado con caracteres especiales
#
#Scenario: Importación fallida de campos adicionales de ordenes y modelos con campo de tipo texto simple diligenciado a mas de 50 caracteres
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo texto simple
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo texto simple y diligenciando con mas de 50 caracteres
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo excede longitud máxima
#
#Scenario: Importación exitosa de campos adicionales de ordenes y modelos con campo de tipo párrafo diligenciado
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo párrafo
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo párrafo y diligenciando el campo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#Scenario: Importación fallida de campos adicionales de ordenes y modelos con campo de tipo párrafo diligenciado a mas de 500 caracteres
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo párrafo
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo párrafo y diligenciando con mas de 500 caracteres
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo excede longitud máxima
#
#
#Scenario: Importación exitosa de campos adicionales de ordenes y modelos con campo de tipo numérico diligenciado
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo numérico
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo numérico y diligenciando el campo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#
#Scenario: Importación fallida de campos adicionales de ordenes y modelos con campo de tipo numérico diligenciado con caracteres alfabéticos
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo numérico
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo numérico y diligenciando con caracteres alfabéticos
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo no permite caracteres alfabéticos
#
#Scenario: Importación fallida de campos adicionales de ordenes y modelos con campo de tipo numérico diligenciado con caracteres especiales
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo numérico
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo numérico y diligenciando con caracteres especiales
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo no permite caracteres especiales
#
#Scenario: Importación exitosa de campos adicionales de ordenes y modelos con campo de tipo numérico diligenciado con números negativos
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo numérico
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo numérico y diligenciando el campo con números negativos
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#Scenario: Importación fallida de campos adicionales de ordenes y modelos con campo de tipo numérico diligenciado con números decimales separados por punto
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo numérico
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo numérico y diligenciando con decimales separados por punto
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo no permite caracteres especiales
#
#Scenario: Importación fallida de campos adicionales de ordenes y modelos con campo de tipo numérico diligenciado con números decimales separados por coma
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo numérico
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo numérico y diligenciando con decimales separados por coma
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo no permite caracteres especiales
#
#Scenario: Importación exitosa de campo adicional de orden y modelo con campo de tipo fecha valido
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo fecha
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo fecha y diligenciando el campo con dato valido DD/MM/AAA
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#Scenario: Importación fallida de campo adicional de orden y modelo con campo de tipo fecha invalido en día mayor a 31
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo fecha
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo fecha y diligenciando el campo con dato de día mayor a 31
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo tiene fecha invalida
#	
#
#Scenario: Importación fallida de campo adicional de orden y modelo con campo de tipo fecha invalido en mes mayor a 12
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo fecha
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo fecha y diligenciando el campo con dato de mes mayor a 12
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo tiene fecha invalida
#
#Scenario: Importación fallida de campo adicional de orden y modelo con campo de tipo fecha invalido en año de menos de 4 dígitos
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo fecha
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo fecha y diligenciando el campo con dato de año menor a 4 dígitos
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo tiene fecha invalida
#
#Scenario: Importación exitosa de campo adicional de orden y modelo con campo de tipo listado con opción valida
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo lista
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo lista y diligenciando el campo con opción valida
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#Scenario: Importación exitosa de campo adicional de orden y modelo con campo de tipo listado con opción inexistente
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo lista
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo lista y diligenciando el campo con opción inexistente	
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo tiene opción invalida
#
#
#Scenario: Importación exitosa de campo adicional de orden y modelo con campo de tipo listado con opción distinta a la configuración por texto en mayúscula o minúscula
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de tipo lista
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con campo de tipo lista y diligenciando el campo con opción escrita distinto a la configuración por caracteres en mayúscula y minúscula	
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo
#
##Excepciones
#Scenario: Importación fallida de ordenes con campo adicional inexistente sin diligenciar
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de orden configurados
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo inexistente sin diligenciar
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#
#Scenario: Importación fallida de ordenes con campo adicional inexistente diligenciado
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de orden configurados
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo inexistente diligenciado
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#	
#
#Scenario: Importación fallida de orden con campos adicionales de cliente diligenciados
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de cliente configurados
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo de cliente diligenciado
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#
#Scenario: Importación fallida de orden con campos adicionales de compañía diligenciados
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de compañía configurados
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo de compañía diligenciado
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#
#Scenario: Importación fallida de orden con campos adicionales de servicio diligenciados
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de servicio configurados
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo de servicio diligenciado
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#
#Scenario: Importación fallida de orden con campos adicionales de cliente sin diligenciar
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de cliente configurados
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo de cliente sin diligenciar
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#
#Scenario: Importación fallida de orden con campos adicionales de compañía sin diligenciar
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de compañía configurados
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo de compañía sin diligenciar
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#
#Scenario: Importación fallida de orden con campos adicionales de servicio sin diligenciar
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de servicio configurados
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo de servicio sin diligenciar
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#
##Todos los roles
#Scenario: Importación exitosa de orden con campos adicionales de ordenes y modelos con todos los permisos en todos los roles diligenciando los campos
#	Given Tengo usuario con todos los roles
#	And Tengo campos adicionales de orden configurados con todos los permisos
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes y modelos configurando encabezado con nombre de campo y diligenciando los campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#
#
#
##Lectura
#Scenario: Importación fallida de orden con campos adicionales de ordenes y modelos con permisos de solo lectura en rol despachador diligenciando los campos
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados como solo lectura
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de solo lectura configurando encabezado con nombre de campo y diligenciando los campos
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje con nombre de campo es solo lectura
#
#Scenario: Importación exitosa de orden con campos adicionales de ordenes y modelos con permisos de solo lectura en rol despachador sin diligenciar los campos
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados como solo lectura
#	When Accedo a la aplicación
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de solo lectura configurando encabezado con nombre de campo sin diligenciar los campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo adicional sin información
#
#
#
#Scenario: Importación exitosa de orden con campos adicionales de ordenes y modelos con permisos de solo lectura en rol despachador y permisos de escritura en rol monitor diligenciando los campos
#	Given Tengo usuario con rol monitor y despachador
#	And Tengo campos adicionales de ordenes y modelos configurados obligatorios
#	And Tengo permisos de solo lectura en campos para rol despachador
#	And Tengo permisos de escritura en campos para rol monitor
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol monitor y despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes diligenciando los campo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo por unión de permisos de escritura de rol monitor al rol despachador
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#
#Scenario: Importación fallida de orden con campos adicionales de ordenes y modelos con permisos de solo lectura en rol despachador y permisos de escritura en rol especialista
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados con obligatoriedad
#	And Tengo permisos de solo lectura en campos para rol despachador
#	And Tengo permisos de escritura en campos para rol especialista
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes diligenciando los campo
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#Scenario: Importación fallida de orden con campos adicionales de ordenes y modelos obligatorios con permisos de solo lectura en rol despachador y permisos de escritura en rol monitor
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados con obligatoriedad
#	And Tengo permisos de solo lectura en campos para rol despachador
#	And Tengo permisos de escritura en campos para rol monitor
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes diligenciando los campo
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
##Escritura
#Scenario: Importación exitosa de orden con campos adicionales de ordenes y modelos con permisos de escritura en rol despachador diligenciando los campos
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de escritura
#	And Tengo permisos de escritura en campos para rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes diligenciando los campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#Scenario: Importación exitosa de orden con campos adicionales de ordenes y modelos con permisos de escritura en rol despachador sin diligenciar los campos
#	Given Tengo usuario con rol despachador
#	And Tengo campos adicionales de ordenes y modelos configurados de escritura
#	And Tengo permisos de escritura en campos para rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes sin diligenciar los campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo adicional sin información
#
#
#
#Scenario: Importación fallida de orden con campos adicionales de ordenes sin permisos de escritura en rol despachador diligenciando los campos
#	Given Tengo usuario con rol despachador
#	And Tengo permisos de solo lectura en campos para rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes diligenciando los campos
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de usuario no cuenta con permisos
#
#
#
#Scenario: Importación fallida de orden con campos adicionales de ordenes y modelos con permisos de escritura en rol despachador y permisos de obligatoriedad en rol monitor sin diligenciar
#	Given Tengo usuario con rol despachador y monitor
#	And Tengo permisos de solo escritura en campos para rol despachador
#	And Tengo permisos de obligatoriedad en campos para rol monitor
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol monitor y despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes sin diligenciar los campos
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#Scenario: Importación fallida de orden con campos adicionales de ordenes y modelos con permisos de escritura en rol despachador y permisos de obligatoriedad en rol monitor sin configurar en archivo
#	Given Tengo usuario con rol despachador y monitor
#	And Tengo permisos de solo escritura en campos para rol despachador
#	And Tengo permisos de obligatoriedad en campos para rol monitor
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol monitor y despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes sin configurar campos obligatorios en encabezado
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#Scenario: Importación exitosa de orden con campos adicionales de ordenes y modelos con permisos de escritura en rol despachador y permisos de obligatoriedad en rol especialista
#	Given Tengo usuario con rol despachador
#	And Tengo permisos de escritura en campos para rol despachador
#	And Tengo permisos de obligatoriedad en campos para rol especialista
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes sin diligenciar
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo adicional sin información
#
#
#
##Obligatoriedad
#Scenario: Importación exitosa de orden con campos adicionales de ordenes y modelos con permisos de obligatoriedad en rol despachador diligenciando campos
#	Given Tengo usuario con rol despachador
#	And Tengo permisos de obligatoriedad en campos para rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes diligenciando los campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#
#Scenario: Importación fallida de orden con campos adicionales de ordenes y modelos con permisos de obligatoriedad en rol despachador sin diligenciar campos
#	Given Tengo usuario con rol despachador
#	And Tengo permisos de obligatoriedad en campos para rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes sin diligenciar los campos
#	And Realizo click en botón importar
#	Then No se importan las ordenes de trabajo
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#
#
#
#
#Scenario: Importación exitosa de orden con campos adicionales de ordenes sin permisos de obligatoriedad en rol despachador diligenciando campos
#	Given Tengo usuario con rol despachador
#	And No tengo permisos de obligatoriedad para rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes diligenciando los campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
#
#
#
#Scenario: Importación exitosa de orden con campos adicionales de ordenes sin permisos de obligatoriedad en rol despachador sin diligenciar campos
#	Given Tengo usuario con rol despachador
#	And No tengo permisos de obligatoriedad para rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes sin diligenciar los campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo adicional sin información
#
#Scenario: Importación exitosa de orden con campos adicionales de ordenes sin permisos de escritura en rol despachador y permisos de obligatoriedad en rol monitor diligenciando los campos
#	Given Tengo usuario con rol despachador y monitor
#	And No tengo permisos de escritura para rol despachador
#	And Tengo permisos de obligatoriedad en campos para rol monitor
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol monitor y despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con campos adicionales de ordenes diligenciando los campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente
#	And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#	And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#	And Se muestra un mensaje con la cantidad de registros importados como ordenes de trabajo vs el total de registros del archivo
#	And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#	And Al revisar la orden de trabajo se muestra el campo diligenciado con el dato de archivo
#
##Performance
#
#Scenario: Importación exitosa de orden de trabajo con 2000 registros validos añadiendo longitud y latitud en orden de trabajo.
#Given Tengo usuario con rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con todas las ordenes diligenciando longitud y latitud en cada orden de trabajo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente en -- minutos
#
#Scenario: Importación exitosa de orden con campo adicional de ordenes y modelos con 10 campos adicionales sin diligenciar
#	Given Tengo usuario con rol despachador
#	And Tengo 50 campos adicionales de ordenes y modelos configurados
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con todos los campos adicionales de ordenes sin diligenciar
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente en -- minutos
#
#Scenario: Importación exitosa de ordenes con  campo adicional de ordenes y modelos con 10 campos adicionales diligenciados
#	Given Tengo usuario con rol despachador
#	And Tengo 50 campos adicionales de ordenes y modelos configurados
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con todos los campos adicionales de ordenes diligenciados
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente en -- minutos
#
#
#Scenario: Importación exitosa de ordenes con campo adicional de ordenes y modelos con 10 campos adicionales diligenciados con longitud máxima en cada campo
#	Given Tengo usuario con rol despachador
#	And Tengo 50 ordenes campos adicionales de ordenes y modelos configurados
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con todos los campos adicionales de ordenes diligenciados con longitud máxima en campos
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente en -- minutos
#
#Scenario: Importación exitosa de orden de trabajo con 2000 registros validos añadiendo longitud, latitud y dirección en orden de trabajo.
#Given Tengo usuario con rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con todas las ordenes diligenciando longitud, latitud y dirección en cada orden de trabajo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente en -- minutos
#
#
#Scenario: Importación exitosa de orden de trabajo con 2000 registros validos añadiendo longitud, latitud y productos tipo cantidad y código único en orden de trabajo.
#Given Tengo usuario con rol despachador
#	When Accedo a la aplicación
#	And Realizo Login con usuario rol despachador
#	And Accedo a ítem Ordenes
#	And Selecciono importación de ordenes
#	And Cargo archivo configurado con todas las ordenes diligenciando longitud, latitud, productos tipo cantidad y código único en cada orden de trabajo
#	And Realizo click en botón importar
#	Then Se importan las ordenes de trabajo exitosamente en -- minutos
#
#
