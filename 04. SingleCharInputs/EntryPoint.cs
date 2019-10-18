using System;
class EntryPoint
{
    static void Main()
    {
        Console.Write("How old are you? ");
        char age = (char)Console.Read();
        //Console.Read() reads a character from the ascii table
        //You must type cast to read the actual char
        //But chars only read one char at a time.
        Console.WriteLine($"You are {age} years old.");
    }
}

