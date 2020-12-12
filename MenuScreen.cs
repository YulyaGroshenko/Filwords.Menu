using System;
using System.Collections.Generic;
using System.Text;

namespace Filwords.Menu
{
    class MenuScreen
    { 
        public static void PrintMenu(ConsoleColor colorNewGame, ConsoleColor colorResume, ConsoleColor colorRating, ConsoleColor colorExit)
        {
            string name = "F I L L W O R D S";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2), 1);
            Console.WriteLine($"{name}");
            Console.ResetColor();

            string newGame = "New Game";
            string resume = "Resume";
            string rating = "Rating";
            string exit = "Exit";
            

            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2) + 5, 2);
            Console.ForegroundColor = colorNewGame;
            Console.WriteLine($"{newGame}");

            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2) + 6, 3);
            Console.ForegroundColor = colorResume;
            Console.WriteLine($"{resume}");

            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2) + 6, 4);
            Console.ForegroundColor = colorRating;
            Console.WriteLine($"{rating}");

            Console.SetCursorPosition((Console.WindowWidth / 2) - (Console.WindowHeight / 2) + 7, 5);
            Console.ForegroundColor = colorExit;
            Console.WriteLine($"{exit}");
 

        }
        
    }
}
