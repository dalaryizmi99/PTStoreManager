using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PTStoreManager.Startup))]
namespace PTStoreManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
