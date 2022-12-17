namespace Training.Core.Persons;

public  class InvalidEmailException : Exception
{
    public InvalidEmailException(string message) : base(message)
    {
    }
}