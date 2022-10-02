using Stub.Domain;

namespace TestStub
{

    public class DummyAuthenticator : IAuthenticator
    {
        public bool Validate(string username, string password)
        {
            if (username == "gaston")
                return false;
            return false;
        }
    }
}