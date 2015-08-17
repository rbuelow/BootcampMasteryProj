using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RyanNickMasteryProject.Startup))]
namespace RyanNickMasteryProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
