using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteAspNet.Startup))]
namespace WebSiteAspNet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
