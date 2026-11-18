using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("15, Irepodun", "Lagos", "Lagos State", "america");
        Customer customer1 = new Customer("Joshua Uyinosagbon Anthony", address1);
        Product product1 = new Product("Binacon Fan", "P01", 50, 2);
        Product product2 = new Product("Apple", "A02", 3, 99);
        Product product3 = new Product("Chair", "Ch05", 27, 2);
        Order order = new Order();
        order.GetCustomer(customer1);
        order.AppendProducts(product1);
        order.AppendProducts(product2);
        order.AppendProducts(product3); 
        order.PrintPackingLabel();
        order.PrintShippingLabel();
        order.GetCost();

    }
}