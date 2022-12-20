using System.Reflection;
using Training.Core.Persons;

namespace MSTest;

[TestClass]
public class CustomerTest
{
    [TestMethod]
    public void SetEmail_ValidEmail_GetEmailShouldReturnTheInputEmail()
    {
        var email = "danielfyo@hotmail.com";
        var customer = new Customer();
        customer.SetEmail(email);
        Assert.AreEqual(customer.GetEmail(), email);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidEmailException))]
    public void SetEmail_InvalidEmail_ShouldThrowInvalidEmailException()
    {
        var email = "danielfyo";

        try
        {
            var customer = new Customer();
            customer.SetEmail(email);
        }
        catch (InvalidEmailException e)
        {
            Assert.AreEqual($"{email} is not a valid input for email", e.Message);
            throw;
        }
    }
    
    [TestMethod]
    public void IsValidEmail_InvalidEmail_ShouldThrowInvalidEmailException()
    {
        var email = "danielfyo";
        var customer = new Customer();
        var methodInfo = typeof(Customer).GetMethod("IsValidEmail", BindingFlags.NonPublic | BindingFlags.Instance);
        object[] parameters = { email };
        var isValid = methodInfo.Invoke(customer, parameters) as bool?;
        Assert.IsFalse(isValid);
    }
    
    [TestMethod]
    public void IsValidEmail_ValidEmail_ShouldReturnTrue()
    {
        var type = typeof(Customer); //obetener el tipo de la clase qeu contiene el metodo privado
        var methodInfo = type.GetMethod("IsValidEmail", BindingFlags.NonPublic | BindingFlags.Instance); // obtener info del metodo
        var isValid = methodInfo?.Invoke(new Customer(),new object[] {"danielfyo@hotmail.com"}) as bool?;
        Assert.IsTrue(isValid);
    }
    
    [TestMethod]
    public void IsValidEmail_InvalidEmail_ShouldReturnFalse()
    {
        var email = "danielfyo";
        var customer = new Customer();
        var methodInfo = typeof(Customer).GetMethod("IsValidEmail", BindingFlags.NonPublic | BindingFlags.Instance);
        object[] parameters = { email };
        var isValid = methodInfo.Invoke(customer, parameters) as bool?;
        Assert.IsFalse(isValid);
    }
}