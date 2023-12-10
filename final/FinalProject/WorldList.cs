using System.Collections.Generic;

public class WorldList{
    private List<Race> _allRaces;

    private List<Event> _allEvents;

    private List<Location> _allLocations;

    private List<Person> _allPeople;

    private List<Kingdom> _allKingdoms;

    public List<Race> GetRaces(){
        return _allRaces;
    }
    
    public List<Event> GetEvents(){
        return _allEvents;
    }

    public List<Location> GetLocations(){
        return _allLocations;
    }

    public List<Person> GetPeople(){
        return _allPeople;
    }

    public List<Kingdom> GetKingdoms(){
        return _allKingdoms;
    }

    public void AddToRaces(Race race){
        _allRaces.Add(race);
    }


    //I COULD NOT FIGURE OUT HOW TO RUN THESE WITHOUT REPEATING IT OVER AND OVER AGAIN SADLY
    //Each one of these takes in a list, displays all the items and returns whichever gets selected. 
    public Race DisplayAllRaces(List<Race> races){
        Dictionary<int, string> EntryPair = new Dictionary<int, string>();
        int i = 1;
        foreach(Race @entry in races){
            EntryPair.Add(i,@entry.GetName());
            i += 1;
        }
        foreach(KeyValuePair<int,string> pair in EntryPair){
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
        int input = int.Parse(Console.ReadLine());
        
        Race userChoice = null; 
        foreach(Race @entry in races){
            if (@entry.GetName() == EntryPair[input]){
                userChoice = @entry;
            }
        }
        return userChoice;
    }

    public Event DisplayAllEvents(List<Event> events){
        Dictionary<int, string> EntryPair = new Dictionary<int, string>();
        int i = 1;
        foreach(Event @entry in events){
            EntryPair.Add(i,@entry.GetName());
            i += 1;
        }
        foreach(KeyValuePair<int,string> pair in EntryPair){
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
        int input = int.Parse(Console.ReadLine());
        
        Event userChoice = null; 
        foreach(Event @entry in events){
            if (@entry.GetName() == EntryPair[input]){
                userChoice = @entry;
            }
        }
        return userChoice;
    }

    public Person DisplayAllPeople(List<Person> people){
        Dictionary<int, string> EntryPair = new Dictionary<int, string>();
        int i = 1;
        foreach(Person @entry in people){
            EntryPair.Add(i,@entry.GetName());
            i += 1;
        }
        foreach(KeyValuePair<int,string> pair in EntryPair){
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
        int input = int.Parse(Console.ReadLine());
        
        Person userChoice = null; 
        foreach(Person @entry in people){
            if (@entry.GetName() == EntryPair[input]){
                userChoice = @entry;
            }
        }
        return userChoice;
    }

    public Location DisplayAllLocations(List<Location> locations){
        Dictionary<int, string> EntryPair = new Dictionary<int, string>();
        int i = 1;
        foreach(Location @entry in locations){
            EntryPair.Add(i,@entry.GetName());
            i += 1;
        }
        foreach(KeyValuePair<int,string> pair in EntryPair){
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
        int input = int.Parse(Console.ReadLine());
        
        Location userChoice = null; 
        foreach(Location @entry in locations){
            if (@entry.GetName() == EntryPair[input]){
                userChoice = @entry;
            }
        }
        return userChoice;
    }

    public Kingdom DisplayAllKingdoms(List<Kingdom> kingdoms){
        Dictionary<int, string> EntryPair = new Dictionary<int, string>();
        int i = 1;
        foreach(Kingdom @entry in kingdoms){
            EntryPair.Add(i,@entry.GetName());
            i += 1;
        }
        foreach(KeyValuePair<int,string> pair in EntryPair){
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
        int input = int.Parse(Console.ReadLine());
        
        Kingdom userChoice = null; 
        foreach(Kingdom @entry in kingdoms){
            if (@entry.GetName() == EntryPair[input]){
                userChoice = @entry;
            }
        }
        return userChoice;
    }
    //END OF GIANT BLOCK OF REPEATED CODE

    public void AddToEvents(Event @event){
        _allEvents.Add(@event);
    }

    public void AddToMyLocations(Location location){
        _allLocations.Add(location);
    }

    public void AddToMyPeople(Person person){
        _allPeople.Add(person);
    }

    public void AddToMyKingdoms(Kingdom kingdom){
        _allKingdoms.Add(kingdom);
    }

    public WorldList(){
        _allRaces = new List<Race>();
        _allEvents = new List<Event>();
        _allLocations = new List<Location>();
        _allPeople = new List<Person>();
        _allKingdoms = new List<Kingdom>();
    }
}