using Ducks.Interfaces;

namespace Ducks.Implementations
{
    public class MuteQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "<< Silence >>";
        }
    }
}
