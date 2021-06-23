using Ducks.Interfaces;

namespace Ducks.Implementations
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I can’t fly";
        }
    }
}
