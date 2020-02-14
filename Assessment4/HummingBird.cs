using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment4
{
    class HummingBird : Bird
    {

        public HummingBird(double speed, double weight) : base(speed, weight)
        {
            Speed = 9.0;
            Weight = 1.4;

        }

        public override double BirdMomentum()
        {

            Console.Write("Humming Bird's Momentum: "); return base.BirdMomentum();
        }

        public override string Speak()
        {
            Console.Write("HummingBird's say: ");
            return "HmHmhmmmmmhhhmm";
        }

        public override string ToString()
        {
            return $"HummingBird's speed: {Speed}! \nHummingBird's weight: {Weight}";
            
        }

    }
}
