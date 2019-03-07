using StrategyPattern.Quack;
using System;

namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new DuckQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Model Duck! ");
        }
    }
}
