using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TramitesRelan.Startup))]
namespace TramitesRelan
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
