using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(examples01.Startup))]
namespace examples01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
