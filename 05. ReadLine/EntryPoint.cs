using System;
class EntryPoint
{
    static void Main()
    {
        //Console.Write("How old are you? ");
        
        //string age = Console.ReadLine();

        //Console.ReadLine() reads a string 
        //You do not need to type cast.

        //To read as a number datatype, you must turn it into an interger
        //Use parse to do this
        //int age2 = int.Parse(Console.ReadLine());
        //Console.WriteLine($"You are {age2} years old.");
        //When parsing, it must be a number
        //When using string it can be anything but it won't read as a number


        //Challenge. Input a drive, followed by a path, and the program
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.Write("Enter the drive letter: ");
        string driveLetter = Console.ReadLine();
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();
        Console.Write("Enter the program name: ");
        string fileName = Console.ReadLine(); 
        Console.WriteLine($"{driveLetter}:\\{filePath}\\{fileName}.exe");
        //You shouldn't read Console.Read() because it is used on the next line as well

    }
}

