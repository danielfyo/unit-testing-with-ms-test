using System.Reflection;

namespace MSTest.Examples;

[TestClass]
public class PrivateMethods
{
    public class FakeClass
    {
        private bool PrivateMethod(string? anyValue) => anyValue != null;
    }
    
    [TestMethod]
    public void PrivateClass_PrivateMethod_Success()
    {
        var anyValue = "fake-value";
        var customer = new FakeClass();
        var methodInfo = typeof(FakeClass).GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
        object[] parameters = { anyValue };
        var isValid = methodInfo.Invoke(customer, parameters) as bool?;
        Assert.IsTrue(isValid);
    }
    
    [TestMethod]
    public void PrivateClass_PrivateMethod_Fail()
    {
        string anyValue = null;
        var customer = new FakeClass();
        var methodInfo = typeof(FakeClass).GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
        object[] parameters = { anyValue };
        var isValid = methodInfo.Invoke(customer, parameters) as bool?;
        Assert.IsTrue(isValid);
    }
}