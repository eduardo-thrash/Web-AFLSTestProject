using AFLSUIProjectTest.StepsTest;
using AFLSUIProjectTest.StepsTest.AFLS;

namespace AFLSUIProjectTest.CommonAFLS
{
    public class Login
    {
        public LoginLogoutSteps AFLSLogin = new LoginLogoutSteps();

        public void AdministratorLogin()
        {
            AFLSLogin.WhenIngresoNombreDeUsuarioAdministradorValido("administrator");
            AFLSLogin.WhenIngresoContrasenaDeUsuarioAdministradorValido();
            AFLSLogin.WhenDoyClickEnLogin();
            AFLSLogin.ThenAccedoALaPantallaPrincipalDeConfiguracion();
        }
    }
}