using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson_14.Startup))]
namespace lesson_14
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
