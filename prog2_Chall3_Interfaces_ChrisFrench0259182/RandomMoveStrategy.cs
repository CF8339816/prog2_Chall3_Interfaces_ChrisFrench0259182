using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Chall3_Interfaces_ChrisFrench0259182
{
    public class RandomMoveStrategy : IMoveStrategy
    {
        private Random _rng = new Random();
        public Position Move(Position pos) => new Position(pos.x + _rng.Next(-1, 2), pos.y + _rng.Next(-1, 2));
    }
}
