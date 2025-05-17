using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAuthUsingIdentity.Startup))]
namespace MVCAuthUsingIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
