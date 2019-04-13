namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class AFOrdersPage
    {
        public string AFOrdersModulePath = "//div[contains(@class, 'icon iconsAd additionalFields')]";

        public string Module = "Additional field orders";

        public string EOption = "//*/ul/li[@class='item has-sub open']/ul/li/a[@href='#admin/additionalfields/workorders']";
        public string TOption;

        public string EList = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li";

        public string ENew = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/button[@class='button-add primary_border js-button-add']";
        public string TNew;

        public string ETag = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li/form/div[@class='additional-field-content']/div[@class='col']/div/div/input[@class='js-Label']";
        public string TTag;

        public string EType = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li/form/div[@class='additional-field-content']/div[@class='col js-type-container']/div/div/select[@class='js-type-select js-TypeId']";
        public string TType;
        public string ETypeOption = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li/form/div[@class='additional-field-content']/div[@class='col js-type-container']/div/div/select[@class='js-type-select js-TypeId']";

        public string EHelpText = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li/form/div[@class='additional-field-content']/div[@class='col']/div/div/textarea[@class='js-HelpMessage']";

        //public string EHelpText = "//*[@id='js-HelpMessage-c63']"
        public string THelpText;

        public string EState = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li/form/div[@class='additional-field-content']/div[@class='col']/div/div/div[@class='on-off-switch']/label/div/span";
        public string TState;

        public string EAccept = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li/form/div[@class='bottom-bar']/button[@class='accept-button primary_border js-accept-button']";
        public string TAccept;

        public string EDiscard = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li/form/div[@class='bottom-bar']/button[@class='discard-button secondary_border js-discard-button']";
        public string TDiscard;

        public string ESave = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-footer']/button[@class='button-save primary_bg js-button-save']";
        public string TSave;

        public string ECancel = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-footer']/button[@class='button-cancel secondary_bg js-button-cancel']";
        public string TCancel;

        public string EEdit = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li/form/div[@class='top-bar']/button[@class='edit-button secondary_bg js-edit-button']";
        public string TEdit;

        public string EDelete = "//div[@id='addtional-fields-workorders-general']/div/div[@class='aranda-additional-fields-content js-container-list']/ul/li/form/div[@class='top-bar']/button[@class='delete-button secondary_bg js-delete-button']";
        public string TDelete;
    }
}