using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRRP.Startup))]
namespace CRRP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
