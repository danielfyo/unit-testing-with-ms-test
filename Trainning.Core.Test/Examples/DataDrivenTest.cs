using Training.Infrastructure.Core;

namespace MSTest.Examples;

[TestClass]
public class DataDrivenTest
{
    public TestContext TestContext { get; set; }

    [TestMethod]
    public void FromFixedData(int param1, int param2)
    {
        var expectedValue = "fake value";
        Assert.AreEqual(expectedValue, new FakeClass().Name);
    }
    
    [TestMethod]
    [DataSource("System.Data.SqlClient", 
        "Data Source=localhost;Initial Catalog=db-test;Persist Security Info=True;User ID=SA; Password=SecretPassword@0918273456; MultipleActiveResultSets=True",
        "Customer",
        DataAccessMethod.Sequential)]
    public void FromFixedData()
    {
        var expectedValue = "fake value";
        Assert.AreEqual(expectedValue, new FakeClass().Name);
    }
}