using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(F1TeamManager.Startup))]
namespace F1TeamManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
