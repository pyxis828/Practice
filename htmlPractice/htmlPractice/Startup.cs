using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(htmlPractice.Startup))]
namespace htmlPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
