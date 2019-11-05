using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Game_Composite
{
    class Knight : Unit
    {
        public Knight() : base(8, 2, 1)
        {
        }

        public Knight(int damage, int speed, int range) : base(damage, speed, range)
        {
        }
    }

    class Archer : Unit
    {
        public Archer() : base(5, 5, 8)
        {
        }

        public Archer(int damage, int speed, int range) : base(damage, speed, range)
        {
        }
    }

    class Cavalry : Unit
    {
        public Cavalry() : base(6, 7, 1)
        {
        }

        public Cavalry(int damage, int speed, int range) : base(damage, speed, range)
        {
        }
    }

    class Catapult : Unit
    {
        public Catapult() : base(15, 1, 13)
        {
        }

        public Catapult(int damage, int speed, int range) : base(damage, speed, range)
        {
        }
    }
}
