using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Crickets chirping.....");
        }
    }
}
