using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerViewer.Startup))]
namespace CustomerViewer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
