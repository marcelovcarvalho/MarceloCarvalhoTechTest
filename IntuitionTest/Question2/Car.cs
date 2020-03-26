using System;
namespace IntuitionTest.Question2
{
    public class Car : ITransport
    {
        public Car()
        {
        }

        public void Move()
        {
            Console.WriteLine("some logic here");
        }
    }
}
