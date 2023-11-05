using System.Reflection.Metadata;

class Activity{
    private int _duration;

    private string _title;

    private string _startingMessage;

    private string _endingMessage;

    private string _description;

    //Methods
    public void Prepare(){
        DisplayStartMessage();
        DisplayDescription();
        PromptDuration();
        Console.Clear();
    }
    public void DisplayStartMessage(){
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
    }

    public void DisplayDescription(){
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndMessage(){
        Console.WriteLine(_endingMessage);
    }

    public void DisplayTitle(){
        Console.WriteLine(_title);
    }

    public void Countdown(){
        for(int i = 5; i <= 0; i -= 1){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayAnimation(){
        List<string> frames = new List<string>();
        frames.Add("+");
        frames.Add("-");
        frames.Add("0");
        frames.Add("-");
        frames.Add("+");
        
        foreach (string frame in frames){
            Console.Write(frame);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    //Getters and Setters

        //Duration
    public void SetDuration(int dur){
        _duration = dur;
    }

    public void PromptDuration(){
        Console.WriteLine("How long in seconds would you like for your session to last? - ");
        _duration = int.Parse(Console.ReadLine());
    }

        //StartMessage
    public void setStartMessage(string msg){
        _startingMessage = msg;
    }

        //title
    public void setTitle(string title){
        _title = title;
    }

    public string getTitle(){
        return _title;
    }
        //ending messages
    public void setEndMessage(string msg){
        _endingMessage = msg;
    }

    public string getEndMessage(){
        return _endingMessage;
    }

        //description
    public string getDesc(){
        return _description;
    }

    public void setDesc(string desc){
        _description = desc;
    }

    public string getStrDuration(){
        string strDuration = _duration.ToString();
        return strDuration;
    }

    public int getIntDuration(){
        return _duration;
    }
}