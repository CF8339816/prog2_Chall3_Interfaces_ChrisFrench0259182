using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Chall3_Interfaces_ChrisFrench0259182
{
    public interface IMoveStrategy
    {
        Position Move(Position currentPos, int maxWidth, int maxHeight);// adding a min max  move check 
       
        //currentPos.Y == nextX;
        //currentPos.Y == nextY;
    }
}
