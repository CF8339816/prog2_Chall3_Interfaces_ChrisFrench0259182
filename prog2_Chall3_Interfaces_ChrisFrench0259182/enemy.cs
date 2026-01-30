using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prog2_Chall3_Interfaces_ChrisFrench0259182
{
    public class Enemy
    {
        public Position Position;
       
        public ConsoleColor Color;
        public IMoveStrategy _moveStrategy;
      






        public Enemy(Position position, ConsoleColor color, IMoveStrategy strategy) //setsenemy positioon , colour , and the  movement strat usedd
        {
            
            Position = position;
            Color = color;
            _moveStrategy = strategy;
         
        }

        public void Move()
        {
            
            Position = _moveStrategy.Move(Position, Console.WindowWidth, Console.WindowHeight); // checks enemy movement against established boundaries
        }
            public int x;
            public int y;
        
         
        }

    }


