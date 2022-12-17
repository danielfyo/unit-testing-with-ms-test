namespace Training.Calc;

public class Calculator
{
    public double AddPositiveValues(double operator1, double operator2)
    {
        if (operator1 < 0)
            throw new InvalidInputValueException($"{nameof(operator1)} is a negative value: {operator1}");
        
        if ( operator2 < 0)
            throw new InvalidInputValueException($"{nameof(operator2)} is a negative value: {operator2}");
        
        return operator1 + operator2;
    }
}