using AFLSUIProjectTest.StepsTest.AFLS;
using System.Threading;

namespace AFLSUIProjectTest.CommonAFLS
{
    public class Logout
    {
        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();

        public void AdministratorLogOff()
        {
            Thread.Sleep(2000);
            LoginLogoutSteps.WhenPulsoLinkDeCierreDeSesion();
            LoginLogoutSteps.ThenSeCierraLaSesionExitosamenteDelUsuarioAdministrador();
        }
    }
}