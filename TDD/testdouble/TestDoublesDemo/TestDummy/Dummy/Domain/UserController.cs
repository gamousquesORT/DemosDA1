
namespace Dummy.Domain
{

    public class UserController
    {
        public UserController()
        {

        }
        
        // authencicator es Dummy - no hace nada
        public bool Login(string username, string password, IAuthenticator authenticator)
        {
            return false;
        }
    }
}