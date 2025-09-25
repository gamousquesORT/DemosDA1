using Dummy.Domain;
using Dummy.Tests;

namespace Test_TestDoubles
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void TestShouldLoginGivenValidCredentials()
        {
            UserController userController = new UserController();

            IAuthenticator authenticator = new DummyAuthenticator();
            bool result = userController.Login("gaston", "1234", authenticator);

            Assert.IsTrue(result);
        }
    }
}