namespace AFLSUIProjectTest.UIMap.AFLS
{
    public class MessagesElements
    {
        public string ResponseElement = "//div[@id='growls']";
        public string ResponseError = "//div[@id='growls']/div[@class='growl growl-error growl-medium']";

        public string SubmitButton = "body > div.ui-dialog.ui-widget.ui-widget-content.ui-corner-all.ui-front.ui-dialog-buttons.ui-draggable > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button.my-button-submit.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only"; //CssSelector
        public string CancelButton = "body > div.ui-dialog.ui-widget.ui-widget-content.ui-corner-all.ui-front.ui-dialog-buttons.ui-draggable > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button.my-button-cancel.ui-button.ui-widget.ui-state-default.ui-corner-all.ui-button-text-only"; //CssSelector
    }

    public class MessagesCopies
    {
        public string SuccessfulOrderCreation = "La orden de trabajo";

        public string SuccessfulOrderUpdate = "fue guardada exitosamente";

        public string SuccessElementConfigurationCreateOrUpdate = "El registro se ha guardado correctamente";

        public string SuccessElementConfigurationDelete = "Registro eliminado correctamente";

        public string FailedElementConfigurationCreateOrUpdate = "Algunos campos no son válidos";

        public string SuccessMailSendToSpecialist = "El correo se envió satisfactoriamente";

        public string FailedElementConfigurationCreateOrUpdateRepeat = "Ya existe un elemento con la información";
    }
}