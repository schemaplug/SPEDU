using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SPEDU.Web.Startup))]
namespace SPEDU.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
