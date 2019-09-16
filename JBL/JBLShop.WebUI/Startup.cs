using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JBLShop.WebUI.Startup))]
namespace JBLShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
