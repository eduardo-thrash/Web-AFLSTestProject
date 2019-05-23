namespace AFLSUIProjectTest.UIMap.AssistMe
{
    public class ElementsAssistMeLogIn
    {
        public string AssistMeLogInModule = "AssistMe LogIn";

        public string AssistMeUserName = "assistMeUser";
        public string AssistMeUserPass = "assistMePass";
        public string AssistMeRequestId = "requestId";
        public string AssistMeRequestIdButton = "span.icon-forward-arrow";
        public string AssistMeLogInButton = "loginBtn";

        public string AssistMeAlertsMessages = "div.assistme-alert.error";
        public string AssistMeLogInAlertsMessages = "div.login-alerts-box";
    }

    public class ElementsAssistMeRegister
    {
        public string AssistMeRegisternModule = "AssistMe Register";

        public string LinkRegisterClient = "#login-form > div > div.col-xs-12.col-sm-12.register-link-container > a"; //CssSelector
        public string TextLinkRegisterClient = "Link Register";

        public string InputNameRegisterClient = "Name";//Id

        public string InputAddressRegisterClient = "addressReadOnly"; //Id
        public string InputAddressDetailRegisterClient = "addressDetail"; //Id
        public string InputControldAddressRegisterClient = "addressLabel"; //Id
        public string ButtontControldAddressRegisterClient = "confirmLocation"; //Id

        public string InputPhoneRegisterClient = "Phone"; //Id
        public string InputEmailRegisterClient = "Email"; //Id
        public string InputUserIdRegisterClient = "UniqueCode"; //Id
        public string InputPasswordRegisterClient = "Password"; //Id
        public string InputPasswordConfirmRegisterClient = "ConfirmPassword"; //Id

        public string AlertName = "//span[contains(@data-for, 'Name')]"; //XPath
        public string AlertEmail = "//span[contains(@data-for, 'Email')]"; //XPath
        public string AlertUserId = "//span[contains(@data-for, 'UniqueCode')]"; //XPath
        public string AlertPassword = "//span[contains(@data-for, 'Password')]"; //XPath
        public string AlertConfirmPassword = "//span[contains(@data-for, 'ConfirmPassword')]"; //XPath

        //Copy Fields
        public string TextInputNameRegisterClient = "Name client";

        public string TextInputAddressRegisterClient = "Address client";
        public string TextInputAddressDetailRegisterClient = "Address Detail";
        public string TextInputControldAddressRegisterClient = "Address";
        public string TextButtontControldAddressRegisterClient = "confirm Location";

        public string TextInputPhoneRegisterClient = "Phone client";
        public string TextInputEmailRegisterClient = "Email client";
        public string TextInputUserIdRegisterClient = "Identification client";
        public string TextInputPasswordRegisterClient = "Password client";
        public string TextInputPasswordConfirmRegisterClient = "Password confirm client";

        public string ButtonSubmit = "submitRegisterForm";//Id
        public string TextButtonSubmit;

        public string AssistMeLogInButton = "loginBtn";
    }
}