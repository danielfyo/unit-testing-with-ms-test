using Training.Core.Mail;
using Microsoft.Extensions.DependencyInjection;
using Training.Core.Users;

namespace MSTest.Users;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var services = new ServiceCollection();
        services.AddTransient<IUserService, UserService>();
        services.AddSingleton<IMailSender, FakeMailSender>();
        var serviceProvider = services.BuildServiceProvider();
        
        var userService = serviceProvider.GetRequiredService<IUserService>();
        userService.CreateUser(new UserDto());
    }
}

public class FakeMailSender : IMailSender
{
    public bool SendEmail(string email, string message)
    {
        return true;
    }
}