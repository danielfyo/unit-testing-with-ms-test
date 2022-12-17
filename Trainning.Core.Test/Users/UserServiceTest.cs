using Microsoft.Extensions.DependencyInjection;
using Training.Core.Users;

namespace MSTest.Users;

[TestClass]
public class UserServiceTest
{
    private readonly IUserService _userService;
    public UserServiceTest()
    {
        var services = new ServiceCollection();
        services.ConfigureUserService();
        var serviceProvider = services.BuildServiceProvider();
        
        _userService = serviceProvider.GetRequiredService<IUserService>();
    }

    [TestMethod]
    public void CreateUser_EmptyParameter_ThrowException()
    {
        Assert.ThrowsException<NotImplementedException>(() => _userService.CreateUser(new UserDto()));
    }

    [TestMethod]
    public void GetUsers_RolEmpty_ReturnNull()
    {
        var response = _userService.GetUsers(string.Empty);
        Assert.IsNull(response);
    }
}