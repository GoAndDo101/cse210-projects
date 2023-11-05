using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class ListingActivity : Activity{
    private List<string> _questions;

    private List<string> _responses;

    public void DisplayPrompt(){
        Random random = new Random();
        int index = random.Next(_questions.Count());
        Console.WriteLine("---" + _questions[index] + "---");
        Console.WriteLine();
    }

    public void Run(){
        Console.WriteLine(_questions);
        Console.WriteLine("Get Ready...");
        DisplayAnimation();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        DisplayPrompt();
        Console.WriteLine("You may begin in: ");
        Countdown();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getIntDuration());

        while (startTime < futureTime){
            string Response = Console.ReadLine();
            _responses.Add(Response);
        }

        Console.Clear();

        Console.WriteLine("You gave " + _responses.Count() + " reponse(s)");
        DisplayEndMessage();
        DisplayAnimation();
    }

    public ListingActivity(){
        _questions = new List<string>();
        _responses = new List<string>();
        _questions.Add("Who are people that you appreciate?");
        _questions.Add("What are personal strengths of yours?");
        _questions.Add("Who are people that you have helped this week?");
        _questions.Add("When have you felt the Holy Ghost this month?");
        _questions.Add("Who are some of your personal heroes?");

        setTitle("Listing Activity");
        setStartMessage("Welcome to the " + getTitle());
        setDesc("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        setEndMessage("Well Done!!! \n \n You have completed another " + getStrDuration() + " seconds of the Listing Activity!");

        Prepare();
        Run();
    }


}