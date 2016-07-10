using System;

namespace DesignPatternPractice
{
    public class EveningState : State2
    {
        public override void WriteProgram(Work w)
        {
            if (w.TaskFinished)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            { 
                if (w.Hour < 17)
                {
                    Console.WriteLine("currentTime: {0} clock, night tired", w.Hour);
                }
                else
                {
                    w.SetState(new SleepState());
                    w.WriteProgram();
                } 
            }
        }
    }
}