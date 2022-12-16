using Microsoft.Extensions.DependencyInjection;

namespace Training.Core.Mail;

public static class MailServiceConfigurator
{
    public static void ConfigureMailService(this IServiceCollection services)
    {
        services.AddSingleton<IMailSender, MailSender>();
    }
}