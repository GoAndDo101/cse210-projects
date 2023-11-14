using System.ComponentModel;

abstract class Goal{
    private int _points;

    private string _title;

    private string _description;

    public abstract void Complete();

    public void SetPoints(int points){
        _points = points;
    }

    public void SetTitle(string title){
        _title = title;
    }

    public void SetDescription(string desc){
        _description = desc;
    }

    public void SaveGoal(){}
}