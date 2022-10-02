using Dummy.Domain;
using Dummy.Tests;
using Xunit;

namespace Test_TestDoubles
{

    public class LoginTests
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
}