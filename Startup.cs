using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolutionCenterWebApp.Startup))]
namespace SolutionCenterWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
