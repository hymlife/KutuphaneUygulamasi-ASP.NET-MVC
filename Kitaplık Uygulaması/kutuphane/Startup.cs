using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kutuphane.Startup))]
namespace kutuphane
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
