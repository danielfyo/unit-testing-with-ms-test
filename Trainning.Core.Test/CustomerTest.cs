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
    [ExpectedException(typeof(InvalidEmailException))]
    public void IsValidEmail_InvalidEmail_ShouldThrowInvalidEmailException()
    {
        var email = "danielfyo";

        var privateType = new PrivateType(typeof(Customer));
        var response = (bool)privateType.InvokeStatic("IsValidEmail", email);

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
}