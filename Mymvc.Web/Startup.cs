using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mymvc.Web.Startup))]
namespace Mymvc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
