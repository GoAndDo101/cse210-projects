using System.Net.Http.Headers;

public class PromptsGenerator{
    public List<string> Prompts;


    public PromptsGenerator(){
        Prompts = new List<string>();
        Prompts.Add("How have you seen God today?");
        Prompts.Add("What's a high and a low from today?");
        Prompts.Add("Have you done any good in the world today?");
        Prompts.Add("What do you want to do better tomorrow?");
    }
    public string GeneratePrompt(){
        var random = new Random();
        int index = random.Next(Prompts.Count);
        string newPrompt = Prompts[index];
        return newPrompt;
    }

}