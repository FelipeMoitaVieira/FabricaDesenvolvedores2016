using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fiap.Exemplo5.Web.MVC.Startup))]
namespace Fiap.Exemplo5.Web.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
