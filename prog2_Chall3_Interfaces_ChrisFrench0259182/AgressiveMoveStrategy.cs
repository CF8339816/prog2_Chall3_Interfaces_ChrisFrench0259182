using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Chall3_Interfaces_ChrisFrench0259182
{

    public class AgressiveMoveStrategy : IMoveStrategy
    {
        public Position Move(Position pos, int maxX, int maxY)// sets up a more player targeted   agressive movement strat

        {
           
            int nextX = pos.x + 1;
            int nextY = pos.y + 1;

           
            if (nextX < 0) nextX = 0;// checks againt max limits
            if (nextX >= maxX) nextX = maxX - 1;

            if (nextY < 0) nextY = 0;// checks againt max limits
            if (nextY >= maxY) nextY = maxY - 1;

            return new Position(nextX, nextY);
            
        }
    }
}
