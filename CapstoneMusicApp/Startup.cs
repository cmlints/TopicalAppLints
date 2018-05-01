using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapstoneMusicApp.Startup))]
namespace CapstoneMusicApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
