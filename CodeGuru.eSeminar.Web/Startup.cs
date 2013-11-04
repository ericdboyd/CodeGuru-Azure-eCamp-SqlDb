using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeGuru.eSeminar.Web.Startup))]
namespace CodeGuru.eSeminar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
