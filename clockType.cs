using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    internal class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;

        public clockType()
        {
            hours = 0; minutes = 0; seconds = 0; 
        }
        public clockType(int h,int m,int s)
        {
            hours = h; minutes = m; seconds = s;
        }
        public void Time()
        {
            Console.WriteLine("Clock :");
            Console.WriteLine(hours+" : "+minutes+" : "+seconds+" ");
            timeincrease();
        }
        public void timeincrease()
        {
            Thread.Sleep(1000);
            Console.SetCursorPosition(0,0);
            seconds++;
            if (seconds >= 60)
            {
                seconds= 0;
                minutes++;
            }
            if(minutes >= 60)
            {
                minutes= 0;
                hours++;
            }
            if(hours >= 24)
            {
                hours= 0;
            }
            Time();
        }
    }
}
