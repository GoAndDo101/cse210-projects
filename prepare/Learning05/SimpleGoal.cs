using System.Text.Json;
using System.IO;
using System.Diagnostics.Contracts;

class SimpleGoal : Goal{
    private bool _complete;

    public override void Complete(User user){
        Console.WriteLine("You completed this goal!");
        user.AddPoints(GetPoints());
    }

    public override string GetStringRepresentation(){
        string StringRep = $"{GetTheType()}||{GetTitle()}||{GetDescription()}||{GetPoints()}||{_complete}";
        return StringRep;
    }

    public override void GetUserGoal(){
        GetUserTitleAndDescription();

        Console.WriteLine("How many points do you when you complete this Goal?");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
    }

    public override string DisplayGoal(){
        return $"{GetCheckMark()} Simple Goal - {GetTitle()} [{GetDescription()}]";
    }

    public SimpleGoal(){
        GetUserGoal();
        _complete = false;
    }
    public SimpleGoal(string title, string description, int points, bool complete){
        SetTitle(title);
        SetDescription(description);
        SetPoints(points);
        _complete = complete;
        SetType("Simple");
    }
}