using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<int> verses = new List<int>();
        verses.Add(11);
        verses.Add(12);
        verses.Add(13);
        Scripture scripture1 = new Scripture("Now my brethren, we see that God is mindful of every people, whatsoever land they may be in; yea, he numbereth his people, and his bowels of mercy are over all the earth. Now this is my joy, and my great thanksgiving; yea, and I will give thanks unto my God forever. Amen.","37","Alma","26");
        Scripture scripture2 = new Scripture("And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. 12 And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities. 13 Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me.", verses, "Alma", "7");

        string response = "";
        int done = 0;

        Console.WriteLine("Select Which verse you would like to try to memorize");
        Console.WriteLine("(1) " + scripture1.ShowReference());
        Console.WriteLine("(2) " + scripture2.ShowReference());
        string userInput = Console.ReadLine();

        if(userInput == "1"){
            bool isHidden = false;
            while(response == "" && done < 1){
                Console.Clear();
                isHidden = scripture1.allHidden();
                if (isHidden == true){
                    done += 1;
                }
                scripture1.Display();
                response = Console.ReadLine(); 
                scripture1.HideWords();
            };
        } if(userInput == "2"){
            bool isHidden = false;
            while(response == "" && done < 1){
                Console.Clear();
                isHidden = scripture2.allHidden();
                if (isHidden == true){
                    done += 1;
                }
                scripture2.Display();
                response = Console.ReadLine(); 
                scripture2.HideWords();
            };

        };

    }
}