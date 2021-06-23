using Ducks.Implementations;

namespace Ducks.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }
        public override string Display()
        {
            return "Looks like a decoy duck";
        }
    }
}
