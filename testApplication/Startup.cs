using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testApplication.Startup))]
namespace testApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
