namespace Training.Calc.Test;

[TestClass]
public class CalculatorTest
{
    double operator1 = -1d;
    double operator2 = 10d;

    [TestInitialize]
    public void DecreaseNegativesBeforeExecution()
    {
        if (operator1 < 0)
            operator1--;
    }
    
    [TestCleanup]
    public void IncreaseNegativesBeforeExecution()
    {
        if (operator1 < 0)
            operator1++;
    }

    [TestMethod]
    public void AddPositiveValues_NegativeValues_FirstTest()
    {
        var calculator = new Calculator();

        Assert.ThrowsException<InvalidInputValueException>(() => calculator.AddPositiveValues(operator1, operator2));
        Assert.ThrowsException<InvalidInputValueException>(() => calculator.AddPositiveValues(operator1, operator2));
    }
    
    [TestMethod]
    public void AddPositiveValues_NegativeValues_SecondTest()
    {
        var calculator = new Calculator();

        Assert.ThrowsException<InvalidInputValueException>(() => calculator.AddPositiveValues(operator1, operator2));
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