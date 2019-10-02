using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumeWeb.Startup))]
namespace ResumeWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
