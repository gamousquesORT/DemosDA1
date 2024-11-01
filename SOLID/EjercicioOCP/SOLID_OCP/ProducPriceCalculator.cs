namespace SOLID_OCP;

public class Product
{

    
    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }

    public Product(string name, string type, decimal price)
    {
        Name = name;
        Type = type;
        Price = price;
    }
    
}

public abstract class TaxCalculator
{
    public abstract decimal CalculateTax(Product product);
}

public class FoodTaxCalculator : TaxCalculator
{
    private const decimal FoodTax = 0.05m;

    public override decimal CalculateTax(Product product)
    {
        return product.Price * FoodTax;
    }
}

public class ElectronicsTaxCalculator : TaxCalculator
{
    private const decimal ElectronicsTax = 0.20m;

    public override decimal CalculateTax(Product product)
    {
        return product.Price * ElectronicsTax;
    }
}

public class OtherProductsTaxCalculator : TaxCalculator
{
    private const decimal OtherProductsTax = 0.10m;

    public override decimal CalculateTax(Product product)
    {
        return product.Price * OtherProductsTax;
    }
}

public class ProducPriceCalculator
{
    private readonly TaxCalculator _taxCalculators;

    public ProducPriceCalculator(TaxCalculator taxCalculators)
    {
        _taxCalculators = taxCalculators;
    }

    public decimal CalculateTax(Product product)
    {
        return _taxCalculators.CalculateTax(product);
    }
}