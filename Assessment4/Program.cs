using System;
using System.Collections.Generic;

namespace Assessment4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Bird> birdList = new List<Bird>();
            birdList.Add(new Chicken(2.5, 5));
            birdList.Add(new Duck(61.1, 4.9));
            birdList.Add(new HummingBird(1.1, 7.2));

            Console.WriteLine("Welcome to Riley's Bird Farm");
            Console.WriteLine("-----------------------------");

            for (int i = 0; i < birdList.Count; i++)
            {
                foreach (Bird bird in birdList)
                {
                    Console.WriteLine($"Type of bird: {bird.GetType()}");
                    Console.WriteLine(bird.ToString());
                    Console.WriteLine(bird.BirdMomentum());
                    Console.WriteLine(bird.Speak());
                    Console.WriteLine("===============================");
                }
            }

            //comment for using SOLID Principles:
           //i have used the solid principles in my challenge by the single responsibility principle when creating classes and giving them similar or one job to do. 
           //also by using LSP in my class creation which is an extension from the open close principle which means
           //we make sure the new derived class extends the base. Also steering clear of ISP and not using unwating IFs. 




            //Chicken chicken = new Chicken();
            //Console.WriteLine(chicken.BirdMomentum());
            //Console.WriteLine(chicken.Speak());

            //Duck duck = new Duck();
            //Console.WriteLine(duck.BirdMomentum());
            //Console.WriteLine(duck.Speak());

            //HummingBird hummingbird = new HummingBird();
            //Console.WriteLine(hummingbird.BirdMomentum());
            //Console.WriteLine(hummingbird.Speak());
        }
    }
}
