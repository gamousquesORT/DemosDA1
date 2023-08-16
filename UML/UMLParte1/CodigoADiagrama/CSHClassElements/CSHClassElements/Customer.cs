using System.Text.RegularExpressions;

namespace CSHClassElements;

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
        // expression-bodied member (return _name;)
        get => _name;  
        
        // set => _name = value;  // expression-bodied member ( _name = value;)
        // if (value == null) throw new ArgumentNullException(nameof(value));
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string Email
    {
     
        get => _email;
        set {
            if (IsValidAEmail(value))
            {
                _address = value; 
                
            }
            else 
            {
                throw new ArgumentNullException(nameof(value));
            } 
        }
    }
    
    private static bool IsValidAEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        return (Regex.IsMatch(email, pattern));
    }

    public string Notes { get; set; } = "";
}

