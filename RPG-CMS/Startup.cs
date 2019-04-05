using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPG_CMS.Startup))]
namespace RPG_CMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
