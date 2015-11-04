using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeChat.Startup))]
namespace WeChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
