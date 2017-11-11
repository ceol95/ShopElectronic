using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopElect.Startup))]
namespace ShopElect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
