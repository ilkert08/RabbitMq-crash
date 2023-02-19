using RabbitMq_crash;


namespace RabbitMq_crash
{
    public class RabbitMqExample
    {
        public static void Main(String[] args)
        {
            var machine = new Machine2();
            machine.Receive();
            Console.ReadKey();
        }

    }
}