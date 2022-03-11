using System;
using System.Collections.Generic;
using System.Text;

namespace work2
{
    class Person
    {
        bool sleep = true;

        public void ClockTickHandler(object clock)
        {
            Console.WriteLine(sleep?"Person is sleeping...":"Person is working...");
        }
        public void ClockAlarmHandler(object clock)
        {
            sleep = false;
            Console.WriteLine("Person is waking up.");
        }
    }
}
