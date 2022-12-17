using Training.Core.Mail;
using Microsoft.Extensions.DependencyInjection;
using Training.Core.Whatsapp;

namespace Training.Core.Users;

public static class UserServiceConfigurator
{
    public static void ConfigureUserService(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
        services.ConfigureMailService();
        services.ConfigureWhatsappService();
    }
}