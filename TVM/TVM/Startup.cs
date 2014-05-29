using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TVM.Startup))]
namespace TVM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
