namespace MSTest.Examples;

[TestClass]
public class TimeOut
{
    [TestMethod]
    [Timeout(2000)] //milliseconds
    public void TimeOutSuccess()
    {
        Thread.Sleep(1900);
    }
    
    [TestMethod]
    [Timeout(2000)] //milliseconds
    public void TimeOutFail()
    {
        Thread.Sleep(2500);
    }
}