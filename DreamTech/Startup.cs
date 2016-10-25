using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DreamTech.Startup))]
namespace DreamTech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
