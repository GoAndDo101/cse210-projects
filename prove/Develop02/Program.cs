using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
            
            journal.FileName = "";

            bool quit = false;
            while(quit == false){
                Console.WriteLine("1 - Write\n2 - Display\n3 - Load\n4 - Save\n5 - Quit");
                string userInput = Console.ReadLine();
                if (userInput == "1"){
                    journal.Write();
                } else if (userInput == "2"){
                    journal.Display();
                } else if (userInput == "3"){
                    journal.Entries = journal.Load();
                } else if (userInput == "4"){
                    journal.Save();
                } else {
                    quit = true;
                }
            }



        
    }
}