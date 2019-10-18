using System;

class EntryPoint
{
static void Main()
{
        Console.BackgroundColor = ConsoleColor.White;

        //You have to use the ForegroundColor property to make every word the selected color
        Console.ForegroundColor = ConsoleColor.Black;//The ConsoleColor property gives you a
        //list of options to choose

        Console.WriteLine("When you start it is like this.");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("In the middle it is like this.");
        Console.ResetColor();//Use this method to change the console back to its default
        Console.WriteLine("In the end you can reset");
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Using write");
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" instead of writeline");
        Console.ResetColor();
        Console.Write(" can be helpful when changing colors.\n");



        //Challenge. Using the info from the last challenge, change
        //the background colors to put life into the information
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

        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

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
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
    }
}
