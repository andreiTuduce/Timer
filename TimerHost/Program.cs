using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using Timer;

namespace TimerHost
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(args);

            Uri baseAddress = new Uri("http://localhost:8000/Timer");

            ServiceHost host = new ServiceHost(typeof(TimerService), baseAddress);

            try
            {
                host.AddServiceEndpoint(typeof(ITimerService), new WSHttpBinding(), "TimerService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);

                host.Open();
                Console.WriteLine("Service is ready.");

                Console.WriteLine("Press any key to close it.");
                Console.ReadLine();
                host.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Exception: {0}", ce.Message);
                host.Abort();
            }

        }
    }
}
