using System.Diagnostics.CodeAnalysis;
using Training.Infrastructure.Core;

namespace MSTest.Examples;

[TestClass]
public class Ignore
{
    [TestMethod]
    [Ignore]
    public void TestCoverage()
    {
        new FakeClass().GetHashCode();
    }
    
    [TestMethod]
    [Ignore]
    public void WholeTest()
    {
        Assert.Fail();
    }
}