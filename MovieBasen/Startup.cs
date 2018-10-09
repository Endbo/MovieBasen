using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieBasen.Startup))]
namespace MovieBasen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
