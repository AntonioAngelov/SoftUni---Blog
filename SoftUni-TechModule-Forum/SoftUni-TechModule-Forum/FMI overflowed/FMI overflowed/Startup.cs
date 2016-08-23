using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FMI_overflowed.Startup))]
namespace FMI_overflowed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
