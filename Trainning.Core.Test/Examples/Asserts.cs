using Training.Infrastructure.Core;

namespace MSTest.Examples;

[TestClass]
public class Asserts
{
    [TestMethod]
    public void AreEqual_Object()
    {
        var fakeClass1 = new FakeClass();
        fakeClass1.Name = "Daniel";
        
        var fakeClass2 = new FakeClass();
        fakeClass2.Name = "Daniel";
        
        Assert.AreEqual(fakeClass1, fakeClass2);
    }
    
    [TestMethod]
    public void AreNotEqual_Object()
    {
        var fakeClass1 = new FakeClass();
        fakeClass1.Name = "Daniel";
        
        var fakeClass2 = new FakeClass();
        fakeClass2.Name = "Felipe";
        
        Assert.AreNotEqual(fakeClass1, fakeClass2);
    }
    
    [TestMethod]
    public void AreEqual()
    {
        var expectedValue = "hola";
        var currentValue = "hola";
        
        Assert.AreEqual(expectedValue, currentValue, "El valor {0} no es igual al valor {1}", expectedValue, currentValue);
    }
    
    [TestMethod]
    public void AreNotEqual()
    {
        var expectedValue = 1;
        var currentValue = 2;
        
        Assert.AreNotEqual(expectedValue, currentValue, "El valor {0} no es igual al valor {1}", expectedValue, currentValue);
    }
    
    [TestMethod]
    public void AreNotSameEqual_WithDifferentPointers_ReturnFalse()
    {
        var fakeClass1 = new FakeClass();
        fakeClass1.Name = "Daniel";
        
        var fakeClass2 = new FakeClass();
        fakeClass2.Name = "Daniel";
        
        Assert.AreNotSame(fakeClass1, fakeClass2);
    }
    
    [TestMethod]
    public void AreSameEqual_WithSamePointers_ReturnTrue()
    {
        var fakeClass1 = new FakeClass();
        fakeClass1.Name = "Daniel";

        var fakeClass2 = fakeClass1;
        
        Assert.AreSame(fakeClass1, fakeClass2);
    }

    [TestMethod]
    public void Fail()
    {
        Assert.Fail("Not implemented");
    }

    [TestMethod]
    public void Inconclusive()
    {
        Assert.Inconclusive("TODO");
    }
    
    [TestMethod]
    public void IsTrue()
    {
        var isValidEmail = true;
        Assert.IsTrue(isValidEmail);
    }
    
    [TestMethod]
    public void IsFalse()
    {
        var isValidEmail = false;
        Assert.IsFalse(isValidEmail);
    }

    [TestMethod]
    public void IsNull()
    {
        string name = null;
        Assert.IsNull(name);
    }
    
    [TestMethod]
    public void IsNotNull()
    {
        string name = "fake-name";
        Assert.IsNotNull(name);
    }
    
    [TestMethod]
    public void IsInstanceOfType()
    {
        Assert.IsInstanceOfType(new ChildFakeClass(), typeof(FakeClass));
        Assert.IsInstanceOfType(new FakeClass(), typeof(FakeClass));
    }
    
    [TestMethod]
    public void IsNotInstanceOfType()
    {
        Assert.IsNotInstanceOfType(new NonChildFakeClass(), typeof(FakeClass));
    }
}

public class ChildFakeClass : FakeClass
{
}

public class NonChildFakeClass
{
}