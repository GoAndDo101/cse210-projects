using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {

        //This Creates a list of numbers that the user will fill out.
        List<int> numbers = new List<int>();
        int userInput = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       
       //This loop continues to ask for a number until the user adds a zero
        while (userInput != 0){
            Console.WriteLine("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            //This block adds every number to the list except for 0
            if (userInput != 0){
                numbers.Add(userInput);
            }

        }

        //This calculates the sum by looping through the list.
        int sum = 0;
        foreach (int number in numbers){
            Console.WriteLine(number);
            sum += number;
        }

        //This the max number and the average and then prints them out.
        int maxNumber = numbers.Max();
        float average = sum / numbers.Count();
        
        Console.WriteLine("The Sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The Max Number is: " + maxNumber);
    }
}