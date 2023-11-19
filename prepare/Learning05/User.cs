using System.Collections;
using System.Configuration.Assemblies;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Transactions;

class User{
    private int _pointTotal = 0;

    private List<string> _levels = new List<string>();

    private string currentLevel;

    public void AddPoints(int points){
        _pointTotal += points;
    }

    private List<Goal> _goals = new List<Goal>();

    public void SaveProgress(){
        using (StreamWriter outputFile = new StreamWriter($"Progress.txt")){
            outputFile.WriteLine(_pointTotal);
            foreach(Goal goal in _goals)
                outputFile.WriteLine(goal.GetStringRepresentation());
        }
    }

    public User(){
        _levels = new List<string>();
        _goals = new List<Goal>();
        _levels.Add("Nerd");
        _levels.Add("Okay");
        _levels.Add("Good");
        _levels.Add("Great");
        _levels.Add("Chad");
        _levels.Add("GigaChad");

        currentLevel = GetLevel();
    }

    public void SetPoints(int points){
        _pointTotal = points;
    }

    public void SetGoals(List<Goal> goals){
        _goals = goals;
    }

    public void AddToGoals(Goal goal){
        _goals.Add(goal);
    }

    public void ListGoals(){
        Console.WriteLine(GetLevel());
        foreach(Goal goal in _goals){
            Console.WriteLine(goal.DisplayGoal());
        }
    }

    public string GetLevel(){
        if(_pointTotal > 500){
            return _levels[5];

        } else if (_pointTotal > 400){
            return _levels[4];            

        } else if (_pointTotal > 300){
            return _levels[3];

        } else if (_pointTotal > 200){
            return _levels[2];

        } else if (_pointTotal > 100){
            return _levels[1];

        } else {
            return _levels[0];
        }
    }

    public void completeGoal(string input){
        foreach(Goal goal in _goals){
            if (input == goal.GetTitle()){
                goal.Complete(this);
            }
        }
    }
}