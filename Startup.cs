using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopAviator.Startup))]
namespace ShopAviator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
