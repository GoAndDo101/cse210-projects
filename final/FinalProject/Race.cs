using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using Microsoft.VisualBasic;

public class Race : LogEntry{

    private string _history;

    private List<Person> _membersOfThisRace;

    private Location _homeplace; 

    private List<Event> _events;

    public void DisplayInfo(){
        Console.WriteLine("Here is the info for this Race");
        Console.WriteLine();
        Console.WriteLine($"History - {_history}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Members of this race");
        foreach(Person person in _membersOfThisRace){
            Console.WriteLine(person.GetName());
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Homeplace - {_homeplace}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Events that involve this race");
        foreach(Event @event in _events){
            Console.WriteLine($"{@event.GetDate()} -- {@event.GetName()}");
        }
    }

    //Getters and Setters

    public string GetHomePlace(){
        return "_homeplace";
    }

    public string GetHistory(){
        return _history;
    }

    public List<Person> GetPeople(){
        return _membersOfThisRace;
    }


    public void SetHistory(string h){
        _history = h;
    }


    // *******************


    public Race(){
        Console.WriteLine("What would you like to name this race?");
        SetName(Console.ReadLine());

        Console.WriteLine("Please briefly describe what members of this race looks like");
        SetDescription(Console.ReadLine());

        Console.WriteLine("Please provide a brief history of your race");
        _history = Console.ReadLine();
        
        Dictionary<string, string> m = new Dictionary<string, string>{
            {"1", "History"},
            {"2", "Members of this race"},
            {"3", "HomePlace"},
            {"4", "Events"}
        };
        SetMenuOptions(m);

        _membersOfThisRace = new List<Person>();

        _events = new List<Event>();
    }

    public void AddToMyLocations(Location location){
        _homeplace = location;
    }

    public void AddToMyPeople(Person person){
        _membersOfThisRace.Add(person);
    }

    public void AddToMyEvents(Event thisEvent){
        _events.Add(thisEvent);
    }

}