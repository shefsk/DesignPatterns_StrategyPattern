# DesignPatterns - Strategy
C# Implementation of Examples from Head First Design Patterns
This solution is an implementation of the Strategy Pattern using the Duck Simulator example from the book Head First Design Patterns.

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
Strategy lets the algorithm vary independently from the clients that use it.

Here the Duck and its extended classes like, MallardDuck, RubberDUck , etc are the Client
The Fly and Quack properties of each duck are encapsulated in the IFlyBehavior and IQuackBehavior interfaces. These interfaces can be 
implemented based on the class that will implement it i.e FlyWithWings implements IFlyBehavior and has the ability to fly, whereas the 
FlyNoWay implements IFlyBehavior but cannot fly.
