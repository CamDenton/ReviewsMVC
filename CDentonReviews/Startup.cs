using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDentonReviews.Startup))]
namespace CDentonReviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
