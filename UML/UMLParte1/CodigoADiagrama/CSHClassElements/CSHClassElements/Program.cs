using CSHClassElements;
namespace CSHClassElements;
public static class Program
{
    private static void Main(string[] args)
    {
        Customer firstCustomer = new Customer();
        Customer secondCustomer = new Customer();
        // initialize the first customer
        firstCustomer.Name = "John Doe";
        firstCustomer.Address = "123 Main St.";
        firstCustomer.Email = "john.doe@example.com";
        firstCustomer.Notes = "Customer since 2021";
        
        // initialize the second customer
        secondCustomer.Name = "María Doe";
        secondCustomer.Address = "18 de julio 1234";
        secondCustomer.Email = "mariadoe@ort.edu.uy";
        secondCustomer.Notes = "Student at ORT";
        
        // display the customer information
        Console.WriteLine("Customer: {0} - Address: {1} - Email: {2} - Notes {3}", 
            firstCustomer.Name, firstCustomer.Address, firstCustomer.Email, firstCustomer.Notes);
       
        Console.WriteLine("Customer: {0} - Address: {1} - Email: {2} - Notes {3}", 
            secondCustomer.Name, secondCustomer.Address, secondCustomer.Email, secondCustomer.Notes);

    }
}