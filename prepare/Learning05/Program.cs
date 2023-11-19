using System;
using System.IO.Compression;
using System.Text.Json;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        string displayMenu(){
            Console.WriteLine("Menu Options");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
            string input = Console.ReadLine();
            return input;
        }

        void CreateNewGoal(){
            bool notDone = true;
            while(notDone){
                Console.WriteLine("What Kind of Goal would you like to create?");
                Console.WriteLine("    1. Eternal Goal");
                Console.WriteLine("    2. Simple Goal");
                Console.WriteLine("    3. Checklist Goal");
                string input = Console.ReadLine();
                switch (input){
                    case "1":
                        EternalGoal eternalGoal = new EternalGoal();
                        user.AddToGoals(eternalGoal);
                        notDone = false;
                        break;
                    case "2":
                        SimpleGoal simpleGoal = new SimpleGoal();
                        user.AddToGoals(simpleGoal);
                        notDone = false;
                        break;
                    case "3":
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        user.AddToGoals(checklistGoal);
                        notDone = false;
                        break;
                    default:
                        Console.WriteLine("Not A Valid Response");
                        break;
                }
            }


        }

        void Load(){
            string[] lines = System.IO.File.ReadAllLines("progress.txt");
            List<Goal> TempGoals = new List<Goal>();
            foreach (string line in lines.Skip(1)){
                string[] parts = line.Split("||");
                if (parts[0] == "Eternal"){
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                    TempGoals.Add(eternalGoal);
                } else if(parts[0] == "Simple"){
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    TempGoals.Add(simpleGoal);
                } else if(parts[0] == "Checklist"){
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[5]));
                    TempGoals.Add(checklistGoal);
                }
            }
            user.SetGoals(TempGoals);
        }

        void DidIt(){
            Console.WriteLine("Which goal have you completed? (Write its name please)");
            user.ListGoals();
            string input = Console.ReadLine();
            user.completeGoal(input);
        }

        bool notDone = true;

        while(notDone){
            string input = displayMenu();
            switch (input){
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    user.ListGoals();
                    break;
                case "3":
                    user.SaveProgress();
                    break;
                case "4":
                    Load();
                    break;
                case "5":
                    DidIt();
                    break;
                case "6":
                    notDone = false;
                    break;
                default:
                    Console.WriteLine("Sorry Why dont you try that again and give a real answer darnit");
                    break;
            }
        }
    }
}