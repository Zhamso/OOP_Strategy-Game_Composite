using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Game_Composite
{
    class Battlefield
    {
        Army army1 = new Army();
        Army army2 = new Army();
        int distance, turn = 1;
        int army1Total = 0, army2Total = 0;

        public Battlefield(Army army1, Army army2, int distance)
        {
            this.army1 = army1;
            this.army2 = army2;
            this.distance = distance;
        }

        public void NextTurn()
        {
            if(turn == 1)
            {
                Console.WriteLine($"---Ход армии 1---");
                if(army1.GetRange() < distance)
                {
                    Console.WriteLine($"Армия 1 перемещается ближе на {army1.GetSpeed()}");
                    distance = constrainToPositive(distance - army1.GetSpeed());
                }
                Console.WriteLine($"Армия 1 наносит {army1.Fire(distance)} урона сопернику");
                army1Total += army1.Fire(distance);
            }
            else
            {
                Console.WriteLine($"---Ход армии 2---");
                if (army2.GetRange() < distance)
                {
                    Console.WriteLine($"Армия 2 перемещается ближе на {army2.GetSpeed()}");
                    distance = constrainToPositive(distance - army2.GetSpeed());
                }
                Console.WriteLine($"Армия 2 наносит {army2.Fire(distance)} урона сопернику");
                army2Total += army2.Fire(distance);
            }
            Console.WriteLine($"Дистанция = {distance}");
            Console.WriteLine();
            turn *= -1;
        }

        public void PrintScores()
        {
            Console.WriteLine("---Итоги---");
            Console.WriteLine($"Армия 1 нанесла {army1Total} урона");
            Console.WriteLine($"Армия 2 нанесла {army2Total} урона");
        }

        private int constrainToPositive(int a)
        {
            if(a < 0)
            {
                return 0;
            }
            else
            {
                return a;
            }
        }
    }
}
