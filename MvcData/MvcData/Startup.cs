using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcData.Startup))]
namespace MvcData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
