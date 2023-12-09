public class Outdoor : Event
{
    private string _weather = "";

    public Outdoor(string weather, string title, string description, string date, string time, string street, string city, string state)
                  :base(title, description, date, time, street, city, state)
    {
        _weather = weather;
        SetType("Outdoor");
    }


    public override string DisplayFullDetails()
    {
        return "Full Details:\n" +
                         $"Event: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}\nTime: {GetTime()}\nAddress: {GetAddress().GetFullAddress()}\nWeather Forecast: {_weather}\n";
    }

}