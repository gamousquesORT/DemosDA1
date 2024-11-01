using System;
namespace SOLID_OCP;

public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>
        {
            { new Product("Bread", "Food", 1)},
            { new Product("Laptop", "Electronics", 1000) },
            { new Product("Chocolate", "Food", 10) },
        };

        Dictionary<string, TaxCalculator> calculators = new Dictionary<string, TaxCalculator>
        {
            { "Food", new FoodTaxCalculator() },
            { "Electronics", new ElectronicsTaxCalculator() },
            { "Other", new OtherProductsTaxCalculator() }
        };

        decimal taxForProduct = 0; 
        foreach (var product in products)
        {
            ProducPriceCalculator calculator = new ProducPriceCalculator(calculators[product.Type]);
            taxForProduct = calculator.CalculateTax(product);
            Console.WriteLine($"Tax for {product.Name}: {taxForProduct}");
        }
    }
}