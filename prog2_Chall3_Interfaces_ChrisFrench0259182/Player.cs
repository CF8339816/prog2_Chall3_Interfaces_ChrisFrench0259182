using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Chall3_Interfaces_ChrisFrench0259182
{

    public class Player
    {
        public Position Position;
        public ConsoleColor Color;
        //public int p1_x_input;
        //public int p1_y_input;
        //public int p1_x_pos;
        //public int p1_y_pos;
        //public (int, int) p1_min_max_x = (1, 55);
        //public (int, int) p1_min_max_y = (1, 29);
        //public int p1_Old_X;
        //public int p1_Old_Y;
            


        public Player(Position position, ConsoleColor color)// established variables for  player locaTIUON AND COLOUR
        {
            Position = position;
            Color = color;
            Console.Write(" ");
        }
    }


    public struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)// gets the player position
        {
            this.x = x;
            this.y = y;
        }

        //public void DrawPlayer()
        //{

        //    Console.SetCursorPosition(this.x, this.y);

          
        //    Console.Write(" ");



        //}
    }
}

