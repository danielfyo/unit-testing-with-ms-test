namespace Training.Calc.Test;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void AddPositiveValues_NegativeValues_()
    {
        var calculator = new Calculator();

        var operator1 = -5d;
        var operator2 = 10d;

        Assert.ThrowsException<InvalidInputValueException>(() => calculator.AddPositiveValues(operator1, operator2));
        
        operator1 = 5d;
        operator2 = -10d;

        Assert.ThrowsException<InvalidInputValueException>(() => calculator.AddPositiveValues(operator1, operator2));
    }
    
    [TestMethod]
    public void AddPositiveValues_PositiveValues_ReturnOperator1Plus2()
    {
        var calculator = new Calculator();

        var operator1 = 5;
        var operator2 = 10;
        var expectedResult = 15d;
        var result = calculator.AddPositiveValues(operator1, operator2);
        Assert.AreEqual(expectedResult, result);
    }
}