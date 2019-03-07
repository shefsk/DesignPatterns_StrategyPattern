using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Quack;

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
