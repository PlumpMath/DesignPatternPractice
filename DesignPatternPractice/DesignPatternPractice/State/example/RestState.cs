using System;

namespace DesignPatternPractice
{
    public class RestState : State2
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("currentTime {0} clock, work off", w.Hour);
        }
    }
}