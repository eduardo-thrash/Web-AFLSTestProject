﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration
{
    public class EmailTemplatesPage
    {
        public string EmailTemplateModule = "Email Template";
        public string GeneralEmailTemplateModule = "General Email Template";
        public string SurveysEmailTemplateModule = "Surveys Email Template";
        public string SLAEmailTemplateModule = "SLAEmailTemplate";
        public string OLAEmailTemplateModule = "OLA Email Template";
        public string UCEmailTemplateModule = "UC Email Template";
        public string AssistMeEmailTemplateModule = "AssistMe Email Template";

        public string EmailTemplateModulePath = "//div[contains(@class, 'icon iconsAd emailTemplates')]";
 
        public string ButtonAddGeneralRecord = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-1']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddGeneralAssigment = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-2']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddGeneralDelay = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-3']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddGeneralChangeOfSpecialist = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-4']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddGeneralCancellation = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-5']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddGeneralExecuted = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-6']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddGeneralEnrollment = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-7']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddGeneralProviders = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-8']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddSurveySatisSurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-1']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddSurveySatisAlert = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-2']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddSurveyNotifySurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-3']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddSurveySummarySurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-4']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddSLAReview = "//div[@class='emailTemplatesSLA']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-1']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddSLAEnding = "//div[@class='emailTemplatesSLA']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-2']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddUCReview = "//div[@class='emailTemplatesUC']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-1']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddUCEnding = "//div[@class='emailTemplatesUC']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-2']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddOLAReview = "//div[@class='emailTemplatesOLA']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-1']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddOLAEnding = "//div[@class='emailTemplatesOLA']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-2']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddAssistMeNotifyUserAssistMe = "//div[@class='emailTemplatesClient']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-1']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";
        public string ButtonAddAssistMeNotifyOrderAssistMe = "//div[@class='emailTemplatesClient']/div[@id='rightsidebar']/div/div/div/div[@id='tabs-2']/div/form/div/div[@class='row config']/div[@class='col tokens']/div/input[@id='btnAddToken']";

        public string ListGeneralRecord = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListGeneralAssigment = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListGeneralDelay = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-3']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListGeneralChangeOfSpecialist = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-4']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListGeneralCancellation = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-5']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListGeneralExecuted = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-6']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListGeneralEnrollment = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-7']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListGeneralProviders = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-8']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListSurveySatisSurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListSurveySatisAlert = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListSurveyNotifySurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-3']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListSurveySummarySurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-4']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListSLAReview = "//div[@class='emailTemplatesSLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListSLAEnding = "//div[@class='emailTemplatesSLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListUCReview = "//div[@class='emailTemplatesUC']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListUCEnding = "//div[@class='emailTemplatesUC']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListOLAReview = "//div[@class='emailTemplatesOLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListOLAEnding = "//div[@class='emailTemplatesOLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListAssistMeNotifyUserAssistMe = "//div[@class='emailTemplatesClient']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";
        public string ListAssistMeNotifyOrderAssistMe = "//div[@class='emailTemplatesClient']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/div/a";

        public string OptionGeneralRecord = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionGeneralAssigment = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionGeneralDelay = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-3']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionGeneralChangeOfSpecialist = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-4']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionGeneralCancellation = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-5']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionGeneralExecuted = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-6']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionGeneralEnrollment = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-7']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionGeneralProviders = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-8']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionSurveySatisSurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionSurveySatisAlert = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionSurveyNotifySurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-3']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionSurveySummarySurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-4']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionSLAReview = "//div[@class='emailTemplatesSLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionSLAEnding = "//div[@class='emailTemplatesSLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionUCReview = "//div[@class='emailTemplatesUC']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionUCEnding = "//div[@class='emailTemplatesUC']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionOLAReview = "//div[@class='emailTemplatesOLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionOLAEnding = "//div[@class='emailTemplatesOLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionAssistMeNotifyUserAssistMe = "//div[@class='emailTemplatesClient']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";
        public string OptionAssistMeNotifyOrderAssistMe = "//div[@class='emailTemplatesClient']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/form/div[@class='row  top']/div[@class='row config']/div[@class='col tokens']/div/div/div/ul/li/a/label";

        public string TabGeneralRecord = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-1']";       
        public string TabGeneralAssigment = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-2']";
        public string TabGeneralDelay = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-3']";
        public string TabGeneralChangeOfSpecialist = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-4']";
        public string TabGeneralCancellation = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-5']";
        public string TabGeneralExecuted = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-6']";
        public string TabGeneralEnrollment = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-7']";
        public string TabGeneralProviders = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-8']";
        public string TabSurveySatisSurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-1']";
        public string TabSurveySatisAlert = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-2']";
        public string TabSurveyNotifySurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-3']";
        public string TabSurveySummarySurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-4']";
        public string TabSLAReview = "//div[@class='emailTemplatesSLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-1']";
        public string TabSLAEnding = "//div[@class='emailTemplatesSLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-2']";
        public string TabUCReview = "//div[@class='emailTemplatesUC']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-1']";
        public string TabUCEnding = "//div[@class='emailTemplatesUC']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-2']";
        public string TabOLAReview = "//div[@class='emailTemplatesOLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-1']";
        public string TabOLAEnding = "//div[@class='emailTemplatesOLA']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-2']";
        public string TabAssistMeNotifyUserAssistMe = "//div[@class='emailTemplatesClient']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-1']";
        public string TabAssistMeNotifyOrderAssistMe = "//div[@class='emailTemplatesClient']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-2']";
        public string SaveTemplateGeneral = "//div[@class='emailTemplates']/div[@id='rightsidebar']/div/div[@class='row bottom comments']/div/input[@id='btnSave']";
        public string SaveTemplateSurvey = "//div[@class='emailTemplatesSurveys']/div[@id='rightsidebar']/div/div[@class='row bottom comments']/div/input[@id='btnSave']";
        public string SaveTemplateSLA = "//div[@class='emailTemplatesSLA']/div[@id='rightsidebar']/div/div[@class='row bottom comments']/div/input[@id='btnSave']";
        public string SaveTemplateUC = "//div[@class='emailTemplatesUC']/div[@id='rightsidebar']/div/div[@class='row bottom comments']/div/input[@id='btnSave']";
        public string SaveTemplateOLA = "//div[@class='emailTemplatesOLA']/div[@id='rightsidebar']/div/div[@class='row bottom comments']/div/input[@id='btnSave']";
        public string SaveTemplateAssistMe = "//div[@class='emailTemplatesClient']/div[@id='rightsidebar']/div/div[@class='row bottom comments']/div/input[@id='btnSave']";
    }
}