namespace Ejemplos;

public class Wallet
{
    private decimal _money=0;
    
    public decimal Money
    {
        get { return _money; }
        set { _money = value; }
    }
    
    public void AddMoney(decimal money)
    {
        _money += money;
    }
    public void DrawMoney(decimal money)
    {
        _money -= money;
    }
}