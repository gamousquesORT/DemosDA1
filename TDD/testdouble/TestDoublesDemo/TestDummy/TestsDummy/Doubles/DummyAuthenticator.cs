using Dummy.Domain;

namespace Dummy.Tests
{

    public class DummyAuthenticator : IAuthenticator
    {
        public bool Validate(string username, string password)
        {
            return true;
        }
    }
}