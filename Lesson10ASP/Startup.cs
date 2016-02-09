using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson10ASP.Startup))]
namespace Lesson10ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
