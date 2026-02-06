using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string WholeAddress()
    {
        string wholeAddress = "\nStreet: " + _streetAddress + " City: " + _city + " State: " + _state + " Country: " + _country;
        return wholeAddress;
    }
    public Boolean InCountry()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }
}