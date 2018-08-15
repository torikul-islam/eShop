using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eShop.Startup))]
namespace eShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
