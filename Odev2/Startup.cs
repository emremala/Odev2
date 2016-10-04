using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Odev2.Startup))]
namespace Odev2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
