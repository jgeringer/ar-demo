using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(techdemo.Startup))]
namespace techdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
