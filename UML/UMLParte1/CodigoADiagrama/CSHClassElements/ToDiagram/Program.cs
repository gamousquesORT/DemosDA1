namespace ToDiagram;

class Program
{
    static void Main(string[] args)
    {
        Customer firstCustomer = new Customer();
        firstCustomer.Name = "John Doe";
        firstCustomer.Address = "123 Main St.";
        firstCustomer.Email = "johndoe@ort.edu.uy";
        Console.WriteLine("Customer: {0} - Address: {1} - Email: {2}",
            firstCustomer.Name, firstCustomer.Address, firstCustomer.Email);
    }
}