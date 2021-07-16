using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TH_WEB456.Startup))]
namespace TH_WEB456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
