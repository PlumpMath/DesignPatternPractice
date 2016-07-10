using System;

namespace DesignPatternPractice
{
    public class AfternoonState : State2
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine("currentTime: {0} clock, evening work", w.Hour);
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }
}