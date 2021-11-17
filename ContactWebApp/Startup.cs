using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(finaltest.Startup))]
namespace finaltest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
