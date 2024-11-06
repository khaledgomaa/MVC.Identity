using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.Demo.Identity.Startup))]
namespace MVC.Demo.Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
