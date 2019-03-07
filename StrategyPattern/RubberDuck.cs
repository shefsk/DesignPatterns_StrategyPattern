using StrategyPattern.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck!!");
        }
    }
}
