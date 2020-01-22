using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cn894815_mis4200.Startup))]
namespace cn894815_mis4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
