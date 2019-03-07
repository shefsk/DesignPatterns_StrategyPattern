using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly :( ");
        }
    }
}
