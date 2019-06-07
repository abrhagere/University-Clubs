using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MU_Clubs.Startup))]
namespace MU_Clubs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
