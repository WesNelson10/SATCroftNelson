using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SATCroftNelson.UI.MVC.Startup))]
namespace SATCroftNelson.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
