using System.Diagnostics;

public class Location : LogEntry{

    private List<Event> _events;

    private List<Person> _people;

    private List<Race> _races;

    public List<Event> GetEvents(){
        return _events;
    }

    public void AddToPeople(Person person){
        _people.Add(person);
    }

    public void AddToEvents(Event _event){
        _events.Add(_event);
    }

    public void AddToRaces(Race r){
        _races.Add(r);
    }


    public Location(){
        Console.WriteLine("What would you like to name this Location?");
        SetName(Console.ReadLine());

        Console.WriteLine("Please provide a brief description of this location");
        SetDescription(Console.ReadLine());

        Dictionary<string, string> m = new Dictionary<string, string>{
            {"1", "Events"},
            {"2", "Races"},
            {"3", "People"},
        };
        SetMenuOptions(m);

        _events = new List<Event>();

        _races = new List<Race>();

        _people = new List<Person>();
    }
}