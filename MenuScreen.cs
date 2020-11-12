using System;
using System.Collections.Generic;
using System.Text;

namespace Filwords.Menu
{
    class MenuScreen
    {
        public static void Print()
        {
            string name = "F I L L W O R D S";
            string newGame = "New Game";
            string resume = "Resume";
            string rating = "Rating";
            string exit = "Exit";

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2), 1); 
            Console.WriteLine($"{name}");
            Console.ResetColor();
            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2) + 5, 2);
            Console.WriteLine($"{newGame}");

            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2) + 6, 3);
            Console.WriteLine($"{resume}");

            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2) + 6, 4);
            Console.WriteLine($"{rating}");

            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2) + 7, 5);
            Console.WriteLine($"{exit}");
        }
    }
}
