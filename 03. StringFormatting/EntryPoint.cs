using System;
class EntryPoint
{
    static void Main()
    {
        string fruit = "strawberry";
        string juice = "juice";

        //To align the characters to the right, put a place holder in the cw
        //Then place the number of spaces needed until the last character 
        //Is placed at the number
        Console.WriteLine("{0, 10}", fruit);
        Console.WriteLine("{0, 10}", juice);
        //note: Hold shift and press enter to jump 
        //to next line in code no matter where you are

        //You can also use it in interpolation
        Console.WriteLine($"{fruit,15}");
        Console.WriteLine($"{juice,15}");

        //Formatting with dollar signs
        int dollarSigns = 10000;
        Console.WriteLine($"{dollarSigns,15:C}");//The :C changes to currency
        double dollarSigns2 = 10000.567890;
        Console.WriteLine($"{dollarSigns2,15:C5}");//The number after the currency specifies the number
        //of points after the decimal. Remember float only has 7 digits so it would be rounded
        //try double instead
        Console.WriteLine("{0, 10:N10}", dollarSigns2);//The :N changes to number, no currency sign


        //Challenge. Using formatting, set up the protein intake form. The boarders should all be 
        //In the same alignment. Seperators should be used to seperate the week and the total.
        //All day numbers should have 2 decimials
        string proteinIntakeWeek = "Protein Intake Week: 1";
        float proteinDay1 = 80.88557f;
        float proteinDay2 = 94.56465f;
        float proteinDay3 = 78.67893f;
        float proteinDay4 = 88.66654f;
        float proteinDay5 = 88.6466f;
        float proteinDay6 = 76.777f;
        float proteinDay7 = 91.85759f;
        float proteinIntakeWeekTotal = 0.0f;

        string seperator = new string('=', proteinIntakeWeek.Length);
        string boarder = "|";

        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(boarder + seperator + boarder);
        Console.WriteLine(boarder + ($"{proteinIntakeWeek,15}") + boarder);
        Console.WriteLine(boarder + ($"{seperator,10}") + boarder);
        Console.WriteLine(boarder + ($"{proteinDay1,22:N2}") + boarder);
        Console.WriteLine(boarder + ($"{proteinDay2,22:N2}") + boarder);
        Console.WriteLine(boarder + ($"{proteinDay3,22:N2}") + boarder);
        Console.WriteLine(boarder + ($"{proteinDay4,22:N2}") + boarder);
        Console.WriteLine(boarder + ($"{proteinDay5,22:N2}") + boarder);
        Console.WriteLine(boarder + ($"{proteinDay6,22:N2}") + boarder);
        Console.WriteLine(boarder + ($"{proteinDay7,22:N2}") + boarder);
        Console.WriteLine(boarder + seperator + boarder);
        proteinIntakeWeekTotal = proteinDay1 + proteinDay2 + proteinDay3 +
            proteinDay4 + proteinDay5 + proteinDay6 + proteinDay7;
        Console.WriteLine(boarder + "Total: " + ($"{proteinIntakeWeekTotal,15:N2}") + boarder);
        Console.WriteLine(boarder + seperator + boarder);
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
    }
}


