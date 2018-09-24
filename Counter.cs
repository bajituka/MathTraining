using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MathTraining
{
    class Counter
    {
        public static void CountDown()
        {
            int timeLeft = 30;
            while (timeLeft != 0)
            {
                Thread.Sleep(1000);
                timeLeft--;
            }
            Console.WriteLine("Время вышло!");
        }
    }
}
