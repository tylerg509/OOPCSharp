Why use static members? 
    1. To represent concepts that are singleton. DateTime.Now; Console.WriteLine()

Signature = what makes method unique. Name/parameters make it unique.

Constructor overloading = Same name different parameters within a class. Signatures must be different
public class Customer
{
    public Customer()
    public Customer(string name)
    public Customer(int id, string name)
}