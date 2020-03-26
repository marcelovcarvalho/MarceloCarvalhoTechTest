using System;
namespace IntuitionTest.Question2
{
    public class Truck : ITransport
    {
        public Truck()
        {
        }

        public void Move()
        {
            Console.WriteLine("something else here");
        }
    }
}
