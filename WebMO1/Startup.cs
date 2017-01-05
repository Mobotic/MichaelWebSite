using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMO1.Startup))]
namespace WebMO1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
