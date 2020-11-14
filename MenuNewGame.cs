using System;
using System.Collections.Generic;
using System.Text;

namespace Filwords.Menu
{
    class MenuNewGame
    {
        public static void WriteName()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2), 3);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What's your name?");
            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2), 4);
            string playerName = Console.ReadLine();
            Console.ResetColor();
        }
    }
}

