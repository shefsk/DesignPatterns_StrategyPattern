using System;

/// <summary>
/// Client
/// </summary>
namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior;
        public IQuackBehavior QuackBehavior;

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            FlyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }

    }
}
