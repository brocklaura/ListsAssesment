using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment4
{
    abstract class Bird
    {

        private double speed;
        private double weight;


        public Bird(double speed, double weight)
        {
            speed = Speed;
            weight = Weight;
        }

        public double Speed { get => speed; set => speed = value; }
        public double Weight { get => weight; set => weight = value; }

        public virtual double BirdMomentum()
        {
            double calculatedMomentum;
            calculatedMomentum = Speed * Weight;
            return calculatedMomentum;
        }

        public abstract string Speak();
  

    }
}
