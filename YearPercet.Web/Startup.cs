using Microsoft.Owin;

using YearPercet.Web;

[assembly: OwinStartup(typeof(Startup))]

namespace YearPercet.Web
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}