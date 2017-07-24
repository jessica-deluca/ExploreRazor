using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExporeRazor.Startup))]
namespace ExporeRazor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
