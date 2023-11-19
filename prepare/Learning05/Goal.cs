using System.ComponentModel;
using System.Text.Json;

abstract class Goal{
    private int _points;

    private bool _complete;

    private string _type;

    private string _title;

    private string _description;

    public abstract void Complete(User user);

    public abstract string GetStringRepresentation();

    public abstract void GetUserGoal();

    public void GetUserTitleAndDescription(){
        Console.WriteLine("What is the title of the goal you are setting?");
        string title = Console.ReadLine();
        SetTitle(title);

        Console.WriteLine("Can you give a brief description of your goal?");
        string description = Console.ReadLine();
        SetDescription(description);
    }

    public void SetPoints(int points){
        _points = points;
    }

    public void SetType(string type){
        _type = type;
    }

    public string GetTheType(){
        return _type;
    }

    public string GetCheckMark(){
        if (_complete == true){
            return "[X]";
        } else {
            return "[ ]";
        }
    }

    public void AddPoints(int points){
    }

    public abstract string DisplayGoal();

    public void SetTitle(string title){
        _title = title;
    }

    public void SetDescription(string desc){
        _description = desc;
    }

    public int GetPoints(){
        return _points;
    }

    public string GetTitle(){
        return _title;
    }

    public string GetDescription(){
        return _description;
    }

    public void SetComplete(bool trueOrFalse){
        _complete = trueOrFalse;
    }
    public bool isComplete(){
        return _complete;
    }

}