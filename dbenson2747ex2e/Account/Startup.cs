using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dbenson2747ex2e.Startup))]
namespace dbenson2747ex2e
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
