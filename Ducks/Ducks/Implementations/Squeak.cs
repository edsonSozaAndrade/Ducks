using Ducks.Interfaces;
using System;

namespace Ducks.Implementations
{
    public class Squeak : IQuackBehavior
    {
        public string Quack()
        {
            return "Squeak";
        }
    }
}
