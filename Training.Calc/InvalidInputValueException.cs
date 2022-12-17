namespace Training.Calc;

public class InvalidInputValueException : Exception
{
    public InvalidInputValueException()
    {
        
    }
    public InvalidInputValueException(string message) : base(message)
    {
    }
}