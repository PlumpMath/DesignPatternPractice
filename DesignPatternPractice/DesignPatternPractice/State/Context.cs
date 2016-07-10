using System;

namespace DesignPatternPractice
{
    public class Context
    {
        private State state;
        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("Current State:" + state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}