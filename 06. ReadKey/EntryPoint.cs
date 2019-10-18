using System;
using System.Text;
class EntryPoint
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        //The ReadKey method creates a new datatype for when you enter information
        //ConsoleKeyInfo

        ConsoleKeyInfo key = Console.ReadKey();//ReadKey() is activated right when you press the key
        Console.WriteLine();
        char keyAsChar = key.KeyChar; //To use the actual character, use the .KeyChar property 
        //Without this property, printing out key by itself makes the letter capital
        Console.WriteLine("Key : " + keyAsChar);
        
        //This is how you get inputs (for games, etc)

        //Modifiers are a property that you can use to see what modifiers you pressed while pressing a key
        //The encoding from before is needed to see what type of key you pressed with the modifier
        Console.WriteLine("Modifier: " + key.Modifiers);
        //You can use multiple modifiers. They are only in a predefined order



    }
}

