# Preview.Bot.Component.CustomAction
Adaptive CallCustomCodeAction packaged with IHostingStartup


See also: ASPNETCORE_PREVENTHOSTINGSTARTUP  

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
