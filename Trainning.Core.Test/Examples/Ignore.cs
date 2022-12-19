using System.Diagnostics.CodeAnalysis;

namespace MSTest.Examples;

[TestClass]
public class Ignore
{
    [TestMethod]
    [ExcludeFromCodeCoverage]
    public void TestCoverage()
    {
    }
    
    [TestMethod]
    [Ignore]
    public void WholeTest()
    {
    }
}