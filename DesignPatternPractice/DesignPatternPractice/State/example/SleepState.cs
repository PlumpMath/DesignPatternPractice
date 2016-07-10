using System;

namespace DesignPatternPractice
{
    public class SleepState : State2
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("currentTime {0} clock, sleep", w.Hour);
        }
    }
}