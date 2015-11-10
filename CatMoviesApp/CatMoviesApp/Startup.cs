using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatMoviesApp.Startup))]
namespace CatMoviesApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
