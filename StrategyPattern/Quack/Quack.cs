using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Quack
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            //implements duck quacking
        }
    }
}
