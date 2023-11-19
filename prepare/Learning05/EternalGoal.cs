using System.Text.Json;
using System.IO;
class EternalGoal : Goal{

    private int _timesCompleted = 0;

    public override void Complete(User user){
        Console.WriteLine("You Completed " + GetTitle());
        user.AddPoints(GetPoints());
        _timesCompleted += 1;
    }

    public override string GetStringRepresentation(){
        string StringRep = $"{GetTheType()}||{GetTitle()}||{GetDescription()}||{GetPoints()}||{_timesCompleted}";
        return StringRep;
    }
    public override void GetUserGoal(){
        GetUserTitleAndDescription();

        Console.WriteLine("How many points do you get for every time you complete this Goal?");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
    }
    public int GetTimesCompleted(){
        return _timesCompleted;
    }

    public EternalGoal(){
        GetUserGoal();
    }

    public override string DisplayGoal(){
        return $"{GetCheckMark()} Eternal Goal - {GetTitle()} [{GetDescription()}]";
    }

    public EternalGoal(string title, string description, int points, int timesCompleted){
        SetTitle(title);
        SetDescription(description);
        SetPoints(points);
        _timesCompleted = timesCompleted;
        SetComplete(false);
        SetType("Eternal");
    }
}