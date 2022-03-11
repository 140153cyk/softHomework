using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace work2
{
    class Clock
    {
        public event Action<object> OnTick;
        public event Action<object> OnAlarm;

        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public int[] alarmTime = new int[3];

        public void SetAlarmTime(int hour,int minute,int second)
        {
            alarmTime[0] = hour;
            alarmTime[1] = minute;
            alarmTime[2] = second;

        }

        public void Start()
        {
            Hour = Minute = Second = 0;
            Timer mytimer = new Timer();
                mytimer.Elapsed += (object source, System.Timers.ElapsedEventArgs e) =>
                {
                    Second++;
                    Minute += Second / 60;
                    Hour += Minute / 60;
                    Second %= 60;
                    Minute %= 60;
                    Hour %= 24;
                    Tick();
                };
            mytimer.Enabled = true;
            mytimer.AutoReset = true;
            mytimer.Interval = 1000;
            mytimer.Start();

            Tick();

        }
        public void Tick()
        {
            

            Console.WriteLine(Hour+" : "+ Minute + " : " + Second );
            OnTick(this);
         if (Hour == alarmTime[0] && Minute == alarmTime[1] && Second == alarmTime[2]) Alarm();
           
          
           
        }
        public void Alarm()
        {
            Console.WriteLine("clock is alarming!!");
            OnAlarm(this);
        }
    }
}
