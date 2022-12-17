using Microsoft.Extensions.DependencyInjection;
using Training.Core.Users;

namespace MSTest.Users;

[TestClass]
public class UserServiceTest
{
    private readonly IUserService _userService;
    private int startedTest = 0;
    private int testDone = 0;
    
    public UserServiceTest()
    {
        var services = new ServiceCollection();
        services.ConfigureUserService();
        var serviceProvider = services.BuildServiceProvider();
        
        _userService = serviceProvider.GetRequiredService<IUserService>();
    }

    [TestInitialize]
    public void IncreaseExeNum() => startedTest++;
    
    [TestCleanup]
    public void IncreaseTestExecuted() => testDone++;
    
    [TestMethod]
    public void CreateUser_EmptyParameter_ThrowException()
    {
        Assert.ThrowsException<NotImplementedException>(() => _userService.CreateUser(new UserDto()));
    }

    [TestMethod]
    public void GetUsers_RolEmpty_ReturnEmptyList()
    {
        var response = _userService.GetUsers(string.Empty);
        Assert.IsNull(response);
    }
}