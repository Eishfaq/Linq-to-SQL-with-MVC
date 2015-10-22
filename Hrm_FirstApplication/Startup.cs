using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hrm_FirstApplication.Startup))]
namespace Hrm_FirstApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
