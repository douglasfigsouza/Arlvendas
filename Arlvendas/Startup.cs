using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arlvendas.Startup))]
namespace Arlvendas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
