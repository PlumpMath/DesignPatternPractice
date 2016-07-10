using System;

namespace DesignPatternPractice
{
    public class NoonState : State2
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("currentTime: {0} clock, afternoon rest", w.Hour);
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }
}