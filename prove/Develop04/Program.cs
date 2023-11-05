using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        bool go = true;
        while(go == true){
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Hyperventilation Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Listing Activity");
            Console.WriteLine("5. Quit");
            string input = Console.ReadLine();

            if(input == "1"){
                BreathingActivity ba = new BreathingActivity();
            } else if (input == "2"){
                HyperventilationActivity ha = new HyperventilationActivity();
            } else if (input == "3"){
                ReflectionActivity ra = new ReflectionActivity();
            } else if (input == "4"){
                ListingActivity la = new ListingActivity();
            } else if (input == "5"){
                go = false;
            } else{
                Console.WriteLine("Oops that's not a correct input!");
            }

        }


    }
}