using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lostandfound4.Startup))]
namespace lostandfound4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
