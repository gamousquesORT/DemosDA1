namespace Ejemplos;

public class Commerce
{
    public void Checkout(Customer customer, float amount)
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