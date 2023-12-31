using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class BreathingActivity : Activity{
    public void Breathe(){
        Console.WriteLine("Get ready...");
        DisplayAnimation();
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getIntDuration());

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
        int integer = getIntDuration();
        string LocalDur = integer.ToString();
        setEndMessage("Well Done!!! \n \n You have completed another " + LocalDur + " seconds of the breathing activity.");

        Prepare();
        Breathe();
    }
}