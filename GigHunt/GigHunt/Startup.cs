using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHunt.Startup))]
namespace GigHunt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
