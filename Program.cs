using System;

namespace Filwords.Menu
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            MenuScreen.PrintMenu(ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
            MenuSelect.Select();
        } 
    }
}
