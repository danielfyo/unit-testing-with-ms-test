namespace MSTest.AccessModifiers;

[TestClass]
public class AccessModifiersTest
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


    public abstract class PersonBase
    {
        public string Nombre { get; set; }

        public virtual void Crear(string value, string nombre)
        {
            Nombre = nombre;
        }
    }

    public class Employee : PersonBase
    {
        public string Code { get; set; }
        
        public override void Crear(string value, string nombre)
        {
            Code = value;
            base.Crear(value, nombre);
        }
    }
    
    public class Customer : PersonBase
    {
        public string Id { get; set; }
        
        public override void Crear(string value, string nombre)
        {
            Id = value;
            base.Crear(value, nombre);
        }
    }
}