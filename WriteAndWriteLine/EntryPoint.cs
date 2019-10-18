using System;

class EntryPoint
{
    static void Main()
    {
        Console.Write("I am "); //There is no shortcut for console.write
        //Press and hold Alt+Shift and press the DownArrowKey to write the same thing on multiple lines
        //The number of multiple lines you want to use is based on how many times you press the
        //DownArrowKey
        Console.Write("learning from the ");
        Console.Write("best C# course");
        //Using write in pieces like this instead of writeline makes the sentences
        //Have new lines everytime. 
        //Use the newline special character (\n) when using write to make it like writeline
        Console.Write("\nMaybe I'll do more than just");
        Console.Write("\nvanilla skills this time \n\n");

        //Challenge from course, menu items using one console.write
        Console.Write("1. Add new item \n" +
            "2. Edit an item \n" +
            "3. Remove an item \n" +
            "4. Exit \n" +
            "Your choice: \n\n");
        //Pressing enter after a \n character in a single sentence automatically concatinates it
        //This is a Visual Studio effect


        
       
    }
}

