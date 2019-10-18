class EntryPoint
{
    static void Main()
    {
        //Note special characters like the ones here are known as reserved characters
        //And there are escape characters that are used to output reserved characters
        //So they will not have their effect used. Read below, carefully 

        //The backslash "\" character is used to create special characters
        //When using it, the system is expecting a special character to do its effect
        //For instance the \n is newline (like in the WriteAndWriteLine project

        //So, if you were to use a \ when using a file directory, you would 
        //need two \s in order to have the effect of one, because the 
        //first one is used to expect a special character
        //and the second one will be used as the special character
        string exeFile = "swriter.exe";
        string pathToExe = "D:\\LibreOffice\\program\\";
        System.Console.WriteLine(pathToExe + exeFile);
        
        
        //If you want to write a line with quotation marks in them, you cannot
        //just put the quotation marks, you still need a \
        //the first quotation mark has the string, but the \" is how
        //you place quotation marks inside of the output itself
        string exeFile2 = "swriter.exe\"";
        string pathToExe2 = "\"D:\\LibreOffice\\program\\";
        //Notice how the beginning has a "\ and the end has a \"

        System.Console.WriteLine(pathToExe2 + exeFile2);

        //You can use the @ symbol at the beginning of the string works similarly to the \
        //With this you do not need a \ everytime
        //If you want to use quotation marks with the @ symbol, you just need to put
        //Another set of " marks, one for the special character, and another for the character needed
        string exeFile3 = @"swriter.exe""";
        string pathToExe3 = @"""D:\\LibreOffice\\program\";

        System.Console.WriteLine(pathToExe3 + exeFile3);

        //Challenge, using the escape characters, make a certain style of string output 
        System.Console.WriteLine("D:\\\"4_Visual Studio\"\\2019\\Common7\\IDE\\'devenv.exe");
        System.Console.WriteLine(@"D:\""4_Visual Studio""\2019\Common7\IDE\'devenv.exe'");

        //You can use Interpolation, too, when using reserved words
        System.Console.WriteLine($"{{{pathToExe}{exeFile}}}");
        //Like before, if you want to use the character "{" within the output
        //You must escape it similarly as with the quotations
        //Because in Interpolation, you use the "{" as a way to reference to the
        //String that the name "pathToExe" is referencing to



    }
}
