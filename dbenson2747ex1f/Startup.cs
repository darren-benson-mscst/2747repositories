using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dbenson2747ex1f.Startup))]
namespace dbenson2747ex1f
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
