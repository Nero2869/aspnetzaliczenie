using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuctionSystem.Startup))]
namespace AuctionSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
