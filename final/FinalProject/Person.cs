using System.Diagnostics.Tracing;

public class Person : LogEntry{
    private Race _race;

    private int _birthDate;

    private List<Location> _locationsLived;

    private List<Event> _events;



    public void AddToEvents(Event @event){
        _events.Add(@event);
    }

    public void AddToMyLocations(Location location){
        _locationsLived.Add(location);
    }

    public Race GetRace(){
        return _race;
    }
    public void SetRace(Race r){
        _race = r;
    }

    public Person(){
        Console.WriteLine("What is the name of this Character?");
        SetName(Console.ReadLine());

        Console.WriteLine("When was this character born?");
        _birthDate = int.Parse(Console.ReadLine());

        Console.WriteLine("Please provide a brief description of this character");
        SetDescription(Console.ReadLine());

        Dictionary<string, string> m = new Dictionary<string, string>{
            {"1", "Race"},
            {"2", "Locations Lived"},
            {"3", "Events"},
            {"4", "Description"}
        };
        SetMenuOptions(m);

        _locationsLived = new List<Location>();

        _events = new List<Event>();
    }

}