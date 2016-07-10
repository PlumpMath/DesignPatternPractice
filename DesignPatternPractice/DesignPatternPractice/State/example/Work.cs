using System;

namespace DesignPatternPractice
{
    public class Work
    {
        private State2 current;
        public Work()
        {
            current = new ForenoonState();
        }
        public int Hour { get; set; }
        public bool TaskFinished { get; set; }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }

        public void SetState(State2 state)
        {
            current = state;
        }
    }
}