namespace WithDemeter;

public class Wallet
{
    public decimal Money { get; set; } = 0;

    public void AddMoney(decimal money)
    {
        Money += money;
    }
    public void DrawMoney(decimal money)
    {
        Money -= money;
    }
}