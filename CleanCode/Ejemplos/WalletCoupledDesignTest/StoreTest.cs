namespace WalletCoupledDesignTest;
using WalletAppDomain;

public class StoreTest
{
    [Fact]
    public void ShouldReturnTrueGivenEnoughMoney()
    {
        // Arrange
        Store store = new Store();
        Customer customer = new Customer();
        customer.Wallet.Money = 200;
        decimal amount = 100;

        //act
        bool result = store.Checkout(customer, amount);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void ShouldThrowWalletExceptionGivenInsufficientFunds()
    {
        // Arrange
        Store store = new Store();
        Customer customer = new Customer();
        customer.Wallet.Money = 50;
        decimal amount = 100;

        // Assert
        Assert.Throws<WalletException>(() => store.Checkout(customer, amount));
        
    }
}
