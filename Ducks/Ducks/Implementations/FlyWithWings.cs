using Ducks.Interfaces;

namespace Ducks.Implementations
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "I’m flying!!";
        }
    }
}
