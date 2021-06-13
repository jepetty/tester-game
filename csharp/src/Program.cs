using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Interactive block = new GameObject(10, 10);
            block.interact();
        }
    }
}
