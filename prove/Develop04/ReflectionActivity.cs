using System.Diagnostics;
using System.Net.Http.Headers;

class ReflectionActivity : Activity{
    private List<string> _prompts;

    private List<string> _followUps;

    private List<int> _usedIndex;

    public string SelectPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        return _prompts[index];
    }

    public string SelectFollowUp(){
        Random random = new Random();
        int index = random.Next(_followUps.Count());
        return _followUps[index];
    }

    public void Run(){
        Console.WriteLine(SelectPrompt());
        Console.WriteLine();
        Console.WriteLine("Ponder on this experience for a moment, click enter when you are ready");
        Console.ReadLine();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getIntDuration());

        while(startTime < futureTime){
            Console.WriteLine(SelectFollowUp());
            DisplayAnimation();
            startTime = DateTime.Now;
        }
        DisplayEndMessage();
    }

    public void DisplayFollowUps(){}

    public ReflectionActivity(){
        _prompts = new List<string>();
        _followUps = new List<string>();
        _usedIndex = new List<int>();

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _followUps.Add("Why was this experience meaningful to you?");
        _followUps.Add("Have you ever done anything like this before?");
        _followUps.Add("How did you get started?");
        _followUps.Add("How did you feel when it was complete?");
        _followUps.Add("What made this time different than other times when you were not as successful?");
        _followUps.Add("What is your favorite thing about this experience?");
        _followUps.Add("What could you learn from this experience that applies to other situations?");
        _followUps.Add("What did you learn about yourself through this experience?");
        _followUps.Add("How can you keep this experience in mind in the future?");

        setTitle("Reflection Activity");
        setStartMessage("Welcome to the " + getTitle());
        setDesc("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        int integer = getIntDuration();
        string LocalDur = integer.ToString();
        setEndMessage("Well Done!!! \n \n You have completed another " + LocalDur + " seconds of the Reflection Activity!");

        Prepare();
        Run();
    }
}