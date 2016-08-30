using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeaveTracker.Startup))]
namespace LeaveTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
