using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Game_Composite
{
    interface IUnit
    {
        int Fire(int dist);
        int GetSpeed();
        int GetRange();
    }

    abstract class Unit : IUnit
    {
        protected int Damage, Speed, Range;

        public Unit(int damage, int speed, int range)
        {
            Damage = damage;
            Speed = speed;
            Range = range;
        }

        public int Fire(int dist)
        {
            if(Range >= dist)
            {
                return Damage;
            }
            else
            {
                return 0;
            }
        }

        public int GetRange()
        {
            return Range;
        }

        public int GetSpeed()
        {
            return Speed;
        }
    }

    class Army : IUnit
    {
        ArrayList army = new ArrayList();
        int minRange = -1;

        public void Add(IUnit unit)
        {
            army.Add(unit);
            if(unit.GetRange() < minRange || minRange == -1)
            {
                minRange = unit.GetRange();
            }
        }

        public void Remove(IUnit unit)
        {
            army.Remove(unit);
        }

        public int Fire(int dist)
        {
            int totalDamage = 0;
            foreach (IUnit unit in army)
            {
                totalDamage += unit.Fire(dist);
            }
            return totalDamage;
        }

        public int GetSpeed()
        {
            int min = -1;
            foreach (IUnit unit in army)
            {
                if(unit.GetSpeed() < min || min == -1)
                {
                    min = unit.GetSpeed();
                }
            }
            return min;
        }

        public int GetRange()
        {
            return minRange;
        }
    }
}
