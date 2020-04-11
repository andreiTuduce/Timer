using System;
using System.Linq;
using TimerClient.TimerService;

namespace TimerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int timerDuration = 15 * 60 * 1000;

            if (args.Any())
                timerDuration = int.Parse(args[0]);

            TimerServiceClient timerServiceClient = new TimerServiceClient();

            Console.WriteLine("Started timer!");
            Console.WriteLine(timerDuration);
            timerServiceClient.StartTimer(timerDuration);
        }
    }
}
