using System;

class Program
{
    static void Main(string[] args)
    {
        // This makes a new random number
        Random rnd = new Random();
        int magicNumber = rnd.Next(20);

        // This sets the current guess equal to zero and tests to see if the current guess
        // equals the magic number.
        int currentGuess = -1;
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