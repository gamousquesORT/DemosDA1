namespace WithDemeter;

public class Customer
{
    private Wallet _wallet =new Wallet();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public void AddMoney(decimal amount)
    {
        _wallet.AddMoney(amount);
    }

    public bool Pay(decimal amountToPay)
    {
        if (_wallet.Money >= amountToPay)
        {
            _wallet.DrawMoney(amountToPay);
            return true;
        }

        return false;
    }
}