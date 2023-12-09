public class Lecture : Event
{
    private string _speaker = "";
    private int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, string street, string city, string state)
                 :base(title, description, date, time, street, city, state)
    {
        _speaker = speaker;
        _capacity = capacity;
        SetType("Lecture");
    }

    public override string DisplayFullDetails()
    {
        return "Full Details:\n" +
                $"Event: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}\nTime: {GetTime()}\nSpeaker: {_speaker}\nCapacity: {_capacity} people\nAddress: {GetAddress().GetFullAddress()}\n";
    }
}