using Training.Core;
using Training.Core.Persons;

namespace Training.Calc.Test;

[TestClass]
public partial class AccessModifiersTest
{
    [TestMethod]
    public void AccessModifiers_ProtectedClass_ShouldBeVisibleToLowerLevels()
    {
        var value = "1234";
        var name = "daniel";
        
        var employee = new Employee();
        employee.Crear(value, name);
        Assert.AreEqual(value, employee.Code);
        Assert.AreEqual(name, employee.Nombre);

        var customer = new Customer();
        customer.Crear(value, name);
        Assert.AreEqual(value, customer.Id);
        Assert.AreEqual(name, customer.Nombre);
    }
}