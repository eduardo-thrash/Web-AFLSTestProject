namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class AFCompaniesPage

    {
        //ListContent
        public string AFCompaniesModulePath = "//div[contains(@class, 'icon iconsAd additionalFields')]";

        public string AFCompaniesModule = "additionalFields";

        //DetailContent

        public string AFCompaniesButtonNew = "button.button-add.primary_border.js-button-add";

        public string AFCompaniesInputLabel = "//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div/div/div/input";
        public string TextAFCompaniesInputLabel = "Label";

        public string AFCompaniesType = "//div[@id='addtional-fields-company']/div/div[2]/ul/li[4]/form/div[2]/div[2]/div/div/select";
        public string TextAFCompaniesType = "Type";

        public string AFCompaniesHelp = "//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div/div/div/textarea";
        public string TextAFCompaniesHelp = "Description help";

        public string SelectAFCompaniesListType = "//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select";

        public string AFCompaniesEdit = "button.edit-button.secondary_bg.js-edit-button";
        public string TextAFCompaniesEdit = "Edit Button";

        public string AFCompaniesDelete = "button.edit-button.secondary_bg.js-edit-button";
        public string TextAFCompaniesDelete = "Delete Button";

        public string AFCompaniesYes = "button.bkgColor1.js-button-yes";
        public string TextAFCompaniesYes = "Yes Button";

        public string AFCompaniesAccept = "button.accept-button.primary_border.js-accept-button";
        public string TextAFCompaniesAccept = "Accept Button";

        public string AFCompaniesDiscard = "button.discard-button.secondary_border.js-discard-button";
        public string TextAFCompaniesDiscard = "Discard Button";

        public string AFCompaniesState = "//div[@id='addtional-fields-company']/div/div[2]/ul/li/form/div[2]/div/div[3]/div/div/label/div/span";
        public string TextAFCompaniesState = "Status switch";

        public string AFCompaniesSubmit = "//div[@class='additionalFields col row']/div[@id='addtional-fields-company']/div/div[@class='aranda-additional-fields-footer']/button[@class='button-save primary_bg js-button-save']";
        public string TextAFCompaniesSubmit = "Save Button";

        public string AFCompaniesCancel = "div.addtional-fields-company > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";
        public string TextAFCompaniesCancel = "Cancel Button";
    }
}