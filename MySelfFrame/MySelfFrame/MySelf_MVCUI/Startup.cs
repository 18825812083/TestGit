using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySelf_MVCUI.Startup))]
namespace MySelf_MVCUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
