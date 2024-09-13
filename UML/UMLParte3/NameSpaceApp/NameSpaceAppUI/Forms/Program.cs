using NameSpaceAppBackEnd.Controllers;

namespace NameSpaceAppUI.Forms;

class Program
{
    static void Main(string[] args)
    {
        UserCtrl userCtrl = new UserCtrl();
        userCtrl.CreateUser("John Doe");

    }
}