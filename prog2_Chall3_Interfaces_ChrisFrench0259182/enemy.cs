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
       // public EnemyPosition(int, int);
        public ConsoleColor Color;
        public IMoveStrategy _moveStrategy;
        //public int enemy_x_pos;
        //public int enemy_y_pos;
        //public int enemy_Old_X;
        //public int enemy_Old_Y;
        //public (int, int) enemy_min_max_x = (15, 35);
        //public (int, int) enemy_min_max_y = (12, 29);
        
       // public (int,int) location = (enemy_x_pos, enemy_y_pos);
        public Enemy(Position position, ConsoleColor color, IMoveStrategy strategy) //setsenemy positioon , colour , and the  movement strat usedd
        {
            
            Position = position;
            Color = color;
            _moveStrategy = strategy;
            Console.Write(" ");
        }

        public void Move()
        {
            //if (p1_x_pos > enemy_x_pos)
            //{
            //    enemy_x_pos++;
            //}
            //if (p1_x_pos < enemy_x_pos)
            //{
            //    enemy_x_pos--;
            //}
            //if (p1_y_pos > enemy_y_pos)
            //{
            //    enemy_y_pos++;
            //}
            //if (p1_y_pos < enemy_y_pos)
            //{
            //    enemy_y_pos--;
            //}
            Position = _moveStrategy.Move(Position, Console.WindowWidth, Console.WindowHeight); // checks enemy movement against established boundaries
        }
            public int x;
            public int y;
        
           //// public EnemyPosition(int x, int y)// gets the player position
           // {
           //     this.x = x;
           //     this.y = y;
           // }

            //public void DrawEnemy()
            //{

            //    Console.SetCursorPosition(next.X, next.Y);


            //    Console.Write(" ");



            //}
        }

    }


