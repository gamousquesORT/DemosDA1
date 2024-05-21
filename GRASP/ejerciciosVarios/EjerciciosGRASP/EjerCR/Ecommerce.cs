namespace EjerCR;

using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

public class Order
{
    public List<Product> Products { get; private set; } = new List<Product>();

    public void AddProduct(string name, double price)
    {
        Product product = new Product(name, price);
        Products.Add(product);
    }
}


