using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NSWRFS.Status.Startup))]
namespace NSWRFS.Status
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
