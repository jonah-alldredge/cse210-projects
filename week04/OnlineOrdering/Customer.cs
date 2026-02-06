using System;

public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    public string ShippingLabel()
    {
        string wholeAddress = _name + _address.WholeAddress();
        return wholeAddress;
    }

    public Boolean LiveCountry()
    {
        return _address.InCountry();
    }
}