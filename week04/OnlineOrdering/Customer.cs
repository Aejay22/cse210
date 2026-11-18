using System;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
public class Customer
{
    private string _name;
    private string _address;
    private bool _whetherUsa;
    public Customer(string name, Address address){
        _name = name;
        _address = address.GetAddress();
        _whetherUsa = address.IfUsa();
    }
    public string CustomerDetail()
    {
        return $"{_name}\n{_address}";
    }
    public bool ReturnWhetherUsa()
    {
        return _whetherUsa;
    }
    
}