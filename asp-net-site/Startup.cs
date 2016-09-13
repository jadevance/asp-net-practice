using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_net_site.Startup))]
namespace asp_net_site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
