
using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address(
            "15, Irepodun",
            "Lagos",
            "Lagos State",
            "Nigeria"
        );

        Customer customer1 = new Customer(
            "Joshua Uyinosagbon Anthony",
            address1
        );

        Product product1 = new Product("Binacon Fan", "P01", 50, 2);
        Product product2 = new Product("Apple", "A02", 3, 99);
        Product product3 = new Product("Chair", "Ch05", 27, 2);

        Order order1 = new Order();

        order1.GetCustomer(customer1);
        order1.AppendProducts(product1);
        order1.AppendProducts(product2);
        order1.AppendProducts(product3);

        Console.WriteLine("========== ORDER 1 ==========");

        order1.PrintPackingLabel();
        order1.PrintShippingLabel();
        order1.GetCost();



        Address address2 = new Address(
            "25, Allen Avenue",
            "Ikeja",
            "Lagos State",
            "Nigeria"
        );

        Customer customer2 = new Customer(
            "Collins Omojewhw",
            address2
        );

        Product product4 = new Product("Standing Fan", "P04", 75, 1);
        Product product5 = new Product("Television", "P05", 250, 2);
        Product product6 = new Product("Extension Box", "P06", 15, 3);

        Order order2 = new Order();

        order2.GetCustomer(customer2);
        order2.AppendProducts(product4);
        order2.AppendProducts(product5);
        order2.AppendProducts(product6);

        Console.WriteLine("========== ORDER 2 ==========");

        order2.PrintPackingLabel();
        order2.PrintShippingLabel();
        order2.GetCost();


        Address address3 = new Address(
            "10, Oxford Street",
            "London",
            "Greater London",
            "United Kingdom"
        );

        Customer customer3 = new Customer(
            "Daniel Emmanuel",
            address3
        );

        Product product7 = new Product("Laptop", "P07", 850, 1);
        Product product8 = new Product("Wireless Mouse", "P08", 25, 2);
        Product product9 = new Product("Keyboard", "P09", 40, 1);

        Order order3 = new Order();

        order3.GetCustomer(customer3);
        order3.AppendProducts(product7);
        order3.AppendProducts(product8);
        order3.AppendProducts(product9);

        Console.WriteLine("========== ORDER 3 ==========");

        order3.PrintPackingLabel();
        order3.PrintShippingLabel();
        order3.GetCost();



        Address address4 = new Address(
            "20, Broadway",
            "New York",
            "New York",
            "USA"
        );

        Customer customer4 = new Customer(
            "Henry Williams",
            address4
        );

        Product product10 = new Product("Office Chair", "P10", 120, 2);
        Product product11 = new Product("Office Table", "P11", 200, 1);
        Product product12 = new Product("Desk Lamp", "P12", 35, 3);

        Order order4 = new Order();

        order4.GetCustomer(customer4);
        order4.AppendProducts(product10);
        order4.AppendProducts(product11);
        order4.AppendProducts(product12);

        Console.WriteLine("========== ORDER 4 ==========");

        order4.PrintPackingLabel();
        order4.PrintShippingLabel();
        order4.GetCost();
    }
}
