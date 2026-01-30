using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Chall3_Interfaces_ChrisFrench0259182
{
    public class RandomMoveStrategy : IMoveStrategy
    {
        private Random _rando = new Random();
        public Position Move(Position pos, int maxX, int maxY)
        {

            maxX = 11;
            maxY = 11; 
            int nextX = pos.x + _rando.Next(-1, 2); //randomises mocve 
            int nextY = pos.y + _rando.Next(-1, 2);

          
            nextX = Math.Max(0, Math.Min(nextX, maxX - 1));// checks againt max limits
            nextY = Math.Max(0, Math.Min(nextY, maxY - 1));// checks againt max limits

            return new Position(nextX, nextY);
        }
    }
}
