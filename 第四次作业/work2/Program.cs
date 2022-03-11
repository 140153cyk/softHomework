using System;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.SetAlarmTime(0, 0, 5);
            Person student = new Person();

            clock.OnAlarm += student.ClockAlarmHandler;
            clock.OnTick += student.ClockTickHandler;

            clock.Start();

            while (true) { }

        }
    }
}
