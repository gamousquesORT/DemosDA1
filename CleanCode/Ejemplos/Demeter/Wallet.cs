namespace Ejemplos;

public class Wallet
{
    private float _money=0;
    
    public float Money
    {
        get { return _money; }
        set { _money = value; }
    }
    
    public AddMoney(float money)
    {
        _money += money;
    }
    public DrawMoney(float money)
    {
        _money -= money;
    }
}