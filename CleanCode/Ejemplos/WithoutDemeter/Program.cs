// See https://aka.ms/new-console-template for more information

using Ejemplos;

Commerce commerce = new Commerce();
Customer customer = new Customer();
Wallet w = customer.Wallet;
w.Money = 100;
commerce.Checkout(customer, 110);
