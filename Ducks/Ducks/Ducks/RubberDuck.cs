using Ducks.Implementations;

namespace Ducks.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }
        public override string Display()
        {
            return "Looks like a rubber duck";
        }
    }
}
