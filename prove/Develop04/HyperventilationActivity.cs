using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class HyperventilationActivity : Activity{
    public void Breathe(){
        Console.WriteLine("Get ready...");
        DisplayAnimation();
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getIntDuration());

        while(startTime < futureTime){
            Console.WriteLine("Breathe In...");
            Console.WriteLine("Breathe Out... ");
            startTime = DateTime.Now;
        }
        DisplayEndMessage();
    }



    public HyperventilationActivity(){
        setTitle("Hyperventilation Activity");
        setStartMessage("Welome to the " + getTitle());
        setDesc("This activity will skyrocket your anxiety and might even make you pass out!");
        int integer = getIntDuration();
        string LocalDur = integer.ToString();
        setEndMessage("Well Done!!! \n \n You have completed another " + LocalDur + " seconds of the hyperventilation activity.");

        Prepare();
        Breathe();
    }
}