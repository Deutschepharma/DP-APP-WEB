using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistema_DP.Startup))]
namespace Sistema_DP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
