using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NPCgenerator.WebMVC.Startup))]
namespace NPCgenerator.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
