using System;
using System.Diagnostics.Contracts;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _type;
    private Address _address;

    public Event(string title, string description, string date, string time, string street, string city, string state)
    {   
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(street,city,state);
            
    }

    public void SetType(string type)
    {
        _type = type;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }


    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }


    public string DisplayStandard()
    {
        return "Standard Details:\n" +
                $"Event: {_title}\nDescription: {_description}\nDate:{_date}\nTime:{_time}\nAddress: {_address.GetFullAddress()}\n";
    }

    public virtual string DisplayFullDetails()
    {
        return "Full Details:\n" +
                         $"Event: {_title}\nType: {_type}\nDescription: {_description}\nDate: {_date}\nTime: {_time}Address: {_address.GetFullAddress()}\n";
    }

    public string DisplayShortDescription()
    {
        return "Short Description:\n" +
                         $"Type: {_type}\nEvent: {_title}\nDate: {_date}\n\n";;
    }
}