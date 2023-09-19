using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int userGrade = int.Parse(Console.ReadLine());
        
        string userLetter = "nothing";
        if (userGrade > 90){
            userLetter = "A";
        }
        else if (userGrade > 80){
            userLetter = "B";
        }
        else if (userGrade > 70){
            userLetter = "C";
        }
        else if (userGrade > 60){
            userLetter = "D";
        }
        else if (userGrade < 60){
            userLetter = "F";
        }

        if (userGrade > 70){
            Console.WriteLine("You Passed!");
        }
        else {
            Console.WriteLine("YOU SHALL NOT PASS");
        }


        string sign = " ";
        //take remainder and determine whether its a plus or minus
        int remainder = userGrade % 10; 

        // determine if the grade is an A or an F in which it wouldnt need the plus and minus
        if (userGrade < 95 && userGrade > 60){
            if(remainder >= 7){
                sign = "+";
            } else if (remainder <= 3){
                sign = "-";
            } else {
                sign = " ";
            }
        }

        

        Console.WriteLine(userLetter + sign);

    }
}