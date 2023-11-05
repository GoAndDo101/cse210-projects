using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class BreathingActivity : Activity{
    public void Breathe(){
        Console.WriteLine("Get ready...");
        DisplayAnimation();
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        Console.WriteLine(startTime);
        DateTime futureTime = startTime.AddSeconds(getIntDuration());
        Console.WriteLine(futureTime);

        while(startTime < futureTime){
            Console.WriteLine("Breathe In...");
            Countdown();
            Console.WriteLine("Breathe Out... ");
            Countdown();
            startTime = DateTime.Now;
        }
        DisplayEndMessage();
    }



    public BreathingActivity(){
        setTitle("Breathing Activity");
        setStartMessage("Welome to the " + getTitle());
        setDesc("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
        setEndMessage("Well Done!!! \n \n You have completed another " + getStrDuration() + " seconds of the breathing activity.");

        Prepare();
        Breathe();
    }
}