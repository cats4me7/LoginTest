using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginTest5.Startup))]
namespace LoginTest5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
