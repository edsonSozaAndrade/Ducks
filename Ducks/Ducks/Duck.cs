using Ducks.Interfaces;

namespace Ducks
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public abstract string Display();

        public string PerformFly()
        {
            return flyBehavior.Fly();
        }
        public string PerformQuack()
        {
            return quackBehavior.Quack();
        }
        public string Swim()
        {
            return "All ducks float, even decoys";
        }
    }
}
