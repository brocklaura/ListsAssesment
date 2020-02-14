using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment4
{
    class Duck : Bird
    {


        public Duck(double speed, double weight) : base(speed, weight)
        {
            Speed = 60.0;
            Weight = 3.5;

        }

        public override double BirdMomentum()
        {

            Console.Write("Duck's momentum: "); return base.BirdMomentum();
        }

        public override string Speak()
        {

            Console.Write("Duck's say: "); return $"Quack quack";
        }

        public override string ToString()
        {
            return $"Duck's speed: {Speed}! \nDuck's weight: {Weight}";
        }

    }
}
