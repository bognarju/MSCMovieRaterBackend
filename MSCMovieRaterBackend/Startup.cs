using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MSCMovieRaterBackend.Startup))]

namespace MSCMovieRaterBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}