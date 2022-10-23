public class Sinfonian
{
    public string? Name { get; set; }
    public string? Event { get; set; }
    public DateTime Date { get; set; }

    public Sinfonian(string Name, string Event, DateTime Date)
    {
        this.Name = Name;
        this.Event = Event;
        this.Date = Date;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nEvent: {Event}\nDateTime: {Date}\n--------------------\n";
    }
}