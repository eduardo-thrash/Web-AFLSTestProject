using AFLSUIProjectTest.StepsTest;

namespace AFLSUIProjectTest.CommonAFLS
{
    public class Login
    {
        private LoginLogoutSteps AFLSLogin = new LoginLogoutSteps();

        public void AdministratorLogin()
        {
            AFLSLogin.WhenIngresoNombreDeUsuarioAdministradorValido("administrator");
            AFLSLogin.WhenIngresoContrasenaDeUsuarioAdministradorValido();
            AFLSLogin.WhenDoyClickEnLogin();
            AFLSLogin.ThenAccedoALaPantallaPrincipalDeConfiguracion();
        }
    }
}