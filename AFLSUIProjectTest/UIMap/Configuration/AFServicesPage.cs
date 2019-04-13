namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class AFServicesPage

    {
        //ListContent
        public string AFServicesModulePath = "//div[contains(@class, 'icon iconsAd additionalFields')]";

        public string AFServicesModule = "additionalFields";

        //DetailContent

        public string AFServicesButtonNew = "button.button-add.primary_border.js-button-add";

        public string AFServicesInputLabel = "//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div/div/div/input";
        public string TextAFServicesInputLabel = "Label";

        public string AFServicesType = "//div[@id='addtional-fields-service']/div/div[2]/ul/li[4]/form/div[2]/div[2]/div/div/select";
        public string TextAFServicesType = "Type";

        public string AFServicesHelp = "//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div/div/div/textarea";
        public string TextAFServicesHelp = "Description help";

        public string SelectAFServicesListType = "//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select";

        public string AFServicesEdit = "button.edit-button.secondary_bg.js-edit-button";
        public string TextAFServicesEdit = "Edit Button";

        public string AFServicesDelete = "button.edit-button.secondary_bg.js-edit-button";
        public string TextAFServicesDelete = "Delete Button";

        public string AFServicesYes = "button.bkgColor1.js-button-yes";
        public string TextAFServicesYes = "Yes Button";

        public string AFServicesAccept = "button.accept-button.primary_border.js-accept-button";
        public string TextAFServicesAccept = "Accept Button";

        public string AFServicesDiscard = "button.discard-button.secondary_border.js-discard-button";
        public string TextAFServicesDiscard = "Discard Button";

        public string AFServicesState = "//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div/div[3]/div/div/label/div/span";
        public string TextAFServicesState = "Status switch";

        public string AFServicesSubmit = "//div[@class='additionalFields col row']/div[@id='addtional-fields-service']/div/div[@class='aranda-additional-fields-footer']/button[@class='button-save primary_bg js-button-save']";
        public string TextAFServicesSubmit = "Save Button";

        public string AFServicesCancel = "div.addtional-fields-service > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";
        public string TextAFServicesCancel = "Cancel Button";
    }
}