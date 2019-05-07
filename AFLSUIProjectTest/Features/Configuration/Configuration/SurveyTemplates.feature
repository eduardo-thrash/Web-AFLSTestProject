Feature: SurveyTemplates
	
@migrationAFLS
Scenario: Creación exitosa de plantilla de encuesta
	Given Tengo un usuario con rol administrador
	When Accedo a la aplicación
	And Accedo a ítem Configuración
	And Accedo al menú Configuración
	And Selecciono la opción plantillas de encuestas
	And Doy click en Nueva encuesta
	And Diligencio nombre de encuesta
	And Diligencio titulo de encuesta
	And Diligencio descripción de encuesta
	And Doy click en switch de habilitación de encuesta
	And Doy click en habilitación de nivel de satisfacción
	And Diligencio nivel de satisfacción
	And Doy click en Guardar plantilla de encuesta
	Then Se muestra mensaje indicando que se guardo el registro exitosamente
	And Se registra encuesta en la tabla AFW_SURVEY