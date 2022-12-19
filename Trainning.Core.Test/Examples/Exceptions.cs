namespace MSTest.Examples;

public class MyCustomException : Exception
{
    public MyCustomException()
    {
    }

    public MyCustomException(string message) : base(message)
    {
    }
}

[TestClass]
public class Exceptions
{
    [TestMethod]
    [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
    public void TestException_DerivedException_Success()
    {
        throw new MyCustomException();
    }
    
    [TestMethod]
    [ExpectedException(typeof(Exception), AllowDerivedTypes = false)]
    public void TestException_DerivedException_Fail()
    {
        throw new MyCustomException();
    }
    
    [TestMethod]
    [ExpectedException(typeof(MyCustomException))]
    public void TestException_ThrowException_HandleExceptionAndMessage()
    {
        var expectedMessage = "My custom message";
        try
        {
            throw new MyCustomException(expectedMessage);
        }
        catch (MyCustomException e)
        {
            Assert.AreEqual(expectedMessage, e.Message);
            throw;
        }
    }
    
    [TestMethod]
    public void TestException_HandleException()
    {
        Assert.ThrowsException<MyCustomException>(() => throw  new MyCustomException());
    }
}