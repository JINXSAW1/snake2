using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 35);
            Console.SetBufferSize(80, 35);
            Console.Title = "Snake";

            Walls walls = new Walls(80, 35);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();

            FoodCreator foodCreator = new FoodCreator(80, 35, '+');
            Point food = foodCreator.CreateFood(); 
            food.Draw();


            while(true)
            {
                if ( walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.UsedKey(key.Key);
                }
                
                
            }
            GameOver();



        }
        static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(35, 18);
            Console.WriteLine("Game over");
            Console.Read();
        }
        
    }
}
