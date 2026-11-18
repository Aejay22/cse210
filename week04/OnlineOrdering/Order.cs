using System;
using System.Collections.Generic;
using System.Net.Security;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private int _shippingCost;
    private double _total;

    public void PrintPackingLabel()
    {
        Console.WriteLine("PACKING LABEL");
        _total = 0;
        foreach(Product product in _products)
        {
            Console.WriteLine(product.ProductBought());
            _total += product.TotalCost();
            
        }
        Console.WriteLine("");
    }
    public void PrintShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(_customer.CustomerDetail());
        if (_customer.ReturnWhetherUsa())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        Console.WriteLine("");
        
    }
    public void GetCost()
    {
        Console.WriteLine("COST");
        Console.WriteLine($"Products: ${_total}");
        Console.WriteLine($"Shipping: ${_shippingCost}");
        Console.WriteLine($"Total: ${_total+_shippingCost}");
        Console.WriteLine("");
        
    }
    public void GetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public void AppendProducts(Product product)
    {
        _products.Add(product);
    }



}