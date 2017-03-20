using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingWebSite.Startup))]
namespace ShoppingWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
