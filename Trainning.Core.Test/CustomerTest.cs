using Training.Core.Persons;

namespace MSTest;

[TestClass]
public class CustomerTest
{
    [TestMethod]
    public void Customer_ValidEmail_GetEmailShouldReturnTheInputEmail()
    {
        var email = "danielfyo@hotmail.com";
        var customer = new Customer();
        customer.SetEmail(email);
        Assert.AreEqual(customer.GetEmail(), email);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidEmailException))]
    public void Customer_InvalidEmail_ShouldThrowInvalidEmailException()
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
}