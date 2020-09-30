using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProject1NIT.Startup))]
namespace MVCProject1NIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
