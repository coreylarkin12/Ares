using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nessus.Startup))]
namespace Nessus
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
