public class Resume{

    public string Name = "";
    public List<Job> Jobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs: ");
        foreach (Job j in Jobs){
            j.Display();
        }
    }
}