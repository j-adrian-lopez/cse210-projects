public class Reception : Event
{
    private string _email = "";
    public Reception(string email, string title, string description, string date, string time, string street, string city, string state)
                    :base(title, description, date, time, street, city, state)
    {
        _email = email;
        SetType("Reception");
    }

    public string GetEmail()
    {
        return _email;
    }


    public override string DisplayFullDetails()
    {
        return "Full Details:\n" +
                $"Event: {GetTitle()}\nDescription: {GetDescription()}\nDate:{GetDate()}\nTime:{GetTime()}\nAddress: {GetAddress().GetFullAddress()}\nRSVP Email:{_email}\n";
    }
}