using Microsoft.AspNetCore.Hosting;
using Microsoft.Bot.Builder;
using System;

[assembly: HostingStartup(typeof(Preview.Bot.Component.CustomAction.CallCustomActionHostingStartup))]

namespace Preview.Bot.Component.CustomAction
{
    public class CallCustomActionHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            Console.WriteLine("CallCustomActionHostingStartup.TestHostingStartup");
            
            ComponentRegistration.Add(new CallCustomActionComponentRegistration());
            
            //builder.ConfigureServices(services =>
            //{
            //    // Create a factory with a GetServices method that can
            //    // be called in middleware to obtain a list of the app's
            //    // services.
            //    Func<IServiceProvider, IServiceDescriptorsService> factory =
            //        provider => new ServiceDescriptorsService(services);

            //    // Register the factory in the service container.
            //    services.AddSingleton(factory);

            //    // Implement a startup filter that is used to register 
            //    // two middleware components.
            //    services.AddSingleton<IStartupFilter, DiagnosticMiddlewareStartupFilter>();
            //});
        }
    }
}