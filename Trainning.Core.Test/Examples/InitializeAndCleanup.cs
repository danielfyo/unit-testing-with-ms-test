namespace MSTest.Examples;

[TestClass]
public class InitializeAndCleanup
{
    [TestInitialize]
    public void ExecutedBeforeEachTest()
    {
    }
    
    [TestCleanup]
    public void ExecutedAfterEachTest()
    {
    }
    
    [ClassInitialize]
    public static void ExecutedBeforeEachTestClass()
    {
    }
    
    [ClassCleanup]
    public static void ExecutedAfterEachTestClass()
    {
    }
    
    [AssemblyInitialize]
    public static void ExecutedBeforeEachTestAssembly()
    {
    }
    
    [AssemblyCleanup]
    public static void ExecutedAfterEachTestAssembly()
    {
    }
    
    [TestMethod]
    public void Test()
    {
    }
    
}