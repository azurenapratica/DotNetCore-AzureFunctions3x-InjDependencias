using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using ServerlessDI.Interfaces;
using ServerlessDI.Implementations;

[assembly: FunctionsStartup(typeof(ServerlessDI.Startup))]
namespace ServerlessDI
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<ITesteA, TesteA>();
            builder.Services.AddTransient<ITesteB, TesteB>();
            builder.Services.AddScoped<TesteC>();
            
            builder.Services.AddTransient<TesteInjecao>();
        }
    }
}