using System;
class EntryPoint
{
    static void Main()
    {
        Console.Title = "The Thief & The Muse";//To change the title at the top of the console
        Console.CursorVisible = true;//To make the cursor (pronouced curser) to visible, takes a boolean
        Console.CursorSize = 50;//Changes cursor size (between 1-100). Must be visible

        //You can change the cursor on the left and top position
        //Console.SetCursorPosition(20, 10);
        //As well as on solo axises left and right
        Console.CursorLeft = 20;
        Console.CursorTop = 10;
        Console.ReadLine();


    }
}

