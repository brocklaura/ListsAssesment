using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment4
{
    class Chicken : Bird
    {
        public Chicken(double speed, double weight) : base(speed, weight)
        {
            Speed = 9.0;
            Weight = 1.4;
        }

        public override double BirdMomentum()
        {

            Console.Write("Chicken's momentum: "); return base.BirdMomentum();
        }

        public override string Speak()
        {

            Console.Write("Chicken's say: "); return $"cluck cluck";
        }

        public override string ToString()
        {
            return $"Chicken's speed: {Speed}! \nChicken's weight: {Weight}";
        }
    }

 
    
}
