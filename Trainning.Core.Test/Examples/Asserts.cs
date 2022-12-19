namespace MSTest.Examples;

[TestClass]
public class Asserts
{
    [TestMethod]
    public void AreEqual()
    {
        Assert.AreEqual(1, 1);
    }
    
    [TestMethod]
    public void AreNotEqual()
    {
    }
    
    [TestMethod]
    public void AreSameEqual()
    {
    }
    
    [TestMethod]
    public void AreNotSameEqual()
    {
    }
    
    [TestMethod]
    public void Fail()
    {
        Assert.Fail();
    }

    [TestMethod]
    public void Inconclusive()
    {
    }
    
    [TestMethod]
    public void IsTrue()
    {
    }
    
    [TestMethod]
    public void IsFalse()
    {
    }

    [TestMethod]
    public void IsNull()
    {
    }
    
    [TestMethod]
    public void IsNotNull()
    {
    }
    
    [TestMethod]
    public void IsInstanceOfType()
    {
    }
}