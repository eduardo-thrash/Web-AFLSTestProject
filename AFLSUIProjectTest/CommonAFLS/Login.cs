using AFLSUIProjectTest.StepsTest.AFLS;

namespace AFLSUIProjectTest.CommonAFLS
{
    public class Login
    {
        public LoginLogoutSteps AFLSLogin = new LoginLogoutSteps();

        public string UserAdministrator = "thrash";
        public string PassAdministrator = "123456";
        public string UserMonitor;
        public string UserInventory;
        public string UserDispatcher;

        public void AdministratorLogin()
        {
            AFLSLogin.WhenIngresoNombreDeUsuarioAdministradorValido(UserAdministrator);
            AFLSLogin.WhenIngresoContrasenaDeUsuarioAdministradorValido(PassAdministrator);
            AFLSLogin.WhenDoyClickEnLogin();
            AFLSLogin.ThenAccedoALaPantallaPrincipalDeConfiguracion();
        }
    }
}