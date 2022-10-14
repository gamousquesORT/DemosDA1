namespace Ejemplos;

public class Commerce
{
    public Checkout(Customer customer, float amount)
    {
        Wallet wallet = customer.Wallet;
        if (wallet.Money >= amount)
        {
            wallet.Money -= amount;
            Console.WriteLine("Purchase completed");
        }
        else
        {
            Console.WriteLine("Not enough money");
        }
    }
}