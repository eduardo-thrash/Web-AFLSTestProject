using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFLSUIProjectTest.StepsTest.AFLS;


namespace AFLSUIProjectTest.CommonAFLS
{
    public class Logout
    {
        LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();

        public void AdministratorLogOff()
        {
            LoginLogoutSteps.WhenPulsoLinkDeCierreDeSesion();
            LoginLogoutSteps.ThenSeCierraLaSesionExitosamenteDelUsuarioAdministrador();
        }
    }
}
