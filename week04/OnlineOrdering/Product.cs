using System;
using System.Reflection.Metadata.Ecma335;
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    int _quantity;
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string ProductBought()
    {
        return $"{_name}: {_productId}";
    }


}