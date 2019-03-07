using StrategyPattern.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new DuckQuack();
        }


        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck!!");
        }
    }
}
