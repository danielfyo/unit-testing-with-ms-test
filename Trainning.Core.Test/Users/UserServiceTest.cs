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

    [TestMethod]
    public void CreateUser_NormalScenario_ShouldCallIMailSenderSendEmailOnce()
    {
        var services = new ServiceCollection();
        services.AddTransient<IUserService, UserService>();
        
        Mock<IMailSender> mockMailService = new ();
        mockMailService
            .Setup(mock => mock.SendEmail(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(()=> false);
        services.AddTransient(_ => mockMailService.Object);

        Mock<IWhatsappService> mockWhatsappService = new ();
        mockWhatsappService.Setup(mock => mock.SendMessage(It.IsAny<string>(), It.IsAny<string>()));
        services.AddTransient(_ => mockWhatsappService.Object);
            
        var serviceProvider = services.BuildServiceProvider();
        _userService = serviceProvider.GetRequiredService<IUserService>();
        
        _userService.CreateUser(new UserDto());
        mockMailService.Verify(m=>m.SendEmail(It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(2));
        mockWhatsappService.Verify(m=>m.SendMessage(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }
    
    [TestMethod]
    public void CreateUser_MailServiceFail_ShouldCallWhatsappHelperSendMessage()
    {
        var services = new ServiceCollection();
        services.AddTransient<IUserService, UserService>();
        
        Mock<IMailSender> mockMailService = new ();
        mockMailService
            .Setup(mock => mock.SendEmail(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(()=> true);
        services.AddTransient(_ => mockMailService.Object);

        Mock<IWhatsappService> mockWhatsappService = new ();
        mockWhatsappService.Setup(mock => mock.SendMessage(It.IsAny<string>(), It.IsAny<string>()));
        services.AddTransient(_ => mockWhatsappService.Object);
            
        var serviceProvider = services.BuildServiceProvider();
        _userService = serviceProvider.GetRequiredService<IUserService>();
        
        _userService.CreateUser(new UserDto());
        mockMailService.Verify(m=>m.SendEmail(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        mockWhatsappService.Verify(m=>m.SendMessage(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }
}