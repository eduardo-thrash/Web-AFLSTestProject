namespace AFLSUIProjectTest.UIMap
{
    public class ConfigurationMenuPage
    {
        public string ServiceCatalogueMenu = "a.menu-principal.services";
        public string AdministrationMenu = "a.menu-principal.admin";
        public string InventoryMenu = "a.menu-principal.inventory";
        public string ConfigurationMenu = "a.menu-principal.configuration";
        public string IntegrationMenu = "a.menu-principal.integration";

        //Service Catalogue
        public string SLAOption = "//a[contains(@href, '#admin/sla')]";

        public string ChronometerOption = "//a[contains(@href, '#admin/chronometers')]";
        public string ServiceOption = "//a[contains(@href, '#admin/services')]";
        public string CalendarOption = "//a[contains(@href, '#admin/calendars')]";
        public string UCOption = "//a[contains(@href, '#admin/uc')]";
        public string OLAOption = "//a[contains(@href, '#admin/ola')]";
        public string ModelOption = "//a[contains(@href, '#admin/model')]";
        public string RelationOption = "//a[contains(@href, '#admin/relations')]";

        //Administration
        public string CompanyOption = "//a[contains(@href, '#admin/companies')]";

        public string ClientOption = "//a[contains(@href, '#admin/clients')]";
        public string PositionOption = "//a[contains(@href, '#admin/positions')]";
        public string ProviderOption = "//a[contains(@href, '#admin/providers')]";
        public string WebUserOption = "//a[contains(@href, '#admin/users/web')]";
        public string MobileUserOption = "//a[contains(@href, '#admin/users/mobile')]";
        public string WebGroupOption = "//a[contains(@href, '#admin/groups/web')]";
        public string MobileGroupOption = "//a[contains(@href, '#admin/groups/mobile')]";
        public string ZoneOption = "//a[contains(@href, '#admin/coverageZones')]";
        public string MeansTransportOption = "//a[contains(@href, '#admin/meansTransports')]";
        public string SkillOption = "//a[contains(@href, '#admin/skills')]";

        //Inventory
        public string MeasureOption = "//a[contains(@href, '#admin/measures')]";

        public string ProductOption = "//a[contains(@href, '#admin/products')]";
        public string LocationOption = "//a[contains(@href, '#admin/zones')]";

        //Configuration
        public string EstablishmentOption = "//a[contains(@href, '#admin/establishment')]";

        public string AFClientsOption = "//a[contains(@href, '#admin/additionalfields/clients')]";
        public string AFCompaniesOption = "//a[contains(@href, '#admin/additionalfields/companies')]";
        public string AFServicesOption = "//a[contains(@href, '#admin/additionalfields/services')]";
        public string AFOrdersOption = "//a[contains(@href, '#admin/additionalfields/workorders')]";

        public string NonWorkingDaysOption = "//a[contains(@href, '#admin/nonWorking')]";
        public string QuickAnswersOption = "//a[contains(@href, '#admin/quickAnswers')]";
        public string MailServerOption = "//a[contains(@href, '#admin/mail')]";
        public string SurveyGeneralConfigurationOption = "//a[contains(@href, '#admin/surveys/config')]";
        public string SurveyTemplateOption = "//a[contains(@href, '#admin/surveys/templates')]";
        public string AssigmentRulesOption = "//a[contains(@href, '#admin/businessRules')]";
        public string AccuracyOption = "//a[contains(@href, '#admin/accuracy')]";

        public string GeneralEmailTemplateOption = "//a[contains(@href, '#admin/emailTemplates/general')]";
        public string SurveysEmailTemplateOption = "//a[contains(@href, '#admin/emailTemplates/surveys')]";
        public string SLAEmailTemplateOption = "//a[contains(@href, '#admin/emailTemplates/sla')]";
        public string OLAEmailTemplateOption = "//a[contains(@href, '#admin/emailTemplates/ola')]";
        public string UCEmailTemplateOption = "//a[contains(@href, '#admin/emailTemplates/uc')]";
        public string AssistMeEmailTemplateOption = "//a[contains(@href, '#admin/emailTemplates/client')]";
        public string LicensingOption = "//a[contains(@href, '#admin/licensing')]";
        public string AssistMeOption = "//a[contains(@href, '#admin/channels/assistme')]";

        //Integration
        public string LDAPOption = "//a[contains(@href, '#admin/ldap')]";

        public string ASDKOption = "//a[contains(@href, '#admin/asdk')]";
        public string ThirdPartyOption = "//a[contains(@href, '#admin/integration')]";
    }
}