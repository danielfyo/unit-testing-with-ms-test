namespace Training.Core.Whatsapp;

public interface IWhatsappService
{ 
    bool SendMessage(string phoneNumber, string message);
}