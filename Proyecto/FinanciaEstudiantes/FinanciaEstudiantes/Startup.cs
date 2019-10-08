using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinanciaEstudiantes.Startup))]
namespace FinanciaEstudiantes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
