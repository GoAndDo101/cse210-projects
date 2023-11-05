using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity ba1 = new BreathingActivity();
        ba1.Prepare();
        ba1.Breathe();

        ListingActivity la1 = new ListingActivity();
        la1.Prepare();
        la1.Run();
    }
}