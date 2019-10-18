using System;
class EntryPoint
{
    static void Main()
    {
        Console.Title = "Cursor Size";
        //Methods used to change the console size.
        Console.WindowHeight = 15;
        Console.WindowWidth = 25;
        //Console.SetWindowSize(20, 20);
        //Console.SetWindowSize(Console.LargestWindowHeight, Console.LargestWindowWidth);
        //Buffering: Controls the actual size of the console and how much you'll be able to scroll
        Console.BufferHeight = 15;
        Console.BufferWidth = 25;
        //Console.SetBufferSize(20, 20);
        //Console.SetBufferSize(Console.LargestWindowHeight, Console.LargestWindowWidth);
        //Buffersize must be greater than or equal to windowsize
        //WindowLeft/Top controls what part of the console you are viewing
        //Console.WindowLeft = 10;
        //Console.WindowTop = 10; 
        //Console.SetWindowPosition(10, 10);
        //The window position must be smaller than the buffersize - the windowsize 


        //Challenge. Using the info from the last challenge, change
        //The window and buffer size to make the entire output on a single
        //no scroll screen
        string proteinIntakeWeek = "Protein Intake Week: 1";
        float proteinDay1 = 80.88557f;
        float proteinDay2 = 94.56465f;
        float proteinDay3 = 78.67893f;
        float proteinDay4 = 88.66654f;
        float proteinDay5 = 88.6466f;
        float proteinDay6 = 76.777f;
        float proteinDay7 = 91.85759f;
        float proteinIntakeWeekTotal = proteinDay1 + proteinDay2 + proteinDay3 +
            proteinDay4 + proteinDay5 + proteinDay6 + proteinDay7;

        string seperator = new string('=', proteinIntakeWeek.Length);

        //This information is used to make the colors variables to be used
        //for easier access.
        ConsoleColor seperatorBackgroundColor = ConsoleColor.Red;
        ConsoleColor dataBackgroundColor = ConsoleColor.DarkGreen;
        ConsoleColor weekBackgroundColor = ConsoleColor.DarkYellow;
        ConsoleColor weekTotalBackgroundColor = ConsoleColor.DarkBlue;

     

        Console.ForegroundColor = ConsoleColor.White;

        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|");
        Console.Write(seperator);
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");

        Console.Write("|");
        Console.BackgroundColor = weekBackgroundColor;
        Console.Write($"{proteinIntakeWeek,15}");
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");


        Console.Write("|");
        Console.Write(seperator);
        Console.Write("|\n");

        Console.Write("|");
        Console.BackgroundColor = dataBackgroundColor;
        Console.Write($"{proteinDay1,22:N2}");
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");

        Console.Write("|");
        Console.BackgroundColor = dataBackgroundColor;
        Console.Write($"{proteinDay2,22:N2}");
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");

        Console.Write("|");
        Console.BackgroundColor = dataBackgroundColor;
        Console.Write($"{proteinDay3,22:N2}");
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");

        Console.Write("|");
        Console.BackgroundColor = dataBackgroundColor;
        Console.Write($"{proteinDay4,22:N2}");
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");

        Console.Write("|");
        Console.BackgroundColor = dataBackgroundColor;
        Console.Write($"{proteinDay5,22:N2}");
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");

        Console.Write("|");
        Console.BackgroundColor = dataBackgroundColor;
        Console.Write($"{proteinDay6,22:N2}");
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");

        Console.Write("|");
        Console.BackgroundColor = dataBackgroundColor;
        Console.Write($"{proteinDay7,22:N2}");
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");

        Console.Write("|");
        Console.Write(seperator);
        Console.Write("|\n");

        Console.Write("|");
        Console.BackgroundColor = weekTotalBackgroundColor;
        Console.Write("Total: " + ($"{proteinIntakeWeekTotal,15:N2}"));
        Console.BackgroundColor = seperatorBackgroundColor;
        Console.Write("|\n");

        Console.Write("|");
        Console.Write(seperator);
        Console.Write("|\n");

        Console.ResetColor();
  
    }
}


