using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainingPlanner.Startup))]
namespace TrainingPlanner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
