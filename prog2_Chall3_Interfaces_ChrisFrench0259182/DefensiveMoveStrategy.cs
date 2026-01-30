using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace prog2_Chall3_Interfaces_ChrisFrench0259182
{
    public class DefensiveMoveStrategy : IMoveStrategy
    {
        public Position Move(Position currentPos, int maxX, int maxY)// sets up passive movement strat
        {

            maxX = 11;
            maxY = 11;
            int nextX = currentPos.x - 1;
            int nextY = currentPos.y - 1;

         
            if (nextX < 0) nextX = 0;// checks againt max limits
            else if (nextX >= maxX) nextX = maxX - 1;

           
            if (nextY < 0) nextY = 0;// checks againt max limits
            else if (nextY >= maxY) nextY = maxY - 1;

            return new Position(nextX, nextY);
        }
    }
}
    