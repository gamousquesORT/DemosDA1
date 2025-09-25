using Stub.Domain;
namespace TestStub;

public class AuthenticatorStub : IAuthenticator
{
    public bool Validate(string username, string password)
    {
        return true;
    }
}

public class InvalidAuthenticator : IAuthenticator
{
    public bool Validate(string username, string password)
    {
        return false;
    }
}