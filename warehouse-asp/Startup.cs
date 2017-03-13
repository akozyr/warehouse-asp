using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(warehouse_asp.Startup))]
namespace warehouse_asp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
