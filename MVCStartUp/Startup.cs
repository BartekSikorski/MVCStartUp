using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCStartUp.Startup))]
namespace MVCStartUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
