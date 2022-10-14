namespace Ejemplos;

public class Customer
{
    private Wallet wallet=new Wallet();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Wallet Wallet { get; }
}