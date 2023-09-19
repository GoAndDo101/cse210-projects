using System;

class Program
{
    static void Main(string[] args)
    {

        //This function welcomes the user
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        //This function asks the user for their name
        static string PromptUserName(){
            Console.WriteLine("Please Enter Your Name");
            string userName = Console.ReadLine();
            return userName; 
        }

        //This function asks the user for their favorite number
        static int PromptUserNumber(){
            Console.WriteLine("Please Enter Your Favorite Number");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;

        }

        //This function squares whatever number is put into it
        static int SquareNumber(int num){
            int number = num * num;
            return number;
        }
        //This function displays the user name along with the squared number
        static void DisplayResult(string name, int num){
            Console.WriteLine(name + ", the square of your number is " + num);
        }





        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);


    }
}