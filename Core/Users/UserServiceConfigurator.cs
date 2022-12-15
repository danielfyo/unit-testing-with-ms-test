using Core.Mail;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Users;

public static class UserServiceConfigurator
{
    public static void ConfigureUserService(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
        services.ConfigureMailService();
    }
}