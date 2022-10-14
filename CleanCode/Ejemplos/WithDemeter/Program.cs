// See https://aka.ms/new-console-template for more information

using WithDemeter;

Commerce commerce = new Commerce();
Customer customer = new Customer();
customer.AddMoney(100);
commerce.Checkout(customer, 110);

