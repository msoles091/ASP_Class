using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NbaPlayerStats.Domain.Startup))]
namespace NbaPlayerStats.Domain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
