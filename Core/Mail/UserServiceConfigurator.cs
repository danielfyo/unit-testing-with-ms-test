using Microsoft.Extensions.DependencyInjection;

namespace Core.Mail;

public static class MailServiceConfigurator
{
    public static void ConfigureMailService(this IServiceCollection services)
    {
        services.AddSingleton<IMailSender, MailSender>();
    }
}