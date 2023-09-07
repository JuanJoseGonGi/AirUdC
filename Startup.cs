using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirUdC.Startup))]
namespace AirUdC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
