using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBConnect.Startup))]
namespace DBConnect
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
