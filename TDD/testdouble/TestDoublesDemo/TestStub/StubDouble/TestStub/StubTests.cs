using Stub.Domain;
using TestStub;

namespace TestStub;

public class StubTests
{

    [Fact]
    public void TestShouldLoginGivenValidCredentials()
    {
        UserController userController = new UserController();

        IAuthenticator authenticator = new DummyAuthenticator();
        bool result = userController.Login("gaston", "1234", authenticator);

        Assert.True(result);
    }
}