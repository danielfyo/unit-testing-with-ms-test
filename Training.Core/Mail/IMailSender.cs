namespace Training.Core.Mail;

public interface IMailSender
{
    bool SendEmail(string email, string message);
}