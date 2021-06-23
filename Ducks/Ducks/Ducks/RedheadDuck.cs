using Ducks.Implementations;

namespace Ducks.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override string Display()
        {
            return "Looks like a red head";
        }
    }
}
