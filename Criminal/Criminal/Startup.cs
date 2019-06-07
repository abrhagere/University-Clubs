using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Criminal.Startup))]
namespace Criminal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
