

public class AbsenceData
{
    public string? Name {get; set;}
    public string? Event { get; set; }
    public DateTime? Date {get; set;}
    public string? AbsenceReason {get; set;}
    public bool? Recur {get; set;}

    public AbsenceData(string Name, string Event, DateTime Date, string AbsenceReason, bool Recur)
    {
        this.Name = Name;
        this.Event = Event;
        this.Date = Date;
        this.AbsenceReason = AbsenceReason;
        this.Recur = Recur;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nEvent: {Event}\nDate: {Date}\nReason for Absence: {AbsenceReason}";
    }
}