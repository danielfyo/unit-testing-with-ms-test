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
        services.ConfigureUserService();
        var serviceProvider = services.BuildServiceProvider();
        
        var userService = serviceProvider.GetRequiredService<IUserService>();
        Assert.ThrowsException<NotImplementedException>(() => userService.CreateUser(new UserDto()));
    }
}