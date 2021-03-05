using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PASSION_PROJECT_MVP.Startup))]
namespace PASSION_PROJECT_MVP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
