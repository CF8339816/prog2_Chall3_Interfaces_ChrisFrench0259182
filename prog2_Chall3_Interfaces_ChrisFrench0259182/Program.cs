using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Chall3_Interfaces_ChrisFrench0259182
{
    class Program
    {
        public static Player player = new Player(new Position(10, 10), ConsoleColor.Green); // sets player spawn and colouur
       
        
        
        //public static ConsoleColor[] spriteColors = { ConsoleColor.Cyan, ConsoleColor.Red};

        static void Main()
        {
         
            IMoveStrategy aggressive = new AgressiveMoveStrategy(); //sets new agresive move strat
            IMoveStrategy passive = new PassiveMoveStrategy();  // sets new passive movew strat
            IMoveStrategy random = new RandomMoveStrategy();//sets new ranndom move strat

            Enemy enemy = new Enemy(new Position(0, 0), ConsoleColor.Red, passive); // sets enemy spawn and colour and preset movement style
            Console.SetCursorPosition( 2, 14);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("press:\n ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("M " );
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("to Move,\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" I");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" for agressive move,\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" O");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" for passive movement,\n ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("P ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("for randomised movement.\n ");
            Console.Write(" and ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("esc");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" to exit the program \n");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                if (Console.KeyAvailable) // sets key calls for the different move strats
                {
                    var key = Console.ReadKey(true).Key;
                    Console.SetCursorPosition(2, 21);
                    if (key == ConsoleKey.M) enemy.Move();
                    else if (key == ConsoleKey.I) enemy._moveStrategy = aggressive;
                    else if (key == ConsoleKey.O) enemy._moveStrategy = passive;
                    else if (key == ConsoleKey.P) enemy._moveStrategy = random;
                    else if (key == ConsoleKey.Escape) break;
                    Console.SetCursorPosition( 2, 21);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"enemy location ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"({enemy.Position.x}, {enemy.Position.y}) \n ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"enemy movements style ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{enemy._moveStrategy.GetType().Name}");
                }
            }
        }

        //static void DrawPlayer()
        //{

        //    Console.SetCursorPosition(p1_x_pos, p1_y_pos);

        //    Console.ForegroundColor = spriteColors[0];
        //    Console.Write("&");

        //    Console.ResetColor();

        //}






    }
}
