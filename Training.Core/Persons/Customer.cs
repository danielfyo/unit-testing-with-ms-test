using System.Text.RegularExpressions;

namespace Training.Core.Persons;

internal class Customer : PersonBase
{
    public string Id { get; set; }
    
    private string _email;

    public void SetEmail(string email)
    {
        _email = IsValidEmail(email) ? email : throw new InvalidEmailException($"{email} is not a valid input for email");
    }

    private bool IsValidEmail(string email)
    {
        var regex = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");
        return regex.Match(email).Success;
    }
    
    public string GetEmail() => _email;
    
    public override void Crear(string value, string nombre)
    {
        Id = value;
        base.Crear(value, nombre);
    }
}