using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using System.IO;


public class Journal{
    public string JournalName { get; set; }

    public string FileName { get; set; }

    public List<Entry> Entries { get; set; }


    public Journal(){
        Entries = new List<Entry>();
    }

    public void Write(){
        //make a prompt generator and generate a prompt
        PromptsGenerator gnrtr = new PromptsGenerator();
        string prompt = gnrtr.GeneratePrompt();
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        List<string> inputs = new List<string>();


        //get the current date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        //get a rating on the persons day
        Console.WriteLine("Rate your day today.");
        Console.WriteLine("1 - Awful\n2 - bad\n3 - alright\n4 - good\n5 - great!");
        string day_index = Console.ReadLine();

        string day_rating;

        //turn the day rating into a word instead of a variable
        if (day_index == "1"){
            day_rating = "awful";
        } else if(day_index == "2"){
            day_rating = "bad";
        } else if(day_index == "3"){
            day_rating = "alright";
        } else if (day_index == "4"){
            day_rating = "good";
        } else if (day_index == "5"){
            day_rating = "great!";
        } else{
            day_rating = "Unknowable";
        }

        Entry entry = new Entry();
        entry.EntryDate = dateText;
        entry.Prompt = prompt;
        entry.Rating = day_rating;
        entry.Response = input;

        Entries.Add(entry);
    }

    public void Display(){
        foreach (Entry entry in Entries){
            Console.WriteLine();
            Console.WriteLine("Today was a(n) " + entry.Rating + " day");
            Console.WriteLine("Date - " + entry.EntryDate + " prompt - " + entry.Prompt);
            Console.WriteLine(entry.Response);
            Console.WriteLine();
        
        };
    }

    public List<Entry> Load(){
        Console.WriteLine("What file would you like to access? ");
        this.FileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(this.FileName);
        
        List<Entry> prevList = new List<Entry>();

        foreach (string line in lines){
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();
            newEntry.EntryDate = parts[0];
            newEntry.Prompt = parts[1];
            newEntry.Rating = parts[2];
            newEntry.Rating = parts[3];

            prevList.Add(newEntry);
        }
        return prevList;


        }

    public void Quit(){

    }

    public void Save(){
        Console.WriteLine("What would you like to save your file as? ");
        this.FileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(this.FileName)){
            foreach (Entry entry in Entries){
                outputFile.WriteLine($"{entry.EntryDate},{entry.Prompt},{entry.Rating},{entry.Response}");
            }
        }
    }
}