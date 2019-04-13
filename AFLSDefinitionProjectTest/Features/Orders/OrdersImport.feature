Feature: OrdersImport
#
##Basic Import
#Scenario: Importación exitosa de ordenes con todos los campos del archivo diligenciados
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con datos diligenciados
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo
#
#Scenario: Importación exitosa de ordenes con solo campos obligatorios diligenciados
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con solo datos obligatorios diligenciados (contactname, servid, subject, description, uniqueReference)
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo
#
#Scenario: Importación fallida de ordenes sin campo nombre de contacto diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo contactname diligenciado
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#Scenario: Importación fallida de ordenes con campo nombre de contacto diligenciado con mas de 100 caracteres
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo contactname diligenciado con mas de 100 caracteres
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo excede longitud máxima
#
#Scenario: Importación fallida de ordenes sin campo servicio diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo serviceid diligenciado
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#
#Scenario: Importación fallida de ordenes con campo servicio diligenciado con id de servicio inexistente
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo serviceid diligenciando id inexistente
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es invalido
#
#Scenario: Importación fallida de ordenes con campo servicio diligenciado con id de servicio inactivo
#Given Tengo usuario con rol despachador
#And Tengo servicios inactivos
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo serviceid diligenciando id inactivo
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es inactivo
#
#Scenario: Importación fallida de ordenes con campo servicio diligenciado con id de servicio con ANS vencido
#Given Tengo usuario con rol despachador
#And Tengo servicios con ANS vencido
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo serviceid diligenciando id con ANS vencido
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo tiene ANS vencido
#
#Scenario: Importación fallida de ordenes con campo servicio diligenciado con id de servicio que no tiene asociado el cliente
#Given Tengo usuario con rol despachador
#And Tengo servicios no asociados al cliente
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo serviceid diligenciando id no asociado al cliente
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo no asociado al cliente
#
#Scenario: Importación fallida de ordenes sin campo asunto diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo subject diligenciado
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#Scenario: Importación fallida de ordenes con campo asunto diligenciado con mas de 100 caracteres
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo subject diligenciado con mas de 100 caracteres
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo excede longitud máxima
#
#Scenario: Importación fallida de ordenes sin campo descripción diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo description diligenciado
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#Scenario: Importación exitosa de ordenes sin campo productos diligenciado y servicio configurado con inventario
#Given Tengo usuario con rol despachador
#And Tengo servicios con inventario configurado
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo spareparts diligenciado y campo serviceid con id de servicio con inventario por defecto
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#And se muestra la orden con inventario por defecto del servicio asociado a la orden
#
#Scenario: Importación exitosa de ordenes sin campo productos diligenciado y servicio configurado sin inventario
#Given Tengo usuario con rol despachador
#And Tengo servicios sin inventario configurado
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo spareparts diligenciado y campo serviceid con id de servicio sin inventario por defecto
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#And se muestra la orden sin inventario asociado
#
#Scenario: Importación exitosa de ordenes con campo productos diligenciado y servicio configurado sin inventario
#Given Tengo usuario con rol despachador
#And Tengo servicios sin inventario configurado
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo spareparts diligenciado y campo serviceid con id de servicio sin inventario por defecto
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#And se muestra la orden con inventario asociado envido en el registro del archivo
#
#Scenario: Importación exitosa de ordenes con campo productos diligenciado y servicio configurado con inventario
#Given Tengo usuario con rol despachador
#And Tengo servicios con inventario configurado
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo spareparts diligenciado y campo serviceid con id de servicio con inventario por defecto
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#And se muestra la orden con inventario asociado enviado en el registro del archivo
#
#Scenario: Importación exitosa de ordenes con campo productos diligenciados con cantidades en cero
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo spareparts diligenciado con cantidades en cero
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#And se muestra la orden sin inventario asociado
#
#Scenario: Importación fallida de ordenes con campo productos diligenciados con id de productos inactivos
#Given Tengo usuario con rol despachador
#And Tengo productos inactivos
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo spareparts diligenciado con id de producto inactivo
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo inactivo
#
#Scenario: Importación fallida de ordenes con campo productos diligenciados con id de productos inexistentes
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo spareparts diligenciado con id de producto inexistente
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#
#
#Scenario: Importación exitosa de ordenes sin campo correo electrónico diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo contactemail diligenciado
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo
#
#Scenario: Importación fallido de ordenes con campo correo electrónico diligenciado con mas de 250 caracteres
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo contactemail diligenciado con mas de 250 caracteres
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo excede longitud máxima
#
#
#
#Scenario: Importación fallido de ordenes con campo correo electrónico diligenciado con formato invalido
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo contactemail diligenciado con formato invalido
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo con formato invalido
#
#
#Scenario: Importación exitosa de ordenes sin campo número de contacto diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo contactphone diligenciado
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo
#
#
#Scenario: Importación fallida de ordenes con campo número de contacto diligenciado con mas de 32 caracteres
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo contactphone diligenciado con mas de 32 caracteres
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo debe ser de 6 a 32 caracteres
#
#
#
#
#Scenario: Importación fallida de ordenes con campo número de contacto diligenciado con menos de 6 caracteres
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo contactphone diligenciado con menos de 6 caracteres
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo debe ser de 6 a 32 caracteres
#
#
#Scenario: Importación exitosa de ordenes sin campo longitud-latitud diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo latitude-longitude sin diligenciar
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo
#
#Scenario: Importación exitosa de ordenes sin campo dirección diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo adress sin diligenciar
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo
#
#
#
#Scenario: Importación exitosa de ordenes con campo dirección invalido
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo adress diligenciando dirección invalida
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo y ubicación genérica en Zona geográfica
#
#
#
#
#Scenario: Importación exitosa de ordenes con campo longitud-latitud diligenciado y sin campo dirección diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo latitude-longitude diligenciado y campo adress sin diligenciar
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo y dirección correcta por coordenadas
#
#
#
#
#Scenario: Importación exitosa de ordenes sin campo longitud-latitud diligenciado y con campo dirección diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo latitude-longitude diligenciado y campo adress diligenciado
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo y dirección correcta por dirección de maps
#
#
#
#
#Scenario: Importación exitosa de ordenes con campo longitud-latitud diligenciado en solo longitud y con campo dirección diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo latitude-longitude diligenciando solo longitud y campo adress diligenciado
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo y dirección correcta por dirección de maps
#
#
#Scenario: Importación exitosa de ordenes con campo longitud-latitud diligenciado en solo latitud y con campo dirección diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo latitude-longitude diligenciando solo latitud y campo adress diligenciado
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra con los datos diligenciados en el archivo y dirección correcta por dirección de maps
#
#
#Scenario: Importación fallida de ordenes con campo longitud-latitud diligenciado latitud o longitud y sin campo dirección diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo latitude-longitude diligenciando solo latitud o longitud y campo adress sin diligenciar
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo tiene dirección invalida
#
#
#
#
#Scenario: Importación exitosa de ordenes sin campo detalle dirección diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo addladdress diligenciado
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#
#
#Scenario: Importación fallida de ordenes con campo detalle dirección diligenciado a mas de 250 caracteres
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo addladdress diligenciado con mas de 250 caracteres
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo excede longitud máxima
#
#
#
#
#Scenario: Importación fallida de ordenes sin campo código único diligenciado
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campo uniqueReference diligenciado
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#
#
#
#
#Scenario: Importación fallida de ordenes con campo código único diligenciado de cliente inexistente
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo uniqueReference diligenciado con datos de cliente inexistente 
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo invalido
#
#
#Scenario: Importación fallida de ordenes con campo código único diligenciado de cliente inactivo
#Given Tengo usuario con rol despachador
#And Tengo clientes inactivos
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo uniqueReference diligenciado con datos de cliente inactivo 
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es inactivo
#
#
#Scenario: Importación exitosa de ordenes con campo código único diligenciado de cliente importado de ASDK
#Given Tengo usuario con rol despachador
#And Tengo clientes importados desde ASDK
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo uniqueReference diligenciado con datos de cliente importado de ASDK 
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#
#
#Scenario: Importación exitosa de ordenes con campo código único diligenciado de cliente importado de LDAP
#Given Tengo usuario con rol despachador
#And Tengo clientes importados desde ASDK
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo uniqueReference diligenciado con datos de cliente importado LDAP 
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#
#
#Scenario: Importación exitosa de ordenes con campo código único diligenciado de cliente creado en AssitMe
#Given Tengo usuario con rol despachador
#And Tengo clientes importados desde AssistMe
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campo uniqueReference diligenciado con datos de cliente creado en AssistMe LDAP 
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#
##Campos adicionales
#Scenario: Importación exitosa de ordenes sin campos adicionales añadidos en encabezado
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados como escritura para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado sin campos adicionales
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#
#
#Scenario: Importación exitosa de ordenes con campos adicionales añadidos en encabezado de escritura sin diligenciar
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados como escritura para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campos adicionales en encabezado pero sin diligenciar en registros del archivo
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#
#
#Scenario: Importación exitosa de ordenes con campos adicionales añadidos en encabezado de escritura diligenciados
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados como escritura para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campos adicionales en encabezado y diligenciados en registros del archivo
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#
#
#Scenario: Importación exitosa de ordenes con campos adicionales añadidos en encabezado obligatorios diligenciados
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados como obligatorios para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campos adicionales en encabezado y diligenciados en registros del archivo
#And Realizo click en botón importar
#Then Se importan las ordenes de trabajo exitosamente
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la orden de trabajo se muestra el campo diligenciado con los datos de archivo
#
#
#Scenario: Importación fallida de ordenes con campos adicionales añadidos en encabezado obligatorios sin diligenciar
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados como obligatorios para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campos adicionales en encabezado pero sin diligenciar en registros del archivo
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#
#Scenario: Importación fallida de ordenes con encabezado incompleto sin añadir un atributo en medio del encabezado
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campos adicionales en encabezado pero sin configurar nombre de campo adicional en medio del registro
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And se muestra un mensaje indicando que la estructura es invalida
#
#Scenario: Importación fallida de ordenes con encabezado incompleto sin añadir un atributo obligatorio
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados como obligatorios para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campos adicionales en encabezado pero sin configurar nombre de campo obligatorio para rol despachador
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de nombre de campo es obligatorio
#
#
#
#
#Scenario: Importación fallida de ordenes con mas datos diligenciados de los que existen en encabezado
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados como obligatorios para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campos adicionales en encabezado pero diligenciando mas campos de los configurados en campos adicionales
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And Se muestra una barra de progreso con los registros importados, fallidos y restantes
#And Al terminar la importación se muestra un mapa centrado con las coordenadas validadas correctamente
#And Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al descargar el archivo y abrirlo se muestran los registros no importados con mensaje de longitud de registro invalido
#
#
##Estructura
#Scenario: Importación fallida de ordenes con datos separados por coma (,)
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados como obligatorios para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con campos adicionales en encabezado separado por coma (,)
#And Realizo click en botón importar
#Then No se importan las ordenes de trabajo
#And se muestra un mensaje indicando que la estructura es invalida
#
#
##ProgressBar, Sesión y Mapa
#
#Scenario: Validación exitosa de sesión activa en importación de ordenes
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con ordenes de trabajo con registros validos e inválidos
#And Realizo click en botón importar
#Then Se muestra una ventana emergente con una barra de progreso que avanza por cada registro validado
#And Se muestra numero de registros importados exitosamente como ordenes
#And Se muestra numero de registros no importadas como ordenes
#And Se muestra numero de total de registros en el archivo
#And en la tabla AFW_USER_SESSION_TOKEN se extiende el cierre de sesión del usuario por cada registro exitoso o cada 5 segundos
#
#Scenario: Validación exitosa de progress bar en importación de ordenes
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con ordenes de trabajo con registros validos e inválidos
#And Realizo click en botón importar
#Then Se muestra una ventana emergente con una barra de progreso que avanza por cada registro validado
#And Se muestra numero de registros importados exitosamente como ordenes
#And Se muestra numero de registros no importadas como ordenes
#And Se muestra numero de total de registros en el archivo
#
#Scenario: Validación exitosa de mapa en importación de ordenes exitosas y fallidas
#Given Tengo usuario con rol despachador
#And Tengo campos adicionales de ordenes y modelos configurados como obligatorios para rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con ordenes de trabajo con registros exitosos y fallidos pero dirección valida
#And Realizo click en botón importar
#And Termina importación de ordenes
#Then Se muestra un mapa centrado con las coordenadas o direcciones validas sin importar si el registro se importo como orden o no
#
#
##Logs
#Scenario: Generación exitosa de archivos al terminar importación de ordenes exitosa
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con registros exitosas
#And Realizo click en botón importar
#And Termina importación de ordenes
#Then Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al revisar la carpeta downloads de la aplicación web, se muestran un archivo .csv y .json con registros fallidos siendo vació si no hay errores
#
#Scenario: Generación exitosa de archivo de errores al terminar importación de ordenes fallida
#Given Tengo usuario con rol despachador
#When Accedo a la aplicación
#And Realizo Login con usuario rol despachador
#And Accedo a ítem Ordenes
#And Selecciono importación de ordenes
#And Cargo archivo configurado con registros fallidos
#And Realizo click en botón importar
#And Termina importación de ordenes
#Then Se muestra un botón para descargar el archivo si contiene registro con error y un botón para cerrar el mapa
#And Al dar click en Botón descargar se descarga y/o muestra archivo con registros fallidos y mensaje de error en cada uno
#And Al revisar la carpeta downloads de la aplicación web, se muestran un archivo .csv y .json con registros fallidos
#
#Scenario: Borrado exitoso de archivos generados en importaciones de ordenes por parámetro de días
#Given Tengo Permisos de revisión de archivos en carpeta de aplicación web
#When Realizo importación de ordenes
#And Se generan registros de ordenes no importadas
#And Valido ejecución exitosa de tarea de base de datos Clean Garbage
#Then Se borran archivos de importación de la carpeta downloads de la aplicación Web
#And Se borran registros de menos del Delta de días configurados en parámetro DaysToExpireGarbageClean
#
##Asignación
#Scenario: Asignación exitosa de proveedor en ordenes importadas
#Given Tengo Permisos de revisión de archivos en carpeta de aplicación web
#When Realizo importación de ordenes
#And se ejecuta tarea de base de datos Unassigned Provider Order
#Then Se muestran las ordenes importadas con proveedor asociado de acuerdo a la zona de la orden
#And Se muestra las ordenes sin zona sin proveedor asociado
#
#Scenario: Asignación exitosa de especialista en ordenes importadas
#Given Tengo Permisos de revisión de archivos en carpeta de aplicación web
#When Realizo importación de ordenes
#And Se ejecuta tarea de base de datos Unassigned Provider Order
#And Se ejecuta la tarea EngineService
#Then Se muestran las ordenes importadas con proveedor asociado y especialista asignado
#And Se muestra las ordenes sin proveedor sin especialista asociado
#
#
