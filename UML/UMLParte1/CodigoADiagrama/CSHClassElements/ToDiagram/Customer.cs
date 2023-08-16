using System.Text.RegularExpressions;

namespace ToDiagram;

public class Customer
{
    private string _name = "";
    private string _address = "";
    private string _email = "me@example.com";

    public Customer()
    {

    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string Email
    {
     
        get => "contact:"+ _email;
        set {
            if (IsValidEmail(value))
            {
                _address = value; 
                
            }
            else 
            {
                throw new ArgumentNullException(nameof(value));
            } 
        }
    }
    
    private static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        return (Regex.IsMatch(email, pattern));
    }


}