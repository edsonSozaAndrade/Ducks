using Ducks.Implementations;
using System;

namespace Ducks.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override string Display()
        {
            return "Looks like a mallard";
        }
    }
}
