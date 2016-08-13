using System;

namespace DesignPatternPractice
{
    public class NBAObserver
    {
        private string name;
        private ISubject sub;
        public NBAObserver(string name, ISubject sub) 
        {
            this.name = name;
            this.sub = sub;
        }

        public void Update()
        {
            Console.WriteLine("{0} {1} plz close NBAChannel, go to work!", sub.SubjectState, name);
        }
    }
}