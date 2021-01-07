# Preview.Bot.Component.CustomAction
Adaptive CallCustomCodeAction packaged with IHostingStartup


See also: [Specify the hosting startup assembly](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/platform-specific-configuration?view=aspnetcore-5.0#specify-the-hosting-startup-assembly)


```csharp
[assembly: HostingStartup(typeof(Preview.Bot.Component.CustomAction.CallCustomActionHostingStartup))]

namespace Preview.Bot.Component.CustomAction
{
    public class CallCustomActionHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            Console.WriteLine("CallCustomActionHostingStartup.Configure");
            
            ComponentRegistration.Add(new CallCustomActionComponentRegistration());
        }
    }
}
```
See:
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/platform-specific-configuration
