using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Convergr.NET.Startup))]
namespace Convergr.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
