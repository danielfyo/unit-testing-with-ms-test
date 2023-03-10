using Training.Core.Mail;
using Training.Core.Whatsapp;

namespace Training.Core.Users;

internal class UserService : IUserService
{
    private readonly IMailSender _mailService;
    private readonly IWhatsappService _whatsappService;
       
    public UserService(IMailSender mailService, IWhatsappService whatsappService)
    {
        _mailService = mailService;
        _whatsappService = whatsappService;
    }

    public void CreateUser(UserDto user)
    {
        if(!_mailService.SendEmail(user.Email, "message"))
            _whatsappService.SendMessage(user.PhoneNumber, "Welcome!");
    }

    public IEnumerable<UserDto> GetUsers(string rol)
    {
        return null;
    }
}