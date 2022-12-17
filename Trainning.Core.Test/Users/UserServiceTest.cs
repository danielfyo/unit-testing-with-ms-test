using Microsoft.Extensions.DependencyInjection;
using Training.Core.Users;

namespace MSTest.Users;

[TestClass]
public class UserServiceTest
{
    [TestMethod]
    public void CreateUser_EmptyParameter_ThrowException()
    {
        var services = new ServiceCollection();
        services.ConfigureUserService();
        var serviceProvider = services.BuildServiceProvider();
        
        var userService = serviceProvider.GetRequiredService<IUserService>();
        Assert.ThrowsException<NotImplementedException>(() => userService.CreateUser(new UserDto()));
    }
}