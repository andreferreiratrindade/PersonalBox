using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalBox.MVC.Startup))]
namespace PersonalBox.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
