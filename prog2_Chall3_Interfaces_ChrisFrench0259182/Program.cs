using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace prog2_Chall3_Interfaces_ChrisFrench0259182
{
    class Program
    { 
        
        public static int maxX = 11; //sets max  x range 
        public static int maxY = 11; // sets max  y range 
        public static int nextX; 
        public static int nextY;
        //  static bool isPlaying = true;
       



        static void Main()
        {

            Player player = new Player(new Position(10, 10), ConsoleColor.Green); // sets player spawn and colouur
            
            IMoveStrategy aggressive = new AgressiveMoveStrategy(); //sets new agresive move strat
            IMoveStrategy defensive = new DefensiveMoveStrategy();  // sets new passive movew strat
            IMoveStrategy random = new RandomMoveStrategy();//sets new ranndom move strat
            
            Enemy enemy = new Enemy(new Position(0, 0), ConsoleColor.Red, random); // sets enemy spawn and colour and preset movement style

            //while (isPlaying)
            //{
                DrawPlayer();
                DrawEnemy();







                Console.SetCursorPosition(2, 14);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("press:\n ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("M ");
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
                Console.Write("Q");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" to exit the program \n");
                Console.ForegroundColor = ConsoleColor.White;
                while (true)
                {
                    if (Console.KeyAvailable) // sets key calls for the different move strats
                    {
                        var key = Console.ReadKey(true).Key;

                        if (key == ConsoleKey.M)
                        {
                            enemy.Move();
                            DrawPlayer();
                            DrawEnemy();
                        }
                        else if (key == ConsoleKey.I) enemy._moveStrategy = aggressive;
                        else if (key == ConsoleKey.O) enemy._moveStrategy = random;
                        else if (key == ConsoleKey.P) enemy._moveStrategy = defensive;
                        else if (key == ConsoleKey.Escape) break;
                        //else if (key == ConsoleKey.Escape) isPlaying = false;//Quit the 'is playing' loop
                        Console.SetCursorPosition(2, 21);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"player location ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"({player.Position.x}, {player.Position.y}) \n ");
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

                ConsoleKey GetKey = default;
                if (GetKey == ConsoleKey.Q)
                {

                    // isPlaying = false;//Quit the 'is playing' loop
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n you  have  chosen to  exit  sorry to see you go... ");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
            }
         
       // }

       static void DrawPlayer()
       {

            Player player = new Player(new Position(10, 10), ConsoleColor.Green); // sets player spawn and colouur
            Console.SetCursorPosition(player.Position.x, player.Position.y);
       
            Console.ForegroundColor = player.Color; 
           
            Console.Write("&");

           
        }

       public static void DrawEnemy()
        {
            IMoveStrategy aggressive = new AgressiveMoveStrategy(); //sets new agresive move strat
            IMoveStrategy defensive = new DefensiveMoveStrategy();  // sets new passive movew strat
            IMoveStrategy random = new RandomMoveStrategy();//sets new ranndom move strat

            Enemy enemy = new Enemy(new Position(0, 0), ConsoleColor.Red, random); // sets enemy spawn and colour and preset movement style


            //Position.x == nextX;
            //Position.y == nextY;
            //enemy.x == nextX;
            //enemy.y == nextY;
            //enemy.Position.x == nextX;
            //enemy.Position.y == nextY;


            Console.SetCursorPosition(enemy.Position.x, enemy.Position.y);

            Console.ForegroundColor = enemy.Color;

            Console.Write("#");



        }




    }
}
