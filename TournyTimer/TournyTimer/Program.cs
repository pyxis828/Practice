using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Media;

namespace TournyTimer
{
    class Program
    {
        static void Main(string[] args)
        {             
            Timer timer = new Timer();                    
            timer.Interval =  1000;
            timer.Enabled = true;                    
            timer.Elapsed += new ElapsedEventHandler(timerZero);
            timer.Start();
        }
        static void timerZero(object sender, ElapsedEventArgs e)
        {
            int time = 10;
            int i = time;
            string[] clock = new string[time];
            for (i = time; i >= 0; i--)
            {
                clock[i] = i.ToString();
                //SystemSounds.Hand.Play();
                //Console.WriteLine(i.ToString("00:00" + " "));
                if (i == 0)
                {
                    Console.WriteLine(clock[i] + "Time's up");
                    SystemSounds.Exclamation.Play();
                }
            }
        }
    }     
  }