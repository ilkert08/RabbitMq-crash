using RabbitMq_crash;


namespace RabbitMq_crash
{
    public class RabbitMqExample
    {
        public static void Main(String[] args)
        {
            var machine = new Machine1();
            int i = 1;
            string firstMessage = "We declare war to your country! "+ i++;
            machine.Publish(firstMessage);
            while (true)
            {
                var readMessage = Console.ReadLine();
                string message = $"Read - {readMessage}: {i++}";
                machine.Publish(message);

                if (readMessage != null && readMessage.Equals("end"))
                    break;
                
            }

            Console.ReadKey();
        }

    }
}