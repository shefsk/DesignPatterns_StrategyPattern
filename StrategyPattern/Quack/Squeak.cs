using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Quack
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
