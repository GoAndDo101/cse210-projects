using System;

class Program
{
    static void Main(string[] args)
    {
        // This takes input from the user to choose the number that they're going to guess.
        Console.WriteLine("What is your Magic Number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        // This sets the current guess equal to zero and tests to see if the current guess
        // equals the magic number.
        int currentGuess = 0;
        while (currentGuess != magicNumber){
            // This asks the user for their guess.
            Console.WriteLine("Guess a number! ");
            currentGuess = int.Parse(Console.ReadLine());

            if (currentGuess > magicNumber){
                Console.WriteLine("TOO HIGH");

            } else if (currentGuess < magicNumber){
                Console.WriteLine("TOO LOW");
            } else{
                Console.WriteLine("YA GOT IT YEAAAH");
            }

        }
    }
}