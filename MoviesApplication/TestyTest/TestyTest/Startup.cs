using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestyTest.Startup))]
namespace TestyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
