using Microsoft.Extensions.DependencyInjection;
using Moq;
using Training.Core.Mail;
using Training.Core.Users;
using Training.Core.Whatsapp;

namespace MSTest.Users;

[TestClass]
public class UserServiceTest
{
    private IUserService _userService;
    private Mock<IMailSender> mockMailService = new ();
    Mock<IWhatsappService> mockWhatsappService = new ();

    public UserServiceTest()
    {
        var services = new ServiceCollection();
        services.AddTransient<IUserService, UserService>();
        
        mockMailService
            .Setup(mock => mock
                .SendEmail(It.Is<string>(p => p == "fail"), It.IsAny<string>()))
            .Returns(()=> false);

        mockMailService
            .Setup(mock => mock
                .SendEmail(It.Is<string>(p => p == "works"), It.IsAny<string>()))
            .Returns(()=> true);
        
        
        services.AddTransient(_ => mockMailService.Object);

        mockWhatsappService.Setup(mock => mock.SendMessage(It.IsAny<string>(), It.IsAny<string>()));
        services.AddTransient(_ => mockWhatsappService.Object);
            
        var serviceProvider = services.BuildServiceProvider();
        _userService = serviceProvider.GetRequiredService<IUserService>();
    }

    [TestMethod]
    public void CreateUser_NormalScenario_ShouldCallIMailSenderSendEmailOnce()
    {
        var user = new UserDto
        {
            Email =  "fail"
        };
        _userService.CreateUser(user);
        mockMailService.Verify(m=>m.SendEmail(It.Is<string>(p => p == user.Email), It.IsAny<string>()), Times.Once);
        mockWhatsappService.Verify(m=>m.SendMessage(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }
    
    [TestMethod]
    public void CreateUser_MailServiceFail_ShouldCallWhatsappHelperSendMessage()
    {
        _userService.CreateUser(new UserDto
        {
            Email = "works"
        });
        mockMailService.Verify(m=>m.SendEmail(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        mockWhatsappService.Verify(m=>m.SendMessage(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }
}