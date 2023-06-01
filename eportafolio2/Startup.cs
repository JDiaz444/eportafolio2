using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eportafolio2.Startup))]
namespace eportafolio2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
