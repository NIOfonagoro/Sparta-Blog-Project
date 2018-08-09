using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sparta_Blog_Project.Startup))]
namespace Sparta_Blog_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
