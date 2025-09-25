using Stub.Domain;
using TestStub;

namespace TestStub;

[TestClass]
public class StubTests
{
    [TestMethod]
    public void ShouldLoginGivenValidCredentials()
    {
        UserController userController = new UserController();

        IAuthenticator authenticator = new AuthenticatorStub();
        bool result = userController.Login("gaston", "1234", authenticator);

        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void ShouldThrowInvalidArguentExceptionGivenInvalidCredentials()
    {
        UserController userController = new UserController();

        IAuthenticator authenticator = new InvalidAuthenticator();
        bool result = userController.Login("gaston", "1234", authenticator);

        Assert.IsFalse(result);
    }
}