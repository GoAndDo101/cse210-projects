using System.Diagnostics.Contracts;
using System.Reflection;

public abstract class LogEntry{
    private string _name;

    private Dictionary<string, string> _menuOptions;

    public void SetMenuOptions(Dictionary<string, string> dict){
        _menuOptions = dict;
    }
    public Dictionary<string, string> GetMenu(){
        return _menuOptions;
    }

    private string _description;

    public string GetDescription(){
        return _description;
    }

    public string GetName(){
        return _name;
    }

    public void SetName(string n){
        _name = n;
    }

    public void SetDescription(string s){
        _description = s;
    }
}