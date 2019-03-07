using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!!");
        }
    }
}
