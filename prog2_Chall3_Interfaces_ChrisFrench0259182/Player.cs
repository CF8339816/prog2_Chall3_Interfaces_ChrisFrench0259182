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
    
            


        public Player(Position position, ConsoleColor color)// established variables for  player locaTIUON AND COLOUR
        {
            Position = position;
            Color = color;
            //Console.Write(" ");
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

       
    }
}

