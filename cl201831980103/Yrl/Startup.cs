using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cl201831980103.Startup))]
namespace cl201831980103
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
