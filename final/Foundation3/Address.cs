using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;

    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city} {_state}";
    }


}