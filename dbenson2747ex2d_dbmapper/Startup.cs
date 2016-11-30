using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dbenson2747ex2d.Startup))]
namespace dbenson2747ex2d
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
