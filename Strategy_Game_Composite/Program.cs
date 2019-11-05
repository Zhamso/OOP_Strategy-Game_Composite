using System;
using System.Collections.Generic;

namespace Strategy_Game_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Army archers = new Army();
            archers.Add(new Archer());
            archers.Add(new Archer());
            archers.Add(new Knight());

            Army knights = new Army();
            knights.Add(new Knight());
                Army subArmy = new Army();
                subArmy.Add(new Knight());
                subArmy.Add(new Archer());
            knights.Add(subArmy);

            Battlefield battlefield = new Battlefield(archers, knights, 10);

            for (int i = 0; i < 8; i++)
            {
                Console.ReadKey();
                battlefield.NextTurn();
            }
            Console.ReadKey();
            battlefield.PrintScores();
        }
    }
}
