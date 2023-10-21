using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Scripture{
    private Reference _reference = new Reference(); 

    private List<Word> Words = new List<Word>();

    public void Display(){
        Console.WriteLine(_reference.displayReference());
        foreach(Word word in Words){
            Console.Write(word.ShowWord(word));
            Console.Write(" ");
        }
    }

    public void ClearConsole(){
        Console.Clear();
    }

    public void HideWords(){
        Random random = new Random();
        foreach(Word word in Words){
            if (word.checkHidden() == false){
                int randInt = random.Next(2);
                if (randInt == 1){
                    word.Hide();
                }
            }
        }
    }

    public bool allHidden(){
        List<Word> shownList = new List<Word>();
        foreach(Word word in Words){
            if(word.checkHidden() == false){
                shownList.Add(word);
            }
            
        }
        if(shownList.Count() == 0){
                return true;
            }
        return false;
    }

    public void Quit(){}

//this method takes all the words passed through the constructor
//and creates a list of Word objects out of them 
    private void addTextToWordList(string text){
        this.Words = new List<Word>();
        string[] splittedWords = text.Split(" ");
        foreach (string stringWord in splittedWords){
            Word word = new Word(stringWord);
            Words.Add(word);
        }
    }
    public string ShowReference(){
        return this._reference.displayReference();
    }

    public Scripture(string text, List<int> verses, string book, string chapter){
        addTextToWordList(text);
        _reference = new Reference(book,chapter,verses);
    }

    public Scripture(string text, string verse, string book, string chapter){
        addTextToWordList(text);
        _reference = new Reference(book,chapter,verse);
    }

}