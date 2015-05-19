using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(koyaTracker.Startup))]
namespace koyaTracker
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
