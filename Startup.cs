using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductManagementWithAuthenticationAndAuthorization.Startup))]
namespace ProductManagementWithAuthenticationAndAuthorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
