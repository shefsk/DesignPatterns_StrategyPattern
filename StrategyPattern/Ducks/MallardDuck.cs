using StrategyPattern.Quack;
using System;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new DuckQuack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I am a real Mallard Duck.");
        }
              
    }
}
