using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppTutorialYoutube.Startup))]
namespace AppTutorialYoutube
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
