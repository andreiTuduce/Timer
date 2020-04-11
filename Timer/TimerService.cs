using System;
using System.Timers;

namespace Timer
{
    public class TimerService : ITimerService
    {
        public void StartTimer(int miliseconds)
        {
            Console.WriteLine(miliseconds);

            int minutes = miliseconds / 1000 / 60;
            Console.WriteLine("Timer was started for {0} minutes", minutes);

            System.Timers.Timer timer = new System.Timers.Timer(miliseconds);

            timer.Elapsed += TimerPassed;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void TimerPassed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Event passed");
            Console.WriteLine(sender);

            System.Timers.Timer timer = (System.Timers.Timer)sender;

            Console.WriteLine("Timer is stopped!");
            timer.Stop();
        }
    }
}
