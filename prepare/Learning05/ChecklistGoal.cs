using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.IO;
using System.Security.Principal;
using System.Dynamic;

class ChecklistGoal : Goal{

    private bool _completed = false;

    private int _timesCompleted = 0;

    private int _totalNeeded;

    private int _fullyCompletePoints;

    public int GetTimesCompleted(){
        return _timesCompleted;
    }

    public int GetTotalNeeded(){
        return _totalNeeded;
    }    
    public override void Complete(User user){
        _timesCompleted += 1;
        SetComplete(true);
        user.AddPoints(GetPoints());
        if(_timesCompleted >= _totalNeeded){
            user.AddPoints(_fullyCompletePoints);
            _completed = true;
            Console.WriteLine("You have completed this goal!");
        }

    }

    public override string DisplayGoal(){
        return $"{GetCheckMark()} Checklist Goal - {GetTitle()} [{GetDescription()}] Completed {_timesCompleted}/{_totalNeeded}";
    }

    public override string GetStringRepresentation()
    {
        string StringRep = $"{GetTheType()}||{GetTitle()}||{GetDescription()}||{GetPoints()}||{_timesCompleted}||{_totalNeeded}||{_fullyCompletePoints}";
        return StringRep;
    }

    public override void GetUserGoal(){
        GetUserTitleAndDescription();

        Console.WriteLine("How many times do you want to complete this goal?");
        _totalNeeded = int.Parse(Console.ReadLine());

        Console.WriteLine("How many points will you get every single time you complete the Goal?");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);

        Console.WriteLine("How many points will you get when you reach your milestone?");
        _fullyCompletePoints = int.Parse(Console.ReadLine());
    }

    public ChecklistGoal(string title, string description, int points, int timesCompleted, int totalNeeded, int fullyCompletePoints){
        SetTitle(title);
        SetDescription(description);
        SetPoints(points);
        SetComplete(false);
        _timesCompleted = timesCompleted;
        _totalNeeded = totalNeeded;
        _fullyCompletePoints = fullyCompletePoints;
        SetType("Checklist");
    }

    public ChecklistGoal(){
        SetType("Checklist");
        GetUserGoal();
    }
}