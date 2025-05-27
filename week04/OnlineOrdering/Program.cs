using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Gorgonio Aguiar 1047", "Melo", "Cerro Largo", "Uruguay");
        Address address1 = new Address("UT 84602", "Provo", "Utah", "USA");

        Customer byuStudent = new Customer("Jhon Smith", address1);
        Customer me = new Customer("Joel Gonzalez", address);

        Product bookOfMormon10 = new Product("Book Of Mormon", 1, 3.5, 10);
        Product hollyBible3 = new Product("The Holly Bible", 2, 5.25, 3);
        Product preachMyGospel1 = new Product("Preach My Gospel", 5, 9.99, 1);


        List<Product> productsForBYU = [bookOfMormon10, hollyBible3, preachMyGospel1];
        List<Product> productsForUruguay = [bookOfMormon10, preachMyGospel1];

        Order order = new Order(productsForBYU, byuStudent);
        Order order1 = new Order(productsForUruguay, me);

        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
        Console.WriteLine($"List of Products:\n{order.PackingLabel()}");
        Console.WriteLine($"Shipping to:\n{order.ShippingLabel()}");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine($"List of Products:\n{order1.PackingLabel()}");
        Console.WriteLine($"Shipping to:\n{order1.ShippingLabel()}");

    }
}