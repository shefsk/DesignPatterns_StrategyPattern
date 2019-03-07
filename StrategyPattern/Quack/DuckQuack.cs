using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Quack
{
    public class DuckQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
