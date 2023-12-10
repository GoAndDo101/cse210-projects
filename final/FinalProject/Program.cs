using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        string Menu (Dictionary<string, string> options){
            foreach(KeyValuePair<string, string> pair in options){
                Console.WriteLine($"{pair.Key}. {pair.Value}");
            }
            string output = Console.ReadLine();
            return output;
        } 
        

        Console.WriteLine("What is the name of your world?");

        WorldList worldList = new WorldList();

        string WorldName = Console.ReadLine();
        Console.WriteLine("Welcome to " + WorldName);


        Dictionary<string, string> FirstPage = new Dictionary<string, string>
        {
            { "1", "Make a new log" },
            { "2", "Make an edit" },
            { "3", "Display Info" },
            { "4", "Quit"}
        };

        Dictionary<string, string> Options = new Dictionary<string, string>
        {
            { "1", "Race" },
            { "2", "Character" },
            { "3", "Event" },
            { "4", "Location" },
            { "5", "Kingdom"}
        };

        Dictionary<string, string> HowEdit = new Dictionary<string, string>
        {
            { "1", "Edit Info" },
            { "2", "Add Info" },
        };

        Dictionary<string, string> AssignOrCreate = new Dictionary<string, string>
        {
            { "1", "Create" },
            { "2", "Assign" },
        };

        Boolean notDone = true;
        while(notDone){
            string input = Menu(FirstPage);
            if (input == "1"){

                //Display Options to create a new entry
                input = Menu(Options);

                //Create a new entry based off of info given
                if (input == "1"){
                    Race race = new Race();
                    worldList.AddToRaces(race);
                } else if (input == "2"){
                    Person person = new Person();
                    worldList.AddToMyPeople(person);
                } else if (input == "3"){
                    Event _event = new Event();
                    worldList.AddToEvents(_event);
                } else if (input == "4"){
                    Location location = new Location();
                    worldList.AddToMyLocations(location);
                }

            } else if (input == "2"){

                //Display options to edit an entry
                input = Menu(Options);

                //race option
                if (input == "1"){
                    //display all races to choose from
                    Console.WriteLine("Which race would you like to edit?");
                    Race chosen_race = worldList.DisplayAllRaces(worldList.GetRaces());

                    //displays options for what to edit
                    input = Menu(chosen_race.GetMenu());
                    
                    //rewrite a races history
                    if(input == "1"){
                        Console.WriteLine("Rewrite this races history");
                        chosen_race.SetHistory(Console.ReadLine());
                    }
                    //Edit the members of this race
                    else if(input == "2"){
                        Console.WriteLine("Would you like to create a new person to add to this race? Or assign an already existing one?");
                        input = Menu(AssignOrCreate);

                        //Create a new person
                        if (input == "1"){
                            Person person = new Person();
                            worldList.AddToMyPeople(person);
                            person.SetRace(chosen_race);
                            chosen_race.AddToMyPeople(person);

                        //Assgn an already existing one
                        } else if(input == "2"){
                            Console.WriteLine("Choose Your Person");
                            Person person = worldList.DisplayAllPeople(worldList.GetPeople());

                            //Also remove it from the old list
                            Race oldRace = person.GetRace();
                            List<Person> oldFolks = oldRace.GetPeople();
                            oldFolks.Remove(person);
                            person.SetRace(chosen_race);
                            chosen_race.AddToMyPeople(person);
                        } 

                    //Rewrite or add a races location
                    } else if (input == "3"){
                        Console.WriteLine("Would you like to create a new location or assign an already existing one?");
                        input = Menu(AssignOrCreate);

                        if (input == "1"){
                            Location location = new Location();
                            worldList.AddToMyLocations(location);
                            location.AddToRaces(chosen_race);
                            chosen_race.AddToMyLocations(location);


                        } else if(input == "2"){
                            Console.WriteLine("Choose your homeplace");
                            Location location = worldList.DisplayAllLocations(worldList.GetLocations());

                            chosen_race.AddToMyLocations(location);
                            location.AddToRaces(chosen_race);
                        }
                    // Add an event
                    } else if (input == "4"){
                        Console.WriteLine("Create your new event for this race");
                        Event @event = new Event();
                        @event.AddToRaces(chosen_race);
                        chosen_race.AddToMyEvents(@event);
                    } 
                //Editing People
                } else if(input == "2"){
                    Console.WriteLine("Which Person would you like to edit?");
                    Person chosen_person = worldList.DisplayAllPeople(worldList.GetPeople());

                    input = Menu(chosen_person.GetMenu());
                    //Editing Peoples races
                    if (input == "1"){
                        Console.WriteLine("Would you like to create a new race or assign an existing one?");
                        input = Menu(AssignOrCreate);

                        if (input == "1"){
                            Race race = new Race();
                            worldList.AddToRaces(race);
                            race.AddToMyPeople(chosen_person);
                            chosen_person.SetRace(race);
                        }
                        else if (input == "2"){
                            Console.WriteLine("Choose your race");
                            Race race = worldList.DisplayAllRaces(worldList.GetRaces());

                            chosen_person.SetRace(race);
                            race.AddToMyPeople(chosen_person);
                            
                        }

                    //Editing peoples locations
                    } else if (input == "2"){
                        Console.WriteLine("Would you like to create a new location? or Add this character to an existing one?");
                        input = Menu(AssignOrCreate);

                        if(input == "1"){
                            Location location = new Location();
                            worldList.AddToMyLocations(location);
                            location.AddToPeople(chosen_person);
                            chosen_person.AddToMyLocations(location);

                        } else if (input == "2"){
                            Console.WriteLine("Choose your location");
                            Location location = worldList.DisplayAllLocations(worldList.GetLocations());

                            location.AddToPeople(chosen_person);
                            chosen_person.AddToMyLocations(location);
                        }
                    //Edit an event
                    } else if (input == "3"){
                        Console.WriteLine("Would you like to make a new event or add to an existing one?");
                        input = Menu(AssignOrCreate);
                        if (input == "1"){
                            Event @event = new Event();
                            worldList.AddToEvents(@event);
                            @event.AddPerson(chosen_person);
                            chosen_person.AddToEvents(@event);
                        } else if(input == "2"){
                            Console.WriteLine("Choose your event");
                            Event @event = worldList.DisplayAllEvents(worldList.GetEvents());

                            chosen_person.AddToEvents(@event);
                            @event.AddPerson(chosen_person);
                        }
                    } else if (input == "4"){
                        Console.WriteLine("Please Rewrite your description");
                        chosen_person.SetDescription(Console.ReadLine());

                    }
                //editing locations
                if (input == "4"){
                    Console.WriteLine("Which location would you like to edit?");
                    Location chosen_location = worldList.DisplayAllLocations(worldList.GetLocations());

                    input = Menu(chosen_location.GetMenu());
                    //Events
                    if (input == "1"){
                        Console.WriteLine("Would you like to create a new event or assign an old one?");
                        input = Menu(AssignOrCreate);

                        if(input == "1"){
                            Event @event = new Event();
                            worldList.AddToEvents(@event);
                            @event.AssignLocation(chosen_location);
                            chosen_location.AddToEvents(@event);


                        } else if(input == "2"){
                            Console.WriteLine("Choose your event");
                            Event @event = worldList.DisplayAllEvents(worldList.GetEvents());
                            Location oldLocal = @event.GetLocation();
                            List<Event> oldEvent = oldLocal.GetEvents();
                            oldEvent.Remove(@event);

                            chosen_location.AddToEvents(@event);
                            @event.AssignLocation(chosen_location);
                        }
                    //Races
                    } else if (input == "2"){
                        Console.WriteLine("Would you like to create a new race or assign an old one?");
                        input = Console.ReadLine();

                        if (input == "1"){
                            Race race = new Race();
                            worldList.AddToRaces(race);
                            race.AddToMyLocations(chosen_location);
                            chosen_location.AddToRaces(race);

                        } else if (input == "2"){
                            Console.WriteLine("Choose which race you'd like to assign");
                            Race race = worldList.DisplayAllRaces(worldList.GetRaces());

                            chosen_location.AddToRaces(race);
                            race.AddToMyLocations(chosen_location);
                        }

                    //People
                    } else if (input == "3"){
                        Console.WriteLine("Would you like to create a new person or assign an existing one?");
                        input = Menu(AssignOrCreate);

                        if (input == "1"){
                            Person person = new Person();
                            person.AddToMyLocations(chosen_location);
                            chosen_location.AddToPeople(person);
                            worldList.AddToMyPeople(person);
                        } else if (input == "2"){
                            Console.WriteLine("Choose which person you would like to assign");
                            Person person = worldList.DisplayAllPeople(worldList.GetPeople());

                            person.AddToMyLocations(chosen_location);
                            chosen_location.AddToPeople(chosen_person);
                        }
                    } 
                }

                } else if(input == "3"){

                } else if(input == "4"){
                    notDone = false;
                } 
        }
        }

        
    }
}