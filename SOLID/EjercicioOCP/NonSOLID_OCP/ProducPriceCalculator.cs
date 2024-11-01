namespace NonSOLID_OCP;
using System;

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

public class TaxCalculator
{
    private const decimal FoodTax = 0.05m;
    private const decimal ElectronicsTax = 0.20m;
    private const decimal OtherProductsTax = 0.10m;

    public decimal CalculateTax(Product product)
    {
        switch (product.Type)
        {
            case "Food":
                return product.Price * FoodTax;
            case "Electronics":
                return product.Price * ElectronicsTax;
            default:
                return product.Price * OtherProductsTax;
        }
    }
}



