using Microsoft.Extensions.DependencyInjection;

namespace Training.Core.Whatsapp;

public static class WhatsappServiceConfigurator
{
    public static void ConfigureWhatsappService(this IServiceCollection services)
    {
        services.AddTransient<IWhatsappService, WhatsappService>();
    }
}