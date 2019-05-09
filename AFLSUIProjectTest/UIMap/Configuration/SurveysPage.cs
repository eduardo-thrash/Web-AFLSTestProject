namespace AFLSTestProjectUI.UIMap.Configuration
{
    public class ElementsSurvey
    {
        public string SurveyModule = "Surveys";
        public string SurveyModulePath = "//div[contains(@class, 'icon iconsAd surveysconfig')]";

        public string SurveyInputLevel = "satisfaction_level_global";
        public string SurveyInputTime = "satisfaction_level_time_period";
        public string SurveyInputInternalMonitor = "//div[@class='surveysConfig col row cgarandaCommonSurveyComponentContainer']//input[@id='internalTargetsFinder']";
        public string SurveyInputExternalMonitor = "//div[@id='tabstrip-1']/div[2]/div[2]/div/div/input";
        public string SurveyButtonExternalMonitorAdd = "//div[@class='surveysConfig col row cgarandaCommonSurveyComponentContainer']//button[@class='_add_monitor_btn']";

        public string TextSurveyInputLevel = "Level";
        public string TextSurveyInputTime = "Satisfaction level time period";
        public string TextSurveyInputInternalMonitor = "Internal monitor";
        public string TextSurveyInputExternalMonitor = "External monitor";
        public string TextSurveyButtonExternalMonitorAdd = "external monitor Add";

        public string ButtonSurveySave = "//div[@class='surveysConfig col row cgarandaCommonSurveyComponentContainer']/div/div/div[@class='actionButtons _actionbutton']/button[@class= 'bkgColor1 _saveGeneralSurvey']";
        public string ButtonSurveyCancel = "/html/body/div[1]/div/div[2]/div/div[2]/div[2]/div/div/div[2]/button[@class='cancelBtn bkgColor3 _cancelBtn']";

        public string Name = "_txtNameSurvey";
        public string Title = "_txtTitleSurvey";
        public string Description = "_txtDescriptionSurvey";
        public string EnableSurvey = "//div[@id='tabs-1']/form/div[4]/div/label/div/div";
        public string LevelSurvey = "_satisfactionLevel";
        public string EnableLevel = "//div[@id='tabs-1']/form/div[5]/div/label[2]/span";

        public string ButtonSurveyTemplateSave = "/html/body/div[1]/div/div[2]/div/div[2]/div[2]/div[2]/div/div[3]/button[@class='saveBtn bkgColor1 _saveBtn']";
        public string ButtonSurveyTemplateCancel = "/html/body/div[1]/div/div[2]/div/div[2]/div[2]/div/div/div[2]/button[@class='cancelBtn bkgColor3 _cancelBtn']";
    }
}