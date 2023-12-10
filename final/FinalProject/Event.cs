using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Security.AccessControl;

public class Event : LogEntry{
    private string _dateYear;

    private List<Person> _people;

    private Location _location;

    private Kingdom _kingdom;

    private List<Race> _races;

    public string GetDate(){
        return _dateYear;
    }

    public Location GetLocation(){
        return _location;
    }

    public void AddKingdom (Kingdom kingdom){
        _kingdom = kingdom;
    }

    public void AddToRaces(Race r){
        _races.Add(r);
    }

    public void AssignLocation(Location location){
        _location = location;
    }

    public void AddPerson(Person person){
        _people.Add(person);
    }

    public Event(){
        Console.WriteLine("Please write the title of this event");
        SetName(Console.ReadLine());

        Console.WriteLine("What year did this happen");
        _dateYear = (Console.ReadLine());

        Console.WriteLine("Please give a brief description of this event");
        SetDescription(Console.ReadLine());

        _races = new List<Race>();

        _people = new List<Person>();

    }
}