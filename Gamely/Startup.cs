using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gamely.Startup))]
namespace Gamely
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
