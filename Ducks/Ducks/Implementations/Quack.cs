using Ducks.Interfaces;
using System;

namespace Ducks.Implementations
{
    public class Quack : IQuackBehavior
    {
        string IQuackBehavior.Quack()
        {
            return "Quack";
        }
    }
}
