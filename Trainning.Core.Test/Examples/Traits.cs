namespace MSTest.Examples;

[TestClass]
public class Traits
{
    [TestMethod]
    [TestCategory("Category 1")]
    [TestProperty("Test Group", "Performance")]
    [Owner("Test Owner")]
    [Priority(1)]
    public void Test1()
    {
    }
    
    [TestMethod]
    [TestCategory("Category 2")]
    [TestProperty("Test Group", "Security")]
    [Owner("Test Owner")]
    [Priority(2)]
    public void Test2()
    {
    }
    
    [TestMethod]
    [TestCategory("Category 1")]
    [TestProperty("Test Destination", "Quality Code")]
    [Owner("Test Owner")]
    [Priority(3)]
    public void Test3()
    {
    }
    
    [TestMethod]
    [TestCategory("Category 1")]
    [TestCategory("Category 2")]
    [TestProperty("Test Destination", "Deployment")]
    [Owner("Test Owner")]
    [Priority(4)]
    public void Test4()
    {
    }
}