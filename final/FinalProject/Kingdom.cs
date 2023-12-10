public class Kingdom : LogEntry{
    private string _dateEstablished;

    private List<Person> _leaders;

    private List<Person> _people;

    public Kingdom(){
        Console.WriteLine("What is the name of this kingdom?");
        SetName(Console.ReadLine());

        Console.WriteLine("Please give a brief description of this kingdom");
        SetDescription(Console.ReadLine());

        Console.WriteLine("When was this kingdom established?");
        _dateEstablished = Console.ReadLine();
    }
}