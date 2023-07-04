using Funq;
using ServiceStack;
using ChinookDemo.ServiceInterface;

[assembly: HostingStartup(typeof(ChinookDemo.AppHost))]

namespace ChinookDemo;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("ChinookDemo", typeof(MyServices).Assembly) {}

    public override void Configure(Container container)
    {
        // Configure ServiceStack only IOC, Config & Plugins
        SetConfig(new HostConfig {
            UseSameSiteCookies = true,
        });
    }
}
