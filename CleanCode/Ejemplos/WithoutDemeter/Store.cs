namespace Ejemplos;

public class Store
{
    public void Checkout(Customer customer, decimal amount)
    {
        Wallet wallet = customer.Wallet;
        if (wallet.Money >= amount)
        {
            wallet.DrawMoney(amount);
            Console.WriteLine("Purchase completed");
        }
        else
        {
            Console.WriteLine("Not enough money");
        }
    }
}