namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class AFClientsPage

    {
        //ListContent
        public string AFClientsModulePath = "//div[contains(@class, 'icon iconsAd additionalFields')]";

        public string AFClientsModule = "additionalFields";

        //DetailContent

        public string AFClientsButtonNew = "button.button-add.primary_border.js-button-add";

        public string AFClientsInputLabel = "//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div/div/div/input";
        public string TextAFClientsInputLabel = "Label";

        public string AFClientsType = "//div[@id='addtional-fields-client']/div/div[2]/ul/li[4]/form/div[2]/div[2]/div/div/select";
        public string TextAFClientsType = "Type";

        public string AFClientsHelp = "//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div/div/div/textarea";
        public string TextAFClientsHelp = "Description help";

        public string SelectAFClientsListType = "//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select";

        public string AFClientsEdit = "button.edit-button.secondary_bg.js-edit-button";
        public string TextAFClientsEdit = "Edit Button";

        public string AFClientsDelete = "button.edit-button.secondary_bg.js-edit-button";
        public string TextAFClientsDelete = "Delete Button";

        public string AFClientsYes = "button.bkgColor1.js-button-yes";
        public string TextAFClientsYes = "Yes Button";

        public string AFClientsAccept = "button.accept-button.primary_border.js-accept-button";
        public string TextAFClientsAccept = "Accept Button";

        public string AFClientsDiscard = "button.discard-button.secondary_border.js-discard-button";
        public string TextAFClientsDiscard = "Discard Button";

        public string AFClientsState = "//div[@id='addtional-fields-client']/div/div[2]/ul/li/form/div[2]/div/div[3]/div/div/label/div/span";
        public string TextAFClientsState = "Status switch";

        public string AFClientsSubmit = "//div[@class='additionalFields col row']/div[@id='addtional-fields-client']/div/div[@class='aranda-additional-fields-footer']/button[@class='button-save primary_bg js-button-save']";
        public string TextAFClientsSubmit = "Save Button";

        public string AFClientsCancel = "div.addtional-fields-client > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";
        public string TextAFClientsCancel = "Cancel Button";
    }
}