using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegEx.Startup))]
namespace RegEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
