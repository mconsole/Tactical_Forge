using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TacticalForge1.Startup))]
namespace TacticalForge1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
