using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gTest.Startup))]
namespace gTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
