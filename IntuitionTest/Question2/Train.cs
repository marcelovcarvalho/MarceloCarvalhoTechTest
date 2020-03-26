using System;
namespace IntuitionTest.Question2
{
    public class Train : ITransport
    {
        public Train()
        {
        }

        public void Move()
        {
            Console.WriteLine("of course I need more than just Writeln");
        }
    }
}
