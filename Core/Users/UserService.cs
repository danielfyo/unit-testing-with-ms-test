using Core.Mail;

namespace Core.Users;

public class UserService : IUserService
{
    private readonly IMailSender _mailService;
       
    public UserService(IMailSender mailService) => _mailService = mailService;

    public void CreateUser(UserDto user)
    {
        _mailService.SendEmail("email", "message");
        WhatsappHelper.SendMessage(user.PhoneNumber, "Welcome!");
    }

    public IEnumerable<UserDto> GetUsers()
    {
        return new List<UserDto>();
    }
}

public static class WhatsappHelper
{
    public static bool SendMessage(string phoneNumber, string message)
    {
        throw new TimeoutException("unable to access ...url");
        // _httpClient(...url);
        return true;
    }
}