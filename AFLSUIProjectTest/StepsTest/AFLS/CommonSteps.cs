using AFLSUIProjectTest.CommonAFLS;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.AFLS
{
    [Binding]
    public sealed class AFLSCommonSteps
    {
        private Logout Logout = new Logout();

        [Then(@"Realizo cierre de sesión de la aplicación con usuario administrador")]
        public void ThenRealizoCierreDeSesionDeLaAplicacionConUsuarioAdministrador()
        {
            Logout.AdministratorLogOff();
        }
    }
}