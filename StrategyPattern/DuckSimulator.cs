using StrategyPattern.Fly;
using System;

namespace StrategyPattern
{
    public class DuckSimulator
    {
        static void Main(string[] args)
        {
            Duck Mallard = new MallardDuck();
            Mallard.Display();
            Mallard.PerformQuack();
            Mallard.PerformFly();

            Duck Model = new ModelDuck();
            Console.WriteLine();
            Model.Display();
            Model.PerformQuack();
            Model.PerformFly();
            Model.SetFlyBehavior(new FlyRocketPowered());
            Model.PerformFly();

            Duck Redhead = new RedheadDuck();
            Console.WriteLine();
            Redhead.Display();
            Redhead.PerformQuack();
            Redhead.PerformFly();

            Duck Rubber = new RubberDuck();
            Console.WriteLine();
            Rubber.Display();
            Rubber.PerformQuack();
            Rubber.PerformFly();

            Duck Decoy = new DecoyDuck();
            Console.WriteLine();
            Decoy.Display();
            Decoy.PerformQuack();
            Decoy.PerformFly();

        }
    }
}