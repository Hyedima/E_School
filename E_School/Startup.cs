using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_School.Startup))]
namespace E_School
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
