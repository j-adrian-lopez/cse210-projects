using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

public class Customer 
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    public Address GetAddress()
    {
        return _address;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public void SetCustomerName(string name)
    {
        _name = name;
    }

    public bool InUSA()
    {
        return _address.CheckCountry();
    }

}