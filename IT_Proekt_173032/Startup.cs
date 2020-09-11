using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_Proekt_173032.Startup))]
namespace IT_Proekt_173032
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
