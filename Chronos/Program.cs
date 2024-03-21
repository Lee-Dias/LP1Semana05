using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(200);
            crono1.Stop();
            crono2.Stop();
            TimeSpan crono1ts = crono1.Elapsed;
            TimeSpan crono2ts = crono2.Elapsed;

            string crono1elapsedTime =
            String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            crono1ts.Hours, crono1ts.Minutes, crono1ts.Seconds,
            crono1ts.Milliseconds / 10);

            string crono2elapsedTime = 
            String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            crono2ts.Hours, crono2ts.Minutes, crono2ts.Seconds,
            crono2ts.Milliseconds / 10);

            Console.WriteLine("RunTime crono1: " + crono1elapsedTime);
            Console.WriteLine("RunTime crono2: " + crono2elapsedTime);
            
        }   
    }
}
