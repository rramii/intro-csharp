using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson_15.Startup))]
namespace lesson_15
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
