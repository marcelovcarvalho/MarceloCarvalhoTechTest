using System;
namespace IntuitionTest.Question2
{
    public class TransportManager
    {
        public static void DoSomeLogic(ITransport transport)
        {
            transport.Move();
        }
    }
}
